namespace RoslynCompiler.Roslyn
{
    using System;
    using System.CodeDom.Compiler;
    using System.IO;
    using Microsoft.CodeDom.Providers.DotNetCompilerPlatform;
    using RoslynCompiler.Properties;

    internal class SourceEditor
    {
        /// <summary>
        /// Parameters for the compiler can be found at this link
        /// https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/compiler-options/listed-alphabetically
        /// </summary>
        /// 
        private static readonly string DirStart = Environment.CurrentDirectory;
        private static readonly bool True = true, False = false;

        public static readonly string[] DLL = new string[]
        {
           "System.dll", "System.Data.dll"        
        };

        public static void Compile(Build build)
        {
            Checker.RDeleteFiles();
            if (!File.Exists(Checker.RoslynPath))
            {
                ControlActive.CheckMessage(build.BoxStatus, "Компилятор не найден");
            }
            else
            {
                ControlActive.CheckMessage(build.BoxStatus, "Идёт сборка ожидайте");
                using (var provider = new CSharpCodeProvider())
                {
                    string Arguments = $@"/target:exe /unsafe /noconfig /platform:anycpu32bitpreferred";
                    var Params = new CompilerParameters()
                    {
                        OutputAssembly = $"{DirStart}/{build.BoxFileName}.exe",
                        GenerateInMemory = False,
                        GenerateExecutable = True,
                        TreatWarningsAsErrors = False,
                        CompilerOptions = Arguments
                    };
                    if (!string.IsNullOrEmpty(build.BoxIcon))
                    {
                        Params.CompilerOptions += $" /win32icon:{build.BoxIcon}";
                    }
                    switch (build.BoxCombo.SelectedIndex)
                    {
                        case 0:
                            ReferenceData.Search_DLL("'W'", "2.0.50727", SearchOption.TopDirectoryOnly);
                            for (int i = 0; i < ReferenceData.ReferencedDLL.Count; i++)
                            {
                                Params.CoreAssemblyFileName = PathNetFramework.WinMscorlib("2.0.50727");
                                Params.ReferencedAssemblies.Add(ReferenceData.ReferencedDLL[i]);
                            }
                            break;
                        case 1:
                            ReferenceData.Search_DLL("'P'", "4.0", SearchOption.TopDirectoryOnly);
                            for (int i = 0; i < ReferenceData.ReferencedDLL.Count; i++)
                            {
                                Params.CoreAssemblyFileName = PathNetFramework.Progra86Mscorlib("4.0");
                                Params.ReferencedAssemblies.Add(ReferenceData.ReferencedDLL[i]);
                            }
                            break;
                        case 2:
                            ReferenceData.Search_DLL("'P'", "4.5", SearchOption.TopDirectoryOnly);
                            for (int i = 0; i < ReferenceData.ReferencedDLL.Count; i++)
                            {
                                Params.CoreAssemblyFileName = PathNetFramework.Progra86Mscorlib("4.5");
                                Params.ReferencedAssemblies.Add(ReferenceData.ReferencedDLL[i]);
                            }
                            break;
                        default:
                            break;
                    }
                    var SourceCode = Resources.Stub.Replace("[TITLE]", build.BoxTitle).
                        Replace("[MESSAGE]", build.BoxMessage);
                    Checker.CheckResults(provider.CompileAssemblyFromSource(Params, SourceCode), build.BoxStatus);
                }
            }
        }
    }
}
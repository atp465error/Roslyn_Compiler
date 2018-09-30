namespace RoslynCompiler.Roslyn
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Security;

    public class ReferenceData
    {
        public static List<string> ReferencedDLL = new List<string>();

        private static IEnumerable<string> SafeEnumerateFiles(string Path, string Pattern, SearchOption So)
        {
            try
            {
                return Directory.EnumerateFiles(Path, Pattern, So);
            }
            catch (IOException) { }
            catch (SecurityException) { }
            catch (UnauthorizedAccessException) { }

            return Enumerable.Empty<string>();
        }

        public static List<string> GetFilez(string path, SearchOption opt, params string[] patterns)
        {
            var filez = new List<string>();
            foreach (string pattern in patterns)
            {
                try
                {
                    filez.AddRange(SafeEnumerateFiles(path, pattern, opt));
                }
                catch (ArgumentNullException) { }
            }
            return filez;
        }

        public static void Search_DLL(string Status, string NetVersion, SearchOption search)
        {
            try
            {
                for (int i = 0; i < SourceEditor.DLL.Length; i++)
                {
                    if (!Status.Contains("'W'"))
                    {
                        if (Status.Contains("'P'"))
                        {
                            if (!Directory.Exists(PathNetFramework.ReferenceAssemblies86(NetVersion)))
                            {
                                Checker.SaveNewFile("NetFrameworkError.txt", "Ошибка: Папки с данной версией нет! Обновите NetFramework");
                            }
                            else
                            {
                                foreach (string Reference in GetFilez(PathNetFramework.ReferenceAssemblies86(NetVersion), search, SourceEditor.DLL[i]))
                                {
                                    ReferencedDLL.Add(Reference);
                                }
                            }
                        }
                    }
                    else
                    {
                        if (!Directory.Exists(PathNetFramework.ReferenceMicrosoft(NetVersion)))
                        {
                            Checker.SaveNewFile("NetFrameworkError.txt", "Ошибка: Папки с данной версией нет! Обновите NetFramework");
                        }
                        else
                        {
                            foreach (string Reference in GetFilez(PathNetFramework.ReferenceMicrosoft(NetVersion), search, SourceEditor.DLL[i]))
                            {
                                ReferencedDLL.Add(Reference);
                            }
                        }
                    }
                }
            }
            catch (OverflowException) { }
            catch (ArgumentNullException) { }
        }
    }
}
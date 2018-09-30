namespace RoslynCompiler.Roslyn
{
    using System;
    using System.IO;

    public sealed class PathNetFramework
    {
        private static readonly string ProgramFiles = Environment.GetEnvironmentVariable("ProgramFiles(x86)");

        private static readonly string WinPath = Environment.GetFolderPath(Environment.SpecialFolder.Windows);

        #region Windows_Framework

        public static string WinMscorlib(string Version) =>
            Path.Combine(WinPath, $@"Microsoft.NET\Framework\v{Version}\mscorlib.dll");

        public static string ReferenceMicrosoft(string Version) =>
            Path.Combine(WinPath, $@"Microsoft.NET\Framework\v{Version}");

        #region WinX64

        public static string WinMscorlibx64(string Version) =>
            Path.Combine(WinPath, $@"Microsoft.NET\Framework64\v{Version}\mscorlib.dll");

        public static string ReferenceMicrosoftx64(string Version) =>
            Path.Combine(WinPath, $@"Microsoft.NET\Framework64\v{Version}");

        #endregion

        #endregion

        #region ProgramFiles86_Framework

        public static string Progra86Mscorlib(string Version) =>
            Path.Combine(ProgramFiles, $@"Reference Assemblies\Microsoft\Framework\.NETFramework\v{Version}\mscorlib.dll");

        public static string ReferenceAssemblies86(string Version) =>
            Path.Combine(ProgramFiles, $@"Reference Assemblies\Microsoft\Framework\.NETFramework\v{Version}");

        #endregion
    }
}
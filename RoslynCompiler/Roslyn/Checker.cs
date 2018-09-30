namespace RoslynCompiler.Roslyn
{
    using System;
    using System.CodeDom.Compiler;
    using System.IO;
    using System.Security;
    using System.Windows.Forms;

    public class Checker
    {
        public static readonly string RoslynPath = Path.Combine(Environment.CurrentDirectory, @"bin\roslyn\csc.exe");
        private static readonly string FileName = Path.Combine(Environment.CurrentDirectory, "Error_Compiler.txt");

        public static void SaveNewFile(string Filename, string TextError)
        {
            try
            {
                File.WriteAllText(Filename, TextError);
            }
            catch (UnauthorizedAccessException) { }
            catch (IOException) { }
            catch (SecurityException) { }
        }
       
        public static void RDeleteFiles()
        {
            if (File.Exists(path: FileName))
            {
                try
                {
                    File.Delete(path: FileName);
                }
                catch (IOException) { }
                catch (UnauthorizedAccessException) { }
            }
        }

        public static void CheckResults(CompilerResults Results, Label Status)
        {
            if (Results.Errors.Count <= 0)
            {
                ControlActive.CheckMessage(Status, "Билд создан успешно!");
            }
            else
            {
                if (Results.Errors.HasErrors)
                {
                    ControlActive.CheckMessage(Status, "Ошибка при компиляции!");
                    foreach (CompilerError Error in Results.Errors)
                    {
                        SaveNewFile("Error_Compiler.txt", $"Ошибка: {Error.ToString()}\r\nСтрока: {Error.Line}");
                    }
                }
            }
        }
    }
}
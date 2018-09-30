namespace RoslynCompiler
{
    using System;
    using System.Runtime.InteropServices;
    using static RoslynCompiler.Enums;

    internal static class NativeMethods
    {
        [DllImport("user32.dll")]
        public static extern bool AnimateWindow(IntPtr hWnd, int time, AnimateWindowFlags flags);
    }
}
namespace RoslynCompiler
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public class ControlActive
    {
        private static readonly bool False = false;

        private static void Active(Label l)
        {
            try
            {
                Task.Factory.StartNew(() =>
                {
                    Thread.Sleep(0x7D0);
                    l.Invoke((Action)(() => { l.Visible = False; }));
                });
            }
            catch { }
        }

        public static void CheckMessage(Label MessageShow, string Text, bool True = true)
        {
            MessageShow.Visible = True;
            Active(MessageShow);
            MessageShow.Text = Text;
        }
    }
}
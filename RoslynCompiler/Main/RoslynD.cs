namespace RoslynCompiler
{
    using System;
    using System.Diagnostics;
    using System.IO;
    using System.Threading;
    using System.Windows.Forms;

    public partial class RoslynD : Form
    {
        private static readonly bool False = false, True = true;

        protected void Controls_MouseDown(object sender, MouseEventArgs e)
        {
            ((Control)sender).Capture = False;
            var m = Message.Create(this.Handle, 0xa1, new IntPtr(0x2), IntPtr.Zero);
            this.WndProc(m: ref m);
        }

        public RoslynD()
        {
            this.InitializeComponent();
            this.LogoName.MouseDown += this.Controls_MouseDown;
            this.UPanel.MouseDown += this.Controls_MouseDown;
        }

        private void RoslynD_Load(object sender, EventArgs e)
        {
            this.Welcome.Text = $"Добро пожаловать {Environment.UserName}";
            NativeMethods.AnimateWindow(this.Handle, 0x1F4, Enums.AnimateWindowFlags.AW_ACTIVATE | 
            Enums.AnimateWindowFlags.AW_CENTER);
        }

        private void OpenIconDialog_Click(object sender, EventArgs e)
        {
            using (var Open = new OpenFileDialog())
            {
                Open.Title = "Выберите иконку для билд файла.";
                Open.Filter = "Иконка (*.ico)|*.ico";
                Open.Multiselect = False;
                Open.AutoUpgradeEnabled = True;
                Open.CheckFileExists = True;
                Open.RestoreDirectory = True;

                if (!Open.ShowDialog().ToString().Equals("OK"))
                {
                    ControlActive.CheckMessage(this.MessageShow, "Иконка не выбрана!");
                    this.IconOut.Clear();
                    this.LengthIcon.Text = "";
                    this.ViewIconOut.Image = null;
                }
                else
                {
                    this.IconOut.Text = Open.FileName;
                    if (!File.Exists(this.IconOut.Text))
                    {
                        ControlActive.CheckMessage(this.MessageShow, "Иконка повреждена!");
                        this.ViewIconOut.Image = null;
                        this.LengthIcon.Text = "";
                    }
                    else
                    {
                        this.ViewIconOut.ImageLocation = this.IconOut.Text;
                        try
                        {
                            this.LengthIcon.Text = $"Вес: {new FileInfo(this.IconOut.Text).Length} KB";
                        }
                        catch { this.LengthIcon.Text = ""; }
                    }
                }
            };
        }

        private void LinkForum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start("https://xakfor.net/forum/");
            }
            catch { }
        }

        protected void StubCompile_Click(object sender, EventArgs e) => 
            new Thread(() => Roslyn.SourceEditor.Compile(
                new Build(this.TitleOut.Text, this.MessageOut.Text, this.FileNameOut.Text, 
                    this.IconOut.Text, this.NetChoice, this.MessageShow))).Start();

        private void NowExit_Click(object sender, EventArgs e)
        {
            NativeMethods.AnimateWindow(this.Handle, 0x1F4, Enums.AnimateWindowFlags.AW_BLEND |
            Enums.AnimateWindowFlags.AW_HIDE);
            Application.Exit();
        }
    }
}
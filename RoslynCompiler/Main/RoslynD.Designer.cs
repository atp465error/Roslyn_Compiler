namespace RoslynCompiler
{
    partial class RoslynD
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoslynD));
            this.UPanel = new System.Windows.Forms.Panel();
            this.NowExit = new System.Windows.Forms.Button();
            this.LogoName = new System.Windows.Forms.Label();
            this.TextTittle = new System.Windows.Forms.Label();
            this.TextMessage = new System.Windows.Forms.Label();
            this.TextOutFile = new System.Windows.Forms.Label();
            this.TextIcon = new System.Windows.Forms.Label();
            this.Welcome = new System.Windows.Forms.Label();
            this.StubCompile = new System.Windows.Forms.Button();
            this.CoderName = new System.Windows.Forms.Label();
            this.LinkForum = new System.Windows.Forms.LinkLabel();
            this.OpenIconDialog = new System.Windows.Forms.Button();
            this.TitleOut = new System.Windows.Forms.TextBox();
            this.MessageOut = new System.Windows.Forms.TextBox();
            this.FileNameOut = new System.Windows.Forms.TextBox();
            this.IconOut = new System.Windows.Forms.TextBox();
            this.ViewIconOut = new System.Windows.Forms.PictureBox();
            this.MessageShow = new System.Windows.Forms.Label();
            this.LengthIcon = new System.Windows.Forms.Label();
            this.TextOutNetFrame = new System.Windows.Forms.Label();
            this.NetChoice = new System.Windows.Forms.ComboBox();
            this.UPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewIconOut)).BeginInit();
            this.SuspendLayout();
            // 
            // UPanel
            // 
            this.UPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(113)))), ((int)(((byte)(184)))));
            this.UPanel.Controls.Add(this.NowExit);
            this.UPanel.Controls.Add(this.LogoName);
            this.UPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UPanel.Location = new System.Drawing.Point(0, 0);
            this.UPanel.Name = "UPanel";
            this.UPanel.Size = new System.Drawing.Size(439, 27);
            this.UPanel.TabIndex = 0;
            // 
            // NowExit
            // 
            this.NowExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(113)))), ((int)(((byte)(184)))));
            this.NowExit.FlatAppearance.BorderSize = 0;
            this.NowExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.NowExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.NowExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NowExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.NowExit.Location = new System.Drawing.Point(410, 0);
            this.NowExit.Name = "NowExit";
            this.NowExit.Size = new System.Drawing.Size(26, 27);
            this.NowExit.TabIndex = 8;
            this.NowExit.Text = "X";
            this.NowExit.UseVisualStyleBackColor = false;
            this.NowExit.Click += new System.EventHandler(this.NowExit_Click);
            // 
            // LogoName
            // 
            this.LogoName.AutoSize = true;
            this.LogoName.Font = new System.Drawing.Font("Meiryo UI", 8.25F);
            this.LogoName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LogoName.Location = new System.Drawing.Point(6, 6);
            this.LogoName.Name = "LogoName";
            this.LogoName.Size = new System.Drawing.Size(151, 14);
            this.LogoName.TabIndex = 1;
            this.LogoName.Text = "Roslyn Dymamic Compiler";
            // 
            // TextTittle
            // 
            this.TextTittle.AutoSize = true;
            this.TextTittle.Font = new System.Drawing.Font("Meiryo UI", 8.25F);
            this.TextTittle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TextTittle.Location = new System.Drawing.Point(14, 88);
            this.TextTittle.Name = "TextTittle";
            this.TextTittle.Size = new System.Drawing.Size(121, 14);
            this.TextTittle.TabIndex = 2;
            this.TextTittle.Text = "Заголовок консоли:";
            // 
            // TextMessage
            // 
            this.TextMessage.AutoSize = true;
            this.TextMessage.Font = new System.Drawing.Font("Meiryo UI", 8.25F);
            this.TextMessage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TextMessage.Location = new System.Drawing.Point(27, 114);
            this.TextMessage.Name = "TextMessage";
            this.TextMessage.Size = new System.Drawing.Size(108, 14);
            this.TextMessage.TabIndex = 3;
            this.TextMessage.Text = "Текст сообщения:";
            // 
            // TextOutFile
            // 
            this.TextOutFile.AutoSize = true;
            this.TextOutFile.Font = new System.Drawing.Font("Meiryo UI", 8.25F);
            this.TextOutFile.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TextOutFile.Location = new System.Drawing.Point(32, 140);
            this.TextOutFile.Name = "TextOutFile";
            this.TextOutFile.Size = new System.Drawing.Size(103, 14);
            this.TextOutFile.TabIndex = 4;
            this.TextOutFile.Text = "Название файла:";
            // 
            // TextIcon
            // 
            this.TextIcon.AutoSize = true;
            this.TextIcon.Font = new System.Drawing.Font("Meiryo UI", 8.25F);
            this.TextIcon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TextIcon.Location = new System.Drawing.Point(20, 166);
            this.TextIcon.Name = "TextIcon";
            this.TextIcon.Size = new System.Drawing.Size(115, 14);
            this.TextIcon.TabIndex = 5;
            this.TextIcon.Text = "Иконка для файла:";
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.Font = new System.Drawing.Font("Arial Black", 8.25F);
            this.Welcome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Welcome.Location = new System.Drawing.Point(176, 46);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(0, 15);
            this.Welcome.TabIndex = 6;
            // 
            // StubCompile
            // 
            this.StubCompile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(113)))), ((int)(((byte)(184)))));
            this.StubCompile.FlatAppearance.BorderSize = 0;
            this.StubCompile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StubCompile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StubCompile.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.StubCompile.Location = new System.Drawing.Point(139, 216);
            this.StubCompile.Name = "StubCompile";
            this.StubCompile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StubCompile.Size = new System.Drawing.Size(293, 23);
            this.StubCompile.TabIndex = 7;
            this.StubCompile.TabStop = false;
            this.StubCompile.Text = "Скомпилировать файл";
            this.StubCompile.UseVisualStyleBackColor = false;
            this.StubCompile.Click += new System.EventHandler(this.StubCompile_Click);
            // 
            // CoderName
            // 
            this.CoderName.AutoSize = true;
            this.CoderName.Font = new System.Drawing.Font("Meiryo UI", 8.25F);
            this.CoderName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CoderName.Location = new System.Drawing.Point(6, 266);
            this.CoderName.Name = "CoderName";
            this.CoderName.Size = new System.Drawing.Size(99, 14);
            this.CoderName.TabIndex = 8;
            this.CoderName.Text = "#Created Antlion";
            // 
            // LinkForum
            // 
            this.LinkForum.AutoSize = true;
            this.LinkForum.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LinkForum.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(113)))), ((int)(((byte)(184)))));
            this.LinkForum.Location = new System.Drawing.Point(373, 266);
            this.LinkForum.Name = "LinkForum";
            this.LinkForum.Size = new System.Drawing.Size(59, 14);
            this.LinkForum.TabIndex = 9;
            this.LinkForum.TabStop = true;
            this.LinkForum.Text = "XakFor.Net";
            this.LinkForum.VisitedLinkColor = System.Drawing.Color.RoyalBlue;
            this.LinkForum.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkForum_LinkClicked);
            // 
            // OpenIconDialog
            // 
            this.OpenIconDialog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(113)))), ((int)(((byte)(184)))));
            this.OpenIconDialog.FlatAppearance.BorderSize = 0;
            this.OpenIconDialog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenIconDialog.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.OpenIconDialog.Location = new System.Drawing.Point(383, 162);
            this.OpenIconDialog.Name = "OpenIconDialog";
            this.OpenIconDialog.Size = new System.Drawing.Size(49, 21);
            this.OpenIconDialog.TabIndex = 10;
            this.OpenIconDialog.TabStop = false;
            this.OpenIconDialog.Text = "...";
            this.OpenIconDialog.UseVisualStyleBackColor = false;
            this.OpenIconDialog.Click += new System.EventHandler(this.OpenIconDialog_Click);
            // 
            // TitleOut
            // 
            this.TitleOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.TitleOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TitleOut.ForeColor = System.Drawing.SystemColors.Window;
            this.TitleOut.Location = new System.Drawing.Point(139, 85);
            this.TitleOut.MaxLength = 50;
            this.TitleOut.Name = "TitleOut";
            this.TitleOut.Size = new System.Drawing.Size(293, 20);
            this.TitleOut.TabIndex = 11;
            this.TitleOut.TabStop = false;
            this.TitleOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MessageOut
            // 
            this.MessageOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.MessageOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MessageOut.ForeColor = System.Drawing.SystemColors.Window;
            this.MessageOut.Location = new System.Drawing.Point(139, 111);
            this.MessageOut.MaxLength = 999999;
            this.MessageOut.Name = "MessageOut";
            this.MessageOut.Size = new System.Drawing.Size(293, 20);
            this.MessageOut.TabIndex = 12;
            this.MessageOut.TabStop = false;
            this.MessageOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FileNameOut
            // 
            this.FileNameOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.FileNameOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FileNameOut.ForeColor = System.Drawing.SystemColors.Window;
            this.FileNameOut.Location = new System.Drawing.Point(139, 137);
            this.FileNameOut.MaxLength = 20;
            this.FileNameOut.Name = "FileNameOut";
            this.FileNameOut.Size = new System.Drawing.Size(293, 20);
            this.FileNameOut.TabIndex = 13;
            this.FileNameOut.TabStop = false;
            this.FileNameOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // IconOut
            // 
            this.IconOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.IconOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IconOut.ForeColor = System.Drawing.SystemColors.Window;
            this.IconOut.Location = new System.Drawing.Point(139, 163);
            this.IconOut.MaxLength = 200;
            this.IconOut.Name = "IconOut";
            this.IconOut.ReadOnly = true;
            this.IconOut.Size = new System.Drawing.Size(238, 20);
            this.IconOut.TabIndex = 14;
            this.IconOut.TabStop = false;
            this.IconOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ViewIconOut
            // 
            this.ViewIconOut.Location = new System.Drawing.Point(23, 183);
            this.ViewIconOut.Name = "ViewIconOut";
            this.ViewIconOut.Size = new System.Drawing.Size(110, 51);
            this.ViewIconOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ViewIconOut.TabIndex = 15;
            this.ViewIconOut.TabStop = false;
            // 
            // MessageShow
            // 
            this.MessageShow.AutoSize = true;
            this.MessageShow.Font = new System.Drawing.Font("Meiryo UI", 8.25F);
            this.MessageShow.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MessageShow.Location = new System.Drawing.Point(218, 247);
            this.MessageShow.Name = "MessageShow";
            this.MessageShow.Size = new System.Drawing.Size(0, 14);
            this.MessageShow.TabIndex = 16;
            // 
            // LengthIcon
            // 
            this.LengthIcon.AutoSize = true;
            this.LengthIcon.Font = new System.Drawing.Font("Meiryo UI", 8.25F);
            this.LengthIcon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LengthIcon.Location = new System.Drawing.Point(35, 237);
            this.LengthIcon.Name = "LengthIcon";
            this.LengthIcon.Size = new System.Drawing.Size(0, 14);
            this.LengthIcon.TabIndex = 17;
            // 
            // TextOutNetFrame
            // 
            this.TextOutNetFrame.AutoSize = true;
            this.TextOutNetFrame.Font = new System.Drawing.Font("Meiryo UI", 8.25F);
            this.TextOutNetFrame.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TextOutNetFrame.Location = new System.Drawing.Point(137, 192);
            this.TextOutNetFrame.Name = "TextOutNetFrame";
            this.TextOutNetFrame.Size = new System.Drawing.Size(198, 14);
            this.TextOutNetFrame.TabIndex = 18;
            this.TextOutNetFrame.Text = "Выберите версию: NetFramework:";
            // 
            // NetChoice
            // 
            this.NetChoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.NetChoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NetChoice.ForeColor = System.Drawing.SystemColors.Window;
            this.NetChoice.FormattingEnabled = true;
            this.NetChoice.Items.AddRange(new object[] {
            "2.0",
            "4.0",
            "4.5"});
            this.NetChoice.Location = new System.Drawing.Point(341, 188);
            this.NetChoice.Name = "NetChoice";
            this.NetChoice.Size = new System.Drawing.Size(91, 21);
            this.NetChoice.TabIndex = 19;
            this.NetChoice.TabStop = false;
            // 
            // RoslynD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(439, 289);
            this.Controls.Add(this.NetChoice);
            this.Controls.Add(this.TextOutNetFrame);
            this.Controls.Add(this.LengthIcon);
            this.Controls.Add(this.MessageShow);
            this.Controls.Add(this.ViewIconOut);
            this.Controls.Add(this.IconOut);
            this.Controls.Add(this.FileNameOut);
            this.Controls.Add(this.MessageOut);
            this.Controls.Add(this.TitleOut);
            this.Controls.Add(this.OpenIconDialog);
            this.Controls.Add(this.LinkForum);
            this.Controls.Add(this.CoderName);
            this.Controls.Add(this.StubCompile);
            this.Controls.Add(this.Welcome);
            this.Controls.Add(this.TextIcon);
            this.Controls.Add(this.TextOutFile);
            this.Controls.Add(this.TextMessage);
            this.Controls.Add(this.TextTittle);
            this.Controls.Add(this.UPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RoslynD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Roslyn Dynamic Compiler";
            this.Load += new System.EventHandler(this.RoslynD_Load);
            this.UPanel.ResumeLayout(false);
            this.UPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewIconOut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel UPanel;
        private System.Windows.Forms.Button NowExit;
        private System.Windows.Forms.Label LogoName;
        private System.Windows.Forms.Label TextTittle;
        private System.Windows.Forms.Label TextMessage;
        private System.Windows.Forms.Label TextOutFile;
        private System.Windows.Forms.Label TextIcon;
        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.Button StubCompile;
        private System.Windows.Forms.Label CoderName;
        private System.Windows.Forms.LinkLabel LinkForum;
        private System.Windows.Forms.Button OpenIconDialog;
        private System.Windows.Forms.TextBox TitleOut;
        private System.Windows.Forms.TextBox MessageOut;
        private System.Windows.Forms.TextBox FileNameOut;
        private System.Windows.Forms.TextBox IconOut;
        private System.Windows.Forms.PictureBox ViewIconOut;
        private System.Windows.Forms.Label MessageShow;
        private System.Windows.Forms.Label LengthIcon;
        private System.Windows.Forms.Label TextOutNetFrame;
        private System.Windows.Forms.ComboBox NetChoice;
    }
}
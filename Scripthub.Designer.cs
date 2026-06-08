namespace Synapse_X_Remake
{
    partial class Scripthub
    {
        private System.Windows.Forms.RichTextBox ScriptBox;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Scripthub));
            panel1 = new Panel();
            Title = new Label();
            CloseBtn = new CuoreUI.Controls.cuiButton();
            SynLogo = new PictureBox();
            panel2 = new Panel();
            InfYield = new CuoreUI.Controls.cuiButton();
            UncTest = new CuoreUI.Controls.cuiButton();
            SolaraHub = new CuoreUI.Controls.cuiButton();
            ScriptPanel = new Panel();
            cuiButton1 = new CuoreUI.Controls.cuiButton();
            Paste = new CuoreUI.Controls.cuiButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SynLogo).BeginInit();
            panel2.SuspendLayout();
            ScriptPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(50, 50, 50);
            panel1.Controls.Add(Title);
            panel1.Controls.Add(CloseBtn);
            panel1.Controls.Add(SynLogo);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(489, 39);
            panel1.TabIndex = 1;
            panel1.MouseDown += mouse_down;
            panel1.MouseMove += mouse_move;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.ForeColor = Color.White;
            Title.Location = new Point(205, 9);
            Title.Margin = new Padding(4, 0, 4, 0);
            Title.Name = "Title";
            Title.Size = new Size(89, 15);
            Title.TabIndex = 2;
            Title.Text = "WinkyHubs List";
            // 
            // CloseBtn
            // 
            CloseBtn.CheckButton = false;
            CloseBtn.Checked = false;
            CloseBtn.CheckedBackground = Color.Transparent;
            CloseBtn.CheckedForeColor = Color.Transparent;
            CloseBtn.CheckedImageTint = Color.White;
            CloseBtn.CheckedOutline = Color.Transparent;
            CloseBtn.Content = "";
            CloseBtn.Cursor = Cursors.Hand;
            CloseBtn.DialogResult = DialogResult.None;
            CloseBtn.Font = new Font("Microsoft Sans Serif", 9.75F);
            CloseBtn.ForeColor = Color.Transparent;
            CloseBtn.HoverBackground = Color.Transparent;
            CloseBtn.HoverForeColor = Color.Transparent;
            CloseBtn.HoverImageTint = Color.White;
            CloseBtn.HoverOutline = Color.Transparent;
            CloseBtn.Image = (Image)resources.GetObject("CloseBtn.Image");
            CloseBtn.ImageExpand = new Point(0, 0);
            CloseBtn.Location = new Point(452, 6);
            CloseBtn.Margin = new Padding(4, 3, 4, 3);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.NormalBackground = Color.Transparent;
            CloseBtn.NormalForeColor = Color.Transparent;
            CloseBtn.NormalImageTint = Color.White;
            CloseBtn.NormalOutline = Color.Transparent;
            CloseBtn.OutlineThickness = 1F;
            CloseBtn.PressedBackground = Color.Transparent;
            CloseBtn.PressedForeColor = Color.Transparent;
            CloseBtn.PressedImageTint = Color.White;
            CloseBtn.PressedOutline = Color.Transparent;
            CloseBtn.Rounding = new Padding(0);
            CloseBtn.Size = new Size(29, 29);
            CloseBtn.TabIndex = 1;
            CloseBtn.TextAlignment = StringAlignment.Center;
            CloseBtn.TextPadding = -1;
            CloseBtn.TextSpacing = 2;

            CloseBtn.Click += CloseBtn_Click;
            // 
            // SynLogo
            // 
            SynLogo.Image = _123.Properties.Resources.cda35960b514d793a29c376a219f2a42;
            SynLogo.Location = new Point(7, 2);
            SynLogo.Margin = new Padding(4, 3, 4, 3);
            SynLogo.Name = "SynLogo";
            SynLogo.Size = new Size(35, 35);
            SynLogo.SizeMode = PictureBoxSizeMode.Zoom;
            SynLogo.TabIndex = 0;
            SynLogo.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(50, 50, 50);
            panel2.Controls.Add(InfYield);
            panel2.Controls.Add(UncTest);
            panel2.Controls.Add(SolaraHub);
            panel2.Location = new Point(14, 52);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(152, 234);
            panel2.TabIndex = 2;
            // 
            // InfYield
            // 
            InfYield.CheckButton = false;
            InfYield.Checked = false;
            InfYield.CheckedBackground = Color.FromArgb(200, 200, 200);
            InfYield.CheckedForeColor = Color.White;
            InfYield.CheckedImageTint = Color.White;
            InfYield.CheckedOutline = Color.White;
            InfYield.Content = " Infinite Yield";
            InfYield.Cursor = Cursors.Hand;
            InfYield.DialogResult = DialogResult.None;
            InfYield.Font = new Font("Microsoft Sans Serif", 9.75F);
            InfYield.ForeColor = Color.White;
            InfYield.HoverBackground = Color.White;
            InfYield.HoverForeColor = Color.Black;
            InfYield.HoverImageTint = Color.White;
            InfYield.HoverOutline = Color.FromArgb(150, 150, 150);
            InfYield.Image = null;
            InfYield.ImageExpand = new Point(0, 0);
            InfYield.Location = new Point(-1, 79);
            InfYield.Margin = new Padding(4, 3, 4, 3);
            InfYield.Name = "InfYield";
            InfYield.NormalBackground = Color.FromArgb(100, 100, 100);
            InfYield.NormalForeColor = Color.White;
            InfYield.NormalImageTint = Color.Transparent;
            InfYield.NormalOutline = Color.Transparent;
            InfYield.OutlineThickness = 3F;
            InfYield.PressedBackground = Color.WhiteSmoke;
            InfYield.PressedForeColor = Color.White;
            InfYield.PressedImageTint = Color.Transparent;
            InfYield.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            InfYield.Rounding = new Padding(0);
            InfYield.Size = new Size(152, 47);
            InfYield.TabIndex = 4;
            InfYield.TextAlignment = StringAlignment.Near;
            InfYield.TextPadding = -1;
            InfYield.TextSpacing = 2;
            InfYield.Click += InfYield_Click;
            // 
            // UncTest
            // 
            UncTest.CheckButton = false;
            UncTest.Checked = false;
            UncTest.CheckedBackground = Color.FromArgb(200, 200, 200);
            UncTest.CheckedForeColor = Color.White;
            UncTest.CheckedImageTint = Color.White;
            UncTest.CheckedOutline = Color.White;
            UncTest.Content = " UNC Test Env";
            UncTest.Cursor = Cursors.Hand;
            UncTest.DialogResult = DialogResult.None;
            UncTest.Font = new Font("Microsoft Sans Serif", 9.75F);
            UncTest.ForeColor = Color.White;
            UncTest.HoverBackground = Color.White;
            UncTest.HoverForeColor = Color.Black;
            UncTest.HoverImageTint = Color.White;
            UncTest.HoverOutline = Color.FromArgb(150, 150, 150);
            UncTest.Image = null;
            UncTest.ImageExpand = new Point(0, 0);
            UncTest.Location = new Point(-1, 35);
            UncTest.Margin = new Padding(4, 3, 4, 3);
            UncTest.Name = "UncTest";
            UncTest.NormalBackground = Color.FromArgb(100, 100, 100);
            UncTest.NormalForeColor = Color.White;
            UncTest.NormalImageTint = Color.Transparent;
            UncTest.NormalOutline = Color.Transparent;
            UncTest.OutlineThickness = 3F;
            UncTest.PressedBackground = Color.WhiteSmoke;
            UncTest.PressedForeColor = Color.White;
            UncTest.PressedImageTint = Color.Transparent;
            UncTest.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            UncTest.Rounding = new Padding(0);
            UncTest.Size = new Size(152, 49);
            UncTest.TabIndex = 2;
            UncTest.TextAlignment = StringAlignment.Near;
            UncTest.TextPadding = -1;
            UncTest.TextSpacing = 2;
            UncTest.Click += UncTest_Click;
            // 
            // SolaraHub
            // 
            SolaraHub.CheckButton = false;
            SolaraHub.Checked = false;
            SolaraHub.CheckedBackground = Color.FromArgb(200, 200, 200);
            SolaraHub.CheckedForeColor = Color.White;
            SolaraHub.CheckedImageTint = Color.White;
            SolaraHub.CheckedOutline = Color.White;
            SolaraHub.Content = "Solara Hub";
            SolaraHub.Cursor = Cursors.Hand;
            SolaraHub.DialogResult = DialogResult.None;
            SolaraHub.Font = new Font("Microsoft Sans Serif", 9.75F);
            SolaraHub.ForeColor = Color.White;
            SolaraHub.HoverBackground = Color.White;
            SolaraHub.HoverForeColor = Color.Black;
            SolaraHub.HoverImageTint = Color.White;
            SolaraHub.HoverOutline = Color.FromArgb(150, 150, 150);
            SolaraHub.Image = null;
            SolaraHub.ImageExpand = new Point(0, 0);
            SolaraHub.Location = new Point(-1, 0);
            SolaraHub.Margin = new Padding(4, 3, 4, 3);
            SolaraHub.Name = "SolaraHub";
            SolaraHub.NormalBackground = Color.FromArgb(100, 100, 100);
            SolaraHub.NormalForeColor = Color.White;
            SolaraHub.NormalImageTint = Color.Transparent;
            SolaraHub.NormalOutline = Color.Transparent;
            SolaraHub.OutlineThickness = 3F;
            SolaraHub.PressedBackground = Color.WhiteSmoke;
            SolaraHub.PressedForeColor = Color.White;
            SolaraHub.PressedImageTint = Color.Transparent;
            SolaraHub.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            SolaraHub.Rounding = new Padding(0);
            SolaraHub.Size = new Size(152, 38);
            SolaraHub.TabIndex = 0;
            SolaraHub.TextAlignment = StringAlignment.Near;
            SolaraHub.TextPadding = -1;
            SolaraHub.TextSpacing = 2;
            SolaraHub.Click += SolaraHub_Click;
            // 
            // ScriptPanel
            // 
            ScriptPanel.BackColor = Color.FromArgb(50, 50, 50);
            ScriptPanel.Controls.Add(cuiButton1);
            ScriptPanel.Controls.Add(Paste);
            ScriptPanel.Location = new Point(173, 52);
            ScriptPanel.Margin = new Padding(4, 3, 4, 3);
            ScriptPanel.Name = "ScriptPanel";
            ScriptPanel.Size = new Size(302, 234);
            ScriptPanel.TabIndex = 3;
            ScriptPanel.Paint += ScriptPanel_Paint;
            // 
            // cuiButton1
            // 
            cuiButton1.BackColor = Color.FromArgb(55, 55, 55);
            cuiButton1.CheckButton = false;
            cuiButton1.Checked = false;
            cuiButton1.CheckedBackground = Color.FromArgb(55, 55, 55);
            cuiButton1.CheckedForeColor = Color.White;
            cuiButton1.CheckedImageTint = Color.White;
            cuiButton1.CheckedOutline = Color.FromArgb(255, 106, 0);
            cuiButton1.Content = "Clear";
            cuiButton1.Cursor = Cursors.Hand;
            cuiButton1.DialogResult = DialogResult.None;
            cuiButton1.Font = new Font("Microsoft Sans Serif", 9.75F);
            cuiButton1.ForeColor = Color.White;
            cuiButton1.HoverBackground = Color.White;
            cuiButton1.HoverForeColor = Color.Black;
            cuiButton1.HoverImageTint = Color.White;
            cuiButton1.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            cuiButton1.Image = null;
            cuiButton1.ImageExpand = new Point(0, 0);
            cuiButton1.Location = new Point(161, 193);
            cuiButton1.Margin = new Padding(4, 3, 4, 3);
            cuiButton1.Name = "cuiButton1";
            cuiButton1.NormalBackground = Color.FromArgb(55, 55, 55);
            cuiButton1.NormalForeColor = Color.White;
            cuiButton1.NormalImageTint = Color.White;
            cuiButton1.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton1.OutlineThickness = 1F;
            cuiButton1.PressedBackground = Color.WhiteSmoke;
            cuiButton1.PressedForeColor = Color.FromArgb(32, 32, 32);
            cuiButton1.PressedImageTint = Color.White;
            cuiButton1.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton1.Rounding = new Padding(0);
            cuiButton1.Size = new Size(138, 38);
            cuiButton1.TabIndex = 2;
            cuiButton1.TextAlignment = StringAlignment.Center;
            cuiButton1.TextPadding = -1;
            cuiButton1.TextSpacing = 2;
            cuiButton1.Click += cuiButton1_Click;
            // 
            // Paste
            // 
            Paste.BackColor = Color.FromArgb(55, 55, 55);
            Paste.CheckButton = false;
            Paste.Checked = false;
            Paste.CheckedBackground = Color.FromArgb(55, 55, 55);
            Paste.CheckedForeColor = Color.White;
            Paste.CheckedImageTint = Color.White;
            Paste.CheckedOutline = Color.FromArgb(255, 106, 0);
            Paste.Content = "Paste";
            Paste.Cursor = Cursors.Hand;
            Paste.DialogResult = DialogResult.None;
            Paste.Font = new Font("Microsoft Sans Serif", 9.75F);
            Paste.ForeColor = Color.White;
            Paste.HoverBackground = Color.White;
            Paste.HoverForeColor = Color.Black;
            Paste.HoverImageTint = Color.White;
            Paste.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            Paste.Image = null;
            Paste.ImageExpand = new Point(0, 0);
            Paste.Location = new Point(4, 193);
            Paste.Margin = new Padding(4, 3, 4, 3);
            Paste.Name = "Paste";
            Paste.NormalBackground = Color.FromArgb(55, 55, 55);
            Paste.NormalForeColor = Color.White;
            Paste.NormalImageTint = Color.White;
            Paste.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            Paste.OutlineThickness = 1F;
            Paste.PressedBackground = Color.WhiteSmoke;
            Paste.PressedForeColor = Color.FromArgb(32, 32, 32);
            Paste.PressedImageTint = Color.White;
            Paste.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            Paste.Rounding = new Padding(0);
            Paste.Size = new Size(150, 38);
            Paste.TabIndex = 1;
            Paste.TextAlignment = StringAlignment.Center;
            Paste.TextPadding = -1;
            Paste.TextSpacing = 2;
            Paste.Click += Execute_Click;
            // 
            // Scripthub
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 35);
            ClientSize = new Size(489, 300);
            Controls.Add(ScriptPanel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Scripthub";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SynLogo).EndInit();
            panel2.ResumeLayout(false);
            ScriptPanel.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Title;
        private CuoreUI.Controls.cuiButton CloseBtn;
        private System.Windows.Forms.PictureBox SynLogo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel ScriptPanel;
        private CuoreUI.Controls.cuiButton Paste;
        private CuoreUI.Controls.cuiButton cuiButton1;
        private CuoreUI.Controls.cuiButton InfYield;
        private CuoreUI.Controls.cuiButton UncTest;
        private CuoreUI.Controls.cuiButton SolaraHub;
    }
}
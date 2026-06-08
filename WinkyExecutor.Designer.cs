namespace Synapse_X_Remake
{
    partial class WinkyExecutor
    {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinkyExecutor));
            panel1 = new Panel();
            Title = new Label();
            CloseBtn = new CuoreUI.Controls.cuiButton();
            SynLogo = new PictureBox();
            panel2 = new Panel();
            Editor = new Microsoft.Web.WebView2.WinForms.WebView2();
            ExecuteBtn = new CuoreUI.Controls.cuiButton();
            ClearBtn = new CuoreUI.Controls.cuiButton();
            ScripthubBtn = new CuoreUI.Controls.cuiButton();
            AttachBtn = new CuoreUI.Controls.cuiButton();
            SaveBtn = new CuoreUI.Controls.cuiButton();
            cuiButton2 = new CuoreUI.Controls.cuiButton();
            TabsButton1 = new CuoreUI.Controls.cuiButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SynLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Editor).BeginInit();
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
            panel1.Size = new Size(933, 39);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            panel1.MouseDown += mouse_down;
            panel1.MouseMove += mouse_move;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.ForeColor = Color.White;
            Title.Location = new Point(388, 9);
            Title.Margin = new Padding(4, 0, 4, 0);
            Title.Name = "Title";
            Title.Size = new Size(89, 15);
            Title.TabIndex = 2;
            Title.Text = "Winky Executor";
            Title.Click += Title_Click;
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
            CloseBtn.Location = new Point(896, 6);
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
            SynLogo.Location = new Point(5, 6);
            SynLogo.Margin = new Padding(4, 3, 4, 3);
            SynLogo.Name = "SynLogo";
            SynLogo.Size = new Size(50, 29);
            SynLogo.SizeMode = PictureBoxSizeMode.Zoom;
            SynLogo.TabIndex = 0;
            SynLogo.TabStop = false;
            SynLogo.Click += SynLogo_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(50, 50, 50);
            panel2.Location = new Point(744, 46);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(175, 318);
            panel2.TabIndex = 1;
            // 
            // Editor
            // 
            Editor.AllowExternalDrop = true;
            Editor.BackColor = Color.FromArgb(50, 50, 50);
            Editor.CreationProperties = null;
            Editor.DefaultBackgroundColor = Color.White;
            Editor.Location = new Point(14, 46);
            Editor.Margin = new Padding(4, 3, 4, 3);
            Editor.Name = "Editor";
            Editor.Size = new Size(723, 318);
            Editor.TabIndex = 2;
            Editor.ZoomFactor = 1D;
            // 
            // ExecuteBtn
            // 
            ExecuteBtn.BackColor = Color.FromArgb(27, 42, 53);
            ExecuteBtn.CheckButton = false;
            ExecuteBtn.Checked = false;
            ExecuteBtn.CheckedBackground = Color.FromArgb(65, 65, 65);
            ExecuteBtn.CheckedForeColor = Color.White;
            ExecuteBtn.CheckedImageTint = Color.Transparent;
            ExecuteBtn.CheckedOutline = Color.Transparent;
            ExecuteBtn.Content = "Execute";
            ExecuteBtn.Cursor = Cursors.Hand;
            ExecuteBtn.DialogResult = DialogResult.None;
            ExecuteBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ExecuteBtn.ForeColor = Color.White;
            ExecuteBtn.HoverBackground = Color.FromArgb(65, 65, 65);
            ExecuteBtn.HoverForeColor = Color.White;
            ExecuteBtn.HoverImageTint = Color.Transparent;
            ExecuteBtn.HoverOutline = Color.Transparent;
            ExecuteBtn.Image = null;
            ExecuteBtn.ImageExpand = new Point(0, 0);
            ExecuteBtn.Location = new Point(14, 372);
            ExecuteBtn.Margin = new Padding(4, 3, 4, 3);
            ExecuteBtn.Name = "ExecuteBtn";
            ExecuteBtn.NormalBackground = Color.FromArgb(55, 55, 55);
            ExecuteBtn.NormalForeColor = Color.White;
            ExecuteBtn.NormalImageTint = Color.Transparent;
            ExecuteBtn.NormalOutline = Color.Transparent;
            ExecuteBtn.OutlineThickness = 1F;
            ExecuteBtn.PressedBackground = Color.FromArgb(65, 65, 65);
            ExecuteBtn.PressedForeColor = Color.White;
            ExecuteBtn.PressedImageTint = Color.Transparent;
            ExecuteBtn.PressedOutline = Color.Transparent;
            ExecuteBtn.Rounding = new Padding(0);
            ExecuteBtn.Size = new Size(114, 40);
            ExecuteBtn.TabIndex = 3;
            ExecuteBtn.TextAlignment = StringAlignment.Center;
            ExecuteBtn.TextPadding = -1;
            ExecuteBtn.TextSpacing = 2;
            ExecuteBtn.Click += ExecuteBtn_Click;
            // 
            // ClearBtn
            // 
            ClearBtn.CheckButton = false;
            ClearBtn.Checked = false;
            ClearBtn.CheckedBackground = Color.FromArgb(65, 65, 65);
            ClearBtn.CheckedForeColor = Color.White;
            ClearBtn.CheckedImageTint = Color.Transparent;
            ClearBtn.CheckedOutline = Color.Transparent;
            ClearBtn.Content = "Clear";
            ClearBtn.Cursor = Cursors.Hand;
            ClearBtn.DialogResult = DialogResult.None;
            ClearBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ClearBtn.ForeColor = Color.White;
            ClearBtn.HoverBackground = Color.FromArgb(65, 65, 65);
            ClearBtn.HoverForeColor = Color.White;
            ClearBtn.HoverImageTint = Color.Transparent;
            ClearBtn.HoverOutline = Color.Transparent;
            ClearBtn.Image = null;
            ClearBtn.ImageExpand = new Point(0, 0);
            ClearBtn.Location = new Point(135, 372);
            ClearBtn.Margin = new Padding(4, 3, 4, 3);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.NormalBackground = Color.FromArgb(55, 55, 55);
            ClearBtn.NormalForeColor = Color.White;
            ClearBtn.NormalImageTint = Color.Transparent;
            ClearBtn.NormalOutline = Color.Transparent;
            ClearBtn.OutlineThickness = 1F;
            ClearBtn.PressedBackground = Color.FromArgb(65, 65, 65);
            ClearBtn.PressedForeColor = Color.White;
            ClearBtn.PressedImageTint = Color.Transparent;
            ClearBtn.PressedOutline = Color.Transparent;
            ClearBtn.Rounding = new Padding(0);
            ClearBtn.Size = new Size(99, 40);
            ClearBtn.TabIndex = 4;
            ClearBtn.TextAlignment = StringAlignment.Center;
            ClearBtn.TextPadding = -1;
            ClearBtn.TextSpacing = 2;
            ClearBtn.Click += TabsButton1_Click;
            // 
            // ScripthubBtn
            // 
            ScripthubBtn.CheckButton = false;
            ScripthubBtn.Checked = false;
            ScripthubBtn.CheckedBackground = Color.FromArgb(45, 45, 45);
            ScripthubBtn.CheckedForeColor = Color.White;
            ScripthubBtn.CheckedImageTint = Color.Transparent;
            ScripthubBtn.CheckedOutline = Color.Transparent;
            ScripthubBtn.Content = "Script hub";
            ScripthubBtn.Cursor = Cursors.Hand;
            ScripthubBtn.DialogResult = DialogResult.None;
            ScripthubBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ScripthubBtn.ForeColor = Color.White;
            ScripthubBtn.HoverBackground = Color.FromArgb(45, 45, 45);
            ScripthubBtn.HoverForeColor = Color.White;
            ScripthubBtn.HoverImageTint = Color.Transparent;
            ScripthubBtn.HoverOutline = Color.Transparent;
            ScripthubBtn.Image = null;
            ScripthubBtn.ImageExpand = new Point(0, 0);
            ScripthubBtn.Location = new Point(807, 372);
            ScripthubBtn.Margin = new Padding(4, 3, 4, 3);
            ScripthubBtn.Name = "ScripthubBtn";
            ScripthubBtn.NormalBackground = Color.FromArgb(55, 55, 55);
            ScripthubBtn.NormalForeColor = Color.White;
            ScripthubBtn.NormalImageTint = Color.Transparent;
            ScripthubBtn.NormalOutline = Color.Transparent;
            ScripthubBtn.OutlineThickness = 1F;
            ScripthubBtn.PressedBackground = Color.FromArgb(65, 65, 65);
            ScripthubBtn.PressedForeColor = Color.White;
            ScripthubBtn.PressedImageTint = Color.Transparent;
            ScripthubBtn.PressedOutline = Color.Transparent;
            ScripthubBtn.Rounding = new Padding(0);
            ScripthubBtn.Size = new Size(112, 40);
            ScripthubBtn.TabIndex = 5;
            ScripthubBtn.TextAlignment = StringAlignment.Center;
            ScripthubBtn.TextPadding = -1;
            ScripthubBtn.TextSpacing = 2;
            ScripthubBtn.Click += ScripthubBtn_Click;
            // 
            // AttachBtn
            // 
            AttachBtn.CheckButton = false;
            AttachBtn.Checked = false;
            AttachBtn.CheckedBackground = Color.FromArgb(65, 65, 65);
            AttachBtn.CheckedForeColor = Color.White;
            AttachBtn.CheckedImageTint = Color.Transparent;
            AttachBtn.CheckedOutline = Color.Transparent;
            AttachBtn.Content = "Attach";
            AttachBtn.Cursor = Cursors.Hand;
            AttachBtn.DialogResult = DialogResult.None;
            AttachBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AttachBtn.ForeColor = Color.White;
            AttachBtn.HoverBackground = Color.FromArgb(65, 65, 65);
            AttachBtn.HoverForeColor = Color.White;
            AttachBtn.HoverImageTint = Color.Transparent;
            AttachBtn.HoverOutline = Color.Transparent;
            AttachBtn.Image = null;
            AttachBtn.ImageExpand = new Point(0, 0);
            AttachBtn.Location = new Point(688, 372);
            AttachBtn.Margin = new Padding(4, 3, 4, 3);
            AttachBtn.Name = "AttachBtn";
            AttachBtn.NormalBackground = Color.FromArgb(55, 55, 55);
            AttachBtn.NormalForeColor = Color.White;
            AttachBtn.NormalImageTint = Color.Transparent;
            AttachBtn.NormalOutline = Color.Transparent;
            AttachBtn.OutlineThickness = 1F;
            AttachBtn.PressedBackground = Color.FromArgb(65, 65, 65);
            AttachBtn.PressedForeColor = Color.White;
            AttachBtn.PressedImageTint = Color.Transparent;
            AttachBtn.PressedOutline = Color.Transparent;
            AttachBtn.Rounding = new Padding(0);
            AttachBtn.Size = new Size(112, 40);
            AttachBtn.TabIndex = 6;
            AttachBtn.TextAlignment = StringAlignment.Center;
            AttachBtn.TextPadding = -1;
            AttachBtn.TextSpacing = 2;
            AttachBtn.Click += AttachBtn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = Color.FromArgb(27, 42, 53);
            SaveBtn.CheckButton = false;
            SaveBtn.Checked = false;
            SaveBtn.CheckedBackground = Color.FromArgb(65, 65, 65);
            SaveBtn.CheckedForeColor = Color.White;
            SaveBtn.CheckedImageTint = Color.Transparent;
            SaveBtn.CheckedOutline = Color.Transparent;
            SaveBtn.Content = "Save";
            SaveBtn.Cursor = Cursors.Hand;
            SaveBtn.DialogResult = DialogResult.None;
            SaveBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SaveBtn.ForeColor = Color.White;
            SaveBtn.HoverBackground = Color.FromArgb(65, 65, 65);
            SaveBtn.HoverForeColor = Color.White;
            SaveBtn.HoverImageTint = Color.Transparent;
            SaveBtn.HoverOutline = Color.Transparent;
            SaveBtn.Image = null;
            SaveBtn.ImageExpand = new Point(0, 0);
            SaveBtn.Location = new Point(241, 372);
            SaveBtn.Margin = new Padding(4, 3, 4, 3);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.NormalBackground = Color.FromArgb(55, 55, 55);
            SaveBtn.NormalForeColor = Color.White;
            SaveBtn.NormalImageTint = Color.Transparent;
            SaveBtn.NormalOutline = Color.Transparent;
            SaveBtn.OutlineThickness = 1F;
            SaveBtn.PressedBackground = Color.FromArgb(65, 65, 65);
            SaveBtn.PressedForeColor = Color.White;
            SaveBtn.PressedImageTint = Color.Transparent;
            SaveBtn.PressedOutline = Color.Transparent;
            SaveBtn.Rounding = new Padding(0);
            SaveBtn.Size = new Size(114, 40);
            SaveBtn.TabIndex = 7;
            SaveBtn.TextAlignment = StringAlignment.Center;
            SaveBtn.TextPadding = -1;
            SaveBtn.TextSpacing = 2;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // cuiButton2
            // 
            cuiButton2.BackColor = Color.FromArgb(27, 42, 53);
            cuiButton2.CheckButton = false;
            cuiButton2.Checked = false;
            cuiButton2.CheckedBackground = Color.FromArgb(65, 65, 65);
            cuiButton2.CheckedForeColor = Color.White;
            cuiButton2.CheckedImageTint = Color.Transparent;
            cuiButton2.CheckedOutline = Color.Transparent;
            cuiButton2.Content = "Open";
            cuiButton2.Cursor = Cursors.Hand;
            cuiButton2.DialogResult = DialogResult.None;
            cuiButton2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiButton2.ForeColor = Color.White;
            cuiButton2.HoverBackground = Color.FromArgb(65, 65, 65);
            cuiButton2.HoverForeColor = Color.White;
            cuiButton2.HoverImageTint = Color.Transparent;
            cuiButton2.HoverOutline = Color.Transparent;
            cuiButton2.Image = null;
            cuiButton2.ImageExpand = new Point(0, 0);
            cuiButton2.Location = new Point(363, 372);
            cuiButton2.Margin = new Padding(4, 3, 4, 3);
            cuiButton2.Name = "cuiButton2";
            cuiButton2.NormalBackground = Color.FromArgb(55, 55, 55);
            cuiButton2.NormalForeColor = Color.White;
            cuiButton2.NormalImageTint = Color.Transparent;
            cuiButton2.NormalOutline = Color.Transparent;
            cuiButton2.OutlineThickness = 1F;
            cuiButton2.PressedBackground = Color.FromArgb(65, 65, 65);
            cuiButton2.PressedForeColor = Color.White;
            cuiButton2.PressedImageTint = Color.Transparent;
            cuiButton2.PressedOutline = Color.Transparent;
            cuiButton2.Rounding = new Padding(0);
            cuiButton2.Size = new Size(114, 40);
            cuiButton2.TabIndex = 8;
            cuiButton2.TextAlignment = StringAlignment.Center;
            cuiButton2.TextPadding = -1;
            cuiButton2.TextSpacing = 2;
            cuiButton2.Click += Loadbutton1_Click;
            // 
            // TabsButton1
            // 
            TabsButton1.BackColor = Color.FromArgb(27, 42, 53);
            TabsButton1.CheckButton = false;
            TabsButton1.Checked = false;
            TabsButton1.CheckedBackground = Color.FromArgb(65, 65, 65);
            TabsButton1.CheckedForeColor = Color.White;
            TabsButton1.CheckedImageTint = Color.Transparent;
            TabsButton1.CheckedOutline = Color.Transparent;
            TabsButton1.Content = "Tabs";
            TabsButton1.Cursor = Cursors.Hand;
            TabsButton1.DialogResult = DialogResult.None;
            TabsButton1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TabsButton1.ForeColor = Color.White;
            TabsButton1.HoverBackground = Color.FromArgb(65, 65, 65);
            TabsButton1.HoverForeColor = Color.White;
            TabsButton1.HoverImageTint = Color.Transparent;
            TabsButton1.HoverOutline = Color.Transparent;
            TabsButton1.Image = null;
            TabsButton1.ImageExpand = new Point(0, 0);
            TabsButton1.Location = new Point(566, 372);
            TabsButton1.Margin = new Padding(4, 3, 4, 3);
            TabsButton1.Name = "TabsButton1";
            TabsButton1.NormalBackground = Color.FromArgb(55, 55, 55);
            TabsButton1.NormalForeColor = Color.White;
            TabsButton1.NormalImageTint = Color.Transparent;
            TabsButton1.NormalOutline = Color.Transparent;
            TabsButton1.OutlineThickness = 1F;
            TabsButton1.PressedBackground = Color.FromArgb(65, 65, 65);
            TabsButton1.PressedForeColor = Color.White;
            TabsButton1.PressedImageTint = Color.Transparent;
            TabsButton1.PressedOutline = Color.Transparent;
            TabsButton1.Rounding = new Padding(0);
            TabsButton1.Size = new Size(114, 40);
            TabsButton1.TabIndex = 9;
            TabsButton1.TextAlignment = StringAlignment.Center;
            TabsButton1.TextPadding = -1;
            TabsButton1.TextSpacing = 2;
            TabsButton1.Click += TabsButton1_Click;
            // 
            // WinkyExecutor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(933, 419);
            Controls.Add(TabsButton1);
            Controls.Add(cuiButton2);
            Controls.Add(SaveBtn);
            Controls.Add(AttachBtn);
            Controls.Add(ScripthubBtn);
            Controls.Add(ClearBtn);
            Controls.Add(ExecuteBtn);
            Controls.Add(Editor);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "WinkyExecutor";
            Text = "Winky Executor";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SynLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)Editor).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox SynLogo;
        private CuoreUI.Controls.cuiButton CloseBtn;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel panel2;
        private Microsoft.Web.WebView2.WinForms.WebView2 Editor;
        private CuoreUI.Controls.cuiButton ExecuteBtn;
        private CuoreUI.Controls.cuiButton ClearBtn;
        private CuoreUI.Controls.cuiButton ScripthubBtn;
        private CuoreUI.Controls.cuiButton AttachBtn;
        private CuoreUI.Controls.cuiButton SaveBtn;
        private CuoreUI.Controls.cuiButton cuiButton2;
        private CuoreUI.Controls.cuiButton TabsButton1;
    }
}


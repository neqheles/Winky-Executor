using _123;
using Synapse_X_Remake;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using VelocityAPI;

public class RobloxProcesses : Form
{
    private VelAPI vel;
    private ListView listView;
    private Button refreshButton;
    private Panel titleBar;
    private Label titleLabel;
    private Label closeButton;
    private Point mouseLocation;

    private readonly Color BG_DARK = Color.FromArgb(30, 30, 30);
    private readonly Color BG_PANEL = Color.FromArgb(45, 45, 45);
    private readonly Color BG_TITLEBAR = Color.FromArgb(37, 37, 37);
    private readonly Color BTN_NORMAL = Color.FromArgb(55, 55, 55);
    private readonly Color BTN_HOVER = Color.FromArgb(70, 70, 70);
    private readonly Color TEXT_COLOR = Color.FromArgb(220, 220, 220);
    private readonly Color BORDER_COLOR = Color.FromArgb(60, 60, 60);

    public RobloxProcesses(VelAPI velInstance)
    {
        vel = velInstance;
        this.Text = "";
        this.Size = new Size(500, 400);
        this.FormBorderStyle = FormBorderStyle.None;
        this.BackColor = BG_DARK;
        this.StartPosition = FormStartPosition.CenterScreen;

        BuildUI();
        LoadProcesses();
    }

    private void BuildUI()
    {
        titleBar = new Panel
        {
            Dock = DockStyle.Top,
            Height = 32,
            BackColor = BG_TITLEBAR
        };

        titleLabel = new Label
        {
            Text = "Winky Executor — Roblox Processes",
            ForeColor = TEXT_COLOR,
            Font = new Font("Segoe UI", 9f),
            AutoSize = false,
            TextAlign = ContentAlignment.MiddleCenter,
            Dock = DockStyle.Fill
        };

        var closeBtn = new CuoreUI.Controls.cuiButton
        {
            CheckButton = false,
            Checked = false,
            CheckedBackground = Color.Transparent,
            CheckedForeColor = Color.Transparent,
            CheckedImageTint = Color.White,
            CheckedOutline = Color.Transparent,
            Content = "",
            Cursor = Cursors.Hand,
            DialogResult = DialogResult.None,
            ForeColor = Color.Transparent,
            HoverBackground = Color.Transparent,
            HoverForeColor = Color.Transparent,
            HoverImageTint = Color.White,
            HoverOutline = Color.Transparent,
            NormalBackground = Color.Transparent,
            NormalForeColor = Color.Transparent,
            NormalImageTint = Color.White,
            NormalOutline = Color.Transparent,
            OutlineThickness = 1F,
            PressedBackground = Color.Transparent,
            PressedForeColor = Color.Transparent,
            PressedImageTint = Color.White,
            PressedOutline = Color.Transparent,
            Rounding = new Padding(0),
            Size = new Size(29, 29),
            Location = new Point(463, 5),
            TextAlignment = StringAlignment.Center,
        };
        var rm = new System.ComponentModel.ComponentResourceManager(typeof(WinkyExecutor));
        closeBtn.Image = (Image)rm.GetObject("CloseBtn.Image");
        closeBtn.Click += (s, e) => this.Close();

        titleBar.Controls.Add(titleLabel);
        titleBar.Controls.Add(closeBtn);
        closeBtn.BringToFront();

        // Drag
        foreach (Control c in new Control[] { titleBar, titleLabel })
        {
            c.MouseDown += (s, e) => mouseLocation = new Point(-e.X, -e.Y);
            c.MouseMove += (s, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    Point p = Control.MousePosition;
                    p.Offset(mouseLocation.X, mouseLocation.Y);
                    Location = p;
                }
            };
        }

        listView = new ListView
        {
            Dock = DockStyle.Fill,
            View = View.Details,
            FullRowSelect = true,
            BackColor = BG_PANEL,
            ForeColor = TEXT_COLOR,
            BorderStyle = BorderStyle.None,
            Font = new Font("Segoe UI", 9f),
            GridLines = false,
            HeaderStyle = ColumnHeaderStyle.Nonclickable,
            OwnerDraw = true
        };
        listView.Columns.Add("Process Name", 180);
        listView.Columns.Add("PID", 90);
        listView.Columns.Add("Injected", 110);

        listView.DrawColumnHeader += (s, e) =>
        {
            using var bgBrush = new SolidBrush(BG_TITLEBAR);
            using var textBrush = new SolidBrush(Color.FromArgb(160, 160, 160));
            using var font = new Font("Segoe UI", 9f);
            using var sf = new StringFormat
            {
                Alignment = StringAlignment.Near,
                LineAlignment = StringAlignment.Center
            };

            var textRect = new Rectangle(
                e.Bounds.X + 6, e.Bounds.Y,
                e.Bounds.Width - 6, e.Bounds.Height
            );

            e.Graphics.FillRectangle(bgBrush, e.Bounds);

            using var pen = new Pen(BORDER_COLOR);
            e.Graphics.DrawLine(pen,
                e.Bounds.Left, e.Bounds.Bottom - 1,
                e.Bounds.Right, e.Bounds.Bottom - 1);

            e.Graphics.DrawString(e.Header.Text, font, textBrush, textRect, sf);
        };

        listView.DrawItem += (s, e) => e.DrawDefault = true;
        listView.DrawSubItem += (s, e) => e.DrawDefault = true;

        Panel bottomBar = new Panel
        {
            Dock = DockStyle.Bottom,
            Height = 42,
            BackColor = BG_DARK
        };

        refreshButton = new Button
        {
            Text = "Refresh",
            ForeColor = TEXT_COLOR,
            BackColor = BTN_NORMAL,
            FlatStyle = FlatStyle.Flat,
            Size = new Size(110, 30),
            Cursor = Cursors.Hand,
            Font = new Font("Segoe UI", 9f),
            Location = new Point(8, 6)
        };
        refreshButton.FlatAppearance.BorderSize = 0;
        refreshButton.FlatAppearance.MouseOverBackColor = BTN_HOVER;
        refreshButton.Click += (s, e) => LoadProcesses();

        bottomBar.Controls.Add(refreshButton);

        this.Paint += (s, e) =>
        {
            using var pen = new Pen(BORDER_COLOR);
            e.Graphics.DrawRectangle(pen,
                0, 0,
                this.ClientSize.Width - 1,
                this.ClientSize.Height - 1);
        };

        this.Controls.Add(listView);
        this.Controls.Add(bottomBar);
        this.Controls.Add(titleBar);
    }

    private void LoadProcesses()
    {
        listView.Items.Clear();

        Process[] processes = Process.GetProcessesByName("RobloxPlayerBeta");
        if (processes.Length == 0)
        {
            listView.Items.Add(new ListViewItem(new[] { "Roblox not found", "-", "-" })
            {
                ForeColor = Color.White
            });
            return;
        }

        foreach (Process p in processes)
        {
            bool injected = vel.IsAttached(p.Id);
            var item = new ListViewItem(new[]
            {
                p.ProcessName,
                p.Id.ToString(),
                injected ? "Yes" : "No"
            })
            {
                ForeColor = injected
                    ? Color.FromArgb(100, 220, 100)
                    : Color.White
            };
            listView.Items.Add(item);
        }
    }
}
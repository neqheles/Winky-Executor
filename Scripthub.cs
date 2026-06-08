using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VelocityAPI;

namespace Synapse_X_Remake
{
    public partial class Scripthub : Form
    {
        public event Action<string>? OnScriptSelected;
        private VelAPI vel = new VelAPI();

        private Dictionary<string, string> scripts = new Dictionary<string, string>
    {
        { "Solara Hub (keysystem)", "loadstring(game:HttpGet('https://raw.githubusercontent.com/samuraa1/Solara-Hub/refs/heads/main/SH.lua'))()" },
        { "UNC Test Env", "loadstring(game:HttpGet('https://raw.githubusercontent.com/unified-naming-convention/NamingStandard/main/UNCCheckEnv/UNCCheckEnv.lua'))()" },
        { "Infinite Yield", "loadstring(game:HttpGet('https://raw.githubusercontent.com/EdgeIY/infinite-yield/master/source'))()" },
    };
        private Point mouseLocation;
        public Scripthub()
        {
            InitializeComponent();
            this.ScriptBox = new System.Windows.Forms.RichTextBox();
            this.ScriptBox.BackColor = Color.FromArgb(50, 50, 50);
            this.ScriptBox.ForeColor = Color.White;
            this.ScriptBox.BorderStyle = BorderStyle.None;
            this.ScriptBox.ReadOnly = true;
            this.ScriptBox.Location = new Point(4, 4);
            this.ScriptBox.Size = new Size(294, 183);
            this.ScriptBox.Font = new Font("Consolas", 9.75F);
            this.ScriptBox.Name = "ScriptBox";
            this.ScriptPanel.Controls.Add(ScriptBox);
        }

        private void InitializeUI()
        {

        }
        private async void Scripthub_Load(object sender, EventArgs e)
        {
        }

        private void mouse_down(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);

        }

        private void mouse_move(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void SolaraHub_Click(object sender, EventArgs e)
        {
            SetScript("Solara Hub (keysystem)");
        }

        private async void Execute_Click(object sender, EventArgs e)
        {
            OnScriptSelected?.Invoke(ScriptBox.Text);
        }

        private void UnnamedESP_Click(object sender, EventArgs e)
        {
        }

        private void UncTest_Click(object sender, EventArgs e)
        {
            SetScript("UNC Test Env");
        }

        private void UniversalAimbot_Click(object sender, EventArgs e)
        {
        }

        private void InfYield_Click(object sender, EventArgs e)
        {
            SetScript("Infinite Yield");
        }

        private void cuiButton1_Click(object sender, EventArgs e)
        {

        }
        private async void SetScript(string name)
        {
            if (scripts.ContainsKey(name))
            {
                ScriptBox.Text = scripts[name];
                ScriptBox.BringToFront();
            }
        }

        private void ScriptPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

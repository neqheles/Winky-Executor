using _123;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VelocityAPI;

namespace Synapse_X_Remake
{
    public partial class WinkyExecutor : Form
    {
        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        private static extern bool AllocConsole();
        private VelAPI vel = new VelAPI();
        private Point mouseLocation;
        private bool consoleOpen = false;
        public WinkyExecutor()
        {
            InitializeComponent();
            this.TopMost = true;
            vel.StartCommunication();
            this.Load += async (s, e) =>
            {
                {
                    await Editor.EnsureCoreWebView2Async(null);
                    string html = @"<!DOCTYPE html>
<html>
<head>
    <meta charset='utf-8'>
    <style>* { margin: 0; padding: 0; } body { background: #2d2d2d; } #editor { width: 100vw; height: 100vh; }</style>
</head>
<body>
    <div id='editor'></div>
    <script src='https://cdnjs.cloudflare.com/ajax/libs/monaco-editor/0.44.0/min/vs/loader.min.js'></script>
    <script>
        require.config({ paths: { 'vs': 'https://cdnjs.cloudflare.com/ajax/libs/monaco-editor/0.44.0/min/vs' }});
        require(['vs/editor/editor.main'], function() {
            monaco.editor.create(document.getElementById('editor'), {
                value: '',
                language: 'lua',
                theme: 'vs-dark',
                fontSize: 14,
                minimap: { enabled: false }
            });
        });
    </script>
</body>
</html>";
                    Editor.CoreWebView2.NavigateToString(html);
                };
            };
        }

        private void ScripthubBtn_Click(object sender, EventArgs e)
        {
            Form scripthub = Application.OpenForms["ScripthubForm"];
            if (scripthub == null)
            {
                Scripthub s = new Scripthub();
                s.OnScriptSelected += async (code) =>
                {
                    string escaped = code.Replace("\\", "\\\\").Replace("`", "\\`");
                    await Editor.CoreWebView2.ExecuteScriptAsync(
                        $"monaco.editor.getModels()[0].setValue(`{escaped}`);"
                    );
                };
                s.Show();
            }
            else
            {
                scripthub.BringToFront();
            }
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void AttachBtn_Click(object sender, EventArgs e)
        {
            Process[] processes = Process.GetProcessesByName("RobloxPlayerBeta");
            if (processes.Length == 0)
            {
                Logger.Error("process not found!");
                return;
            }
            int pid = processes[0].Id;
            Logger.Attach($"pwn attempt in PID {pid}...");
            await vel.Attach(pid);
            Logger.Attach($"successfuly pwned! PID {pid}");
        }
        private async void ExecuteBtn_Click(object sender, EventArgs e)
        {
            string rawscript = await Editor.CoreWebView2.ExecuteScriptAsync(
                "monaco.editor.getModels()[0].getValue();"
            );
            rawscript = rawscript.Trim('"').Replace("\\n", "\n").Replace("\\r", "\r").Replace("\\t", "\t");
            Logger.Script($"exec running... ({rawscript.Length} characters)");
            VelocityStates result = vel.Execute(rawscript);
            if (result == VelocityStates.Executed)
                Logger.Success("exec success!");
            else
                Logger.Error($"error exec: {result}");
        }

        private async void TabsButton1_Click(object sender, EventArgs e)
        {
            RobloxProcesses form = new RobloxProcesses(vel);
            form.Show();
        }
        private async void ClearBtn_Click(object sender, EventArgs e)
        {
            await Editor.CoreWebView2.ExecuteScriptAsync(
                "monaco.editor.getModels()[0].setValue('');"
            );
        }
        private async void SaveBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Lua files (*.lua)|*.lua|All files (*.*)|*.*";
            dialog.DefaultExt = "lua";
            dialog.Title = "Save";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string rawscript = await Editor.CoreWebView2.ExecuteScriptAsync(
                    "monaco.editor.getModels()[0].getValue();"
                );
                rawscript = rawscript.Trim('"').Replace("\\n", "\n").Replace("\\r", "\r").Replace("\\t", "\t");
                File.WriteAllText(dialog.FileName, rawscript);
                Logger.Success($"lua file saved!: {dialog.FileName}");
            }
        }
        private async void Loadbutton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Lua files (*.lua)|*.lua|All files (*.*)|*.*";
            dialog.Title = "Open";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string code = File.ReadAllText(dialog.FileName);
                string escaped = code.Replace("\\", "\\\\").Replace("`", "\\`");
                await Editor.CoreWebView2.ExecuteScriptAsync(
                    $"monaco.editor.getModels()[0].setValue(`{escaped}`);"
                );
                Logger.Info($"lua file pasted!: {dialog.FileName}");
            }
        }

        private void Title_Click(object sender, EventArgs e)
        {
            WINKY form = new WINKY(vel);
            form.Show();
        }

        private void SynLogo_Click(object sender, EventArgs e)
        {
            if (!consoleOpen)
            {
                Logger.Init();
                consoleOpen = true;
            }
        }
    }
}
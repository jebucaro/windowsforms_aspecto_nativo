using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Taskbar;

namespace IndicadorDeProgreso
{    
    public partial class MainForm : Form
    {
        private readonly TaskbarManager windowTaskbar = TaskbarManager.Instance;
        public MainForm()
        {
            // use Segoe UI in Vista & 7
            Font = SystemFonts.MessageBoxFont;

            InitializeComponent();

            windowTaskbar.ApplicationId = "IndicadorDeProgreso";
        }

        private void BtnNormal_Click(object sender, EventArgs e)
        {
            windowTaskbar.SetProgressState(TaskbarProgressBarState.Normal);
        }

        private void BtnError_Click(object sender, EventArgs e)
        {
            windowTaskbar.SetProgressState(TaskbarProgressBarState.Error);
        }

        private void BtnPaused_Click(object sender, EventArgs e)
        {
            windowTaskbar.SetProgressState(TaskbarProgressBarState.Paused);
        }

        private void BtnNoProgress_Click(object sender, EventArgs e)
        {
            windowTaskbar.SetProgressState(TaskbarProgressBarState.NoProgress);
            tkbProgress.Value = 0;
        }

        private void BtnIndeterminate_Click(object sender, EventArgs e)
        {
            windowTaskbar.SetProgressState(TaskbarProgressBarState.Indeterminate);
        }

        private void TkbProgress_Scroll(object sender, EventArgs e)
        {
            windowTaskbar.SetProgressValue(tkbProgress.Value, tkbProgress.Maximum);
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            windowTaskbar.SetProgressState(TaskbarProgressBarState.NoProgress);
            windowTaskbar.SetProgressValue(tkbProgress.Value, tkbProgress.Maximum);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ArunaRecorder
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void onTopButton_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = (sender as CheckBox).Checked;
        }

        private void captureImageButton_Click(object sender, EventArgs e)
        {
            // to check the operating system type
            if (System.Environment.Is64BitOperatingSystem)
            {
                Process.Start(@"C:\Program Files (x86)\Skillbrains\lightshot\Lightshot.exe");
            }
            else
            {
                Process.Start(@"C:\Program Files\Skillbrains\lightshot\Lightshot.exe");
            }
        }

        private void captureVideoButton_Click(object sender, EventArgs e)
        {
            var selectPathDialog = new SelectPathWindow();
            if(selectPathDialog.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                var selectedPath = selectPathDialog.SelectedPath;
                // use selected path here

            }
        }
    }
}

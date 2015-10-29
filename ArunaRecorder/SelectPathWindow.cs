using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArunaRecorder
{
    public partial class SelectPathWindow : Form
    {
        public string FileName { get; set; }
        public string FolderName { get; set; }
        public string SelectedPath { get { return FolderName + "\\" + FileName; } }

        public SelectPathWindow()
        {
            InitializeComponent();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                folderLocationTextBox.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(this, "Please fill the filename and choose the folder!"
                    , "Save failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private bool isValid()
        {
            if (!string.IsNullOrWhiteSpace(fileNameTextBox.Text) 
                && !string.IsNullOrWhiteSpace(folderLocationTextBox.Text))
            {
                FileName = fileNameTextBox.Text;
                FolderName = folderLocationTextBox.Text;
                return true;
            }

            return false;
        }

    }
}

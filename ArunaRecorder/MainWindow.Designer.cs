namespace ArunaRecorder
{
    partial class MainWindow
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
            this.onTopButton = new System.Windows.Forms.CheckBox();
            this.captureVideoButton = new System.Windows.Forms.Button();
            this.captureImageButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // onTopButton
            // 
            this.onTopButton.AutoSize = true;
            this.onTopButton.Location = new System.Drawing.Point(33, 109);
            this.onTopButton.Name = "onTopButton";
            this.onTopButton.Size = new System.Drawing.Size(92, 17);
            this.onTopButton.TabIndex = 2;
            this.onTopButton.Text = "Always on top";
            this.onTopButton.UseVisualStyleBackColor = true;
            this.onTopButton.CheckedChanged += new System.EventHandler(this.onTopButton_CheckedChanged);
            // 
            // captureVideoButton
            // 
            this.captureVideoButton.BackgroundImage = global::ArunaRecorder.Properties.Resources.button_pensize;
            this.captureVideoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.captureVideoButton.Location = new System.Drawing.Point(179, 27);
            this.captureVideoButton.Name = "captureVideoButton";
            this.captureVideoButton.Size = new System.Drawing.Size(113, 62);
            this.captureVideoButton.TabIndex = 1;
            this.captureVideoButton.UseVisualStyleBackColor = true;
            this.captureVideoButton.Click += new System.EventHandler(this.captureVideoButton_Click);
            // 
            // captureImageButton
            // 
            this.captureImageButton.BackgroundImage = global::ArunaRecorder.Properties.Resources.main_button;
            this.captureImageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.captureImageButton.Location = new System.Drawing.Point(33, 27);
            this.captureImageButton.Name = "captureImageButton";
            this.captureImageButton.Size = new System.Drawing.Size(113, 62);
            this.captureImageButton.TabIndex = 0;
            this.captureImageButton.UseVisualStyleBackColor = true;
            this.captureImageButton.Click += new System.EventHandler(this.captureImageButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 137);
            this.Controls.Add(this.onTopButton);
            this.Controls.Add(this.captureVideoButton);
            this.Controls.Add(this.captureImageButton);
            this.Name = "MainWindow";
            this.Text = "Aruna Recorder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button captureImageButton;
        private System.Windows.Forms.Button captureVideoButton;
        private System.Windows.Forms.CheckBox onTopButton;
    }
}


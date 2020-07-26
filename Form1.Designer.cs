namespace SpaceEngineersUnlocker
{
    partial class MainForm
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
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.PathOpen = new System.Windows.Forms.Button();
            this.PathText = new System.Windows.Forms.TextBox();
            this.PathLabel = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(697, 51);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(75, 23);
            this.ConfirmButton.TabIndex = 0;
            this.ConfirmButton.Text = "Unlock";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // PathOpen
            // 
            this.PathOpen.Location = new System.Drawing.Point(697, 12);
            this.PathOpen.Name = "PathOpen";
            this.PathOpen.Size = new System.Drawing.Size(75, 23);
            this.PathOpen.TabIndex = 1;
            this.PathOpen.Text = "Select";
            this.PathOpen.UseVisualStyleBackColor = true;
            this.PathOpen.Click += new System.EventHandler(this.PathOpen_Click);
            // 
            // PathText
            // 
            this.PathText.Location = new System.Drawing.Point(147, 14);
            this.PathText.Name = "PathText";
            this.PathText.Size = new System.Drawing.Size(544, 20);
            this.PathText.TabIndex = 2;
            // 
            // PathLabel
            // 
            this.PathLabel.AutoSize = true;
            this.PathLabel.Location = new System.Drawing.Point(12, 17);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(135, 13);
            this.PathLabel.TabIndex = 3;
            this.PathLabel.Text = "Space Engineers Location:";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(15, 51);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(676, 23);
            this.progressBar.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 86);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.PathLabel);
            this.Controls.Add(this.PathText);
            this.Controls.Add(this.PathOpen);
            this.Controls.Add(this.ConfirmButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(800, 125);
            this.MinimumSize = new System.Drawing.Size(800, 125);
            this.Name = "MainForm";
            this.Text = "SpaceEngineersUnlocker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Button PathOpen;
        private System.Windows.Forms.TextBox PathText;
        private System.Windows.Forms.Label PathLabel;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}


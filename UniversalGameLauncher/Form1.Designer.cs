namespace UniversalGameLauncher {
    partial class Application {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.playButton = new System.Windows.Forms.Button();
            this.updateProgressBar = new System.Windows.Forms.ProgressBar();
            this.updateLabelText = new System.Windows.Forms.Label();
            this.currentVersionLabel = new System.Windows.Forms.Label();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.navbarButton1 = new System.Windows.Forms.Button();
            this.navbarPanel = new System.Windows.Forms.Panel();
            this.navbarButton4 = new System.Windows.Forms.Button();
            this.navbarButton3 = new System.Windows.Forms.Button();
            this.navbarButton2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.navbarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Font = new System.Drawing.Font("Source Sans Pro Semibold", 25.25F, System.Drawing.FontStyle.Bold);
            this.playButton.Location = new System.Drawing.Point(825, 571);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(191, 60);
            this.playButton.TabIndex = 0;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.OnClickPlay);
            // 
            // updateProgressBar
            // 
            this.updateProgressBar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.updateProgressBar.Location = new System.Drawing.Point(17, 571);
            this.updateProgressBar.Name = "updateProgressBar";
            this.updateProgressBar.Size = new System.Drawing.Size(802, 60);
            this.updateProgressBar.TabIndex = 1;
            // 
            // updateLabelText
            // 
            this.updateLabelText.BackColor = System.Drawing.Color.Transparent;
            this.updateLabelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.updateLabelText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.updateLabelText.Location = new System.Drawing.Point(17, 527);
            this.updateLabelText.Name = "updateLabelText";
            this.updateLabelText.Size = new System.Drawing.Size(802, 30);
            this.updateLabelText.TabIndex = 2;
            this.updateLabelText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentVersionLabel
            // 
            this.currentVersionLabel.AutoSize = true;
            this.currentVersionLabel.BackColor = System.Drawing.Color.Transparent;
            this.currentVersionLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.currentVersionLabel.Location = new System.Drawing.Point(18, 544);
            this.currentVersionLabel.Name = "currentVersionLabel";
            this.currentVersionLabel.Size = new System.Drawing.Size(40, 13);
            this.currentVersionLabel.TabIndex = 3;
            this.currentVersionLabel.Text = "1.0.0.0";
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.logoPictureBox.Location = new System.Drawing.Point(5, 8);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(280, 58);
            this.logoPictureBox.TabIndex = 0;
            this.logoPictureBox.TabStop = false;
            // 
            // navbarButton1
            // 
            this.navbarButton1.BackColor = System.Drawing.Color.Transparent;
            this.navbarButton1.FlatAppearance.BorderSize = 0;
            this.navbarButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.navbarButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.navbarButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navbarButton1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.navbarButton1.Location = new System.Drawing.Point(398, 0);
            this.navbarButton1.Name = "navbarButton1";
            this.navbarButton1.Size = new System.Drawing.Size(125, 72);
            this.navbarButton1.TabIndex = 0;
            this.navbarButton1.Text = "Website";
            this.navbarButton1.UseVisualStyleBackColor = true;
            // 
            // navbarPanel
            // 
            this.navbarPanel.BackColor = System.Drawing.Color.Transparent;
            this.navbarPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.navbarPanel.Controls.Add(this.logoPictureBox);
            this.navbarPanel.Controls.Add(this.navbarButton4);
            this.navbarPanel.Controls.Add(this.navbarButton3);
            this.navbarPanel.Controls.Add(this.navbarButton2);
            this.navbarPanel.Controls.Add(this.navbarButton1);
            this.navbarPanel.Location = new System.Drawing.Point(0, -1);
            this.navbarPanel.Name = "navbarPanel";
            this.navbarPanel.Size = new System.Drawing.Size(1028, 75);
            this.navbarPanel.TabIndex = 0;
            // 
            // navbarButton4
            // 
            this.navbarButton4.BackColor = System.Drawing.Color.Transparent;
            this.navbarButton4.FlatAppearance.BorderSize = 0;
            this.navbarButton4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.navbarButton4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.navbarButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navbarButton4.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.navbarButton4.Location = new System.Drawing.Point(788, 0);
            this.navbarButton4.Name = "navbarButton4";
            this.navbarButton4.Size = new System.Drawing.Size(125, 72);
            this.navbarButton4.TabIndex = 0;
            this.navbarButton4.Text = "Discord";
            this.navbarButton4.UseVisualStyleBackColor = true;
            // 
            // navbarButton3
            // 
            this.navbarButton3.BackColor = System.Drawing.Color.Transparent;
            this.navbarButton3.FlatAppearance.BorderSize = 0;
            this.navbarButton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.navbarButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.navbarButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navbarButton3.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.navbarButton3.Location = new System.Drawing.Point(658, 0);
            this.navbarButton3.Name = "navbarButton3";
            this.navbarButton3.Size = new System.Drawing.Size(125, 72);
            this.navbarButton3.TabIndex = 0;
            this.navbarButton3.Text = "Support";
            this.navbarButton3.UseVisualStyleBackColor = false;
            // 
            // navbarButton2
            // 
            this.navbarButton2.BackColor = System.Drawing.Color.Transparent;
            this.navbarButton2.FlatAppearance.BorderSize = 0;
            this.navbarButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.navbarButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.navbarButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navbarButton2.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.navbarButton2.Location = new System.Drawing.Point(528, 0);
            this.navbarButton2.Name = "navbarButton2";
            this.navbarButton2.Size = new System.Drawing.Size(125, 72);
            this.navbarButton2.TabIndex = 0;
            this.navbarButton2.Text = "Community";
            this.navbarButton2.UseVisualStyleBackColor = true;
            // 
            // Application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::UniversalGameLauncher.Properties.Resources.Fantasy_Background_1028x643;
            this.ClientSize = new System.Drawing.Size(1028, 643);
            this.Controls.Add(this.navbarPanel);
            this.Controls.Add(this.currentVersionLabel);
            this.Controls.Add(this.updateLabelText);
            this.Controls.Add(this.updateProgressBar);
            this.Controls.Add(this.playButton);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Application";
            this.Text = "Temsei Game Launcher";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.OnLoadApplication);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Application_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.navbarPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.ProgressBar updateProgressBar;
        private System.Windows.Forms.Label updateLabelText;
        private System.Windows.Forms.Label currentVersionLabel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Button navbarButton1;
        private System.Windows.Forms.Button navbarButton4;
        private System.Windows.Forms.Button navbarButton3;
        private System.Windows.Forms.Button navbarButton2;
        private System.Windows.Forms.Panel navbarPanel;
    }
}


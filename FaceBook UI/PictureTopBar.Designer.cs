namespace WinFormUI
{
    partial class PictureTopBar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.topPanel = new System.Windows.Forms.Panel();
            this.pictureBoxUsers = new System.Windows.Forms.PictureBox();
            this.labelTopText = new System.Windows.Forms.Label();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.topPanel.BackColor = System.Drawing.Color.White;
            this.topPanel.Controls.Add(this.labelTopText);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "panel1";
            this.topPanel.Size = new System.Drawing.Size(198, 50);
            this.topPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBoxUsers.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBoxUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxUsers.Location = new System.Drawing.Point(0, 50);
            this.pictureBoxUsers.Name = "pictureBox1";
            this.pictureBoxUsers.Size = new System.Drawing.Size(198, 198);
            this.pictureBoxUsers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUsers.TabIndex = 1;
            this.pictureBoxUsers.TabStop = false;
            // 
            // label1
            // 
            this.labelTopText.AutoSize = true;
            this.labelTopText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTopText.Location = new System.Drawing.Point(6, 11);
            this.labelTopText.Name = "label1";
            this.labelTopText.Size = new System.Drawing.Size(79, 29);
            this.labelTopText.TabIndex = 0;
            this.labelTopText.Text = "label1";
            // 
            // PictureTopBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pictureBoxUsers);
            this.Controls.Add(this.topPanel);
            this.Name = "PictureTopBar";
            this.Size = new System.Drawing.Size(198, 248);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label labelTopText;
        private System.Windows.Forms.PictureBox pictureBoxUsers;
    }
}

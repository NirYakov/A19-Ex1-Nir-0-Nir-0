namespace A19_Ex1_Nir_0_Nir_0
{
    partial class FormPostSummary
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
            System.Windows.Forms.LinkLabel linkToPostOnFB;
            this.lableStatus = new System.Windows.Forms.Label();
            this.lableFriendsWhoLikes = new System.Windows.Forms.Label();
            linkToPostOnFB = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // linkToPostOnFB
            // 
            linkToPostOnFB.AutoSize = true;
            linkToPostOnFB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            linkToPostOnFB.Location = new System.Drawing.Point(12, 345);
            linkToPostOnFB.Name = "linkToPostOnFB";
            linkToPostOnFB.Size = new System.Drawing.Size(251, 25);
            linkToPostOnFB.TabIndex = 1;
            linkToPostOnFB.TabStop = true;
            linkToPostOnFB.Text = "Show in Facebook Website";
            linkToPostOnFB.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkToPostOnFB_LinkClicked);
            // 
            // lableStatus
            // 
            this.lableStatus.AutoSize = true;
            this.lableStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableStatus.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lableStatus.Location = new System.Drawing.Point(33, 9);
            this.lableStatus.Name = "lableStatus";
            this.lableStatus.Size = new System.Drawing.Size(35, 36);
            this.lableStatus.TabIndex = 0;
            this.lableStatus.Text = "--";
            this.lableStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lableFriendsWhoLikes
            // 
            this.lableFriendsWhoLikes.AutoSize = true;
            this.lableFriendsWhoLikes.Location = new System.Drawing.Point(111, 106);
            this.lableFriendsWhoLikes.Name = "lableFriendsWhoLikes";
            this.lableFriendsWhoLikes.Size = new System.Drawing.Size(19, 20);
            this.lableFriendsWhoLikes.TabIndex = 2;
            this.lableFriendsWhoLikes.Text = "--";
            // 
            // FormPostSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 379);
            this.Controls.Add(this.lableFriendsWhoLikes);
            this.Controls.Add(linkToPostOnFB);
            this.Controls.Add(this.lableStatus);
            this.Name = "FormPostSummary";
            this.Text = "FormPostSummary";
            this.Load += new System.EventHandler(this.FormPostSummary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lableStatus;
        private System.Windows.Forms.Label lableFriendsWhoLikes;
    }
}
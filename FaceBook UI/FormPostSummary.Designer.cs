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
            this.listBoxComments = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelNumOfLikes = new System.Windows.Forms.Label();
            linkToPostOnFB = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // linkToPostOnFB
            // 
            linkToPostOnFB.AutoSize = true;
            linkToPostOnFB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            linkToPostOnFB.Location = new System.Drawing.Point(8, 224);
            linkToPostOnFB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            linkToPostOnFB.Name = "linkToPostOnFB";
            linkToPostOnFB.Size = new System.Drawing.Size(178, 17);
            linkToPostOnFB.TabIndex = 1;
            linkToPostOnFB.TabStop = true;
            linkToPostOnFB.Text = "Show in Facebook Website";
            linkToPostOnFB.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkToPostOnFB_LinkClicked);
            // 
            // lableStatus
            // 
            this.lableStatus.AutoSize = true;
            this.lableStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.lableStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableStatus.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lableStatus.Location = new System.Drawing.Point(0, 0);
            this.lableStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lableStatus.Name = "lableStatus";
            this.lableStatus.Size = new System.Drawing.Size(26, 25);
            this.lableStatus.TabIndex = 0;
            this.lableStatus.Text = "--";
            // 
            // listBoxComments
            // 
            this.listBoxComments.FormattingEnabled = true;
            this.listBoxComments.Location = new System.Drawing.Point(234, 126);
            this.listBoxComments.Name = "listBoxComments";
            this.listBoxComments.Size = new System.Drawing.Size(461, 95);
            this.listBoxComments.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Likes : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Comments:";
            // 
            // labelNumOfLikes
            // 
            this.labelNumOfLikes.AutoSize = true;
            this.labelNumOfLikes.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumOfLikes.Location = new System.Drawing.Point(65, 120);
            this.labelNumOfLikes.Name = "labelNumOfLikes";
            this.labelNumOfLikes.Size = new System.Drawing.Size(72, 76);
            this.labelNumOfLikes.TabIndex = 6;
            this.labelNumOfLikes.Text = "=";
            // 
            // FormPostSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 246);
            this.Controls.Add(this.labelNumOfLikes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxComments);
            this.Controls.Add(linkToPostOnFB);
            this.Controls.Add(this.lableStatus);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormPostSummary";
            this.Text = "FormPostSummary";
            this.Load += new System.EventHandler(this.FormPostSummary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lableStatus;
        private System.Windows.Forms.ListBox listBoxComments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelNumOfLikes;
    }
}
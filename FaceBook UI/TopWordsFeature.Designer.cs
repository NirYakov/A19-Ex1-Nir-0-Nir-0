namespace WinFormUI
{
    partial class TopWordsFeature
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
            this.listboxTotalPosts = new System.Windows.Forms.ListBox();
            this.listBoxTopWords = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSumTot = new System.Windows.Forms.Label();
            this.textBoxWordToAnalysis = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonLikes = new System.Windows.Forms.RadioButton();
            this.radioButtonAlphabetical = new System.Windows.Forms.RadioButton();
            this.radioButtonRecent = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listboxTotalPosts
            // 
            this.listboxTotalPosts.FormattingEnabled = true;
            this.listboxTotalPosts.ItemHeight = 25;
            this.listboxTotalPosts.Location = new System.Drawing.Point(16, 81);
            this.listboxTotalPosts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listboxTotalPosts.Name = "listboxTotalPosts";
            this.listboxTotalPosts.Size = new System.Drawing.Size(411, 379);
            this.listboxTotalPosts.TabIndex = 0;
            // 
            // listBoxTopWords
            // 
            this.listBoxTopWords.FormattingEnabled = true;
            this.listBoxTopWords.ItemHeight = 25;
            this.listBoxTopWords.Location = new System.Drawing.Point(436, 81);
            this.listBoxTopWords.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxTopWords.Name = "listBoxTopWords";
            this.listBoxTopWords.Size = new System.Drawing.Size(213, 379);
            this.listBoxTopWords.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 571);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total Posts:";
            // 
            // labelSumTot
            // 
            this.labelSumTot.AutoSize = true;
            this.labelSumTot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSumTot.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelSumTot.Location = new System.Drawing.Point(144, 571);
            this.labelSumTot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSumTot.Name = "labelSumTot";
            this.labelSumTot.Size = new System.Drawing.Size(28, 26);
            this.labelSumTot.TabIndex = 4;
            this.labelSumTot.Text = "--";
            // 
            // textBoxWordToAnalysis
            // 
            this.textBoxWordToAnalysis.Location = new System.Drawing.Point(16, 41);
            this.textBoxWordToAnalysis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxWordToAnalysis.Name = "textBoxWordToAnalysis";
            this.textBoxWordToAnalysis.Size = new System.Drawing.Size(253, 31);
            this.textBoxWordToAnalysis.TabIndex = 7;
            this.textBoxWordToAnalysis.TextChanged += new System.EventHandler(this.textBoxWordToAnalysis_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.YellowGreen;
            this.label2.Location = new System.Drawing.Point(440, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 41);
            this.label2.TabIndex = 8;
            this.label2.Text = "Top Words:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 601);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(420, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "(Double click on status to show full details)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonLikes);
            this.groupBox1.Controls.Add(this.radioButtonAlphabetical);
            this.groupBox1.Controls.Add(this.radioButtonRecent);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(24, 469);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(547, 91);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sort By";
            // 
            // radioButtonLikes
            // 
            this.radioButtonLikes.AutoSize = true;
            this.radioButtonLikes.Location = new System.Drawing.Point(292, 31);
            this.radioButtonLikes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonLikes.Name = "radioButtonLikes";
            this.radioButtonLikes.Size = new System.Drawing.Size(94, 29);
            this.radioButtonLikes.TabIndex = 2;
            this.radioButtonLikes.TabStop = true;
            this.radioButtonLikes.Text = "Likes";
            this.radioButtonLikes.UseVisualStyleBackColor = true;
            // 
            // radioButtonAlphabetical
            // 
            this.radioButtonAlphabetical.AutoSize = true;
            this.radioButtonAlphabetical.Location = new System.Drawing.Point(125, 32);
            this.radioButtonAlphabetical.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonAlphabetical.Name = "radioButtonAlphabetical";
            this.radioButtonAlphabetical.Size = new System.Drawing.Size(159, 29);
            this.radioButtonAlphabetical.TabIndex = 1;
            this.radioButtonAlphabetical.TabStop = true;
            this.radioButtonAlphabetical.Text = "alphabetical";
            this.radioButtonAlphabetical.UseVisualStyleBackColor = true;
            // 
            // radioButtonRecent
            // 
            this.radioButtonRecent.AutoSize = true;
            this.radioButtonRecent.Location = new System.Drawing.Point(9, 32);
            this.radioButtonRecent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonRecent.Name = "radioButtonRecent";
            this.radioButtonRecent.Size = new System.Drawing.Size(111, 29);
            this.radioButtonRecent.TabIndex = 0;
            this.radioButtonRecent.TabStop = true;
            this.radioButtonRecent.Text = "Recent";
            this.radioButtonRecent.UseVisualStyleBackColor = true;
            // 
            // TopWordsFeature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 809);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxWordToAnalysis);
            this.Controls.Add(this.labelSumTot);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxTopWords);
            this.Controls.Add(this.listboxTotalPosts);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TopWordsFeature";
            this.Text = "TopWords";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listboxTotalPosts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSumTot;
        private System.Windows.Forms.TextBox textBoxWordToAnalysis;
        private System.Windows.Forms.ListBox listBoxTopWords;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonLikes;
        private System.Windows.Forms.RadioButton radioButtonAlphabetical;
        private System.Windows.Forms.RadioButton radioButtonRecent;
    }
}
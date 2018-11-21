namespace A19_Ex1_Nir_0_Nir_0
{
    partial class FeatureTwo
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
            this.SuspendLayout();
            // 
            // listboxTotalPosts
            // 
            this.listboxTotalPosts.FormattingEnabled = true;
            this.listboxTotalPosts.ItemHeight = 20;
            this.listboxTotalPosts.Location = new System.Drawing.Point(12, 65);
            this.listboxTotalPosts.Name = "listboxTotalPosts";
            this.listboxTotalPosts.Size = new System.Drawing.Size(309, 304);
            this.listboxTotalPosts.TabIndex = 0;
            // 
            // listBoxTopWords
            // 
            this.listBoxTopWords.FormattingEnabled = true;
            this.listBoxTopWords.ItemHeight = 20;
            this.listBoxTopWords.Location = new System.Drawing.Point(327, 65);
            this.listBoxTopWords.Name = "listBoxTopWords";
            this.listBoxTopWords.Size = new System.Drawing.Size(161, 304);
            this.listBoxTopWords.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total Posts:";
            // 
            // labelSumTot
            // 
            this.labelSumTot.AutoSize = true;
            this.labelSumTot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSumTot.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelSumTot.Location = new System.Drawing.Point(110, 372);
            this.labelSumTot.Name = "labelSumTot";
            this.labelSumTot.Size = new System.Drawing.Size(21, 20);
            this.labelSumTot.TabIndex = 4;
            this.labelSumTot.Text = "--";
            // 
            // textBoxWordToAnalysis
            // 
            this.textBoxWordToAnalysis.Location = new System.Drawing.Point(12, 33);
            this.textBoxWordToAnalysis.Name = "textBoxWordToAnalysis";
            this.textBoxWordToAnalysis.Size = new System.Drawing.Size(191, 26);
            this.textBoxWordToAnalysis.TabIndex = 7;
            this.textBoxWordToAnalysis.TextChanged += new System.EventHandler(this.textBoxWordToAnalysis_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.YellowGreen;
            this.label2.Location = new System.Drawing.Point(330, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "Top Words:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 396);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(307, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "(Double click on status to show full details)";
            // 
            // FeatureTwo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 483);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxWordToAnalysis);
            this.Controls.Add(this.labelSumTot);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxTopWords);
            this.Controls.Add(this.listboxTotalPosts);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FeatureTwo";
            this.Text = "FeatureTwo";
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
    }
}
namespace A19_Ex1_Nir_0_Nir_0
{
    partial class FormKeyWords
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
            this.lable_keyword = new System.Windows.Forms.Label();
            this.textBoxWordToSearch = new System.Windows.Forms.TextBox();
            this.btn_keywordsearch = new System.Windows.Forms.Button();
            this.lable_test = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lable_keyword
            // 
            this.lable_keyword.AutoSize = true;
            this.lable_keyword.Location = new System.Drawing.Point(44, 68);
            this.lable_keyword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lable_keyword.Name = "lable_keyword";
            this.lable_keyword.Size = new System.Drawing.Size(77, 20);
            this.lable_keyword.TabIndex = 1;
            this.lable_keyword.Text = "KeyWord:";
            // 
            // textBoxWordToSearch
            // 
            this.textBoxWordToSearch.Location = new System.Drawing.Point(134, 63);
            this.textBoxWordToSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxWordToSearch.Name = "textBoxWordToSearch";
            this.textBoxWordToSearch.Size = new System.Drawing.Size(238, 26);
            this.textBoxWordToSearch.TabIndex = 2;
            // 
            // btn_keywordsearch
            // 
            this.btn_keywordsearch.Location = new System.Drawing.Point(382, 62);
            this.btn_keywordsearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_keywordsearch.Name = "btn_keywordsearch";
            this.btn_keywordsearch.Size = new System.Drawing.Size(81, 31);
            this.btn_keywordsearch.TabIndex = 3;
            this.btn_keywordsearch.Text = "Search";
            this.btn_keywordsearch.UseVisualStyleBackColor = true;
            this.btn_keywordsearch.Click += new System.EventHandler(this.btn_keywordsearch_Click);
            // 
            // lable_test
            // 
            this.lable_test.AutoSize = true;
            this.lable_test.Location = new System.Drawing.Point(339, 206);
            this.lable_test.Name = "lable_test";
            this.lable_test.Size = new System.Drawing.Size(51, 20);
            this.lable_test.TabIndex = 4;
            this.lable_test.Text = "label1";
            // 
            // FormKeyWords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 772);
            this.Controls.Add(this.lable_test);
            this.Controls.Add(this.btn_keywordsearch);
            this.Controls.Add(this.textBoxWordToSearch);
            this.Controls.Add(this.lable_keyword);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormKeyWords";
            this.Text = "FormKeyWords";
            this.Load += new System.EventHandler(this.FormKeyWords_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lable_keyword;
        private System.Windows.Forms.TextBox textBoxWordToSearch;
        private System.Windows.Forms.Button btn_keywordsearch;
        private System.Windows.Forms.Label lable_test;
    }
}
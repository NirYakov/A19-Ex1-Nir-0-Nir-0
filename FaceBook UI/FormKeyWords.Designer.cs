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
            this.listView1 = new System.Windows.Forms.ListView();
            this.lable_keyword = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_keywordsearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(12, 95);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(542, 395);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // lable_keyword
            // 
            this.lable_keyword.AutoSize = true;
            this.lable_keyword.Location = new System.Drawing.Point(29, 44);
            this.lable_keyword.Name = "lable_keyword";
            this.lable_keyword.Size = new System.Drawing.Size(54, 13);
            this.lable_keyword.TabIndex = 1;
            this.lable_keyword.Text = "KeyWord:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(89, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 20);
            this.textBox1.TabIndex = 2;
            // 
            // btn_keywordsearch
            // 
            this.btn_keywordsearch.Location = new System.Drawing.Point(255, 40);
            this.btn_keywordsearch.Name = "btn_keywordsearch";
            this.btn_keywordsearch.Size = new System.Drawing.Size(54, 20);
            this.btn_keywordsearch.TabIndex = 3;
            this.btn_keywordsearch.Text = "Search";
            this.btn_keywordsearch.UseVisualStyleBackColor = true;
            // 
            // FormKeyWords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 502);
            this.Controls.Add(this.btn_keywordsearch);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lable_keyword);
            this.Controls.Add(this.listView1);
            this.Name = "FormKeyWords";
            this.Text = "FormKeyWords";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label lable_keyword;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_keywordsearch;
    }
}
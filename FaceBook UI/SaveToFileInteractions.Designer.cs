namespace WinFormUI
{
    partial class SaveToFileInteractions
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
            this.checkBoxPosts = new System.Windows.Forms.CheckBox();
            this.checkBoxCheckins = new System.Windows.Forms.CheckBox();
            this.checkBoxEvents = new System.Windows.Forms.CheckBox();
            this.checkBoxTagged = new System.Windows.Forms.CheckBox();
            this.groupBoxExtra = new System.Windows.Forms.GroupBox();
            this.labelMessageExplanie = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.folderBrowserDialogPath = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBoxExtra.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxPosts
            // 
            this.checkBoxPosts.AutoSize = true;
            this.checkBoxPosts.Location = new System.Drawing.Point(29, 60);
            this.checkBoxPosts.Name = "checkBoxPosts";
            this.checkBoxPosts.Size = new System.Drawing.Size(98, 29);
            this.checkBoxPosts.TabIndex = 0;
            this.checkBoxPosts.Text = "Posts";
            this.checkBoxPosts.UseVisualStyleBackColor = true;
            // 
            // checkBoxCheckins
            // 
            this.checkBoxCheckins.AutoSize = true;
            this.checkBoxCheckins.Location = new System.Drawing.Point(276, 60);
            this.checkBoxCheckins.Name = "checkBoxCheckins";
            this.checkBoxCheckins.Size = new System.Drawing.Size(133, 29);
            this.checkBoxCheckins.TabIndex = 1;
            this.checkBoxCheckins.Text = "Checkins";
            this.checkBoxCheckins.UseVisualStyleBackColor = true;
            // 
            // checkBoxEvents
            // 
            this.checkBoxEvents.AutoSize = true;
            this.checkBoxEvents.Location = new System.Drawing.Point(29, 115);
            this.checkBoxEvents.Name = "checkBoxEvents";
            this.checkBoxEvents.Size = new System.Drawing.Size(110, 29);
            this.checkBoxEvents.TabIndex = 2;
            this.checkBoxEvents.Text = "Events";
            this.checkBoxEvents.UseVisualStyleBackColor = true;
            // 
            // checkBoxTagged
            // 
            this.checkBoxTagged.AutoSize = true;
            this.checkBoxTagged.Location = new System.Drawing.Point(276, 115);
            this.checkBoxTagged.Name = "checkBoxTagged";
            this.checkBoxTagged.Size = new System.Drawing.Size(117, 29);
            this.checkBoxTagged.TabIndex = 3;
            this.checkBoxTagged.Text = "Tagged";
            this.checkBoxTagged.UseVisualStyleBackColor = true;
            // 
            // groupBoxExtra
            // 
            this.groupBoxExtra.Controls.Add(this.checkBoxTagged);
            this.groupBoxExtra.Controls.Add(this.checkBoxPosts);
            this.groupBoxExtra.Controls.Add(this.checkBoxEvents);
            this.groupBoxExtra.Controls.Add(this.checkBoxCheckins);
            this.groupBoxExtra.Location = new System.Drawing.Point(27, 199);
            this.groupBoxExtra.Name = "groupBoxExtra";
            this.groupBoxExtra.Size = new System.Drawing.Size(452, 172);
            this.groupBoxExtra.TabIndex = 4;
            this.groupBoxExtra.TabStop = false;
            this.groupBoxExtra.Text = "Save Extra Interactions Numbers Of";
            // 
            // labelMessageExplanie
            // 
            this.labelMessageExplanie.AutoSize = true;
            this.labelMessageExplanie.Location = new System.Drawing.Point(22, 84);
            this.labelMessageExplanie.Name = "labelMessageExplanie";
            this.labelMessageExplanie.Size = new System.Drawing.Size(363, 75);
            this.labelMessageExplanie.TabIndex = 5;
            this.labelMessageExplanie.Text = "In Addition to the Name and Stars \r\nYou can info extra data.\r\nTo add press v in a" +
    "ny field you want.";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.White;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelName.Location = new System.Drawing.Point(22, 31);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(97, 33);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "Name";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(28, 389);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 45);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // SaveToFileInteractions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 457);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelMessageExplanie);
            this.Controls.Add(this.groupBoxExtra);
            this.Name = "SaveToFileInteractions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Save Interactions";
            this.groupBoxExtra.ResumeLayout(false);
            this.groupBoxExtra.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxPosts;
        private System.Windows.Forms.CheckBox checkBoxCheckins;
        private System.Windows.Forms.CheckBox checkBoxEvents;
        private System.Windows.Forms.CheckBox checkBoxTagged;
        private System.Windows.Forms.GroupBox groupBoxExtra;
        private System.Windows.Forms.Label labelMessageExplanie;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogPath;
    }
}
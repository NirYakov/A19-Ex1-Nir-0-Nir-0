using FB_Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A19_Ex1_Nir_0_Nir_0
{
    public partial class SaveToFileInteractions : Form
    {
        public UserAnalysis m_UserAnalysisLoaded;
        public UserAnalysis UserAnalysisLoaded
        {
            get { return m_UserAnalysisLoaded; }
            set
            {
                m_UserAnalysisLoaded = value;
                labelName.Text = m_UserAnalysisLoaded.UserIn.Name;
            }
        }

        public SaveToFileInteractions()
        {
            InitializeComponent();
            labelName.BackColor = SettingUi.BackColorTheme();
            labelName.ForeColor = SettingUi.ForeColorTheme();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            folderBrowserDialogPath.ShowDialog();
            string pathToSaveIn = folderBrowserDialogPath.SelectedPath;

            if (pathToSaveIn != string.Empty)
            {
                const string fileEnding = "txt";
                string finalPath = string.Format(
                    @"{0}\{1}.{2}", pathToSaveIn, labelName.Text, fileEnding);

                if (File.Exists(finalPath))
                {
                    File.Delete(finalPath);
                }

                File.AppendAllText(finalPath, allDataToSave());
                MessageBox.Show("Saved!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please Choose a Valid Path.");
            }
        }

        private string allDataToSave()
        {
            StringBuilder stringBuilder = new StringBuilder(100);
            stringBuilder.AppendFormat(
        @"Name: {0}
Gold Stars: {1}
Normal Stars: {2}
", UserAnalysisLoaded.UserIn.Name
, UserAnalysisLoaded.MyStars.GoldenStars
, UserAnalysisLoaded.MyStars.NormalStars);

            if (checkBoxPosts.Checked)
            {
                stringBuilder.AppendFormat("Posts: {0}",UserAnalysisLoaded.PostInteraction).AppendLine();
            }

            if (checkBoxEvents.Checked)
            {
                stringBuilder.AppendFormat("Events: {0}", UserAnalysisLoaded.EventInteraction).AppendLine();
            }

            if (checkBoxCheckins.Checked)
            {
                stringBuilder.AppendFormat("Checkins: {0}", UserAnalysisLoaded.CheckinInteraction).AppendLine();
            }

            if (checkBoxTagged.Checked)
            {
                stringBuilder.AppendFormat("Tagged: {0}", UserAnalysisLoaded.TaggedInteraction).AppendLine();
            }

            return stringBuilder.ToString();
        }
    }
}

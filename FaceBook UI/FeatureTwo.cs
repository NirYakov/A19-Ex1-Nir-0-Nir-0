using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FB_Logic;

namespace A19_Ex1_Nir_0_Nir_0
{
    public partial class FeatureTwo : Form
    {
        private readonly PostAnalysis r_postAnalysis;

        public FeatureTwo(User i_User)
        {
            InitializeComponent();
            InitializeCustomeComponent();
            r_postAnalysis = new PostAnalysis(i_User);
            listboxTotalPosts.DataSource = r_postAnalysis.PostsListStr;
            labelSumTot.Text = listboxTotalPosts.Items.Count.ToString();
            PopulateListBoxTopWords();
        }

        private void InitializeCustomeComponent()
        {
            listboxTotalPosts.MouseDoubleClick += new MouseEventHandler(listboxTotalPosts_MouseDoubleClick);
            listBoxTopWords.SelectedIndexChanged += ListBoxTopWords_SelectedIndexChanged;
            radioButtonAlphabetical.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            radioButtonLikes.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            radioButtonRecent.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
        }

        private void ListBoxTopWords_SelectedIndexChanged(object sender, EventArgs e)
        {
            string stringToSearch = listBoxTopWords.GetItemText(listBoxTopWords.SelectedItem);
            textBoxWordToAnalysis.Text = stringToSearch;
        }


        private void PopulateListBoxTopWords()
        {
            listBoxTopWords.Items.Clear();
            Dictionary<string, int> topWords = r_postAnalysis.GetTopKWords();
            listBoxTopWords.DataSource = new BindingSource(topWords, null);
            listBoxTopWords.DisplayMember = "Key";
            listBoxTopWords.ValueMember = "Value";
        }
        
        private void listboxTotalPosts_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.listboxTotalPosts.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                FormPostSummary formPostSummary = new FormPostSummary(r_postAnalysis.PostsList[index]);
                formPostSummary.ShowDialog();
            }
        }


        private void textBoxWordToAnalysis_TextChanged(object sender, EventArgs e)
        {
            radioButtonRecent.Checked = true;
            string wordToAnalysis = textBoxWordToAnalysis.Text;
            listboxTotalPosts.DataSource = r_postAnalysis.GetPostsByWord(wordToAnalysis);
            labelSumTot.Text = listboxTotalPosts.Items.Count.ToString();
        }

        private void radioButtons_CheckedChanged(object sender, EventArgs e)
         {
            if (radioButtonAlphabetical.Checked)
            {
                listboxTotalPosts.DataSource = r_postAnalysis.SortAlphabetical();
            }
            else if(radioButtonLikes.Checked)
            {
                listboxTotalPosts.DataSource = r_postAnalysis.SortByNumOfLikes();
            }
            else
            {
                listboxTotalPosts.DataSource = r_postAnalysis.SortRecent();
            }
        }

    }
}
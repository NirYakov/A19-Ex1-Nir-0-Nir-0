using FacebookWrapper.ObjectModel;
using FB_Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace A19_Ex1_Nir_0_Nir_0
{
    public partial class FormKeyWords : Form
    {
        private readonly UserManager r_UserManager;

        public FormKeyWords()
        {
            InitializeComponent();
            r_UserManager = new UserManager();

        }

        private void btn_keywordsearch_Click(object sender, EventArgs e)
        {
            string wordToSearch = textBoxWordToSearch.ToString();
            int numOfAppears = r_UserManager.CountWordNumOfAppears(wordToSearch);
            lable_test.Text = numOfAppears.ToString();
        }

        private void FormKeyWords_Load(object sender, EventArgs e)
        {

        }
    }
}

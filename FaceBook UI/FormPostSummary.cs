using System;
using FacebookWrapper.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A19_Ex1_Nir_0_Nir_0
{
    public partial class FormPostSummary : Form
    {
        public Post ThePost { get; set; }

        public FormPostSummary(Post i_ThePost)
        {
            ThePost = i_ThePost;
            InitializeComponent();
        }

        private void FormPostSummary_Load(object sender, EventArgs e)
        {
            lableStatus.Text = ThePost.Message;
           
            foreach (Comment comment in ThePost.Comments)
            {
                listBoxComments.Items.Add(comment.ToString());
            }

            labelNumOfLikes.Text = ThePost.LikedBy.Count.ToString();
        }

        private void linkToPostOnFB_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start(ThePost.Link);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}

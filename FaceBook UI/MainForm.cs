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
    public partial class MainForm : Form
    {
        private readonly UserManager r_UserManager;

        public MainForm()
        {
            InitializeComponent();
            r_UserManager = new UserManager();

        }

        private void InitializationAfterLogIn()
        {
            btnFeature1.Enabled = true;
            btnFeature2.Enabled = true;
            linkFriends.Enabled = true;
            listBoxFriends.Enabled = true;
            pictureBoxFriend.Enabled = true;
            textBoxPost.Enabled = true;
            btnPost.Enabled = true;
            linkPosts.Enabled = true;
            listBoxPosts.Enabled = true;
            linkLabel1.Enabled = true;
            listBoxPages.Enabled = true;
            linkLabel2.Enabled = true;
            listBoxCheckins.Enabled = true;
            linkLabel3.Enabled = true;
            listBoxEvents.Enabled = true;

            panelActive.BackColor = Color.Chartreuse;

            btnLogin.Visible = false;
            pictureBoxLogOut.Visible = true;
        }

        private void listBoxPages_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                r_UserManager.Login();

                this.Text = r_UserManager.UserName;
                pictureBoxUser.LoadAsync(r_UserManager.UserPictureUrl);
                InitializationAfterLogIn();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fetchFriends()
        {
            listBoxFriends.Items.Clear();
            listBoxFriends.DisplayMember = "Name";
            foreach (User friend in r_UserManager.User.Friends)
            {
                listBoxFriends.Items.Add(friend);
                friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
            }

            int friendsNumber = r_UserManager.User.Friends.Count;

            if (friendsNumber == 0)
            {
                MessageBox.Show("No Friends to retrieve :(");
            }
            else
            {
                labelFriendsNum.Text = friendsNumber.ToString();            }

        }

        private void fetchPosts()
        {
            foreach (Post post in r_UserManager.User.Posts)
            {
                if (post.Message != null)
                {
                    listBoxPosts.Items.Add(post.Message);
                }
                else if (post.Caption != null)
                {
                    listBoxPosts.Items.Add(post.Caption);
                }
                else
                {
                    listBoxPosts.Items.Add(string.Format("[{0}]", post.Type));
                }
            }

            int postsNum = r_UserManager.User.Posts.Count;

            if (postsNum == 0)
            {
                MessageBox.Show("No Posts to retrieve :(");
            } else
            {
                labelPostsNum.Text = postsNum.ToString();
            }

        }

        private void displaySelectedFriend()
        {
            if (listBoxFriends.SelectedItems.Count == 1)
            {
                User selectedFriend = listBoxFriends.SelectedItem as User;
                if (selectedFriend.PictureNormalURL != null)
                {
                    pictureBoxFriend.LoadAsync(selectedFriend.PictureNormalURL);
                }
                else
                {
                    pictureBoxFriend.Image = pictureBoxFriend.ErrorImage;
                }
            }
        }

        private void pictureBoxLogOut_Click(object sender, EventArgs e)
        {
            r_UserManager.UserLogOut();
            this.DialogResult = DialogResult.Cancel;
        }

        private void listBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedFriend();
        }

        private void linkFriends_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fetchFriends();
        }

        private void linkPosts_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fetchPosts();
        }
    }
}

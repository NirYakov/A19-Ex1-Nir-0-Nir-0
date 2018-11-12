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
            linkPages.Enabled = true;
            listBoxPages.Enabled = true;
            linkCheckins.Enabled = true;
            listBoxCheckins.Enabled = true;
            labelEvents.Enabled = true;
            listBoxEvents.Enabled = true;
            panelActive.BackColor = Color.Chartreuse;
            btnLogin.Visible = false;
            pictureBoxLogOut.Visible = true;

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                r_UserManager.Login();
                this.Text = r_UserManager.UserName;
                InitializationAfterLogIn();
                pictureBoxUser.LoadAsync(r_UserManager.UserPictureUrl);
                pictureBoxCoverPic.LoadAsync(r_UserManager.UserPictureUrlCover);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkFriends_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fetchFriends();
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
                labelFriendsNum.Text = friendsNumber.ToString();
            }
        }

        private void linkPosts_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fetchPosts();
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
            }
            else
            {
                labelPostsNum.Text = postsNum.ToString();
            }
        }

        private void listBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedFriend();
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
            this.Close();
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            try
            {
                r_UserManager.PostStatus(textBoxPost.Text);
            }
            catch (Exception)
            {
                MessageBox.Show(
@"Can't post status right now,
Back later . :(");
            }
        }

        private void labelEvents_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fetchEvents();
        }

        private void fetchEvents()
        {
            try
            {
                listBoxEvents.Items.Clear();
                listBoxEvents.DisplayMember = "Name";
                foreach (Event fbEvent in r_UserManager.User.Events)
                {
                    listBoxEvents.Items.Add(fbEvent);
                }

                labelEventsNum.Text = r_UserManager.User.Events.Count.ToString();
                if (r_UserManager.User.Events.Count == 0)
                {
                    MessageBox.Show("No Events to retrieve :(");
                }
            }
            catch (Exception)
            {
                ErrorMessage("Events");
            }
        }

        private void listBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxEvents.SelectedItems.Count == 1)
            {
                if (listBoxEvents.SelectedItems.Count == 1)
                {
                    Event selectedEvent = listBoxEvents.SelectedItem as Event;
                    pictureBoxEvent.LoadAsync(selectedEvent.PictureNormalURL);
                }
            }
        }

        private void linkCheckins_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fetchCheckins();
        }

        private void fetchCheckins()
        {
            try
            {
                foreach (Checkin checkin in r_UserManager.User.Checkins)
                {
                    listBoxCheckins.Items.Add(checkin.Place.Name);
                }

                labelCheckinsNum.Text = r_UserManager.User.Checkins.Count.ToString();
                if (r_UserManager.User.Checkins.Count == 0)
                {
                    MessageBox.Show("No Checkins to retrieve :(");
                }
            }
            catch (Exception)
            {
                ErrorMessage("Checkins");
            }
        }

        private void linkPages_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fetchPages();
        }

        private void fetchPages()
        {
            try
            {
                listBoxPages.Items.Clear();
                listBoxPages.DisplayMember = "Name";

                foreach (Page page in r_UserManager.User.LikedPages)
                {
                    listBoxPages.Items.Add(page);
                }

                labelLikedPagesNum.Text = r_UserManager.User.LikedPages.Count.ToString();
                if (r_UserManager.User.LikedPages.Count == 0)
                {
                    MessageBox.Show("No liked pages to retrieve :(");
                }
            }
            catch (Exception)
            {
                ErrorMessage("Liked Pages");
            }
        }

        private void listBoxPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxPages.SelectedItems.Count == 1)
            {
                Page selectedPage = listBoxPages.SelectedItem as Page;
                pictureBoxPage.LoadAsync(selectedPage.PictureNormalURL);
            }
        }

        private void ErrorMessage(string i_ErrorSource)
        {
            MessageBox.Show(
@"Error occurred in {0}
Plase try later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnFeature2_Click(object sender, EventArgs e)
        {
            FormKeyWords formKeyWord = new FormKeyWords();
            formKeyWord.ShowDialog();
        }

        private void btnFeature1_Click(object sender, EventArgs e)
        {
            (new UsersValue(r_UserManager.User)).ShowDialog(); 
        }
    }
}

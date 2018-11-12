using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FB_Logic;

namespace A19_Ex1_Nir_0_Nir_0
{
    public partial class UsersValue : Form
    {
        private readonly UserAnalysis r_UserAnalysis;
        private AlbumManager m_AlbumsManager;
        private readonly List<PictureTopBar> r_PictureTopBars;
        private UserAnalysis m_LoadedUserAnalysis;

        public UsersValue(User i_User)
        {
            InitializeComponent();

            r_UserAnalysis = new UserAnalysis();
            r_UserAnalysis.UserIn = i_User;


            m_AlbumsManager = new AlbumManager(r_UserAnalysis.UserIn.Albums);
            r_PictureTopBars = new List<PictureTopBar>();

            //
            m_LoadedUserAnalysis = r_UserAnalysis;
            //
        }

        private void buttonBringFriends_Click(object sender, EventArgs e)
        {
            PictureTopBar ptb;

            flowLayoutPanel1.Controls.Clear();
            foreach (User friend in r_UserAnalysis.UserIn.Friends)
            {
                ptb = new PictureTopBar() { Size = new Size((int)(200 * 0.75), (int)(250 * 0.75)) };

                ptb.TopPanel.BackColor = Color.Blue;
                ptb.LabelText.ForeColor = Color.WhiteSmoke;
                ptb.Picture.LoadAsync(friend.PictureLargeURL);
                ptb.MyUserAnalysis.UserIn = friend;
                ptb.LabelText.Text = string.Format("{0}", friend.Name);
                ptb.AddToClickEvent(PictureTopBar_Click);
                r_PictureTopBars.Add(ptb);
                flowLayoutPanel1.Controls.Add(ptb);
                friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
            }

            int friendsNumber = r_UserAnalysis.UserIn.Friends.Count;
            if (friendsNumber == 0)
            {
                MessageBox.Show("No Friends to retrieve :(");
            }
        }

        private void PictureTopBar_Click(object sender, EventArgs e)
        {

            PictureTopBar ptb = sender as PictureTopBar;

            if (ptb != null)
            {
                labelTheFirendsCount.Text = ptb.MyUserAnalysis.UserIn.Friends.Count.ToString();
                labelTheName.Text = ptb.MyUserAnalysis.UserIn.Name;
                labelTheTagged.Text = ptb.MyUserAnalysis.UserIn.PhotosTaggedIn.Count.ToString();

                labelBDay.Text = ptb.MyUserAnalysis.UserIn.Birthday;


                m_LoadedUserAnalysis.UserIn = ptb.MyUserAnalysis.UserIn;
                m_AlbumsManager.AlbumCollection = r_UserAnalysis.UserIn.Albums;
            }
        }

        private void buttonInteraction_Click(object sender, EventArgs e)
        {
            if (m_LoadedUserAnalysis.UserIn == null)
            {
                labelEventInteraction.Text = m_LoadedUserAnalysis.NumberOfInteractionInEvents().ToString();
                labelPostInteraction.Text = m_LoadedUserAnalysis.NumberOfInterctionInPosts().ToString();
                labelNameInteraction.Text = m_LoadedUserAnalysis.UserIn.Name;
                labelCheckinInterctions.Text = m_LoadedUserAnalysis.NumberOfCheckinInteraction().ToString();
            }
        }

        private void timerSort_Tick(object sender, EventArgs e)
        {
            int intervalMoving = 10;

            if (radioButtonHideSort.Checked == true)
            {
                panel1.Height -= intervalMoving;
                intervalMoving--;
                if (panel1.Height == 0)
                {
                    intervalMoving = 10;
                    timerSort.Stop();
                    this.Refresh();
                }
            }
            else
            {
                panel1.Height += 10;
                intervalMoving++;
                if ( panel1.Bottom == 185) // panel1.Top == labelAdvence.Top)
                {
                    intervalMoving = 10;
                    timerSort.Stop();
                    this.Refresh();
                }
            }
        }

        private void radioButtonHideSort_CheckedChanged(object sender, EventArgs e)
        {
            timerSort.Start();
        }

        private void buttonActiveSort_Click(object sender, EventArgs e)
        {
            UserAnalysis.eStarsParameters chosenParams = 0;
            if (checkBox1.Checked == true)
            {
                chosenParams |= UserAnalysis.eStarsParameters.checkin;
            }

            if (checkBox1.Checked == true)
            {
                chosenParams |= UserAnalysis.eStarsParameters.posts;
            }

            if (checkBox1.Checked == true)
            {
                chosenParams |= UserAnalysis.eStarsParameters.events;
            }

            if (checkBox1.Checked == true)
            {
                chosenParams |= UserAnalysis.eStarsParameters.tagged;
            }

            foreach (PictureTopBar item in r_PictureTopBars)
            {
                item.MyUserAnalysis.clacStarsFromAnalisis(chosenParams);
            }

            r_PictureTopBars.Sort(new PicCopySortStars());
        }

        private class PicCopySortStars : IComparer<PictureTopBar>
        {
            public int Compare(PictureTopBar i_X, PictureTopBar i_Y)
            {
                return i_X.MyUserAnalysis.CompareTo(i_Y.MyUserAnalysis);
            }
        }

        private void buttonFetchAlbums_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            imageList1.Images.Clear();

            FetchHandler.Fetch(m_AlbumsManager.GetAllAlbums(), imageList1, listView1);
        }

        private void buttonGetPhotos_Click(object sender, EventArgs e)
        {
            int index = listView1.SelectedItems[0].Index;
            if (index >= 0 && index < listView1.Items.Count)
            {
                listView1.Clear();
                imageList1.Images.Clear();

                AlbumWrapper album = m_AlbumsManager.GetAlbum(index);

                FetchHandler.Fetch(album.GetPhotos(), imageList1, listView1);
            }
        }
    }
}

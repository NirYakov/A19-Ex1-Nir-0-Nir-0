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
        private int initSortGroupBoxHeight = 0;

        public UsersValue(User i_User)
        {
            InitializeComponent();

            r_UserAnalysis = new UserAnalysis();
            r_UserAnalysis.UserIn = i_User;


            m_AlbumsManager = new AlbumManager(r_UserAnalysis.UserIn.Albums);
            r_PictureTopBars = new List<PictureTopBar>();

            initSortGroupBoxHeight = groupBoxSortOpt.Height;

            //
            m_LoadedUserAnalysis = r_UserAnalysis;
            //
        }

        private void buttonBringFriends_Click(object sender, EventArgs e)
        {
            try
            {
                PictureTopBar ptb;

                flowLayoutPanel1.Controls.Clear();
                foreach (User friend in r_UserAnalysis.UserIn.Friends)
                {
                    ptb = new PictureTopBar() { Size = new Size((int)(200 * 0.85), (int)(250 * 0.85)) };

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

                buttonBringFriends.Enabled = false;
            }
            catch (Exception)
            {
                ServiceNotAvailableMessage();
            }
        }

        private void PictureTopBar_Click(object sender, EventArgs e)
        {

            PictureTopBar ptb = sender as PictureTopBar;

            try
            {
                updateUserLoadedInfo(ptb.MyUserAnalysis);

                //labelTheFirendsCount.Text = ptb.MyUserAnalysis.UserIn.Friends.Count.ToString();
                //labelTheName.Text = ptb.MyUserAnalysis.UserIn.Name;
                //labelTheTagged.Text = ptb.MyUserAnalysis.UserIn.PhotosTaggedIn.Count.ToString();

                //labelBDay.Text = ptb.MyUserAnalysis.UserIn.Birthday;

                //m_LoadedUserAnalysis.UserIn = ptb.MyUserAnalysis.UserIn;
                //m_AlbumsManager.AlbumCollection = ptb.MyUserAnalysis.UserIn.Albums;
            }
            catch (Exception)
            {
                ServiceNotAvailableMessage();
            }

        }

        private void updateUserLoadedInfo(UserAnalysis i_UserAnalysis)
        {
            labelTheFirendsCount.Text = i_UserAnalysis.UserIn.Friends.Count.ToString();
            labelTheName.Text = i_UserAnalysis.UserIn.Name;
            labelTheTagged.Text = i_UserAnalysis.UserIn.PhotosTaggedIn.Count.ToString();

            labelBDay.Text = i_UserAnalysis.UserIn.Birthday;
            m_LoadedUserAnalysis = i_UserAnalysis;
            m_AlbumsManager.AlbumCollection = i_UserAnalysis.UserIn.Albums;
        }

        private void buttonInteraction_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_LoadedUserAnalysis.UserIn != null)
                {
                    List<int> interactions = new List<int>();

                    labelNameInteraction.Text = m_LoadedUserAnalysis.UserIn.Name;

                    interactions.Add(m_LoadedUserAnalysis.EventInteraction);
                    labelEventInteraction.Text = m_LoadedUserAnalysis.EventInteraction.ToString();

                    interactions.Add(m_LoadedUserAnalysis.PostInteraction);
                    labelPostInteraction.Text = m_LoadedUserAnalysis.PostInteraction.ToString();

                    interactions.Add(m_LoadedUserAnalysis.CheckinInteraction);
                    labelCheckinInterctions.Text = m_LoadedUserAnalysis.CheckinInteraction.ToString();

                    interactions.Add(m_LoadedUserAnalysis.TaggedInteraction);
                    labelTaggedInterctions.Text = m_LoadedUserAnalysis.TaggedInteraction.ToString();

                    m_LoadedUserAnalysis.MyStars.clacStars(false, interactions);
                    labelGoldStarsInteraction.Text = m_LoadedUserAnalysis.MyStars.GoldenStars.ToString();
                    labelNormalStarsInteraction.Text = m_LoadedUserAnalysis.MyStars.NormalStars.ToString();
                                       
                }
            }
            catch (Exception)
            {
                ServiceNotAvailableMessage();
            }
        }

        private void ServiceNotAvailableMessage()
        {
            MessageBox.Show(
 @"The Service not available now
Try Later");
        }

        private void radioButtonHideSort_CheckedChanged(object sender, EventArgs e)
        {
            timerSort.Start();
        }

        private void timerSort_Tick(object sender, EventArgs e)
        {
            int intervalMoving = 10;
            // groupBoxSortOpt.Height
            if (radioButtonHideSort.Checked == true)
            {
                movingMiddle(-intervalMoving);
                // intervalMoving--;
                if (groupBoxSortOpt.Height <= 0)
                {
                    intervalMoving = 10;
                    timerSort.Stop();
                    this.Refresh();
                }
            }
            else
            {
                movingMiddle(intervalMoving);
                //intervalMoving++;
                if (groupBoxSortOpt.Height >= initSortGroupBoxHeight) // panel1.Top == labelAdvence.Top)
                {
                    intervalMoving = 10;
                    timerSort.Stop();
                    this.Refresh();
                }
            }
        }

        private void movingMiddle(int i_IntervalMoving)
        {
            groupBoxSortOpt.Height += i_IntervalMoving;
            groupBoxAdvenceOpt.Top += i_IntervalMoving;
            panelMainData.Top += i_IntervalMoving;
            buttonHelp.Top += i_IntervalMoving;
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

            if (chosenParams != UserAnalysis.eStarsParameters.none) {

                PictureTopBarStarSort ptbStarSort = new PictureTopBarStarSort();

                try
                {
                    foreach (PictureTopBar item in r_PictureTopBars)
                    {
                        item.MyUserAnalysis.clacStarsFromAnalisis(chosenParams);
                    }

                    r_PictureTopBars.Sort(ptbStarSort);
                    flowLayoutPanel1.Controls.Clear();
                    foreach (PictureTopBar item in r_PictureTopBars)
                    {
                        item.LabelText.Text = string.Format("{0} Gold ,{1} normal stars"
                            , item.MyUserAnalysis.MyStars.GoldenStars, item.MyUserAnalysis.MyStars.NormalStars);
                        flowLayoutPanel1.Controls.Add(item);
                    }
                }
                catch (Exception)
                {
                    ServiceNotAvailableMessage();
                }
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

        private class PictureTopBarStarSort : IComparer<PictureTopBar> // bm
        {
            public int Compare(PictureTopBar i_X, PictureTopBar i_Y)
            {
                return i_X.MyUserAnalysis.CompareTo(i_Y.MyUserAnalysis);
            }
        }

        private void buttonLoadMe_Click(object sender, EventArgs e)
        {
            m_LoadedUserAnalysis = r_UserAnalysis;
            MessageBox.Show("Herea!");
            updateUserLoadedInfo(r_UserAnalysis);
            MessageBox.Show(string.Format("{0}",m_LoadedUserAnalysis.UserIn.Name));
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (PictureTopBar item in r_PictureTopBars)
            {
                item.LabelText.Text = item.MyUserAnalysis.UserIn.Name;
                flowLayoutPanel1.Controls.Add(item);
            }
        }
    }
}
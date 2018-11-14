using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
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
        private readonly List<PictureTopBar> r_PictureTopBars;
        private UserAnalysis m_LoadedUserAnalysis;
        private PicturesManager m_PhotosManager;
        private int initSortGroupBoxHeight = 0;

        public UsersValue(User i_User)
        {
            InitializeComponent();

            r_UserAnalysis = new UserAnalysis();
            r_UserAnalysis.UserIn = i_User;


            m_PhotosManager = new PicturesManager() { MyAlbums = r_UserAnalysis.UserIn.Albums };
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
                const float ptbInterval = 0.85f;
                PictureTopBar ptb;
                flowLayoutPanel1.Controls.Clear();

                foreach (User friend in r_UserAnalysis.UserIn.Friends)
                {
                    ptb = newPictureTopBar(ptbInterval, string.Format("{0}", friend.Name), friend.PictureLargeURL);
                    ptb.MyUserAnalysis.UserIn = friend;
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

        private PictureTopBar newPictureTopBar(float i_SizeInterval, string i_LabelTitle, string i_PictureUrl)
        {
            PictureTopBar ptb = new PictureTopBar() { Size = new Size((int)(200 * i_SizeInterval), (int)(250 * i_SizeInterval)) };
            ptb.TopPanel.BackColor = Color.Blue;
            ptb.LabelText.ForeColor = Color.WhiteSmoke;
            ptb.Picture.LoadAsync(i_PictureUrl);
            ptb.LabelText.Text = i_LabelTitle;
            return ptb;
        }

        private void PictureTopBar_Click(object sender, EventArgs e)
        {

            PictureTopBar ptb = sender as PictureTopBar;

            try
            {
                updateUserLoadedInfo(ptb.MyUserAnalysis);
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
            m_PhotosManager.MyAlbums = i_UserAnalysis.UserIn.Albums;
        }

        private void buttonInteraction_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_LoadedUserAnalysis.UserIn != null)
                {
                    int postInteraction, eventInterction, taggedInteraction, checkinInteraction;

                    labelNameInteraction.Text = m_LoadedUserAnalysis.UserIn.Name;

                    postInteraction = m_LoadedUserAnalysis.PostInteraction;
                    eventInterction = m_LoadedUserAnalysis.EventInteraction;
                    checkinInteraction = m_LoadedUserAnalysis.CheckinInteraction;
                    taggedInteraction = m_LoadedUserAnalysis.TaggedInteraction;

                    labelEventInteraction.Text = eventInterction.ToString();
                    labelPostInteraction.Text = postInteraction.ToString();
                    labelCheckinInterctions.Text = checkinInteraction.ToString();
                    labelTaggedInterctions.Text = taggedInteraction.ToString();

                    m_LoadedUserAnalysis.MyStars.clacStars(false, postInteraction, eventInterction, checkinInteraction);
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
            if (radioButtonHideSort.Checked == true)
            {
                movingMiddle(-intervalMoving);
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

            if (chosenParams != UserAnalysis.eStarsParameters.none)
            {

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

            //FetchHandler.Fetch(m_AlbumsManager.GetAllAlbums(), imageList1, listView1);
            try
            {
                bringAndLoadAlbums();
            }
            catch (Exception)
            {
                ServiceNotAvailableMessage();
            }
        }

        private void buttonGetPhotos_Click(object sender, EventArgs e) //// flowLayoutPanel2
        {
            try
            {
                int index = listView1.SelectedItems[0].Index;
                if (index >= 0 && index < listView1.Items.Count)
                {
                    listView1.Clear();
                    imageList1.Images.Clear();
                    listView1.Visible = false;
                    flowLayoutPanel2.Visible = true;

                    List<PictureAnalysis> pictureAnalyses = new List<PictureAnalysis>();
                    PictureAnalysis pictureAnalysis;

                    foreach (Photo item in m_PhotosManager.AlbumAt(index).Photos)
                    {
                        pictureAnalysis = new PictureAnalysis
                        {
                            PictureUrl = item.PictureNormalURL,
                            PictureID = item.Id
                        };

                        pictureAnalysis.CalcStars(item.LikedBy.Count, item.Comments.Count);
                        pictureAnalyses.Add(pictureAnalysis);
                    }

                    pictureAnalyses.Sort(new PictureAnalysisSort());
                    const float ptbInterval = 0.80f;

                    foreach (PictureAnalysis item in pictureAnalyses)
                    {
                        flowLayoutPanel2.Controls.Add(
                            newPictureTopBar(ptbInterval, item.ToString(), item.PictureUrl));
                    }
                }
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Plase pick anther item. you picked wrong index.");
            }
            catch (FieldAccessException)
            {
                MessageBox.Show("Plase pick anther item. you picked wrong index. HERERE?");
            }
            catch (Exception)
            {
                ServiceNotAvailableMessage();
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
            updateUserLoadedInfo(r_UserAnalysis);
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

        public void bringAndLoadAlbums()
        {
            //LinkedList<UserInfo> i_Collection, ImageList i_ImagLst, ListView i_ViewLst;
            PicturesManager photosManager = new PicturesManager() { MyAlbums = m_LoadedUserAnalysis.UserIn.Albums };   // m_LoadedUserAnalysis.UserIn
            List<ItemInfo> allAlbums = (List<ItemInfo>)photosManager.BringAllAlbums();

            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(80, 80);
            listView1.View = View.LargeIcon;
            listView1.LargeImageList = imageList1;

            int indexer = 0;
            ListViewItem item;
            foreach (ItemInfo itemInfo in allAlbums)
            {
                var request = WebRequest.Create(itemInfo.ItemUrl);
                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    imageList1.Images.Add(Bitmap.FromStream(stream));
                }

                item = new ListViewItem();
                item.ImageIndex = indexer++;
                item.Text = itemInfo.ItemName;
                listView1.Items.Add(item);
            }

            if (indexer == 0)
            {
                MessageBox.Show("Nothing!");
            }
        }
    }
}
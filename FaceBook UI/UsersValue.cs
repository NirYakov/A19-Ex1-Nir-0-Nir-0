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
        private PicturesManager m_PicutresManager;
        private int initSortGroupBoxHeight = 0;
        private readonly Color r_BackColor;
        private readonly Color r_ForeColor;
        private string k_BringAlbumsString =
@"Bring
{0}
&Albums";

        private const string r_HelpMessage =
@"Hello,
Here in UserValue you can know if some one
of your friends or even you worth to invest
moeny in advertisement (like watch ad in 
status or swimsuits in picture upload).
our system is give stars for every one by demand.
with the stars you can know
who have more interaction in there account and by
this stars you can decided if you want to invest in
the use or skip to next one . you can to know your
value as well.
Gold star is equal to {0} normal stars
and how the likes and comments became the stars it
our secret. Thank and have fun.

p.s
Interction button calculate user loaded stars.
Refresh button bring back the names to friends.
Sort By -> it's analysis all your friends
by given fields , and sort the best to top.";

        // You can change the gold bar level in the settings."; // bm

        public UsersValue(User i_User)
        {
            InitializeComponent();
            r_UserAnalysis = new UserAnalysis() { UserIn = i_User };
            r_PictureTopBars = new List<PictureTopBar>();
            r_BackColor = SettingUi.BackColorTheme();
            r_ForeColor = SettingUi.ForeColorTheme();
            initializeAll();
        }

        private void initializeAll()
        {
            m_PicutresManager = new PicturesManager() { MyAlbums = r_UserAnalysis.UserIn.Albums };
            initSortGroupBoxHeight = groupBoxSortOpt.Height;
            m_LoadedUserAnalysis = r_UserAnalysis;
            pictureBoxLaodedUser.LoadAsync(m_LoadedUserAnalysis.UserIn.PictureSqaureURL);
            initSettings();
            initListView();
        }

        private void initSettings()
        {
            groupBoxSortOpt.BackColor = r_BackColor;
            checkBoxCheckin.ForeColor = r_ForeColor;
            checkBoxEvents.ForeColor = r_ForeColor;
            checkBoxPosts.ForeColor = r_ForeColor;
            checkBoxTagged.ForeColor = r_ForeColor;

            buttonHelp.BackColor = r_BackColor;
            buttonHelp.ForeColor = r_ForeColor;
        }

        private void initListView()
        {
            imageListPickedUserAlbumsPictures.ColorDepth = ColorDepth.Depth32Bit;
            imageListPickedUserAlbumsPictures.ImageSize = new Size(80, 80);
            listViewPickedUserAlbums.View = View.LargeIcon;
            listViewPickedUserAlbums.LargeImageList = imageListPickedUserAlbumsPictures;
        }

        private void buttonBringFriends_Click(object sender, EventArgs e)
        {
            try
            {
                const float ptbInterval = 0.85f;
                PictureTopBar ptb;
                flowLayoutPanelFriends.Controls.Clear();

                foreach (User friend in r_UserAnalysis.UserIn.Friends)
                {
                    ptb = newPictureTopBar(ptbInterval, string.Format("{0}", friend.Name), friend.PictureLargeURL);
                    ptb.MyUserAnalysis.UserIn = friend;
                    ptb.AddToClickEvent(PictureTopBar_Click);
                    r_PictureTopBars.Add(ptb);
                    flowLayoutPanelFriends.Controls.Add(ptb);
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
            ptb.TopPanel.BackColor = r_BackColor;
            ptb.LabelText.ForeColor = r_ForeColor;
            ptb.Picture.LoadAsync(i_PictureUrl);
            ptb.LabelText.Text = i_LabelTitle;
            return ptb;
        }

        private void PictureTopBar_Click(object sender, EventArgs e)
        {
            PictureTopBar ptb = sender as PictureTopBar;
            if (ptb != null)
            {
                try
                {
                    updateUserLoadedInfo(ptb.MyUserAnalysis);
                }
                catch (Exception)
                {
                    ServiceNotAvailableMessage();
                }
            }
        }

        private void updateUserLoadedInfo(UserAnalysis i_UserAnalysis)
        {
            labelTheName.Text = i_UserAnalysis.UserIn.Name;
            buttonFetchAlbums.Text = string.Format(k_BringAlbumsString, labelTheName.Text);
            buttonSaveToFile.Enabled = false;
            pictureBoxLaodedUser.LoadAsync(i_UserAnalysis.UserIn.PictureSqaureURL);

            labelTheFirendsCount.Text = i_UserAnalysis.UserIn.Friends.Count.ToString();
            labelTheTagged.Text = i_UserAnalysis.UserIn.PhotosTaggedIn.Count.ToString();

            labelBDay.Text = i_UserAnalysis.UserIn.Birthday;
            m_LoadedUserAnalysis = i_UserAnalysis;
            m_PicutresManager.MyAlbums = i_UserAnalysis.UserIn.Albums;
            const bool showAlbumList = true , showPictureList = true;
            clearImagesAlbumAndPicturesContainers(showAlbumList, !showPictureList);
        }

        private void buttonInteraction_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_LoadedUserAnalysis.UserIn != null)
                {
                    const bool pictureInteraction = true;

                    labelNameInteraction.Text = m_LoadedUserAnalysis.UserIn.Name;
                    CalculateAndFillDataUser();

                    m_LoadedUserAnalysis.MyStars.CalulateStars(
                        !pictureInteraction,
                        m_LoadedUserAnalysis.PostInteraction,
                        m_LoadedUserAnalysis.EventInteraction,
                        m_LoadedUserAnalysis.CheckinInteraction,
                        m_LoadedUserAnalysis.TaggedInteraction
                        );

                    labelGoldStarsInteraction.Text = m_LoadedUserAnalysis.MyStars.GoldenStars.ToString();
                    labelNormalStarsInteraction.Text = m_LoadedUserAnalysis.MyStars.NormalStars.ToString();
                    buttonSaveToFile.Enabled = true;
                }
            }
            catch (Exception)
            {
                ServiceNotAvailableMessage();
            }
        }

        private void CalculateAndFillDataUser()
        {
            labelEventInteraction.Text = m_LoadedUserAnalysis.PostInteraction.ToString();
            labelPostInteraction.Text = m_LoadedUserAnalysis.ToString();
            labelCheckinInterctions.Text = m_LoadedUserAnalysis.ToString();
            labelTaggedInterctions.Text = m_LoadedUserAnalysis.ToString();
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
            const int intervalMoving = 10;
            if (radioButtonHideSort.Checked == true)
            {
                movingMiddle(-intervalMoving);
                if (groupBoxSortOpt.Height <= 0)
                {
                    timerSort.Stop();
                    this.Refresh();
                }
            }
            else
            {
                movingMiddle(intervalMoving);
                if (groupBoxSortOpt.Height >= initSortGroupBoxHeight)
                {
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

        private UserAnalysis.eStarsParameters sortParametersPicked()
        {
            UserAnalysis.eStarsParameters chosenParams = UserAnalysis.eStarsParameters.none;
            if (checkBoxCheckin.Checked == true)
            {
                chosenParams |= UserAnalysis.eStarsParameters.checkin;
            }

            if (checkBoxCheckin.Checked == true)
            {
                chosenParams |= UserAnalysis.eStarsParameters.posts;
            }

            if (checkBoxCheckin.Checked == true)
            {
                chosenParams |= UserAnalysis.eStarsParameters.events;
            }

            if (checkBoxCheckin.Checked == true)
            {
                chosenParams |= UserAnalysis.eStarsParameters.tagged;
            }

            return chosenParams;
        }

        private void buttonActiveSort_Click(object sender, EventArgs e)
        {
            UserAnalysis.eStarsParameters chosenParams = sortParametersPicked();
            if (chosenParams != UserAnalysis.eStarsParameters.none)
            {
                try
                {
                    foreach (PictureTopBar item in r_PictureTopBars)
                    {
                        item.MyUserAnalysis.clacStarsFromAnalisis(chosenParams);
                    }

                    r_PictureTopBars.Sort(new PictureTopBarStarSort());
                    flowLayoutPanelFriends.Controls.Clear();
                    foreach (PictureTopBar item in r_PictureTopBars)
                    {
                        item.LabelText.Text = string.Format("{0} Gold ,{1} normal stars"
                            , item.MyUserAnalysis.MyStars.GoldenStars, item.MyUserAnalysis.MyStars.NormalStars);
                        flowLayoutPanelFriends.Controls.Add(item);
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
            const bool showAlbumList = true, showPictureList = true;
            clearImagesAlbumAndPicturesContainers(showAlbumList, !showPictureList);

            try
            {
                bringAndLoadAlbums();
                buttonGetPhotos.Enabled = true;
            }
            catch (Exception)
            {
                ServiceNotAvailableMessage();
            }
        }

        private void bringAndLoadAlbums()
        {
            List<ItemInfo> allAlbums = (List<ItemInfo>)m_PicutresManager.BringAllAlbums();
            int index = 0;
            foreach (ItemInfo itemInfo in allAlbums)
            {
                var request = WebRequest.Create(itemInfo.ItemUrl);
                using (WebResponse response = request.GetResponse())
                using (System.IO.Stream stream = response.GetResponseStream())
                {
                    imageListPickedUserAlbumsPictures.Images.Add(Bitmap.FromStream(stream));
                }

                listViewPickedUserAlbums.Items.Add(new ListViewItem()
                {
                    ImageIndex = index++,
                    Text = itemInfo.ItemName
                });
            }

            if (index == 0)
            {
                MessageBox.Show("Nothing!");
            }
        }

        private void clearImagesAlbumAndPicturesContainers(bool i_ShowAlbumList, bool i_ShowPictureList)
        {
            listViewPickedUserAlbums.Clear();
            imageListPickedUserAlbumsPictures.Images.Clear();
            listViewPickedUserAlbums.Visible = i_ShowAlbumList;
            flowLayoutPanelPickedUserPictures.Visible = i_ShowPictureList;
            flowLayoutPanelPickedUserPictures.Controls.Clear();
        }

        private void buttonGetPhotos_Click(object sender, EventArgs e)
        {
            try
            {
                int index = listViewPickedUserAlbums.SelectedItems[0].Index;
                if (index >= 0 && index < listViewPickedUserAlbums.Items.Count)
                {
                    const bool showAlbumList = true, showPictureList = true;
                    clearImagesAlbumAndPicturesContainers(!showAlbumList, showPictureList);
                    ICollection<PictureAnalysis> pictureAnalyses =
                        FillPictureAnalysisListAndSortByStars(index);

                    const float ptbInterval = 0.80f;
                    foreach (PictureAnalysis item in pictureAnalyses)
                    {
                        flowLayoutPanelPickedUserPictures.Controls.Add(
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

        private ICollection<PictureAnalysis> FillPictureAnalysisListAndSortByStars(int i_Index)
        {
            List<PictureAnalysis> pictureAnalyses = new List<PictureAnalysis>();
            PictureAnalysis pictureAnalysis;
            foreach (Photo item in m_PicutresManager.AlbumAt(i_Index).Photos)
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
            return pictureAnalyses;
        }

        private void buttonLoadMe_Click(object sender, EventArgs e)
        {
            m_LoadedUserAnalysis = r_UserAnalysis;
            updateUserLoadedInfo(r_UserAnalysis);
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            flowLayoutPanelFriends.Controls.Clear();
            foreach (PictureTopBar item in r_PictureTopBars)
            {
                item.LabelText.Text = item.MyUserAnalysis.UserIn.Name;
                flowLayoutPanelFriends.Controls.Add(item);
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format(r_HelpMessage, Stars.GoldStarBar), "Helper for help");
        }

        private void buttonSaveToFile_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new SaveToFileInteractions()
            { UserAnalysisLoaded = m_LoadedUserAnalysis }).ShowDialog();
            this.Show();
        }

        private class PictureTopBarStarSort : IComparer<PictureTopBar>
        {
            public int Compare(PictureTopBar i_X, PictureTopBar i_Y)
            {
                return i_X.MyUserAnalysis.CompareTo(i_Y.MyUserAnalysis);
            }
        }
    }
}
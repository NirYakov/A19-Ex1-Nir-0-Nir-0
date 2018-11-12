using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FB_Logic
{
    public class AlbumWrapper
    {
        #region Class Members
        private Album m_SelectedAlbum;
        private int m_Counter;

        public int Count
        {
            get
            {
                return m_Counter;
            }

            set
            {
                m_Counter = value;
            }
        }
        #endregion

        #region Constructor
        public AlbumWrapper(Album i_album)
        {
            m_SelectedAlbum = i_album;
            m_Counter = Convert.ToInt32(m_SelectedAlbum.Count);
        }
        #endregion

        #region Methods
        public LinkedList<UserInfo> GetPhotos()
        {
            LinkedList<UserInfo> photos = new LinkedList<UserInfo>();
            foreach (Photo photoItem in m_SelectedAlbum.Photos)
            {
                photos.AddLast(new UserInfo(photoItem.Name, photoItem.Id, photoItem.PictureNormalURL));
            }

            return photos;
        }

        public UserInfo GetPhoto(int i_index)
        {
            Photo photo = m_SelectedAlbum.Photos[i_index];

            return new UserInfo(photo.Name, photo.Id, photo.PictureNormalURL);
        }
        #endregion
    }
}

using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FB_Logic
{
    public class AlbumManager
    {
        #region Class Members
        private FacebookObjectCollection<Album> m_AlbumCollection;
        public FacebookObjectCollection<Album> AlbumCollection { get { return m_AlbumCollection; } set { m_AlbumCollection = value; } }
        #endregion

        #region Constructor
        public AlbumManager(FacebookObjectCollection<Album> i_AlbumCollection)
        {
            m_AlbumCollection = i_AlbumCollection;
        }
        #endregion

        #region Methods
        public LinkedList<UserInfo> GetAllAlbums()
        {
            LinkedList<UserInfo> allAlbums = new LinkedList<UserInfo>();
            foreach (Album album in m_AlbumCollection)
            {
                allAlbums.AddLast(new UserInfo(album.Name, album.Id, album.PictureAlbumURL));
            }

            return allAlbums;
        }

        public AlbumWrapper GetAlbum(int i_Index)
        {
            Album selected = m_AlbumCollection[i_Index];
            return new AlbumWrapper(selected);
        }
        #endregion
    }
}

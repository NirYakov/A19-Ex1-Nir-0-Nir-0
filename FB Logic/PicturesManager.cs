﻿using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FB_Logic
{
    public class PicturesManager
    {
        private ICollection<Album> m_Albums;
        public ICollection<Album> MyAlbums { get { return m_Albums; } set { m_Albums = value; } }
        // private int AlbumIndex = -1;
        private Album m_PickedAlbum;

        public ICollection<ItemInfo> BringAllAlbums()
        {
            ICollection<ItemInfo> albumsInfo = new List<ItemInfo>();
            
            foreach (Album album in m_Albums)
            {
                albumsInfo.Add(new ItemInfo(album.Id, album.Name, album.PictureAlbumURL ));
            }

            return albumsInfo;
        }

        public Album AlbumAt(int i_Index)
        {
            m_PickedAlbum = m_Albums.ElementAt(i_Index); //m_Albums[i_Index]; //.get(i_Index);
            return m_PickedAlbum;
        }

        public Album PickedAlbum { get { return m_PickedAlbum; } }
    }

    public struct ItemInfo
    {
        public string ItemID { get; set; }

        public string ItemName { get; set; }

        public string ItemUrl { get; set; }            

        public ItemInfo(string i_ItemID, string i_ItemName, string i_ItemUrl)
        {
            ItemID = i_ItemID;
            ItemName = i_ItemName;
            ItemUrl = i_ItemUrl;
        }
    }
}
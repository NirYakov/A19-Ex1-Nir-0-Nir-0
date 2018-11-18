using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FB_Logic
{
    public class PicturesManager
    {
        public ICollection<Album> MyAlbums { get; set; }

        public ICollection<ItemInfo> BringAllAlbums()
        {
            ICollection<ItemInfo> albumsInfo = new List<ItemInfo>();

            foreach (Album album in MyAlbums)
            {
                albumsInfo.Add(new ItemInfo(album.Id, album.Name, album.PictureAlbumURL));
            }

            return albumsInfo;
        }

        public Album AlbumAt(int i_Index)
        {
            return MyAlbums.ElementAt(i_Index);
        }
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
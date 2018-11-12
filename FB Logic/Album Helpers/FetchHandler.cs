using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FB_Logic
{
    public static class FetchHandler
    {
        public static void Fetch(LinkedList<UserInfo> i_Collection, ImageList i_ImagLst, ListView i_ViewLst)
        {
            i_ImagLst.ColorDepth = ColorDepth.Depth32Bit;
            i_ImagLst.ImageSize = new Size(80, 80);
            i_ViewLst.View = View.LargeIcon;
            i_ViewLst.LargeImageList = i_ImagLst;

            int indexer = 0;
            foreach (UserInfo collectItem in i_Collection)
            {
                var request = WebRequest.Create(collectItem.PictureURL);
                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    i_ImagLst.Images.Add(Bitmap.FromStream(stream));
                }

                ListViewItem item = new ListViewItem();
                item.ImageIndex = indexer++;
                item.Text = collectItem.Name;
                i_ViewLst.Items.Add(item);
            }

            if (indexer == 0)
            {
                MessageBox.Show("Nothing!");
            }
        }
    }
}

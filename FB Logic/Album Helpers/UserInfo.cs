using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FB_Logic
{
    public class UserInfo
    {
        #region Class Members
        string[] userInfoParams = new string[] { "one", "two", "three" };
        public string Name { get; private set; }
        public string ID { get; private set; }
        public string Date { get; private set; }
        public string PictureURL { get; private set; }
        public string PostMessage { get; private set; }
        public string PostCaption { get; private set; }
        public string PostType { get; private set; }
        public string FBEvent { get; private set; }
        public string StartTime { get; private set; }
        public string EndTime { get; private set; }
        public string CheckIn { get; private set; }
        #endregion

        #region Constructor
        public UserInfo(string i_Name, string i_ID, string i_PictureURL)
        {
            Name = i_Name;
            ID = i_ID;
            PictureURL = i_PictureURL;
        }

        public UserInfo(string i_Name, string i_ID, string i_PictureURL, string i_Date)
        {
            Name = i_Name;
            ID = i_ID;
            PictureURL = i_PictureURL;
            Date = i_Date;
        }

        public UserInfo(string i_PostMessage, string i_PostCaption)
        {
            PostMessage = i_PostMessage;
            PostCaption = i_PostCaption;
        }

        public UserInfo(string i_FBEvent, string i_StartTime, string i_EndTime, string i_Empty, string i_Empty2)
        {
            FBEvent = i_FBEvent;
            StartTime = i_StartTime;
            EndTime = i_EndTime;
        }

        public UserInfo(string i_CheckIn)
        {
            CheckIn = i_CheckIn;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return Name;
        }
        #endregion
    }
}

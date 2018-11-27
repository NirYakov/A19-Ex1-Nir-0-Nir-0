using System;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FB_Logic
{
    public class UserManager
    {
        private const string k_AppID = "317399492389792"; // "510658539406597"; // "317399492389792"; 
        private const string k_GuyAppID = "1450160541956417";
        private User m_LoggedInUser;

        public UserManager()
        {
        }

        public void Login()
        {
            LoginResult m_LoginResult = FacebookService.Login(
                k_AppID,
             // k_GuyAppID ,
            "public_profile",
            "user_birthday",
            "user_friends",
            "user_events",
            "user_hometown",
            "user_likes",
            "user_location",
            "user_photos",
            "user_posts",
            "user_tagged_places",
            "user_videos",
            "manage_pages",
            "publish_pages"
           );

            if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                m_LoggedInUser = m_LoginResult.LoggedInUser;
            }
            else
            {
                throw new Exception(m_LoginResult.ErrorMessage);
            }
        }

        public User User
        {
            get { return m_LoggedInUser; }
        }

        public string UserName
        {
            get { return m_LoggedInUser.Name; }
        }

        public string UserPictureUrl
        {
            get { return m_LoggedInUser.PictureNormalURL; }
        }

        public void UserLogOut()
        {
            FacebookService.Logout(new Action(() => { }));
        }

        public string UserPictureUrlCover
        {
            get { return m_LoggedInUser.Cover.SourceURL; }
        }      
    }
}

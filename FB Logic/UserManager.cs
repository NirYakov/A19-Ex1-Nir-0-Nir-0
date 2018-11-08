using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FB_Logic
{
    public class UserManager
    {
        private const string k_AppID = "317399492389792";
        private const string k_GuyAppID = "1450160541956417";
        private LoginResult m_LoginResult;
        private User m_LoggedInUser;

        public UserManager()
        {            
        }

        public void Login()
        {
            LoginResult m_LoginResult = FacebookService.Login(
                // k_AppID ,
                k_GuyAppID ,
                        "public_profile",
                       "user_events",
                       "user_likes",
                       "user_photos",
                       "user_birthday",
                       "user_posts"
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
            FacebookService.Logout(new Action (() => { }) );
        }
    }
}

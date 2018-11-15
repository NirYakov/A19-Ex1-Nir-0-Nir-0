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
        private const string k_AppID = "510658539406597"; // "317399492389792"; 
        private const string k_GuyAppID = "1450160541956417";
        // private LoginResult m_LoginResult;
        private User m_LoggedInUser;

        public UserManager()
        {
        }

        public void Login()
        {
            LoginResult m_LoginResult = FacebookService.Login(
              //  k_AppID,
             k_GuyAppID ,
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

        public string PostStatus(string i_Text)
        {
            Status status = m_LoggedInUser.PostStatus(i_Text);
            return string.Format("Status Posted. ID: {0}", status.Id);
        }

        public List<Post> GetPostsList()
        {
          
            List<Post> userPosts = new List<Post>();
            try
            {
                foreach (Post post in m_LoggedInUser.Posts)
                {
                    userPosts.Add(post);
                }
            }catch(Exception ex)
            {
                throw ex;
            }
            return userPosts;
        }

        public int CountWordNumOfAppears(string i_Word)
        {
            List<Post> userPosts = GetPostsList();
            int counter = 0;
            foreach(Post userpost in userPosts)
            {
                string strPost = userpost.Caption.ToString();
                if(strPost.Contains(i_Word))
                {
                    counter++;
                }
            }

            return 1;
        }

        #region trys permissiom
        //"public_profile",
        //                "user_events",
        //                "user_likes",
        //                "user_photos",
        //                "user_birthday",
        //                "user_posts"
        #endregion
    }
}

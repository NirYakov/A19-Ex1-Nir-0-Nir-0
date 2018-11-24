using System;
using FacebookWrapper.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FB_Logic
{
   public class PostAnalysis
    {
        public User TheUser { get; set; }

        public List<string> PostsListStr { get; set; }

        public List<Post> PostsList { get; set; }

        public PostAnalysis(User i_User)
        {
            TheUser = i_User;
            PostsListStr = this.fetchPostsToStringList();
        }

        public List<string> SortRecent()
        {
            List<string> postResult = this.fetchPostsToStringList();
            return postResult;
        }

        public List<string> SortAlphabetical()
        {
            List<string> postResult = PostsListStr;
            List<Post> dummyList = PostsList;
            postResult.Sort();
            dummyList.Sort(new sortPostAlphabetical());
            PostsList = dummyList;
            return postResult;
        }

        private class sortPostAlphabetical : IComparer<Post>
        {
            public int Compare(Post x, Post y)
            {
                return x.Message.CompareTo(y.Message);
            }
        }

        public List<string> SortByNumOfLikes()
        {
            List<string> postResult = PostsListStr;
            List<Post> dummyList = PostsList;
            postResult.Sort();
            dummyList.Sort(new sortPostByLikes());
            PostsList = dummyList;
            return postResult;
        }

        private class sortPostByLikes : IComparer<Post>
        {
            public int Compare(Post x, Post y)
            {
                return x.LikedBy.Count.CompareTo(y.LikedBy.Count);
            }
        }

        public List<string> GetPostsByWord(string i_WordToSearch)
        {
            List<string> postResult = new List<string>();
            this.fetchPostsToStringList();
            List<Post> dummyList = new List<Post>();
            int i = 0;
            foreach (string post in PostsListStr)
            {
                if (post.ToLower().Contains(i_WordToSearch.ToLower()))
                {
                    postResult.Add(post);
                    dummyList.Add(PostsList[i]);
                }

                i++;
            }

            PostsList = dummyList;
            return postResult;
        }

        private List<string> fetchPostsToStringList()
        {
            List<string> postResult = new List<string>();
            PostsList = new List<Post>();
            PostsList.Clear();
            
            foreach (Post post in TheUser.Posts)
            {
                if (post.Message != null)
                {
                    postResult.Add(post.Message);
                    PostsList.Add(post);
                }
            }

            return postResult;
        }

        public Dictionary<string, int> GetTopKWords()
        {
            int k = 15;
            string input = string.Join(" ", PostsListStr.ToArray());
            string[] words = Regex.Split(input, @"\W");
            var occurrences = new Dictionary<string, int>();

            foreach (var word in words)
            {
                string lowerWord = word.ToLowerInvariant();
                if (!occurrences.ContainsKey(lowerWord))
                {
                    occurrences.Add(lowerWord, 1);
                }
                else
                {
                    occurrences[lowerWord]++;
                }
            }

            return (from wp in occurrences.OrderByDescending(kvp => kvp.Value) select wp).Take(k).ToDictionary(kw => kw.Key, kw => kw.Value);
        }
    }
}

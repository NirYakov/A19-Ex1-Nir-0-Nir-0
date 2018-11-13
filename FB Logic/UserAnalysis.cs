using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FB_Logic
{
    public class UserAnalysis : IComparable<UserAnalysis>
    {
        public User UserIn { get; set; }

        public Stars MyStars { get; }

        public int? m_PostInteraction;
        public int? m_EventInteraction;
        public int? m_CheckinInteraction;
        public int? m_TaggedInteraction;

        public UserAnalysis()
        {
            MyStars = new Stars();
        }

        public int PostInteraction
        {
            get
            {
                if (!m_PostInteraction.HasValue)
                {
                    m_PostInteraction = NumberOfInterctionInPosts();
                }

                return m_PostInteraction.Value;
            }
        }

        public int EventInteraction
        {
            get
            {
                if (!m_EventInteraction.HasValue)
                {
                    m_EventInteraction = NumberOfInteractionInEvents();
                }

                return m_EventInteraction.Value;
            }
        }

        public int CheckinInteraction
        {
            get
            {
                if (!m_CheckinInteraction.HasValue)
                {
                    m_CheckinInteraction = NumberOfCheckinInteraction();
                }


                return m_CheckinInteraction.Value;
            }
        }

        public int TaggedInteraction
        {
            get
            {
                if (!m_TaggedInteraction.HasValue)
                {
                    m_TaggedInteraction = NumberOfTagged();
                }

                return m_TaggedInteraction.Value;
            }
        }

        public int NumberOfInterctionInPosts()
        {
            int sumOfInteraction = 0;
            ICollection<Post> posts = UserIn.Posts;

            foreach (Post item in posts)
            {
                sumOfInteraction += item.Comments.Count * 3;
                sumOfInteraction += item.LikedBy.Count * 2;
            }

            int numberOfPosts = posts.Count;
            return numberOfPosts > 0 ? (sumOfInteraction / (numberOfPosts * 2)) : 0;
        }

        public int NumberOfInteractionInEvents()
        {
            int sumOfInteraction = 0;
            ICollection<Event> events = UserIn.Events;

            int eventUserNumberAttinding = 0;
            foreach (Event item in events)
            {
                eventUserNumberAttinding = item.AttendingUsers.Count;
                if (eventUserNumberAttinding > 100)
                {
                    sumOfInteraction += 25;
                }

                DateTime? dateTime = item.StartTime;
                if (dateTime.HasValue)
                {
                    if (dateTime.Value.DayOfWeek == DayOfWeek.Friday || dateTime.Value.DayOfWeek == DayOfWeek.Thursday)
                    {
                        eventUserNumberAttinding = (int)(eventUserNumberAttinding * 1.5);
                    }
                }

                sumOfInteraction += eventUserNumberAttinding;
            }

            return events.Count > 0 ? (sumOfInteraction / events.Count) : 0;
        }

        public int NumberOfCheckinInteraction()
        {
            int sumOfInteraction = 0;
            ICollection<Checkin> checkins = UserIn.Checkins;

            foreach (Checkin item in checkins)
            {
                sumOfInteraction += item.Comments.Count * 3;
                sumOfInteraction += item.LikedBy.Count * 2;
            }

            return checkins.Count > 0 ? (sumOfInteraction / (checkins.Count * 2)) : 0;
        }

        public int NumberOfTagged()
        {
            return UserIn.PhotosTaggedIn.Count + UserIn.PostsTaggedIn.Count;
        }


        public void clacStarsFromAnalisis(eStarsParameters i_eParameter)
        {
            List<int> allParameters = new List<int>();

            if ((i_eParameter & eStarsParameters.checkin) == eStarsParameters.checkin)
            {
                allParameters.Add(NumberOfCheckinInteraction());
            }

            if ((i_eParameter & eStarsParameters.events) == eStarsParameters.events)
            {
                allParameters.Add(NumberOfInteractionInEvents());
            }

            if ((i_eParameter & eStarsParameters.posts) == eStarsParameters.posts)
            {
                allParameters.Add(NumberOfInterctionInPosts());
            }

            if ((i_eParameter & eStarsParameters.tagged) == eStarsParameters.tagged)
            {
                //// TO CHECK IF I WANT SOMETHING ELSEEE!!@@
                allParameters.Add(NumberOfTagged());
            }

            MyStars.clacStars(false, allParameters);
        }

        public int CompareTo(UserAnalysis other)
        {
            return this.MyStars.CompareTo(other.MyStars);
        }

        [Flags]
        public enum eStarsParameters
        {
            none,
            checkin = 1,
            events = 2,
            posts = 4,
            tagged = 8
        }
    }
}

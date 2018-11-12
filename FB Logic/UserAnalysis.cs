﻿using FacebookWrapper.ObjectModel;
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

        public UserAnalysis()
        {
            MyStars = new Stars();
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
                allParameters.Add(UserIn.PhotosTaggedIn.Count + UserIn.PostsTaggedIn.Count);
            }

            MyStars.clacStars(false, allParameters);
        }

        public int CompareTo(UserAnalysis other)
        {
            return this.MyStars.CompareTo(other.MyStars);
        }

        //public int InteractonByLikeAndComment<T>(ICollection<T> i_Aggregit)
        //{
        //    int sumInteractions = 0;
        //    foreach (T item in i_Aggregit)
        //    {

        //    }
        //}

        [Flags]
        public enum eStarsParameters
        {
            checkin = 1,
            events = 2,
            posts = 4,
            tagged = 8
        }

    }
}

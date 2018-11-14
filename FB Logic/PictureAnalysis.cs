﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FB_Logic
{
    public class PictureAnalysis : IComparable<PictureAnalysis>
    {
        private const int k_CommentValue = 2;
        public Stars MyStars { get; }
        public string PictureUrl { get; set; }
        public string PictureID { get; set; }

        public PictureAnalysis()
        {
            MyStars = new Stars();
        }

        public void CalcStars(int i_LikeCount, int i_CommentCount)
        {
            MyStars.clacStars(true, i_LikeCount + i_CommentCount * k_CommentValue);
        }

        public override string ToString()
        {
            return string.Format("{0} Gold ,{1} normal stars", MyStars.GoldenStars, MyStars.NormalStars);
        }

        public int CompareTo(PictureAnalysis i_Other)
        {
            return this.MyStars.CompareTo(i_Other.MyStars);// i_Other.MyStars.StarsToNumbers() - this.MyStars.StarsToNumbers() ;
        }
    }

    public class PictureAnalysisSort : IComparer<PictureAnalysis>
    {
        public int Compare(PictureAnalysis i_RightPA, PictureAnalysis i_LeftPA)
        {
            return i_RightPA.CompareTo(i_LeftPA);
        }
    }
}
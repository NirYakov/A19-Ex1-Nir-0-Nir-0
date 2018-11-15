using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FB_Logic
{
    public class Stars : IComparable<Stars>
    {
        public static int GoldStarBar { get; }
        private const float k_PicStartsInterval = 1.5f; 

        public int GoldenStars { get; private set; } = 0;

        public int NormalStars { get; private set; } = 0;

        static Stars()
        {
            GoldStarBar = 60; // bm
        }

        public void clacStars(bool i_PicutreStars, params int[] i_Pra)//ICollection<int> i_Pra)
        {
            int result = 0;

            foreach (int number in i_Pra)
            {
                result += number;
            }

            if (i_PicutreStars)
            {
                result = calcolatePhotoInteraction(result);
            }
            else
            {
                if (result > GoldStarBar)
                {
                    result += 10;
                    result += result % 10;
                }
            }

            NormalStars = result % GoldStarBar;
            GoldenStars = result / GoldStarBar;
        }

        private int calcolatePhotoInteraction(int i_Result)
        {
            return (int)(i_Result * k_PicStartsInterval);
        }

        private int calcolateOtherInteraction(int i_Result)
        {
            if (i_Result > GoldStarBar)
            {
                i_Result += 10;
                i_Result += i_Result % 10;
            }
            return i_Result;
        }

        public int CompareTo(Stars i_Other)
        {
            return i_Other.StarsToNumbers() - this.StarsToNumbers();
        }

        public int StarsToNumbers()
        {
            int result = 0;
            result += NormalStars;
            result += GoldenStars * GoldStarBar;
            return result;
        }

        public override string ToString()
        {
            return string.Format("{0} gold and {1} stars", GoldenStars, NormalStars);
        }

        public static Stars NumberToStars(int i_Total)
        {
            int goldStar, normalStar;
            normalStar = i_Total % GoldStarBar;
            goldStar = i_Total / GoldStarBar;

            return new Stars() { GoldenStars = goldStar, NormalStars = normalStar };
        }
    }
}

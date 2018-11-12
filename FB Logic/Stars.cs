using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FB_Logic
{
    public class Stars : IComparable<Stars>
    {
        public const int k_ExstraGoldStarBar = 60; // This how to write public const? 
        private const float k_PicStartsInterval = 1.5f; 

        public int GoldenStars { get; private set; } = 0;

        public int RegolarStars { get; private set; } = 0;

        public void clacStars(bool i_PicutreStars, ICollection<int> i_Pra)
        {
            int result = 0;

            foreach (int number in i_Pra)
            {
                result += number;
            }

            if (i_PicutreStars)
            {
                result = (int)(result * k_PicStartsInterval);
            }
            else
            {
                if (result > k_ExstraGoldStarBar)
                {
                    result += 10;
                    result += result % 10;
                }
            }

            RegolarStars = result % k_ExstraGoldStarBar;
            GoldenStars = result / k_ExstraGoldStarBar;
        }

        public int CompareTo(Stars i_Other)
        {
            return this.StarsToNumbers() - i_Other.StarsToNumbers();
        }

        public int StarsToNumbers()
        {
            int result = 0;
            result += RegolarStars;
            result += GoldenStars * k_ExstraGoldStarBar;
            return result;
        }

        public override string ToString()
        {
            return string.Format("{0} gold and {1} stars", GoldenStars, RegolarStars);
        }
    }
}

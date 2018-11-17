using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A19_Ex1_Nir_0_Nir_0
{
    public static class SettingUi
    {
        private static readonly Color sr_BackColorTheme;
        private static readonly Color sr_ForeColorTheme;

        static SettingUi()
        {
            sr_BackColorTheme = Color.CornflowerBlue;
            sr_ForeColorTheme = Color.White;

            //sr_BackColorTheme = Color.Red;
            //sr_ForeColorTheme = Color.Black;
        }

        public static Color BackColorTheme()
        {
            return sr_BackColorTheme;
        }

        public static Color ForeColorTheme()
        {
            return sr_ForeColorTheme;
        }
    }
}

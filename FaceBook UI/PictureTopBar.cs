using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FB_Logic;

namespace A19_Ex1_Nir_0_Nir_0
{
    public delegate void PicAndPanelClick(object obj, EventArgs e);

    public partial class PictureTopBar : UserControl
    {
        private readonly List<PicAndPanelClick> NotifiersByClick;

        public UserAnalysis MyUserAnalysis { get; }

        public PictureBox Picture { get { return pictureBox1; } set { pictureBox1 = value; } }

        public Label LabelText { get { return label1; } set { label1 = value; } }

        public Panel TopPanel { get { return panel1; } set { panel1 = value; } }

        public PictureTopBar()
        {
            InitializeComponent();
            NotifiersByClick = new List<PicAndPanelClick>();
            MyUserAnalysis = new UserAnalysis();
        }

        public void AddToClickEvent(PicAndPanelClick ok)
        {
            Picture.Click += Notify;
            TopPanel.Click += Notify;
            NotifiersByClick.Add(ok);
        }

        public void Notify(object sender, EventArgs e) // it's the right format ? maybe code stlye check // Mb
        {
            foreach (PicAndPanelClick item in NotifiersByClick)
            {
                item.Invoke(this, e);
            }
        }
    }
}

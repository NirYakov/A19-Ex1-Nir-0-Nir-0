using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FB_Logic;

namespace WinFormUI
{
    public delegate void PicAndPanelClick(object obj, EventArgs e);

    public partial class PictureTopBar : UserControl
    {
        private readonly List<PicAndPanelClick> NotifiersByClick;

        public UserAnalysis MyUserAnalysis { get; }

        public PictureBox Picture { get { return pictureBoxUsers; } set { pictureBoxUsers = value; } }

        public Label LabelText { get { return labelTopText; } set { labelTopText = value; } }

        public Panel TopPanel { get { return topPanel; } set { topPanel = value; } }

        public PictureTopBar()
        {
            InitializeComponent();
            NotifiersByClick = new List<PicAndPanelClick>();
            MyUserAnalysis = new UserAnalysis();
        }

        public void AddToClickEvent(PicAndPanelClick ok)
        {
            Picture.Click += OnClickNotify;
            TopPanel.Click += OnClickNotify;
            NotifiersByClick.Add(ok);
        }

        protected virtual void OnClickNotify(object sender, EventArgs e)
        {
            foreach (PicAndPanelClick item in NotifiersByClick)
            {
                item.Invoke(this, e);
            }
        }
    }
}

namespace A19_Ex1_Nir_0_Nir_0
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.textBoxPost = new System.Windows.Forms.TextBox();
            this.btnPost = new System.Windows.Forms.Button();
            this.linkFriends = new System.Windows.Forms.LinkLabel();
            this.pictureBoxFriend = new System.Windows.Forms.PictureBox();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.linkPages = new System.Windows.Forms.LinkLabel();
            this.linkCheckins = new System.Windows.Forms.LinkLabel();
            this.labelEvents = new System.Windows.Forms.LinkLabel();
            this.listBoxPages = new System.Windows.Forms.ListBox();
            this.listBoxCheckins = new System.Windows.Forms.ListBox();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.linkPosts = new System.Windows.Forms.LinkLabel();
            this.btnFeature1 = new System.Windows.Forms.Button();
            this.btnFeature2 = new System.Windows.Forms.Button();
            this.pictureBoxLogOut = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panelData = new System.Windows.Forms.Panel();
            this.panelActive = new System.Windows.Forms.Panel();
            this.labelEventsNum = new System.Windows.Forms.Label();
            this.labelEventsStatus = new System.Windows.Forms.Label();
            this.labelCheckinsNum = new System.Windows.Forms.Label();
            this.labelCheckinsStatus = new System.Windows.Forms.Label();
            this.labelLikedPagesNum = new System.Windows.Forms.Label();
            this.labelLikedPagesStatus = new System.Windows.Forms.Label();
            this.labelPostsNum = new System.Windows.Forms.Label();
            this.labelPostsStatus = new System.Windows.Forms.Label();
            this.labelFriendsNum = new System.Windows.Forms.Label();
            this.labelFriendsStatus = new System.Windows.Forms.Label();
            this.pictureBoxCoverPic = new System.Windows.Forms.PictureBox();
            this.pictureBoxEvent = new System.Windows.Forms.PictureBox();
            this.pictureBoxPage = new System.Windows.Forms.PictureBox();
            this.buttonSettings = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogOut)).BeginInit();
            this.panelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoverPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPage)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxUser
            // 
            this.pictureBoxUser.ErrorImage = global::A19_Ex1_Nir_0_Nir_0.Properties.Resources.faceLogo;
            this.pictureBoxUser.Image = global::A19_Ex1_Nir_0_Nir_0.Properties.Resources.faceLogo;
            this.pictureBoxUser.InitialImage = global::A19_Ex1_Nir_0_Nir_0.Properties.Resources.faceLogo;
            this.pictureBoxUser.Location = new System.Drawing.Point(44, 140);
            this.pictureBoxUser.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.Size = new System.Drawing.Size(250, 250);
            this.pictureBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUser.TabIndex = 0;
            this.pictureBoxUser.TabStop = false;
            // 
            // textBoxPost
            // 
            this.textBoxPost.Enabled = false;
            this.textBoxPost.Location = new System.Drawing.Point(492, 294);
            this.textBoxPost.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPost.Multiline = true;
            this.textBoxPost.Name = "textBoxPost";
            this.textBoxPost.Size = new System.Drawing.Size(564, 41);
            this.textBoxPost.TabIndex = 2;
            // 
            // btnPost
            // 
            this.btnPost.Enabled = false;
            this.btnPost.Location = new System.Drawing.Point(940, 348);
            this.btnPost.Margin = new System.Windows.Forms.Padding(4);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(116, 40);
            this.btnPost.TabIndex = 3;
            this.btnPost.Text = "Posts";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // linkFriends
            // 
            this.linkFriends.AutoSize = true;
            this.linkFriends.Enabled = false;
            this.linkFriends.LinkArea = new System.Windows.Forms.LinkArea(0, 13);
            this.linkFriends.Location = new System.Drawing.Point(28, 625);
            this.linkFriends.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.linkFriends.Name = "linkFriends";
            this.linkFriends.Size = new System.Drawing.Size(512, 54);
            this.linkFriends.TabIndex = 78;
            this.linkFriends.TabStop = true;
            this.linkFriends.Text = "Fetch Friends (Only friends who also use this app..)\r\n(Click on a friend to view " +
    "it\'s picture)";
            this.linkFriends.UseCompatibleTextRendering = true;
            this.linkFriends.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkFriends_LinkClicked);
            // 
            // pictureBoxFriend
            // 
            this.pictureBoxFriend.Enabled = false;
            this.pictureBoxFriend.Location = new System.Drawing.Point(356, 854);
            this.pictureBoxFriend.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBoxFriend.Name = "pictureBoxFriend";
            this.pictureBoxFriend.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxFriend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFriend.TabIndex = 82;
            this.pictureBoxFriend.TabStop = false;
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.Enabled = false;
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 25;
            this.listBoxFriends.Location = new System.Drawing.Point(28, 717);
            this.listBoxFriends.Margin = new System.Windows.Forms.Padding(6);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(304, 554);
            this.listBoxFriends.TabIndex = 83;
            this.listBoxFriends.SelectedIndexChanged += new System.EventHandler(this.listBoxFriends_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(488, 263);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 25);
            this.label3.TabIndex = 84;
            this.label3.Text = "Post Status:";
            // 
            // linkPages
            // 
            this.linkPages.AutoSize = true;
            this.linkPages.Enabled = false;
            this.linkPages.LinkArea = new System.Windows.Forms.LinkArea(0, 17);
            this.linkPages.Location = new System.Drawing.Point(676, 606);
            this.linkPages.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.linkPages.Name = "linkPages";
            this.linkPages.Size = new System.Drawing.Size(346, 54);
            this.linkPages.TabIndex = 74;
            this.linkPages.TabStop = true;
            this.linkPages.Text = "Fetch Liked Pages \r\n(Click on a page to view it\'s picture)";
            this.linkPages.UseCompatibleTextRendering = true;
            this.linkPages.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPages_LinkClicked);
            // 
            // linkCheckins
            // 
            this.linkCheckins.AutoSize = true;
            this.linkCheckins.Enabled = false;
            this.linkCheckins.LinkArea = new System.Windows.Forms.LinkArea(0, 14);
            this.linkCheckins.Location = new System.Drawing.Point(676, 835);
            this.linkCheckins.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.linkCheckins.Name = "linkCheckins";
            this.linkCheckins.Size = new System.Drawing.Size(369, 54);
            this.linkCheckins.TabIndex = 79;
            this.linkCheckins.TabStop = true;
            this.linkCheckins.Text = "Fetch Checkins \r\n(Click on a checkin to view it\'s details)";
            this.linkCheckins.UseCompatibleTextRendering = true;
            this.linkCheckins.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCheckins_LinkClicked);
            // 
            // labelEvents
            // 
            this.labelEvents.AutoSize = true;
            this.labelEvents.Enabled = false;
            this.labelEvents.LinkArea = new System.Windows.Forms.LinkArea(0, 13);
            this.labelEvents.Location = new System.Drawing.Point(676, 1065);
            this.labelEvents.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelEvents.Name = "labelEvents";
            this.labelEvents.Size = new System.Drawing.Size(363, 54);
            this.labelEvents.TabIndex = 80;
            this.labelEvents.TabStop = true;
            this.labelEvents.Text = "Fetch Events \r\n(Click on an event to view it\'s picture)";
            this.labelEvents.UseCompatibleTextRendering = true;
            this.labelEvents.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelEvents_LinkClicked);
            // 
            // listBoxPages
            // 
            this.listBoxPages.DisplayMember = "name";
            this.listBoxPages.Enabled = false;
            this.listBoxPages.FormattingEnabled = true;
            this.listBoxPages.ItemHeight = 25;
            this.listBoxPages.Location = new System.Drawing.Point(676, 671);
            this.listBoxPages.Margin = new System.Windows.Forms.Padding(6);
            this.listBoxPages.Name = "listBoxPages";
            this.listBoxPages.Size = new System.Drawing.Size(412, 154);
            this.listBoxPages.TabIndex = 85;
            this.listBoxPages.SelectedIndexChanged += new System.EventHandler(this.listBoxPages_SelectedIndexChanged);
            // 
            // listBoxCheckins
            // 
            this.listBoxCheckins.DisplayMember = "name";
            this.listBoxCheckins.Enabled = false;
            this.listBoxCheckins.FormattingEnabled = true;
            this.listBoxCheckins.ItemHeight = 25;
            this.listBoxCheckins.Location = new System.Drawing.Point(676, 900);
            this.listBoxCheckins.Margin = new System.Windows.Forms.Padding(6);
            this.listBoxCheckins.Name = "listBoxCheckins";
            this.listBoxCheckins.Size = new System.Drawing.Size(412, 154);
            this.listBoxCheckins.TabIndex = 86;
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.DisplayMember = "name";
            this.listBoxEvents.Enabled = false;
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.ItemHeight = 25;
            this.listBoxEvents.Location = new System.Drawing.Point(676, 1131);
            this.listBoxEvents.Margin = new System.Windows.Forms.Padding(6);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(412, 154);
            this.listBoxEvents.TabIndex = 87;
            this.listBoxEvents.SelectedIndexChanged += new System.EventHandler(this.listBoxEvents_SelectedIndexChanged);
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.DisplayMember = "name";
            this.listBoxPosts.Enabled = false;
            this.listBoxPosts.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 39;
            this.listBoxPosts.Location = new System.Drawing.Point(492, 398);
            this.listBoxPosts.Margin = new System.Windows.Forms.Padding(6);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(564, 160);
            this.listBoxPosts.TabIndex = 88;
            // 
            // linkPosts
            // 
            this.linkPosts.AutoSize = true;
            this.linkPosts.Enabled = false;
            this.linkPosts.Location = new System.Drawing.Point(490, 365);
            this.linkPosts.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.linkPosts.Name = "linkPosts";
            this.linkPosts.Size = new System.Drawing.Size(126, 25);
            this.linkPosts.TabIndex = 89;
            this.linkPosts.TabStop = true;
            this.linkPosts.Text = "Fetch Posts";
            this.linkPosts.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPosts_LinkClicked);
            // 
            // btnFeature1
            // 
            this.btnFeature1.Enabled = false;
            this.btnFeature1.Location = new System.Drawing.Point(44, 477);
            this.btnFeature1.Margin = new System.Windows.Forms.Padding(4);
            this.btnFeature1.Name = "btnFeature1";
            this.btnFeature1.Size = new System.Drawing.Size(120, 44);
            this.btnFeature1.TabIndex = 90;
            this.btnFeature1.Text = "Feature 1";
            this.btnFeature1.UseVisualStyleBackColor = true;
            this.btnFeature1.Click += new System.EventHandler(this.btnFeature1_Click);
            // 
            // btnFeature2
            // 
            this.btnFeature2.Enabled = false;
            this.btnFeature2.Location = new System.Drawing.Point(40, 540);
            this.btnFeature2.Margin = new System.Windows.Forms.Padding(4);
            this.btnFeature2.Name = "btnFeature2";
            this.btnFeature2.Size = new System.Drawing.Size(120, 44);
            this.btnFeature2.TabIndex = 92;
            this.btnFeature2.Text = "Feature 2";
            this.btnFeature2.UseVisualStyleBackColor = true;
            this.btnFeature2.Click += new System.EventHandler(this.btnFeature2_Click);
            // 
            // pictureBoxLogOut
            // 
            this.pictureBoxLogOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxLogOut.Image = global::A19_Ex1_Nir_0_Nir_0.Properties.Resources.logout4;
            this.pictureBoxLogOut.Location = new System.Drawing.Point(324, 302);
            this.pictureBoxLogOut.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxLogOut.Name = "pictureBoxLogOut";
            this.pictureBoxLogOut.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxLogOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogOut.TabIndex = 93;
            this.pictureBoxLogOut.TabStop = false;
            this.pictureBoxLogOut.Visible = false;
            this.pictureBoxLogOut.Click += new System.EventHandler(this.pictureBoxLogOut_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLogin.Location = new System.Drawing.Point(324, 302);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(120, 50);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Log in";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // panelData
            // 
            this.panelData.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelData.Controls.Add(this.panelActive);
            this.panelData.Controls.Add(this.labelEventsNum);
            this.panelData.Controls.Add(this.labelEventsStatus);
            this.panelData.Controls.Add(this.labelCheckinsNum);
            this.panelData.Controls.Add(this.labelCheckinsStatus);
            this.panelData.Controls.Add(this.labelLikedPagesNum);
            this.panelData.Controls.Add(this.labelLikedPagesStatus);
            this.panelData.Controls.Add(this.labelPostsNum);
            this.panelData.Controls.Add(this.labelPostsStatus);
            this.panelData.Controls.Add(this.labelFriendsNum);
            this.panelData.Controls.Add(this.labelFriendsStatus);
            this.panelData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelData.Location = new System.Drawing.Point(0, 1381);
            this.panelData.Margin = new System.Windows.Forms.Padding(4);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(1116, 44);
            this.panelData.TabIndex = 94;
            // 
            // panelActive
            // 
            this.panelActive.BackColor = System.Drawing.Color.Red;
            this.panelActive.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelActive.Location = new System.Drawing.Point(1071, 0);
            this.panelActive.Margin = new System.Windows.Forms.Padding(4);
            this.panelActive.Name = "panelActive";
            this.panelActive.Size = new System.Drawing.Size(45, 44);
            this.panelActive.TabIndex = 95;
            // 
            // labelEventsNum
            // 
            this.labelEventsNum.AutoSize = true;
            this.labelEventsNum.ForeColor = System.Drawing.Color.White;
            this.labelEventsNum.Location = new System.Drawing.Point(976, 12);
            this.labelEventsNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEventsNum.Name = "labelEventsNum";
            this.labelEventsNum.Size = new System.Drawing.Size(42, 25);
            this.labelEventsNum.TabIndex = 104;
            this.labelEventsNum.Text = "n/a";
            // 
            // labelEventsStatus
            // 
            this.labelEventsStatus.AutoSize = true;
            this.labelEventsStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEventsStatus.ForeColor = System.Drawing.Color.White;
            this.labelEventsStatus.Location = new System.Drawing.Point(872, 12);
            this.labelEventsStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEventsStatus.Name = "labelEventsStatus";
            this.labelEventsStatus.Size = new System.Drawing.Size(91, 25);
            this.labelEventsStatus.TabIndex = 103;
            this.labelEventsStatus.Text = "Events:";
            // 
            // labelCheckinsNum
            // 
            this.labelCheckinsNum.AutoSize = true;
            this.labelCheckinsNum.ForeColor = System.Drawing.Color.White;
            this.labelCheckinsNum.Location = new System.Drawing.Point(780, 12);
            this.labelCheckinsNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCheckinsNum.Name = "labelCheckinsNum";
            this.labelCheckinsNum.Size = new System.Drawing.Size(42, 25);
            this.labelCheckinsNum.TabIndex = 102;
            this.labelCheckinsNum.Text = "n/a";
            // 
            // labelCheckinsStatus
            // 
            this.labelCheckinsStatus.AutoSize = true;
            this.labelCheckinsStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCheckinsStatus.ForeColor = System.Drawing.Color.White;
            this.labelCheckinsStatus.Location = new System.Drawing.Point(652, 12);
            this.labelCheckinsStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCheckinsStatus.Name = "labelCheckinsStatus";
            this.labelCheckinsStatus.Size = new System.Drawing.Size(116, 25);
            this.labelCheckinsStatus.TabIndex = 101;
            this.labelCheckinsStatus.Text = "Checkins:";
            // 
            // labelLikedPagesNum
            // 
            this.labelLikedPagesNum.AutoSize = true;
            this.labelLikedPagesNum.ForeColor = System.Drawing.Color.White;
            this.labelLikedPagesNum.Location = new System.Drawing.Point(568, 12);
            this.labelLikedPagesNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLikedPagesNum.Name = "labelLikedPagesNum";
            this.labelLikedPagesNum.Size = new System.Drawing.Size(42, 25);
            this.labelLikedPagesNum.TabIndex = 100;
            this.labelLikedPagesNum.Text = "n/a";
            // 
            // labelLikedPagesStatus
            // 
            this.labelLikedPagesStatus.AutoSize = true;
            this.labelLikedPagesStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLikedPagesStatus.ForeColor = System.Drawing.Color.White;
            this.labelLikedPagesStatus.Location = new System.Drawing.Point(408, 12);
            this.labelLikedPagesStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLikedPagesStatus.Name = "labelLikedPagesStatus";
            this.labelLikedPagesStatus.Size = new System.Drawing.Size(149, 25);
            this.labelLikedPagesStatus.TabIndex = 99;
            this.labelLikedPagesStatus.Text = "Liked Pages:";
            // 
            // labelPostsNum
            // 
            this.labelPostsNum.AutoSize = true;
            this.labelPostsNum.ForeColor = System.Drawing.Color.White;
            this.labelPostsNum.Location = new System.Drawing.Point(308, 12);
            this.labelPostsNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPostsNum.Name = "labelPostsNum";
            this.labelPostsNum.Size = new System.Drawing.Size(42, 25);
            this.labelPostsNum.TabIndex = 98;
            this.labelPostsNum.Text = "n/a";
            // 
            // labelPostsStatus
            // 
            this.labelPostsStatus.AutoSize = true;
            this.labelPostsStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPostsStatus.ForeColor = System.Drawing.Color.White;
            this.labelPostsStatus.Location = new System.Drawing.Point(220, 12);
            this.labelPostsStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPostsStatus.Name = "labelPostsStatus";
            this.labelPostsStatus.Size = new System.Drawing.Size(78, 25);
            this.labelPostsStatus.TabIndex = 97;
            this.labelPostsStatus.Text = "Posts:";
            // 
            // labelFriendsNum
            // 
            this.labelFriendsNum.AutoSize = true;
            this.labelFriendsNum.ForeColor = System.Drawing.Color.White;
            this.labelFriendsNum.Location = new System.Drawing.Point(122, 12);
            this.labelFriendsNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFriendsNum.Name = "labelFriendsNum";
            this.labelFriendsNum.Size = new System.Drawing.Size(42, 25);
            this.labelFriendsNum.TabIndex = 96;
            this.labelFriendsNum.Text = "n/a";
            // 
            // labelFriendsStatus
            // 
            this.labelFriendsStatus.AutoSize = true;
            this.labelFriendsStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFriendsStatus.ForeColor = System.Drawing.Color.White;
            this.labelFriendsStatus.Location = new System.Drawing.Point(16, 12);
            this.labelFriendsStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFriendsStatus.Name = "labelFriendsStatus";
            this.labelFriendsStatus.Size = new System.Drawing.Size(98, 25);
            this.labelFriendsStatus.TabIndex = 95;
            this.labelFriendsStatus.Text = "Friends:";
            // 
            // pictureBoxCoverPic
            // 
            this.pictureBoxCoverPic.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBoxCoverPic.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxCoverPic.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxCoverPic.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxCoverPic.Name = "pictureBoxCoverPic";
            this.pictureBoxCoverPic.Size = new System.Drawing.Size(1116, 242);
            this.pictureBoxCoverPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoverPic.TabIndex = 96;
            this.pictureBoxCoverPic.TabStop = false;
            // 
            // pictureBoxEvent
            // 
            this.pictureBoxEvent.Location = new System.Drawing.Point(564, 1185);
            this.pictureBoxEvent.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBoxEvent.Name = "pictureBoxEvent";
            this.pictureBoxEvent.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxEvent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEvent.TabIndex = 97;
            this.pictureBoxEvent.TabStop = false;
            // 
            // pictureBoxPage
            // 
            this.pictureBoxPage.Location = new System.Drawing.Point(564, 671);
            this.pictureBoxPage.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBoxPage.Name = "pictureBoxPage";
            this.pictureBoxPage.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxPage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPage.TabIndex = 98;
            this.pictureBoxPage.TabStop = false;
            // 
            // buttonSettings
            // 
            this.buttonSettings.Location = new System.Drawing.Point(268, 502);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(118, 56);
            this.buttonSettings.TabIndex = 99;
            this.buttonSettings.Text = "Settings";
            this.buttonSettings.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 1425);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.pictureBoxPage);
            this.Controls.Add(this.pictureBoxEvent);
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.pictureBoxLogOut);
            this.Controls.Add(this.btnFeature2);
            this.Controls.Add(this.btnFeature1);
            this.Controls.Add(this.linkPosts);
            this.Controls.Add(this.listBoxPosts);
            this.Controls.Add(this.listBoxEvents);
            this.Controls.Add(this.listBoxCheckins);
            this.Controls.Add(this.listBoxPages);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxFriends);
            this.Controls.Add(this.pictureBoxFriend);
            this.Controls.Add(this.labelEvents);
            this.Controls.Add(this.linkCheckins);
            this.Controls.Add(this.linkPages);
            this.Controls.Add(this.linkFriends);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.textBoxPost);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.pictureBoxUser);
            this.Controls.Add(this.pictureBoxCoverPic);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1106, 829);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogOut)).EndInit();
            this.panelData.ResumeLayout(false);
            this.panelData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoverPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxUser;
        private System.Windows.Forms.TextBox textBoxPost;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.LinkLabel linkFriends;
        private System.Windows.Forms.PictureBox pictureBoxFriend;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkPages;
        private System.Windows.Forms.LinkLabel linkCheckins;
        private System.Windows.Forms.LinkLabel labelEvents;
        private System.Windows.Forms.ListBox listBoxPages;
        private System.Windows.Forms.ListBox listBoxCheckins;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.LinkLabel linkPosts;
        private System.Windows.Forms.Button btnFeature1;
        private System.Windows.Forms.Button btnFeature2;
        private System.Windows.Forms.PictureBox pictureBoxLogOut;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.Label labelEventsNum;
        private System.Windows.Forms.Label labelEventsStatus;
        private System.Windows.Forms.Label labelCheckinsNum;
        private System.Windows.Forms.Label labelCheckinsStatus;
        private System.Windows.Forms.Label labelLikedPagesNum;
        private System.Windows.Forms.Label labelLikedPagesStatus;
        private System.Windows.Forms.Label labelPostsNum;
        private System.Windows.Forms.Label labelPostsStatus;
        private System.Windows.Forms.Label labelFriendsNum;
        private System.Windows.Forms.Label labelFriendsStatus;
        private System.Windows.Forms.Panel panelActive;
        private System.Windows.Forms.PictureBox pictureBoxCoverPic;
        private System.Windows.Forms.PictureBox pictureBoxEvent;
        private System.Windows.Forms.PictureBox pictureBoxPage;
        private System.Windows.Forms.Button buttonSettings;
    }
} 
using System;

namespace STNLTTQ
{
    partial class Pika2Vn
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pika2Vn));
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.pnlChessBoard = new System.Windows.Forms.Panel();
            this.progressBar = new System.Windows.Forms.PictureBox();
            this.pctbLifeTime = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chếĐộChơiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avt1 = new System.Windows.Forms.ToolStripMenuItem();
            this.avt2 = new System.Windows.Forms.ToolStripMenuItem();
            this.percent = new System.Windows.Forms.Label();
            this.pctbPause = new System.Windows.Forms.PictureBox();
            this.pctbHome = new System.Windows.Forms.PictureBox();
            this.pctbPlay = new System.Windows.Forms.PictureBox();
            this.pctbSoundOn = new System.Windows.Forms.PictureBox();
            this.pctbSoundOff = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.score = new System.Windows.Forms.Label();
            this.score_title = new System.Windows.Forms.Label();
            this.pctbReset = new System.Windows.Forms.PictureBox();
            this.pctbHelp = new System.Windows.Forms.PictureBox();
            this.BgMusic = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.progressBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbLifeTime)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbSoundOn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbSoundOff)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbReset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BgMusic)).BeginInit();
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // pnlChessBoard
            // 
            this.pnlChessBoard.BackColor = System.Drawing.Color.Transparent;
            this.pnlChessBoard.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlChessBoard.Location = new System.Drawing.Point(-75, 89);
            this.pnlChessBoard.Name = "pnlChessBoard";
            this.pnlChessBoard.Size = new System.Drawing.Size(1545, 811);
            this.pnlChessBoard.TabIndex = 23;
            this.pnlChessBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlChessBoard_Paint);
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.Lime;
            this.progressBar.Location = new System.Drawing.Point(125, 48);
            this.progressBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(1260, 35);
            this.progressBar.TabIndex = 25;
            this.progressBar.TabStop = false;
            // 
            // pctbLifeTime
            // 
            this.pctbLifeTime.BackColor = System.Drawing.Color.Transparent;
            this.pctbLifeTime.Image = global::DoubleFours.Properties.Resources.progressbarEch;
            this.pctbLifeTime.Location = new System.Drawing.Point(-22, 0);
            this.pctbLifeTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pctbLifeTime.Name = "pctbLifeTime";
            this.pctbLifeTime.Size = new System.Drawing.Size(1430, 127);
            this.pctbLifeTime.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbLifeTime.TabIndex = 24;
            this.pctbLifeTime.TabStop = false;
            this.pctbLifeTime.Click += new System.EventHandler(this.pctbLifeTime_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(-223, -26);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(76, 28);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chếĐộChơiToolStripMenuItem});
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // chếĐộChơiToolStripMenuItem
            // 
            this.chếĐộChơiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.avt1,
            this.avt2});
            this.chếĐộChơiToolStripMenuItem.Name = "chếĐộChơiToolStripMenuItem";
            this.chếĐộChơiToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.chếĐộChơiToolStripMenuItem.Text = "Chế Độ Chơi";
            // 
            // avt1
            // 
            this.avt1.BackgroundImage = global::DoubleFours.Properties.Resources.PanNwCursor;
            this.avt1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.avt1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.avt1.Name = "avt1";
            this.avt1.Size = new System.Drawing.Size(235, 26);
            this.avt1.Text = "toolStripMenuItem1";
            this.avt1.Click += new System.EventHandler(this.avt1_Click);
            // 
            // avt2
            // 
            this.avt2.BackgroundImage = global::DoubleFours.Properties.Resources.crossCursor;
            this.avt2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.avt2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.avt2.Name = "avt2";
            this.avt2.Size = new System.Drawing.Size(235, 26);
            this.avt2.Text = "toolStripMenuItem2";
            this.avt2.Click += new System.EventHandler(this.avt2_Click);
            // 
            // percent
            // 
            this.percent.AutoSize = true;
            this.percent.BackColor = System.Drawing.Color.Chocolate;
            this.percent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percent.Location = new System.Drawing.Point(752, 53);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(59, 24);
            this.percent.TabIndex = 26;
            this.percent.Text = "100%";
            // 
            // pctbPause
            // 
            this.pctbPause.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctbPause.BackColor = System.Drawing.Color.Transparent;
            this.pctbPause.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.pctbPause.Image = global::DoubleFours.Properties.Resources.pauseButton;
            this.pctbPause.Location = new System.Drawing.Point(84, 4);
            this.pctbPause.Name = "pctbPause";
            this.pctbPause.Size = new System.Drawing.Size(81, 77);
            this.pctbPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbPause.TabIndex = 5;
            this.pctbPause.TabStop = false;
            this.pctbPause.Click += new System.EventHandler(this.pctbPause_Click);
            // 
            // pctbHome
            // 
            this.pctbHome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctbHome.BackColor = System.Drawing.Color.Transparent;
            this.pctbHome.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.pctbHome.Image = global::DoubleFours.Properties.Resources.home;
            this.pctbHome.Location = new System.Drawing.Point(164, 4);
            this.pctbHome.Name = "pctbHome";
            this.pctbHome.Size = new System.Drawing.Size(81, 77);
            this.pctbHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbHome.TabIndex = 4;
            this.pctbHome.TabStop = false;
            this.pctbHome.Click += new System.EventHandler(this.pctbHome_Click);
            // 
            // pctbPlay
            // 
            this.pctbPlay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctbPlay.BackColor = System.Drawing.Color.Transparent;
            this.pctbPlay.Cursor = System.Windows.Forms.Cursors.Default;
            this.pctbPlay.Enabled = false;
            this.pctbPlay.Image = global::DoubleFours.Properties.Resources.play;
            this.pctbPlay.Location = new System.Drawing.Point(84, 5);
            this.pctbPlay.Name = "pctbPlay";
            this.pctbPlay.Size = new System.Drawing.Size(81, 76);
            this.pctbPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbPlay.TabIndex = 27;
            this.pctbPlay.TabStop = false;
            this.pctbPlay.Visible = false;
            this.pctbPlay.Click += new System.EventHandler(this.pctbPlay_Click);
            // 
            // pctbSoundOn
            // 
            this.pctbSoundOn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctbSoundOn.BackColor = System.Drawing.Color.Transparent;
            this.pctbSoundOn.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.pctbSoundOn.Image = global::DoubleFours.Properties.Resources.sound_on;
            this.pctbSoundOn.Location = new System.Drawing.Point(0, 3);
            this.pctbSoundOn.Name = "pctbSoundOn";
            this.pctbSoundOn.Size = new System.Drawing.Size(81, 77);
            this.pctbSoundOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbSoundOn.TabIndex = 6;
            this.pctbSoundOn.TabStop = false;
            this.pctbSoundOn.Click += new System.EventHandler(this.pctbSound_Click);
            // 
            // pctbSoundOff
            // 
            this.pctbSoundOff.BackColor = System.Drawing.Color.Transparent;
            this.pctbSoundOff.Enabled = false;
            this.pctbSoundOff.Image = global::DoubleFours.Properties.Resources.sound_off;
            this.pctbSoundOff.Location = new System.Drawing.Point(0, 3);
            this.pctbSoundOff.Name = "pctbSoundOff";
            this.pctbSoundOff.Size = new System.Drawing.Size(81, 76);
            this.pctbSoundOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbSoundOff.TabIndex = 31;
            this.pctbSoundOff.TabStop = false;
            this.pctbSoundOff.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.score);
            this.panel1.Controls.Add(this.score_title);
            this.panel1.Controls.Add(this.pctbReset);
            this.panel1.Controls.Add(this.pctbSoundOff);
            this.panel1.Controls.Add(this.pctbHelp);
            this.panel1.Controls.Add(this.pctbSoundOn);
            this.panel1.Controls.Add(this.pctbPlay);
            this.panel1.Controls.Add(this.pctbHome);
            this.panel1.Controls.Add(this.pctbPause);
            this.panel1.Location = new System.Drawing.Point(1721, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 786);
            this.panel1.TabIndex = 32;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.BackColor = System.Drawing.Color.Transparent;
            this.score.Font = new System.Drawing.Font("Algerian", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.ForeColor = System.Drawing.Color.Gold;
            this.score.Location = new System.Drawing.Point(53, 604);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(45, 46);
            this.score.TabIndex = 32;
            this.score.Text = "0";
            this.score.Click += new System.EventHandler(this.score_Click);
            // 
            // score_title
            // 
            this.score_title.AutoSize = true;
            this.score_title.BackColor = System.Drawing.Color.Transparent;
            this.score_title.Font = new System.Drawing.Font("Algerian", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_title.ForeColor = System.Drawing.Color.Gold;
            this.score_title.Location = new System.Drawing.Point(53, 529);
            this.score_title.Name = "score_title";
            this.score_title.Size = new System.Drawing.Size(112, 46);
            this.score_title.TabIndex = 4;
            this.score_title.Text = "Điểm";
            // 
            // pctbReset
            // 
            this.pctbReset.BackColor = System.Drawing.Color.Transparent;
            this.pctbReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctbReset.Image = global::DoubleFours.Properties.Resources.repeat;
            this.pctbReset.Location = new System.Drawing.Point(22, 292);
            this.pctbReset.Name = "pctbReset";
            this.pctbReset.Size = new System.Drawing.Size(89, 88);
            this.pctbReset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbReset.TabIndex = 16;
            this.pctbReset.TabStop = false;
            this.pctbReset.Click += new System.EventHandler(this.pctbReset_Click);
            this.pctbReset.MouseHover += new System.EventHandler(this.pctbReset_MouseHover);
            // 
            // pctbHelp
            // 
            this.pctbHelp.BackColor = System.Drawing.Color.Transparent;
            this.pctbHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctbHelp.Image = global::DoubleFours.Properties.Resources.help;
            this.pctbHelp.Location = new System.Drawing.Point(134, 292);
            this.pctbHelp.Name = "pctbHelp";
            this.pctbHelp.Size = new System.Drawing.Size(89, 88);
            this.pctbHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbHelp.TabIndex = 7;
            this.pctbHelp.TabStop = false;
            this.pctbHelp.Click += new System.EventHandler(this.pctbHelp_Click);
            this.pctbHelp.MouseHover += new System.EventHandler(this.pctbHelp_MouseHover);
            // 
            // BgMusic
            // 
            this.BgMusic.Enabled = true;
            this.BgMusic.Location = new System.Drawing.Point(1447, 898);
            this.BgMusic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BgMusic.Name = "BgMusic";
            this.BgMusic.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("BgMusic.OcxState")));
            this.BgMusic.Size = new System.Drawing.Size(75, 23);
            this.BgMusic.TabIndex = 30;
            this.BgMusic.Visible = false;
            this.BgMusic.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.BgMusic_PlayStateChange);
            // 
            // Pika2Vn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DoubleFours.Properties.Resources.hinhnen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1920, 1051);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BgMusic);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.percent);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.pctbLifeTime);
            this.Controls.Add(this.pnlChessBoard);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Pika2Vn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trúc xanh";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Pika2Vn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.progressBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbLifeTime)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbSoundOn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbSoundOff)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbReset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BgMusic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }




        #endregion
        private System.Windows.Forms.Timer Timer;
        public System.Windows.Forms.Panel pnlChessBoard;
        private System.Windows.Forms.PictureBox progressBar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chếĐộChơiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avt1;
        private System.Windows.Forms.ToolStripMenuItem avt2;
        private AxWMPLib.AxWindowsMediaPlayer BgMusic;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        public System.Windows.Forms.PictureBox pctbLifeTime;
        private System.Windows.Forms.Label percent;
        private System.Windows.Forms.PictureBox pctbPause;
        private System.Windows.Forms.PictureBox pctbSoundOn;
        private System.Windows.Forms.PictureBox pctbSoundOff;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pctbReset;
        private System.Windows.Forms.PictureBox pctbHelp;
        private System.Windows.Forms.PictureBox pctbHome;
        public System.Windows.Forms.PictureBox pctbPlay;
        private System.Windows.Forms.Label score_title;
        public System.Windows.Forms.Label score;
    }
}
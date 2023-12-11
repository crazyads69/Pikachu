using System;

namespace DoubleFours
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
            this.BgMusic = new AxWMPLib.AxWindowsMediaPlayer();
            this.percent = new System.Windows.Forms.Label();
            this.pctbPause = new System.Windows.Forms.PictureBox();
            this.pctbHome = new System.Windows.Forms.PictureBox();
            this.pctbPlay = new System.Windows.Forms.PictureBox();
            this.pctbSoundOn = new System.Windows.Forms.PictureBox();
            this.pctbSoundOff = new System.Windows.Forms.PictureBox();
            this.ptbstone1 = new System.Windows.Forms.PictureBox();
            this.ptbstone6 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ptbstone5 = new System.Windows.Forms.PictureBox();
            this.ptbstone4 = new System.Windows.Forms.PictureBox();
            this.ptbstone3 = new System.Windows.Forms.PictureBox();
            this.ptbstone2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pctbReset = new System.Windows.Forms.PictureBox();
            this.pctbHelp = new System.Windows.Forms.PictureBox();
            this.pctbFlyColor = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.progressBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbLifeTime)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BgMusic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbSoundOn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbSoundOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbstone1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbstone6)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbstone5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbstone4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbstone3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbstone2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbReset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbFlyColor)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(73, 28);
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
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // chếĐộChơiToolStripMenuItem
            // 
            this.chếĐộChơiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.avt1,
            this.avt2});
            this.chếĐộChơiToolStripMenuItem.Name = "chếĐộChơiToolStripMenuItem";
            this.chếĐộChơiToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.chếĐộChơiToolStripMenuItem.Text = "Chế Độ Chơi";
            // 
            // avt1
            // 
            this.avt1.BackgroundImage = global::DoubleFours.Properties.Resources.PanNwCursor;
            this.avt1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.avt1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.avt1.Name = "avt1";
            this.avt1.Size = new System.Drawing.Size(227, 26);
            this.avt1.Text = "toolStripMenuItem1";
            this.avt1.Click += new System.EventHandler(this.avt1_Click);
            // 
            // avt2
            // 
            this.avt2.BackgroundImage = global::DoubleFours.Properties.Resources.crossCursor;
            this.avt2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.avt2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.avt2.Name = "avt2";
            this.avt2.Size = new System.Drawing.Size(227, 26);
            this.avt2.Text = "toolStripMenuItem2";
            this.avt2.Click += new System.EventHandler(this.avt2_Click);
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
            this.pctbHome.Image = ((System.Drawing.Image)(resources.GetObject("pctbHome.Image")));
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
            // 
            // pctbSoundOn
            // 
            this.pctbSoundOn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctbSoundOn.BackColor = System.Drawing.Color.Transparent;
            this.pctbSoundOn.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.pctbSoundOn.Image = ((System.Drawing.Image)(resources.GetObject("pctbSoundOn.Image")));
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
            this.pctbSoundOff.Location = new System.Drawing.Point(0, 5);
            this.pctbSoundOff.Name = "pctbSoundOff";
            this.pctbSoundOff.Size = new System.Drawing.Size(81, 76);
            this.pctbSoundOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbSoundOff.TabIndex = 31;
            this.pctbSoundOff.TabStop = false;
            this.pctbSoundOff.Visible = false;
            // 
            // ptbstone1
            // 
            this.ptbstone1.Image = global::DoubleFours.Properties.Resources.stone1;
            this.ptbstone1.Location = new System.Drawing.Point(5, 709);
            this.ptbstone1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptbstone1.Name = "ptbstone1";
            this.ptbstone1.Size = new System.Drawing.Size(36, 36);
            this.ptbstone1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbstone1.TabIndex = 33;
            this.ptbstone1.TabStop = false;
            // 
            // ptbstone6
            // 
            this.ptbstone6.Image = global::DoubleFours.Properties.Resources.stone6;
            this.ptbstone6.Location = new System.Drawing.Point(192, 709);
            this.ptbstone6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptbstone6.Name = "ptbstone6";
            this.ptbstone6.Size = new System.Drawing.Size(36, 36);
            this.ptbstone6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbstone6.TabIndex = 38;
            this.ptbstone6.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.ptbstone6);
            this.panel1.Controls.Add(this.ptbstone5);
            this.panel1.Controls.Add(this.ptbstone4);
            this.panel1.Controls.Add(this.ptbstone3);
            this.panel1.Controls.Add(this.ptbstone2);
            this.panel1.Controls.Add(this.ptbstone1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pctbReset);
            this.panel1.Controls.Add(this.pctbSoundOff);
            this.panel1.Controls.Add(this.pctbHelp);
            this.panel1.Controls.Add(this.pctbFlyColor);
            this.panel1.Controls.Add(this.pctbSoundOn);
            this.panel1.Controls.Add(this.pctbPlay);
            this.panel1.Controls.Add(this.pctbHome);
            this.panel1.Controls.Add(this.pctbPause);
            this.panel1.Location = new System.Drawing.Point(1732, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 786);
            this.panel1.TabIndex = 32;
            // 
            // ptbstone5
            // 
            this.ptbstone5.Image = global::DoubleFours.Properties.Resources.stone5;
            this.ptbstone5.Location = new System.Drawing.Point(154, 709);
            this.ptbstone5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptbstone5.Name = "ptbstone5";
            this.ptbstone5.Size = new System.Drawing.Size(36, 36);
            this.ptbstone5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbstone5.TabIndex = 37;
            this.ptbstone5.TabStop = false;
            // 
            // ptbstone4
            // 
            this.ptbstone4.Image = global::DoubleFours.Properties.Resources.stone4;
            this.ptbstone4.Location = new System.Drawing.Point(117, 708);
            this.ptbstone4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptbstone4.Name = "ptbstone4";
            this.ptbstone4.Size = new System.Drawing.Size(36, 36);
            this.ptbstone4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbstone4.TabIndex = 36;
            this.ptbstone4.TabStop = false;
            // 
            // ptbstone3
            // 
            this.ptbstone3.Image = global::DoubleFours.Properties.Resources.stone3;
            this.ptbstone3.Location = new System.Drawing.Point(80, 708);
            this.ptbstone3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptbstone3.Name = "ptbstone3";
            this.ptbstone3.Size = new System.Drawing.Size(36, 36);
            this.ptbstone3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbstone3.TabIndex = 35;
            this.ptbstone3.TabStop = false;
            // 
            // ptbstone2
            // 
            this.ptbstone2.Image = global::DoubleFours.Properties.Resources.stone2;
            this.ptbstone2.Location = new System.Drawing.Point(42, 709);
            this.ptbstone2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptbstone2.Name = "ptbstone2";
            this.ptbstone2.Size = new System.Drawing.Size(36, 36);
            this.ptbstone2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbstone2.TabIndex = 34;
            this.ptbstone2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DoubleFours.Properties.Resources.stonebar;
            this.pictureBox1.Location = new System.Drawing.Point(2, 707);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
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
            this.pctbHelp.Image = ((System.Drawing.Image)(resources.GetObject("pctbHelp.Image")));
            this.pctbHelp.Location = new System.Drawing.Point(134, 292);
            this.pctbHelp.Name = "pctbHelp";
            this.pctbHelp.Size = new System.Drawing.Size(89, 88);
            this.pctbHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbHelp.TabIndex = 7;
            this.pctbHelp.TabStop = false;
            this.pctbHelp.Click += new System.EventHandler(this.pctbHelp_Click);
            this.pctbHelp.MouseHover += new System.EventHandler(this.pctbHelp_MouseHover);
            // 
            // pctbFlyColor
            // 
            this.pctbFlyColor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctbFlyColor.BackColor = System.Drawing.Color.Transparent;
            this.pctbFlyColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctbFlyColor.Image = ((System.Drawing.Image)(resources.GetObject("pctbFlyColor.Image")));
            this.pctbFlyColor.Location = new System.Drawing.Point(49, 420);
            this.pctbFlyColor.Name = "pctbFlyColor";
            this.pctbFlyColor.Size = new System.Drawing.Size(137, 264);
            this.pctbFlyColor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbFlyColor.TabIndex = 0;
            this.pctbFlyColor.TabStop = false;
            this.pctbFlyColor.Click += new System.EventHandler(this.pctbFlyColor_Click);
            this.pctbFlyColor.MouseHover += new System.EventHandler(this.pctbFlyColor_MouseHover);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Pika2Vn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pika2Vn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.progressBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbLifeTime)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BgMusic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbSoundOn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbSoundOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbstone1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbstone6)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbstone5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbstone4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbstone3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbstone2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbReset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbFlyColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }




        #endregion
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Panel pnlChessBoard;
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
        private System.Windows.Forms.PictureBox ptbstone1;
        private System.Windows.Forms.PictureBox ptbstone6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ptbstone5;
        private System.Windows.Forms.PictureBox ptbstone4;
        private System.Windows.Forms.PictureBox ptbstone3;
        private System.Windows.Forms.PictureBox ptbstone2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pctbReset;
        private System.Windows.Forms.PictureBox pctbHelp;
        private System.Windows.Forms.PictureBox pctbFlyColor;
        private System.Windows.Forms.PictureBox pctbHome;
        public System.Windows.Forms.PictureBox pctbPlay;
    }
}


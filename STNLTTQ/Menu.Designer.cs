namespace DoubleFours
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.pctbThoat = new System.Windows.Forms.PictureBox();
            this.pctbTiepTuc = new System.Windows.Forms.PictureBox();
            this.pctbBatDau = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctbThoat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbTiepTuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbBatDau)).BeginInit();
            this.SuspendLayout();
            // 
            // pctbThoat
            // 
            this.pctbThoat.BackColor = System.Drawing.Color.Transparent;
            this.pctbThoat.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.pctbThoat.Image = global::DoubleFours.Properties.Resources.thoat;
            this.pctbThoat.Location = new System.Drawing.Point(134, 772);
            this.pctbThoat.Name = "pctbThoat";
            this.pctbThoat.Size = new System.Drawing.Size(327, 96);
            this.pctbThoat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbThoat.TabIndex = 10;
            this.pctbThoat.TabStop = false;
            this.pctbThoat.Click += new System.EventHandler(this.pctbThoat_Click);
            // 
            // pctbTiepTuc
            // 
            this.pctbTiepTuc.BackColor = System.Drawing.Color.Transparent;
            this.pctbTiepTuc.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.pctbTiepTuc.Enabled = false;
            this.pctbTiepTuc.Image = global::DoubleFours.Properties.Resources.tieptuc;
            this.pctbTiepTuc.Location = new System.Drawing.Point(134, 300);
            this.pctbTiepTuc.Name = "pctbTiepTuc";
            this.pctbTiepTuc.Size = new System.Drawing.Size(327, 96);
            this.pctbTiepTuc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbTiepTuc.TabIndex = 8;
            this.pctbTiepTuc.TabStop = false;
            this.pctbTiepTuc.Click += new System.EventHandler(this.pctbTiepTuc_Click);
            // 
            // pctbBatDau
            // 
            this.pctbBatDau.BackColor = System.Drawing.Color.Transparent;
            this.pctbBatDau.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.pctbBatDau.Image = global::DoubleFours.Properties.Resources.batdau;
            this.pctbBatDau.Location = new System.Drawing.Point(134, 126);
            this.pctbBatDau.Name = "pctbBatDau";
            this.pctbBatDau.Size = new System.Drawing.Size(327, 96);
            this.pctbBatDau.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbBatDau.TabIndex = 7;
            this.pctbBatDau.TabStop = false;
            this.pctbBatDau.Click += new System.EventHandler(this.pctbBatDau_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DoubleFours.Properties.Resources.wallpaper_menu1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.pctbThoat);
            this.Controls.Add(this.pctbTiepTuc);
            this.Controls.Add(this.pctbBatDau);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctbThoat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbTiepTuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbBatDau)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.PictureBox pctbTiepTuc;
        public System.Windows.Forms.PictureBox pctbBatDau;
        public System.Windows.Forms.PictureBox pctbThoat;
    }
}
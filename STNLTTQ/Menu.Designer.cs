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
            this.btnBack = new System.Windows.Forms.Button();
            this.pctbHDSD = new System.Windows.Forms.PictureBox();
            this.pctbThoat = new System.Windows.Forms.PictureBox();
            this.pctbHuongDan = new System.Windows.Forms.PictureBox();
            this.pctbTiepTuc = new System.Windows.Forms.PictureBox();
            this.pctbBatDau = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctbHDSD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbThoat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbHuongDan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbTiepTuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbBatDau)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Enabled = false;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(1538, 153);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(107, 43);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Quay Lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pctbHDSD
            // 
            this.pctbHDSD.BackColor = System.Drawing.Color.Transparent;
            this.pctbHDSD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctbHDSD.Location = new System.Drawing.Point(715, 153);
            this.pctbHDSD.Name = "pctbHDSD";
            this.pctbHDSD.Size = new System.Drawing.Size(930, 558);
            this.pctbHDSD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbHDSD.TabIndex = 11;
            this.pctbHDSD.TabStop = false;
            // 
            // pctbThoat
            // 
            this.pctbThoat.BackColor = System.Drawing.Color.Transparent;
            this.pctbThoat.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.pctbThoat.Image = global::DoubleFours.Properties.Resources.thoat;
            this.pctbThoat.Location = new System.Drawing.Point(134, 648);
            this.pctbThoat.Name = "pctbThoat";
            this.pctbThoat.Size = new System.Drawing.Size(327, 96);
            this.pctbThoat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbThoat.TabIndex = 10;
            this.pctbThoat.TabStop = false;
            this.pctbThoat.Click += new System.EventHandler(this.pctbThoat_Click);
            // 
            // pctbHuongDan
            // 
            this.pctbHuongDan.BackColor = System.Drawing.Color.Transparent;
            this.pctbHuongDan.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.pctbHuongDan.Image = global::DoubleFours.Properties.Resources.huongdan;
            this.pctbHuongDan.Location = new System.Drawing.Point(134, 474);
            this.pctbHuongDan.Name = "pctbHuongDan";
            this.pctbHuongDan.Size = new System.Drawing.Size(327, 96);
            this.pctbHuongDan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbHuongDan.TabIndex = 9;
            this.pctbHuongDan.TabStop = false;
            this.pctbHuongDan.Click += new System.EventHandler(this.pctbHuongDan_Click);
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
            this.BackgroundImage = global::DoubleFours.Properties.Resources.menu4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pctbHDSD);
            this.Controls.Add(this.pctbThoat);
            this.Controls.Add(this.pctbHuongDan);
            this.Controls.Add(this.pctbTiepTuc);
            this.Controls.Add(this.pctbBatDau);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pctbHDSD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbThoat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbHuongDan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbTiepTuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbBatDau)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pctbHDSD;
        public System.Windows.Forms.PictureBox pctbTiepTuc;
        public System.Windows.Forms.PictureBox pctbBatDau;
        public System.Windows.Forms.PictureBox pctbThoat;
        public System.Windows.Forms.PictureBox pctbHuongDan;
    }
}
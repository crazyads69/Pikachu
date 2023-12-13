namespace DoubleFours
{
    partial class Levels
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Levels));
            this.radEasy = new System.Windows.Forms.RadioButton();
            this.radNormal = new System.Windows.Forms.RadioButton();
            this.radHard = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radEasy
            // 
            this.radEasy.AutoSize = true;
            this.radEasy.BackColor = System.Drawing.Color.Transparent;
            this.radEasy.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.radEasy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radEasy.ForeColor = System.Drawing.Color.Orange;
            this.radEasy.Location = new System.Drawing.Point(365, 37);
            this.radEasy.Name = "radEasy";
            this.radEasy.Size = new System.Drawing.Size(192, 28);
            this.radEasy.TabIndex = 0;
            this.radEasy.TabStop = true;
            this.radEasy.Text = "Dễ (20 pokemon)";
            this.radEasy.UseVisualStyleBackColor = false;
            this.radEasy.CheckedChanged += new System.EventHandler(this.radEasy_CheckedChanged);
            // 
            // radNormal
            // 
            this.radNormal.AutoSize = true;
            this.radNormal.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.radNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNormal.ForeColor = System.Drawing.Color.Orange;
            this.radNormal.Location = new System.Drawing.Point(365, 113);
            this.radNormal.Name = "radNormal";
            this.radNormal.Size = new System.Drawing.Size(270, 28);
            this.radNormal.TabIndex = 1;
            this.radNormal.TabStop = true;
            this.radNormal.Text = "Trung Bình (25 pokemon)";
            this.radNormal.UseVisualStyleBackColor = true;
            this.radNormal.CheckedChanged += new System.EventHandler(this.radNormal_CheckedChanged);
            // 
            // radHard
            // 
            this.radHard.AutoSize = true;
            this.radHard.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.radHard.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radHard.ForeColor = System.Drawing.Color.Orange;
            this.radHard.Location = new System.Drawing.Point(365, 189);
            this.radHard.Name = "radHard";
            this.radHard.Size = new System.Drawing.Size(203, 28);
            this.radHard.TabIndex = 2;
            this.radHard.TabStop = true;
            this.radHard.Text = "Khó (30 pokemon)";
            this.radHard.UseVisualStyleBackColor = true;
            this.radHard.CheckedChanged += new System.EventHandler(this.radHard_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Algerian", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 48);
            this.label1.TabIndex = 3;
            this.label1.Text = "CHỌN GIÁO ÁN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(260, 239);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(123, 39);
            this.btnPlay.TabIndex = 4;
            this.btnPlay.Text = "Chơi Ngay";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // Levels
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(638, 300);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radHard);
            this.Controls.Add(this.radNormal);
            this.Controls.Add(this.radEasy);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Levels";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Levels";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Levels_FormClosed);
            this.Load += new System.EventHandler(this.Levels_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radEasy;
        private System.Windows.Forms.RadioButton radNormal;
        private System.Windows.Forms.RadioButton radHard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPlay;
    }
}
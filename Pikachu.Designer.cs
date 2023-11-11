namespace Pikachu
{
	partial class Pikachu
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
			this.uiLabel1 = new Sunny.UI.UILabel();
			this.uiButton2 = new Sunny.UI.UIButton();
			this.uiButton1 = new Sunny.UI.UIButton();
			this.uiButton3 = new Sunny.UI.UIButton();
			this.uiButton4 = new Sunny.UI.UIButton();
			this.SuspendLayout();
			// 
			// uiLabel1
			// 
			this.uiLabel1.AutoSize = true;
			this.uiLabel1.BackColor = System.Drawing.Color.DarkOrange;
			this.uiLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.uiLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.uiLabel1.Location = new System.Drawing.Point(231, 88);
			this.uiLabel1.Name = "uiLabel1";
			this.uiLabel1.Size = new System.Drawing.Size(238, 67);
			this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
			this.uiLabel1.TabIndex = 0;
			this.uiLabel1.Text = "PIKACHU";
			this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.uiLabel1.UseCompatibleTextRendering = true;
			// 
			// uiButton2
			// 
			this.uiButton2.BackColor = System.Drawing.Color.Transparent;
			this.uiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.uiButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.uiButton2.Location = new System.Drawing.Point(68, 397);
			this.uiButton2.MinimumSize = new System.Drawing.Size(1, 1);
			this.uiButton2.Name = "uiButton2";
			this.uiButton2.Size = new System.Drawing.Size(529, 87);
			this.uiButton2.TabIndex = 2;
			this.uiButton2.Text = "Tiếp tục";
			this.uiButton2.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			// 
			// uiButton1
			// 
			this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.uiButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.uiButton1.Location = new System.Drawing.Point(68, 254);
			this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
			this.uiButton1.Name = "uiButton1";
			this.uiButton1.Size = new System.Drawing.Size(529, 86);
			this.uiButton1.TabIndex = 3;
			this.uiButton1.Text = "Trò chơi mới";
			this.uiButton1.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			// 
			// uiButton3
			// 
			this.uiButton3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.uiButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.uiButton3.Location = new System.Drawing.Point(68, 536);
			this.uiButton3.MinimumSize = new System.Drawing.Size(1, 1);
			this.uiButton3.Name = "uiButton3";
			this.uiButton3.Size = new System.Drawing.Size(529, 87);
			this.uiButton3.TabIndex = 4;
			this.uiButton3.Text = "Hướng dẫn";
			this.uiButton3.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			// 
			// uiButton4
			// 
			this.uiButton4.Cursor = System.Windows.Forms.Cursors.Hand;
			this.uiButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.uiButton4.Location = new System.Drawing.Point(68, 683);
			this.uiButton4.MinimumSize = new System.Drawing.Size(1, 1);
			this.uiButton4.Name = "uiButton4";
			this.uiButton4.Size = new System.Drawing.Size(529, 86);
			this.uiButton4.TabIndex = 5;
			this.uiButton4.Text = "Thoát";
			this.uiButton4.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			// 
			// Pikachu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Pikachu.Properties.Resources.background;
			this.ClientSize = new System.Drawing.Size(1597, 897);
			this.Controls.Add(this.uiButton4);
			this.Controls.Add(this.uiButton3);
			this.Controls.Add(this.uiButton1);
			this.Controls.Add(this.uiButton2);
			this.Controls.Add(this.uiLabel1);
			this.Name = "Pikachu";
			this.Text = "PIKACHU";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Sunny.UI.UILabel uiLabel1;
		private Sunny.UI.UIButton uiButton2;
		private Sunny.UI.UIButton uiButton1;
		private Sunny.UI.UIButton uiButton3;
		private Sunny.UI.UIButton uiButton4;
	}
}


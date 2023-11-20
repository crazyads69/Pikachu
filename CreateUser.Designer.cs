namespace Pikachu
{
	partial class CreateUser
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
			this.uiTextBox1 = new Sunny.UI.UITextBox();
			this.uiButton1 = new Sunny.UI.UIButton();
			this.uiButton2 = new Sunny.UI.UIButton();
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// uiLabel1
			// 
			this.uiLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.uiLabel1.Location = new System.Drawing.Point(12, 88);
			this.uiLabel1.Name = "uiLabel1";
			this.uiLabel1.Size = new System.Drawing.Size(713, 63);
			this.uiLabel1.TabIndex = 0;
			this.uiLabel1.Text = "Nhập tên người chơi mới: ";
			this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.uiLabel1.Click += new System.EventHandler(this.uiLabel1_Click);
			// 
			// uiTextBox1
			// 
			this.uiTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.uiTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.uiTextBox1.Location = new System.Drawing.Point(19, 169);
			this.uiTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.uiTextBox1.MinimumSize = new System.Drawing.Size(1, 16);
			this.uiTextBox1.Name = "uiTextBox1";
			this.uiTextBox1.Padding = new System.Windows.Forms.Padding(5);
			this.uiTextBox1.ShowText = false;
			this.uiTextBox1.Size = new System.Drawing.Size(569, 67);
			this.uiTextBox1.TabIndex = 1;
			this.uiTextBox1.Text = "Nhập tên vào đây";
			this.uiTextBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
			this.uiTextBox1.Watermark = "";
			this.uiTextBox1.TextChanged += new System.EventHandler(this.uiTextBox1_TextChanged);
			// 
			// uiButton1
			// 
			this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.uiButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.uiButton1.Location = new System.Drawing.Point(1315, 710);
			this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
			this.uiButton1.Name = "uiButton1";
			this.uiButton1.Size = new System.Drawing.Size(163, 52);
			this.uiButton1.TabIndex = 2;
			this.uiButton1.Text = "OK";
			this.uiButton1.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click);
			// 
			// uiButton2
			// 
			this.uiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.uiButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.uiButton2.Location = new System.Drawing.Point(1064, 710);
			this.uiButton2.MinimumSize = new System.Drawing.Size(1, 1);
			this.uiButton2.Name = "uiButton2";
			this.uiButton2.Size = new System.Drawing.Size(148, 52);
			this.uiButton2.TabIndex = 3;
			this.uiButton2.Text = "Huỷ";
			this.uiButton2.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.uiButton2.Click += new System.EventHandler(this.uiButton2_Click);
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(19, 269);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(1566, 421);
			this.listView1.TabIndex = 4;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "STT";
			this.columnHeader1.Width = 111;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Tên người chơi";
			this.columnHeader2.Width = 395;
			// 
			// CreateUser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LemonChiffon;
			this.ClientSize = new System.Drawing.Size(1597, 813);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.uiButton2);
			this.Controls.Add(this.uiButton1);
			this.Controls.Add(this.uiTextBox1);
			this.Controls.Add(this.uiLabel1);
			this.Name = "CreateUser";
			this.Text = "CreateUser";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.ResumeLayout(false);

		}

		#endregion

		private Sunny.UI.UILabel uiLabel1;
		private Sunny.UI.UITextBox uiTextBox1;
		private Sunny.UI.UIButton uiButton1;
		private Sunny.UI.UIButton uiButton2;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
	}
}
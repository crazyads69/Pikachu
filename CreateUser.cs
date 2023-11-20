using System;
using System.Windows.Forms;

namespace Pikachu
{
	public partial class CreateUser : Form
	{
		public CreateUser()
		{

			InitializeComponent();
			GetData.GetPlayersList(listView1);
		}

		private void uiLabel1_Click(object sender, EventArgs e)
		{

		}

		private void uiTextBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void uiButton1_Click(object sender, EventArgs e)
		{
			string playerName = uiTextBox1.Text;
			Init.InsertPlayerName(playerName);
			MessageBox.Show("Tạo người chơi mới thành công!");
			this.Close();
		}

		private void uiButton2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void listView1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}

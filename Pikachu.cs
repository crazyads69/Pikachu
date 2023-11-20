using System;
using System.Windows.Forms;

namespace Pikachu
{
	public partial class Pikachu : Form
	{
		public Pikachu()
		{
			Init.InitializeDatabase();
			InitializeComponent();
		}

		private void uiButton1_Click(object sender, EventArgs e)
		{
			var createUser = new CreateUser();
			createUser.ShowDialog();
		}


	}
}

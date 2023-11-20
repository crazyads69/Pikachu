using System.Data.SQLite;
using System.Windows.Forms;

namespace Pikachu
{
	internal class GetData
	{
		private static string databaseFile = "pikachu.db";
		public static void GetPlayersList(ListView listViewPlayers)
		{
			string connectionString = $"Data Source={databaseFile}";
			using (SQLiteConnection connection = new SQLiteConnection(connectionString))
			{
				connection.Open();

				string query = "SELECT * FROM players";
				using (SQLiteCommand command = new SQLiteCommand(query, connection))
				{
					using (SQLiteDataReader reader = command.ExecuteReader())
					{
						while (reader.Read())
						{
							// Retrieve player data from the reader
							int playerId = reader.GetInt32(0);
							string playerName = reader.GetString(1);
							// ... retrieve other player properties

							// Create a new ListViewItem and add player data to it

							// ... add other player properties as sub-items

							// Add the ListViewItem to the ListView
							ListViewItem item = new ListViewItem(playerId.ToString());
							item.SubItems.Add(playerName);

							listViewPlayers.Items.Add(item);

						}
					}
				}
			}
		}
	}
}


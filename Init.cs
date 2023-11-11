using System.Data.SQLite;
using System.IO;

namespace Pikachu
{

	internal class Init
	{
		// Name for DB
		private static string databaseFile = "pikachu.db";
		// Init database function to create database if not exists
		public static void InitializeDatabase()
		{
			string connectionString = $"Data Source={databaseFile}";
			// Check if exist db then do nothing else create db 
			if (!File.Exists(databaseFile))
			{
				// Create DB
				SQLiteConnection.CreateFile(databaseFile);

				// Open connection
				using (SQLiteConnection connection = new SQLiteConnection(connectionString))
				{
					connection.Open();

					// Create players table
					string createPlayersTableQuery = "CREATE TABLE IF NOT EXISTS players (" + "player_id INTEGER PRIMARY KEY AUTOINCREMENT," + "player_name TEXT NOT NULL," + "high_score INTEGER," + "total_games_played INTEGER," + "total_times_played INTEGER" + ")";

					using (SQLiteCommand command = new SQLiteCommand(createPlayersTableQuery, connection))
					{
						command.ExecuteNonQuery();
					}
				}
				// Create levels table
				using (SQLiteConnection connection = new SQLiteConnection(connectionString))
				{
					connection.Open();

					string createLevelsTableQuery = "CREATE TABLE IF NOT EXISTS levels (" +
						"level_id INTEGER PRIMARY KEY AUTOINCREMENT," +
						"level_num INTEGER," +
						"time_limit INTEGER," +
						"win_condition TEXT," +
						"max_moves INTEGER" +
						");";

					using (SQLiteCommand command = new SQLiteCommand(createLevelsTableQuery, connection))
					{
						command.ExecuteNonQuery();
					}
				}

				// Create matrix table
				using (SQLiteConnection connection = new SQLiteConnection(connectionString))
				{
					connection.Open();

					string createMatrixTableQuery = "CREATE TABLE IF NOT EXISTS matrix (" +
						"matrix_id INTEGER PRIMARY KEY AUTOINCREMENT," +
						"player_id INTEGER," +
						"level_id INTEGER," +
						"matrix_num INTEGER," +
						"remain_moves INTEGER," +
						"remain_time INTEGER," +
						"current_matrix TEXT," +
						"FOREIGN KEY(player_id) REFERENCES players(player_id)," +
						"FOREIGN KEY(level_id) REFERENCES levels(level_id)" +
						");";

					using (SQLiteCommand command = new SQLiteCommand(createMatrixTableQuery, connection))
					{
						command.ExecuteNonQuery();
					}
				}

				// Create scores table
				using (SQLiteConnection connection = new SQLiteConnection(connectionString))
				{
					connection.Open();

					string createScoresTableQuery = "CREATE TABLE IF NOT EXISTS scores (" +
						"score_id INTEGER PRIMARY KEY AUTOINCREMENT," +
						"player_id INTEGER," +
						"level_id INTEGER," +
						"score INTEGER," +
						"FOREIGN KEY(player_id) REFERENCES players(player_id)," +
						"FOREIGN KEY(level_id) REFERENCES levels(level_id)" +
						");";

					using (SQLiteCommand command = new SQLiteCommand(createScoresTableQuery, connection))
					{
						command.ExecuteNonQuery();
					}
				}
			}
		}
	}
}

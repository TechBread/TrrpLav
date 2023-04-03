using Front_end;
using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using System.Configuration;
using System.Data;
using User = Front_end.User;

namespace MainServer
{
	internal class DbWorker
	{
		static readonly string _mainConnStr = new NpgsqlConnectionStringBuilder
		{
			Host = ConfigurationManager.AppSettings.Get("host"),
			Port = Convert.ToInt32(ConfigurationManager.AppSettings.Get("db_port")),
			Database = "postgres",
			Username = ConfigurationManager.AppSettings.Get("username"),
			Password = ConfigurationManager.AppSettings.Get("password")
		}.ConnectionString;

		static readonly string _connStr = new NpgsqlConnectionStringBuilder
		{
			Host = ConfigurationManager.AppSettings.Get("host"),
			Port = Convert.ToInt32(ConfigurationManager.AppSettings.Get("db_port")),
			Database = ConfigurationManager.AppSettings.Get("database"),
			Username = ConfigurationManager.AppSettings.Get("username"),
			Password = ConfigurationManager.AppSettings.Get("password")
		}.ConnectionString;

		public static List<User> GetOnlineUser()
		{
			using var conn = new NpgsqlConnection(_connStr);
			try
			{
				conn.Open();

				using (var cmd = new NpgsqlCommand
				{
					Connection = conn,
					CommandText = @"DELETE FROM users_status where last_ping < now() - interval '5 second'"
				})
				{
						int row = cmd.ExecuteNonQuery();
				}
				using (var cmd = new NpgsqlCommand
				{
					Connection = conn,
					CommandText = @"SELECT * FROM users_status"
				})
				{
					var reader = cmd.ExecuteReader();

					while(reader.Read())
					{
						Console.WriteLine(reader.GetString(0), reader.GetString(1), reader.GetString(2));
					}
				}


			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}

			return null;
		}
		public static bool AddUserDb(User user)
		{
			using var conn = new NpgsqlConnection(_connStr);
			try
			{
				conn.Open();

				using (var cmd = new NpgsqlCommand
				{
					Connection = conn,
					CommandText = @"insert into users (username) values (@username)
							on conflict do nothing;"
				})
				{
					cmd.Parameters.AddWithValue("@username", user.userName);
					try
					{
						int row = cmd.ExecuteNonQuery();
						if (row > 0)
							return true;
					}
					catch (Exception ex)
					{
						Console.WriteLine(ex.ToString());
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}

			return false;

		}

		public static List<User> GetUsersStat(User user)
		{
			using var conn = new NpgsqlConnection(_connStr);
			try
			{
				conn.Open();

				using (var cmd = new NpgsqlCommand
				{
					Connection = conn,
					CommandText = @"SELECT * FROM user_status WHERE username != @username;"
				})
				{
					try
					{
						cmd.Parameters.AddWithValue("@username", user.userName);
						var reader = cmd.ExecuteReader();
						var usersList = new List<User>();
						while(reader.Read())
						{
							usersList.Add(new User(
								reader.GetString("username"), 
								reader.GetString("ip"), 
								reader.GetInt32("port")
								));
						}
						return usersList;
					}
					catch (Exception ex)
					{
						Console.WriteLine(ex.ToString());
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}

			return new List<User>();
		}

		public static User? GetUserStat(User user)
		{
			using var conn = new NpgsqlConnection(_connStr);
			try
			{
				conn.Open();

				using (var cmd = new NpgsqlCommand
				{
					Connection = conn,
					CommandText = @"SELECT * FROM user_status WHERE username = @username;"
				})
				{
					cmd.Parameters.AddWithValue("@username", user.userName);
					try
					{
						var reader = cmd.ExecuteReader();
						if (reader.Read())
							return new User(
									reader.GetString("username"),
									reader.GetString("ip"),
									reader.GetInt32("port")
									);
					}
					catch (Exception ex)
					{
						Console.WriteLine(ex.ToString());
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}

			return null;
		}
		public static void DeleteUsersStatForTime(NpgsqlConnection conn)
		{
			using (var cmd = new NpgsqlCommand
			{
				Connection = conn,
				CommandText = @"DELETE FROM user_status WHERE now() - interval '1 sec' > last_ping"
			})
			{
				try
				{
					int row = cmd.ExecuteNonQuery();
					Console.WriteLine($"Row del count = {row}");
				
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.ToString());
				}
			}
		}
		public static bool UpdateUserStat(User user)
		{
			using var conn = new NpgsqlConnection(_connStr);
			try
			{ 
				conn.Open();
				DeleteUsersStatForTime(conn);
				int portCount = 0;
				do
				{
					try
					{
							using (var cmd = new NpgsqlCommand
						{
							Connection = conn,
							CommandText = @"SELECT COUNT(*) FROM user_status WHERE ip = @ip and port = @port;"
						})
						{
							cmd.Parameters.AddWithValue("@ip", user.ip);
							cmd.Parameters.AddWithValue("@port", user.port);
						
								portCount = Convert.ToInt32(cmd.ExecuteScalar());
								Console.WriteLine(portCount);
								if (portCount > 0)
									user.port--;
							}
						
					}
					catch (Exception ex)
					{
						Console.WriteLine("Select ex = " + ex.ToString());
					}
				} while (portCount > 0);
				
				using (var cmd = new NpgsqlCommand
				{
					Connection = conn,
					CommandText = @"insert into user_status (username, ip, port, last_ping) values (@username, @ip, @port, now())
							on conflict (username) do UPDATE SET last_ping = now();"
				})
				{
					
					cmd.Parameters.AddWithValue("@username", user.userName);
					cmd.Parameters.AddWithValue("@ip", user.ip);
					cmd.Parameters.AddWithValue("@port", user.port);

					try
					{
						int row = cmd.ExecuteNonQuery();
						
						if (row > 0)
						{
							Console.WriteLine($"{user.userName}, welcome!)");
							return true;
						}
							
					}
					catch (Exception ex)
					{
						Console.WriteLine(ex.ToString());
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}

			return false;

		}
		public static void PrepDb()
		{
			using var conn = new NpgsqlConnection(_mainConnStr);
			try
			{
				conn.Open();
				try
				{
					using var sqlCommand = new NpgsqlCommand
					{
						Connection = conn,
						CommandText = @"create database " + ConfigurationManager.AppSettings.Get("database")
					};
					Console.WriteLine(sqlCommand.ExecuteNonQuery());

				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message);
				}


				conn.ChangeDatabase(ConfigurationManager.AppSettings.Get("database"));
				using (var cmd = new NpgsqlCommand
				{
					Connection = conn,
					CommandText = File.ReadAllText(ConfigurationManager.AppSettings.Get("sqlscript_path"))
				})
				{
					Console.WriteLine(cmd.ExecuteNonQuery());

				}
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}

		}
	}
}

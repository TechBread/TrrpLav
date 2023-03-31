using Front_end;
using Grpc.Core;
using Grpc.Core.Utils;
using Npgsql;
using System.Configuration;
using UserServ;


namespace MainServer
{
	class UserServiceRealization : UserWork.UserWorkBase
	{
		private static List<UsersStatus> users = new List<UsersStatus>();

		static readonly string _connStr = new NpgsqlConnectionStringBuilder
		{
			Host = ConfigurationManager.AppSettings.Get("host"),
			Port = Convert.ToInt32(ConfigurationManager.AppSettings.Get("db_port")),
			Database = ConfigurationManager.AppSettings.Get("database"),
			Username = ConfigurationManager.AppSettings.Get("username"),
			Password = ConfigurationManager.AppSettings.Get("password")
		}.ConnectionString;

		public override Task<UsersStatus> Auth(UserRequest request, ServerCallContext context)
		{
			var user = new User(request.Username);
			var status = addUserDb(user);

			return Task.FromResult(new UsersStatus { Status = status });
		}
		

		private bool addUserDb(User user)
		{
			using var conn = new NpgsqlConnection(_connStr);

			using (var cmd = new NpgsqlCommand
			{
				Connection = conn,
				CommandText = @"insert into users (username) value (@username)
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
			return false;

		}
	}
}

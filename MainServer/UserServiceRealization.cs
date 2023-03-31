using Front_end;
using Grpc.Core;
using Grpc.Core.Utils;
using Npgsql;
using System.Configuration;
using System.Linq;
using UserServ;


namespace MainServer
{
	class UserServiceRealization : UserWork.UserWorkBase
	{
		private static List<User> users = new List<User>();

		static readonly string _connStr = new NpgsqlConnectionStringBuilder
		{
			Host = ConfigurationManager.AppSettings.Get("host"),
			Port = Convert.ToInt32(ConfigurationManager.AppSettings.Get("db_port")),
			Database = ConfigurationManager.AppSettings.Get("database"),
			Username = ConfigurationManager.AppSettings.Get("username"),
			Password = ConfigurationManager.AppSettings.Get("password")
		}.ConnectionString;

		public override async Task<UserServ.Status> Auth(UserRequest request, ServerCallContext context)
		{
			var user = new User(request.Username, request.Ip);
			var status = addUserDb(user);

			
			users.Add(user);
			return new UserServ.Status { Status_ = status };
		}

		public override async Task GetUsers(UserRequest request, IServerStreamWriter<UserRequest> responseStream, ServerCallContext context)
		{
			var user = new User(request.Username, request.Ip);
			var temp = users.FindAll(x => !x.Equals(user));
			var tempRequest = new List<UserRequest>();
			foreach (var item in temp)
			{
				tempRequest.Add(new UserRequest(item.userName, item.ip));
			}
			
			await responseStream.WriteAllAsync(tempRequest);
		}

		public override Task<UserServ.Status> StartGame(UserRequest request, ServerCallContext context)
		{
			return base.StartGame(request, context);
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

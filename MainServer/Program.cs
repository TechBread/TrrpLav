using Front_end;
using MainServer;
using Npgsql;
using System.Configuration;
using UserServ;

internal class Program
{
	
	private static void Main(string[] args)
	{
		string host = ConfigurationManager.AppSettings.Get("ip");
		int port = Convert.ToInt32( ConfigurationManager.AppSettings.Get("port"));
		var server = new Grpc.Core.Server
		{
			Services = { UserWork.BindService(new UserServiceRealization()),},
			Ports = {new Grpc.Core.ServerPort(host, port, Grpc.Core.ServerCredentials.Insecure)},

		};

		server.Start();
		

		Console.WriteLine("MainServer Start");
		Console.ReadLine();
	}


}
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace Front_end
{
	[Serializable]
	public class User
	{
		public string userName { get; set; }
		public bool Status { get; set; }
		public string ip { get; set; }
		public User(string userName)
		{
			this.userName = userName;
		}
		public User(string userName, string ip)
		{
			this.userName = userName;
			this.ip = ip;
		}
		[JsonConstructor]
		public User(string userName, bool status, string ip)
		{
			this.userName = userName;
			this.Status = status;
			this.ip = ip;
		}

		public static string GetLocalIPAddress()
		{
			var host = Dns.GetHostEntry(Dns.GetHostName());
			foreach (var ip in host.AddressList)
			{
				if (ip.AddressFamily == AddressFamily.InterNetwork)
				{
					return ip.ToString();
				}
			}
			throw new Exception("No network adapters with an IPv4 address in the system!");
		}

		public bool setOffline()
		{
			Status = false;
			return Status;
		}

		public bool setOnline()
		{
			Status=true;
			return Status;
		}

		public override bool Equals(object? obj)
		{
			
			var other = obj as User;
			if (other == null) return false;
			if (userName == other.userName) return true;

			return false;
		}
	}
	[Serializable]
	public class GameInfo
	{
		public User fPlayer { get; set; }
		public User sPlayer { get; set; }
        public User winner { get; set; }
		public string startTime { get; set; }
        public string fTime { get; set; }
		public string  sTime { get; set; }
        public int fMoveCount { get; set; }
        public int sMoveCount { get; set; }
		public GameInfo(User fPlayer, User sPlayer, User winner,string startTime, string fTime, string sTime, int fMoveCount, int sMoveCount)
		{
			this.fPlayer = fPlayer;
			this.sPlayer = sPlayer;
			this.winner = winner;
			this.startTime = startTime;
			this.sTime = sTime;
			this.fTime = fTime;
			this.fMoveCount = fMoveCount;
			this.sMoveCount = sMoveCount;
		}
		public override string ToString()
		{
			return fPlayer.userName + " - " + sPlayer.userName;
		}
	}
}

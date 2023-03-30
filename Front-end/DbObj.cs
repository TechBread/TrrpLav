using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Front_end
{
	public class User
	{
		public string userName { get; set; }
		public User(string userName)
		{
			this.userName = userName;
		}

	}
	public class GameInfo
	{
		public User fPlayer { get; set; }
		public User sPlayer { get; set; }
        public User winner { get; set; }
        public string winTime { get; set; }
        public int fMoveCount { get; set; }
        public int sMoveCount { get; set; }
		public GameInfo(User fPlayer, User sPlayer, User winner, string winTime, int fMoveCount, int sMoveCount)
		{
			this.fPlayer = fPlayer;
			this.sPlayer = sPlayer;
			this.winner = winner;
			this.winTime = winTime;
			this.fMoveCount = fMoveCount;
			this.sMoveCount = sMoveCount;
		}
		public override string ToString()
		{
			return fPlayer.userName + " - " + sPlayer.userName;
		}
	}
}

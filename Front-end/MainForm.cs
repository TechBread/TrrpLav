using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Front_end
{
	
	public partial class MainForm : Form
	{
		private User curUser;
		private List<User> users = new List<User>();
		private List<GameInfo> history = new List<GameInfo>();
		public MainForm(User curUser)
		{ 
			this.curUser = curUser;
			InitializeComponent();
			getUsers();
			getGamesInfo();
		}
		private void getUsers()
		{
			//get from DB
			users.Clear();
			playersLb.Clear();
			users.Add(new User("User1"));
			users.Add(new User("User2"));
			users.Add(new User("User3"));
			foreach(var user in users)
			{
				playersLb.Items.Add(user.userName);
			}
		}
		private void getGamesInfo()
		{
			//get from DB
			history.Clear();
			historyLb.Clear();
			history.Add(new GameInfo(users[0], users[1], users[0], "3:23", 5, 8));
            history.Add(new GameInfo(users[2], users[0], users[2], "5:01", 6, 7));
            history.Add(new GameInfo(users[2], users[1], users[1], "1:11", 4, 3));
			foreach(var gi in history)
			{
				historyLb.Items.Add(gi.ToString());
				historyLb.Items[historyLb.Items.Count - 1].Tag = gi;
			}
        }
		private void inviteBtn_Click(object sender, EventArgs e)
		{
			if(playersLb.SelectedItems.Count == 0)
			{
				MessageBox.Show("Select player to invite", "Instruction");
			}
			else if(isPlayerAccept())
			{
				GameForm gf = new GameForm(playersLb.SelectedItems[0].Text);
				gf.ShowDialog();
			}
			//sendInvite
		}
		public bool isPlayerAccept()
		{
			return true;
		}
		private void refreshPlayersBtn_Click(object sender, EventArgs e)
		{
			getUsers();
		}

		private void viewGameDetailBtn_Click(object sender, EventArgs e)
		{
			if(historyLb.SelectedItems.Count == 0)
			{
				MessageBox.Show("Select game to view", "Instruction");
			}
			else
			{
				var selItem = (GameInfo)historyLb.SelectedItems[0].Tag;
				string info = "Winner: " + selItem.winner.userName + "\nGame duration: " + selItem.winTime +
					"\n" + selItem.fPlayer.userName + " move count: " + selItem.fMoveCount + "\n" + selItem.sPlayer.userName + " move count: " + selItem.sMoveCount;
				MessageBox.Show(info, "Game players: " + selItem.ToString());
			}
		}

		private void refreshHistoryBtn_Click(object sender, EventArgs e)
		{
			getGamesInfo();
		}
	}
}

namespace Front_end
{
	public partial class StartForm : Form
	{

		public StartForm()
		{
			InitializeComponent();
		}

		private void loginBtn_Click(object sender, EventArgs e)
		{
			if (isNewUser(loginTb.Text))
				addUserToDB(loginTb.Text);
			User curUser = new User(loginTb.Text);
			MainForm mf = new MainForm(curUser);
			mf.ShowDialog();
		}
		private void addUserToDB(string username)
		{
			//Adding to DB
		}
		private bool isNewUser(string username)
		{
			//Learn from DB
			return false;
		}
	}
}
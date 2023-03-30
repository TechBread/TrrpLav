namespace Front_end
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inviteBtn = new System.Windows.Forms.Button();
            this.viewGameDetailBtn = new System.Windows.Forms.Button();
            this.refreshPlayersBtn = new System.Windows.Forms.Button();
            this.refreshHistoryBtn = new System.Windows.Forms.Button();
            this.playersLb = new System.Windows.Forms.ListView();
            this.historyLb = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(181, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Players";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(613, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 38);
            this.label2.TabIndex = 3;
            this.label2.Text = "Game History";
            // 
            // inviteBtn
            // 
            this.inviteBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inviteBtn.Location = new System.Drawing.Point(49, 624);
            this.inviteBtn.Name = "inviteBtn";
            this.inviteBtn.Size = new System.Drawing.Size(181, 52);
            this.inviteBtn.TabIndex = 4;
            this.inviteBtn.Text = "Invite Player";
            this.inviteBtn.UseVisualStyleBackColor = true;
            this.inviteBtn.Click += new System.EventHandler(this.inviteBtn_Click);
            // 
            // viewGameDetailBtn
            // 
            this.viewGameDetailBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.viewGameDetailBtn.Location = new System.Drawing.Point(523, 624);
            this.viewGameDetailBtn.Name = "viewGameDetailBtn";
            this.viewGameDetailBtn.Size = new System.Drawing.Size(179, 52);
            this.viewGameDetailBtn.TabIndex = 5;
            this.viewGameDetailBtn.Text = "Veiw Details";
            this.viewGameDetailBtn.UseVisualStyleBackColor = true;
            this.viewGameDetailBtn.Click += new System.EventHandler(this.viewGameDetailBtn_Click);
            // 
            // refreshPlayersBtn
            // 
            this.refreshPlayersBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.refreshPlayersBtn.Location = new System.Drawing.Point(250, 624);
            this.refreshPlayersBtn.Name = "refreshPlayersBtn";
            this.refreshPlayersBtn.Size = new System.Drawing.Size(181, 52);
            this.refreshPlayersBtn.TabIndex = 6;
            this.refreshPlayersBtn.Text = "Refresh";
            this.refreshPlayersBtn.UseVisualStyleBackColor = true;
            this.refreshPlayersBtn.Click += new System.EventHandler(this.refreshPlayersBtn_Click);
            // 
            // refreshHistoryBtn
            // 
            this.refreshHistoryBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.refreshHistoryBtn.Location = new System.Drawing.Point(721, 624);
            this.refreshHistoryBtn.Name = "refreshHistoryBtn";
            this.refreshHistoryBtn.Size = new System.Drawing.Size(180, 52);
            this.refreshHistoryBtn.TabIndex = 7;
            this.refreshHistoryBtn.Text = "Refresh";
            this.refreshHistoryBtn.UseVisualStyleBackColor = true;
            this.refreshHistoryBtn.Click += new System.EventHandler(this.refreshHistoryBtn_Click);
            // 
            // playersLb
            // 
            this.playersLb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.playersLb.Location = new System.Drawing.Point(28, 59);
            this.playersLb.Name = "playersLb";
            this.playersLb.Size = new System.Drawing.Size(429, 553);
            this.playersLb.TabIndex = 8;
            this.playersLb.UseCompatibleStateImageBehavior = false;
            this.playersLb.View = System.Windows.Forms.View.List;
            // 
            // historyLb
            // 
            this.historyLb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.historyLb.Location = new System.Drawing.Point(495, 59);
            this.historyLb.Name = "historyLb";
            this.historyLb.Size = new System.Drawing.Size(429, 553);
            this.historyLb.TabIndex = 9;
            this.historyLb.UseCompatibleStateImageBehavior = false;
            this.historyLb.View = System.Windows.Forms.View.List;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 716);
            this.Controls.Add(this.historyLb);
            this.Controls.Add(this.playersLb);
            this.Controls.Add(this.refreshHistoryBtn);
            this.Controls.Add(this.refreshPlayersBtn);
            this.Controls.Add(this.viewGameDetailBtn);
            this.Controls.Add(this.inviteBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "InfoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private Label label1;
		private Label label2;
		private Button inviteBtn;
		private Button viewGameDetailBtn;
        private Button refreshPlayersBtn;
        private Button refreshHistoryBtn;
        private ListView playersLb;
        private ListView historyLb;
    }
}
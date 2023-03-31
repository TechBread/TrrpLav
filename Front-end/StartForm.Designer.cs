namespace Front_end
{
	partial class StartForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.loginTb = new System.Windows.Forms.TextBox();
			this.loginBtn = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// loginTb
			// 
			this.loginTb.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.loginTb.Location = new System.Drawing.Point(178, 128);
			this.loginTb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.loginTb.MaxLength = 16;
			this.loginTb.Name = "loginTb";
			this.loginTb.PlaceholderText = "Username";
			this.loginTb.Size = new System.Drawing.Size(201, 32);
			this.loginTb.TabIndex = 0;
			this.loginTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.loginTb.TextChanged += new System.EventHandler(this.loginTb_TextChanged);
			// 
			// loginBtn
			// 
			this.loginBtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.loginBtn.Location = new System.Drawing.Point(178, 165);
			this.loginBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.loginBtn.Name = "loginBtn";
			this.loginBtn.Size = new System.Drawing.Size(200, 32);
			this.loginBtn.TabIndex = 1;
			this.loginBtn.Text = "Login";
			this.loginBtn.UseVisualStyleBackColor = true;
			this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(181, 56);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(187, 32);
			this.label1.TabIndex = 2;
			this.label1.Text = "Hangman Game";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// StartForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(560, 270);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.loginBtn);
			this.Controls.Add(this.loginTb);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "StartForm";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private TextBox loginTb;
		private Button loginBtn;
		private Label label1;
	}
}
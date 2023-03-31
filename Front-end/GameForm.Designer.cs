namespace Front_end
{
    partial class GameForm
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
			this.fPlayerPB = new System.Windows.Forms.PictureBox();
			this.sPlayerPB = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.opponentNameLb = new System.Windows.Forms.Label();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.fMoveCount = new System.Windows.Forms.Label();
			this.fHpLeft = new System.Windows.Forms.Label();
			this.sHpLeft = new System.Windows.Forms.Label();
			this.sMoveCount = new System.Windows.Forms.Label();
			this.giveAnsBtn = new System.Windows.Forms.Button();
			this.answersTb = new System.Windows.Forms.TextBox();
			this.answerLb = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.fPlayerPB)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sPlayerPB)).BeginInit();
			this.SuspendLayout();
			// 
			// fPlayerPB
			// 
			this.fPlayerPB.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.fPlayerPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.fPlayerPB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.fPlayerPB.Location = new System.Drawing.Point(38, 38);
			this.fPlayerPB.Margin = new System.Windows.Forms.Padding(2);
			this.fPlayerPB.Name = "fPlayerPB";
			this.fPlayerPB.Size = new System.Drawing.Size(358, 290);
			this.fPlayerPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.fPlayerPB.TabIndex = 0;
			this.fPlayerPB.TabStop = false;
			// 
			// sPlayerPB
			// 
			this.sPlayerPB.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.sPlayerPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.sPlayerPB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.sPlayerPB.Location = new System.Drawing.Point(501, 38);
			this.sPlayerPB.Margin = new System.Windows.Forms.Padding(2);
			this.sPlayerPB.Name = "sPlayerPB";
			this.sPlayerPB.Size = new System.Drawing.Size(358, 290);
			this.sPlayerPB.TabIndex = 1;
			this.sPlayerPB.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(197, 5);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 25);
			this.label1.TabIndex = 2;
			this.label1.Text = "You";
			// 
			// opponentNameLb
			// 
			this.opponentNameLb.AutoSize = true;
			this.opponentNameLb.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.opponentNameLb.Location = new System.Drawing.Point(674, 5);
			this.opponentNameLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.opponentNameLb.Name = "opponentNameLb";
			this.opponentNameLb.Size = new System.Drawing.Size(0, 25);
			this.opponentNameLb.TabIndex = 3;
			this.opponentNameLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// splitter1
			// 
			this.splitter1.Location = new System.Drawing.Point(0, 0);
			this.splitter1.Margin = new System.Windows.Forms.Padding(2);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(3, 542);
			this.splitter1.TabIndex = 4;
			this.splitter1.TabStop = false;
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.textBox1.Enabled = false;
			this.textBox1.Location = new System.Drawing.Point(444, 0);
			this.textBox1.Margin = new System.Windows.Forms.Padding(2);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(8, 407);
			this.textBox1.TabIndex = 5;
			// 
			// textBox2
			// 
			this.textBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.textBox2.Enabled = false;
			this.textBox2.Location = new System.Drawing.Point(5, 401);
			this.textBox2.Margin = new System.Windows.Forms.Padding(2);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(890, 8);
			this.textBox2.TabIndex = 6;
			// 
			// fMoveCount
			// 
			this.fMoveCount.AutoSize = true;
			this.fMoveCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.fMoveCount.Location = new System.Drawing.Point(151, 338);
			this.fMoveCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.fMoveCount.Name = "fMoveCount";
			this.fMoveCount.Size = new System.Drawing.Size(115, 21);
			this.fMoveCount.TabIndex = 7;
			this.fMoveCount.Text = "Moves count: 0";
			// 
			// fHpLeft
			// 
			this.fHpLeft.AutoSize = true;
			this.fHpLeft.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.fHpLeft.Location = new System.Drawing.Point(170, 365);
			this.fHpLeft.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.fHpLeft.Name = "fHpLeft";
			this.fHpLeft.Size = new System.Drawing.Size(81, 21);
			this.fHpLeft.TabIndex = 8;
			this.fHpLeft.Text = "HP left: 10";
			// 
			// sHpLeft
			// 
			this.sHpLeft.AutoSize = true;
			this.sHpLeft.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.sHpLeft.Location = new System.Drawing.Point(640, 365);
			this.sHpLeft.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.sHpLeft.Name = "sHpLeft";
			this.sHpLeft.Size = new System.Drawing.Size(81, 21);
			this.sHpLeft.TabIndex = 10;
			this.sHpLeft.Text = "HP left: 10";
			// 
			// sMoveCount
			// 
			this.sMoveCount.AutoSize = true;
			this.sMoveCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.sMoveCount.Location = new System.Drawing.Point(621, 338);
			this.sMoveCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.sMoveCount.Name = "sMoveCount";
			this.sMoveCount.Size = new System.Drawing.Size(115, 21);
			this.sMoveCount.TabIndex = 9;
			this.sMoveCount.Text = "Moves count: 0";
			// 
			// giveAnsBtn
			// 
			this.giveAnsBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.giveAnsBtn.Location = new System.Drawing.Point(310, 499);
			this.giveAnsBtn.Margin = new System.Windows.Forms.Padding(2);
			this.giveAnsBtn.Name = "giveAnsBtn";
			this.giveAnsBtn.Size = new System.Drawing.Size(281, 29);
			this.giveAnsBtn.TabIndex = 11;
			this.giveAnsBtn.Text = "Give answer";
			this.giveAnsBtn.UseVisualStyleBackColor = true;
			this.giveAnsBtn.Click += new System.EventHandler(this.giveAnsBtn_Click);
			// 
			// answersTb
			// 
			this.answersTb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.answersTb.Location = new System.Drawing.Point(340, 464);
			this.answersTb.Margin = new System.Windows.Forms.Padding(2);
			this.answersTb.MaxLength = 1;
			this.answersTb.Name = "answersTb";
			this.answersTb.Size = new System.Drawing.Size(220, 29);
			this.answersTb.TabIndex = 12;
			this.answersTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// answerLb
			// 
			this.answerLb.AutoSize = true;
			this.answerLb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.answerLb.Location = new System.Drawing.Point(340, 427);
			this.answerLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.answerLb.Name = "answerLb";
			this.answerLb.Size = new System.Drawing.Size(63, 21);
			this.answerLb.TabIndex = 13;
			this.answerLb.Text = "Word:   ";
			this.answerLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// GameForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(892, 542);
			this.Controls.Add(this.answerLb);
			this.Controls.Add(this.answersTb);
			this.Controls.Add(this.giveAnsBtn);
			this.Controls.Add(this.sHpLeft);
			this.Controls.Add(this.sMoveCount);
			this.Controls.Add(this.fHpLeft);
			this.Controls.Add(this.fMoveCount);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.splitter1);
			this.Controls.Add(this.opponentNameLb);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.sPlayerPB);
			this.Controls.Add(this.fPlayerPB);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "GameForm";
			this.Text = "GameForm";
			this.Load += new System.EventHandler(this.GameForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.fPlayerPB)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sPlayerPB)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private PictureBox fPlayerPB;
        private PictureBox sPlayerPB;
        private Label label1;
        private Label opponentNameLb;
        private Splitter splitter1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label fMoveCount;
        private Label fHpLeft;
        private Label sHpLeft;
        private Label sMoveCount;
        private Button giveAnsBtn;
        private TextBox answersTb;
        private Label answerLb;
    }
}
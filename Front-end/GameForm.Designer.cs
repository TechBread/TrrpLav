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
            this.playerName = new System.Windows.Forms.Label();
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
            this.fPlayerPB.Location = new System.Drawing.Point(54, 63);
            this.fPlayerPB.Name = "fPlayerPB";
            this.fPlayerPB.Size = new System.Drawing.Size(511, 482);
            this.fPlayerPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fPlayerPB.TabIndex = 0;
            this.fPlayerPB.TabStop = false;
            // 
            // sPlayerPB
            // 
            this.sPlayerPB.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sPlayerPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.sPlayerPB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sPlayerPB.Location = new System.Drawing.Point(716, 63);
            this.sPlayerPB.Name = "sPlayerPB";
            this.sPlayerPB.Size = new System.Drawing.Size(511, 482);
            this.sPlayerPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sPlayerPB.TabIndex = 1;
            this.sPlayerPB.TabStop = false;
            // 
            // playerName
            // 
            this.playerName.AutoSize = true;
            this.playerName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.playerName.Location = new System.Drawing.Point(281, 8);
            this.playerName.Name = "playerName";
            this.playerName.Size = new System.Drawing.Size(62, 38);
            this.playerName.TabIndex = 2;
            this.playerName.Text = "You";
            // 
            // opponentNameLb
            // 
            this.opponentNameLb.AutoSize = true;
            this.opponentNameLb.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.opponentNameLb.Location = new System.Drawing.Point(963, 8);
            this.opponentNameLb.Name = "opponentNameLb";
            this.opponentNameLb.Size = new System.Drawing.Size(0, 38);
            this.opponentNameLb.TabIndex = 3;
            this.opponentNameLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(4, 903);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(634, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(10, 676);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(7, 668);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(1270, 11);
            this.textBox2.TabIndex = 6;
            // 
            // fMoveCount
            // 
            this.fMoveCount.AutoSize = true;
            this.fMoveCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fMoveCount.Location = new System.Drawing.Point(216, 563);
            this.fMoveCount.Name = "fMoveCount";
            this.fMoveCount.Size = new System.Drawing.Size(178, 32);
            this.fMoveCount.TabIndex = 7;
            this.fMoveCount.Text = "Moves count: 0";
            // 
            // fHpLeft
            // 
            this.fHpLeft.AutoSize = true;
            this.fHpLeft.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fHpLeft.Location = new System.Drawing.Point(243, 608);
            this.fHpLeft.Name = "fHpLeft";
            this.fHpLeft.Size = new System.Drawing.Size(124, 32);
            this.fHpLeft.TabIndex = 8;
            this.fHpLeft.Text = "HP left: 10";
            // 
            // sHpLeft
            // 
            this.sHpLeft.AutoSize = true;
            this.sHpLeft.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sHpLeft.Location = new System.Drawing.Point(914, 608);
            this.sHpLeft.Name = "sHpLeft";
            this.sHpLeft.Size = new System.Drawing.Size(124, 32);
            this.sHpLeft.TabIndex = 10;
            this.sHpLeft.Text = "HP left: 10";
            // 
            // sMoveCount
            // 
            this.sMoveCount.AutoSize = true;
            this.sMoveCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sMoveCount.Location = new System.Drawing.Point(887, 563);
            this.sMoveCount.Name = "sMoveCount";
            this.sMoveCount.Size = new System.Drawing.Size(178, 32);
            this.sMoveCount.TabIndex = 9;
            this.sMoveCount.Text = "Moves count: 0";
            // 
            // giveAnsBtn
            // 
            this.giveAnsBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.giveAnsBtn.Location = new System.Drawing.Point(443, 832);
            this.giveAnsBtn.Name = "giveAnsBtn";
            this.giveAnsBtn.Size = new System.Drawing.Size(401, 48);
            this.giveAnsBtn.TabIndex = 11;
            this.giveAnsBtn.Text = "Give answer";
            this.giveAnsBtn.UseVisualStyleBackColor = true;
            this.giveAnsBtn.Click += new System.EventHandler(this.giveAnsBtn_Click);
            // 
            // answersTb
            // 
            this.answersTb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.answersTb.Location = new System.Drawing.Point(486, 773);
            this.answersTb.MaxLength = 1;
            this.answersTb.Name = "answersTb";
            this.answersTb.Size = new System.Drawing.Size(313, 39);
            this.answersTb.TabIndex = 12;
            this.answersTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // answerLb
            // 
            this.answerLb.AutoSize = true;
            this.answerLb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.answerLb.Location = new System.Drawing.Point(486, 712);
            this.answerLb.Name = "answerLb";
            this.answerLb.Size = new System.Drawing.Size(97, 32);
            this.answerLb.TabIndex = 13;
            this.answerLb.Text = "Word:   ";
            this.answerLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 903);
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
            this.Controls.Add(this.playerName);
            this.Controls.Add(this.sPlayerPB);
            this.Controls.Add(this.fPlayerPB);
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.fPlayerPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPlayerPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox fPlayerPB;
        public PictureBox sPlayerPB;
        private Label playerName;
        private Label opponentNameLb;
        private Splitter splitter1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label fMoveCount;
        private Label fHpLeft;
        public Label sHpLeft;
        public Label sMoveCount;
        private Button giveAnsBtn;
        private TextBox answersTb;
        private Label answerLb;
    }
}
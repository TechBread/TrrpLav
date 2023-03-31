using Microsoft.VisualBasic.Devices;
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
    public partial class GameForm : Form
    {
        private string quest = "Загадка";
        private string answers = "";
        private int hp = 10;
        private int movesCount = 0;
        public GameForm(string oppName)
        {
            InitializeComponent();
            opponentNameLb.Text = oppName;
            for (int i = 0; i < quest.Length; i++)
                answerLb.Text += "=";
        }

        private void giveAnsBtn_Click(object sender, EventArgs e)
        {
            if(answersTb.Text != "")
            {
                char ans = answersTb.Text[0];
                if(!answers.Contains(ans))
                {
                    answersTb.Text = "";
                    answers += ans;
                    movesCount++;
                    fMoveCount.Text = "Moves count: " + movesCount;
                    if (quest.Contains(ans))
                    {
                        string curAns = "";
                        for (int i = 0; i < quest.Length; i++)
                            curAns += answers.Contains(quest[i]) ? quest[i] : "=";
                        answerLb.Text = "Word:   " + curAns;
                        if(!curAns.Contains('='))
                        {
                            MessageBox.Show("You win!");
                            Close();
                        }
                    }
                    else
                    {
                        hp--;
                        fHpLeft.Text = "HP left: " + hp;
                        fPlayerPB.Image = new Bitmap((10 - hp).ToString() + ".png");
                        if(hp == 0)
                        {
                            MessageBox.Show("You loose!");
                            Close();
                        }
                    }
                    sendDataToOpp();
                }
            }
        }
        private void sendDataToOpp()
        {
            //write code
        }

        private void GameForm_Load(object sender, EventArgs e)
        {

        }
    }
}

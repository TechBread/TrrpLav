using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Diagnostics;
using System.Security.Policy;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using RabbitMQ.Client;
using System.IO;

namespace Front_end
{
    public partial class GameForm : Form
    {
        Stopwatch sw = new Stopwatch();
        DateTime startTime;
        private string quest = "Загадка";
        private string answers = "";
        private bool isWinner = false;
        private int hp = 10;
        private int movesCount = 0;
        private Socket tcpSocket = null;
        private Socket listener = null;
        private Socket tcpServSocket = null;
        private Thread receivingThread;
        private MainForm mf;
        private User curUser;
        private User oppUser;
        public GameForm(string oppName, User curUser, MainForm mf)
        {
            InitializeComponent();
            opponentNameLb.Text = oppName;
            for (int i = 0; i < quest.Length; i++)
                answerLb.Text += "=";

            this.mf = mf;
            this.curUser = curUser;
            playerName.Text = curUser.userName;

            IPAddress ip;
            int port;

            if (curUser.userName == "first") 
            {
                //server socket init
                var buffer = new byte[512];
                int size = 0;

                ip = IPAddress.Any;
                port = 8555;
                var tcpEndPoint = new IPEndPoint(ip, port);
                tcpServSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                tcpServSocket.Bind(tcpEndPoint);
                tcpServSocket.Listen();
                listener = tcpServSocket.Accept();

                //server socket receive opponent user and send curUser with startTime
                if (listener.Connected)
                {
                    size = listener.Receive(buffer);
                    MemoryStream ms = new MemoryStream(buffer);
                    BinaryFormatter bf = new BinaryFormatter();
                    User userData = (User)bf.Deserialize(ms);
                    oppUser = userData;

                    ms = new MemoryStream();
                    bf = new BinaryFormatter();
                    bf.Serialize(ms, curUser);
                    listener.Send(ms.GetBuffer());

                    ms = new MemoryStream();
                    bf = new BinaryFormatter();
                    bf.Serialize(ms, startTime);
                    listener.Send(ms.GetBuffer());
                }
            }
            else if(curUser.userName == "second")
            {
                //client socket init
                var buffer = new byte[512];
                int size = 0;

                ip = IPAddress.Parse("192.168.1.95");
                port = 8555;
                var tcpEndPoint = new IPEndPoint(ip, port);
                tcpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                tcpSocket.Connect(tcpEndPoint);

                //client socket send curUser and receive opponent user with startTime
                if(tcpSocket.Connected)
                {
                    MemoryStream ms = new MemoryStream();
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(ms, curUser);
                    tcpSocket.Send(ms.GetBuffer());

                    size = tcpSocket.Receive(buffer);
                    ms = new MemoryStream(buffer);
                    bf = new BinaryFormatter();
                    User userData = (User)bf.Deserialize(ms);
                    oppUser = userData;

                    size = tcpSocket.Receive(buffer);
                    ms = new MemoryStream(buffer);
                    bf = new BinaryFormatter();
                    DateTime timeData = (DateTime)bf.Deserialize(ms);
                    startTime = timeData;
                }
            }
            sw.Start();
            receivingThread = new Thread(socketReceive);
            receivingThread.Start();
            if (curUser.userName == "first")
                startTime = DateTime.Now;
        }
        private void socketReceive()
        {
            Console.WriteLine("Поток для получения данных начал работать");
            var buffer = new byte[512];
            int size = 0;

            while(true)
            {
                bool exit = false;
                do
                {
                    try
                    {
                        if (curUser.userName == "first")
                        {
                            Console.WriteLine("first: готов к получению данных");
                            size = listener.Receive(buffer);
                            Console.WriteLine("first: получил данные " + size);
                        }
                        else if (curUser.userName == "second")
                        {
                            Console.WriteLine("second: готов к получению данных");
                            size = tcpSocket.Receive(buffer);
                            Console.WriteLine("second: получил данные " + size);
                        }

                        MemoryStream ms = new MemoryStream(buffer);
                        BinaryFormatter formatter = new BinaryFormatter();
                        GameData recData = (GameData)formatter.Deserialize(ms);

                        SetLableTextForThread(sMoveCount, "Moves count: " + recData.moveCount.ToString());
                        SetLableTextForThread(sHpLeft, "HP left: " + recData.lifeLeft.ToString());
                        SetPicBoxImageForThread(sPlayerPB, new Bitmap((10 - recData.lifeLeft).ToString() + ".png"));
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.ToString());
                        exit = true;
                    }
                }
                while (!exit && size != 0 && (curUser.userName == "first" ? listener.Available > 0 : tcpSocket.Available > 0));

                if (exit || size == 0)
                    break;
            }

            Console.WriteLine("Поток для чтения данных умер!");
        }
        private void SetPicBoxImageForThread(System.Windows.Forms.PictureBox pb, Bitmap img)
        {
            if (pb.InvokeRequired)
            {
                pb.BeginInvoke((MethodInvoker)delegate () { pb.Image = img; });
            }
            else
            {
                pb.Image = img;
            }
        }
        private void SetLableTextForThread(System.Windows.Forms.Label l, string inputText)
        {
            if (l.InvokeRequired)
            {
                l.BeginInvoke((MethodInvoker)delegate () { l.Text = inputText;});
            }
            else
            {
                l.Text = inputText;
            }
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
                            isWinner = true;
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
                    answersTb.Select();
                    sendDataToOpp();
                }
            }
        }
        private void sendDataToOpp()
        {
            MemoryStream ms = new MemoryStream();
            BinaryFormatter bf = new BinaryFormatter();

            GameData gd = new GameData(movesCount, hp);
            bf.Serialize(ms, gd);

            try
            {
                if (curUser.userName == "first" && listener.Connected)
                    listener.Send(ms.GetBuffer());
                else if (curUser.userName == "second" && tcpSocket.Connected)
                    tcpSocket.Send(ms.GetBuffer());
            } catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        private void sendWithMQ(GameInfo gi)
        {
            string ip = "localhost";
            var factory = new ConnectionFactory() { HostName = ip };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: "history",
                                        durable: false,
                                        exclusive: false,
                                        autoDelete: false,
                                        arguments: null);

                string message = JsonSerializer.Serialize(gi);
                var body = Encoding.UTF8.GetBytes(message);

                channel.BasicPublish(exchange: "",
                                        routingKey: "history",
                                        basicProperties: null,
                                        body: body);
            }
        }
        private void GameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            sw.Stop();

            if (curUser.userName == "first")
            {
                TimeSpan tp = sw.Elapsed;
                DateTime dt = DateTime.Parse(tp.ToString());
                GameInfo gi = new GameInfo(curUser.userName == "first" ? curUser : oppUser, curUser.userName == "first" ? oppUser : curUser,
                    isWinner ? curUser : oppUser, startTime.ToString(), curUser.userName == "first" ? dt.ToString() : "", curUser.userName == "first" ? "" : dt.ToString(),
                    curUser.userName == "first" ? movesCount : int.MaxValue, curUser.userName == "first" ? int.MaxValue : movesCount);
                sendWithMQ(gi);
            }

            if (tcpSocket != null)
            {
                tcpSocket.Close();
            }
            if (listener != null)
            {
                listener.Close();
            }
            if(tcpServSocket != null)
            {
                tcpServSocket.Close();
            }
            mf.Visible = true;
        }
    }
}

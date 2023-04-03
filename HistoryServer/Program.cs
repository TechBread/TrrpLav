using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text.Json;
using Front_end;
using Npgsql;
using Microsoft.VisualBasic;

namespace HistoryServer
{
    class Program
    {
        static readonly string _connStr = new NpgsqlConnectionStringBuilder
        {
            Host = ConfigurationManager.AppSettings.Get("host"),
            Port = Convert.ToInt32(ConfigurationManager.AppSettings.Get("db_port")),
            Database = ConfigurationManager.AppSettings.Get("database"),
            Username = ConfigurationManager.AppSettings.Get("username"),
            Password = ConfigurationManager.AppSettings.Get("password")
        }.ConnectionString;
        static void Main(string[] args)
        {
            MQWork();
        }
        private static void MQWork()
        {
            string ip = ConfigurationManager.AppSettings.Get("ip");
            var factory = new ConnectionFactory() { HostName = ip };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: "history",
                                     durable: false,
                                     exclusive: false,
                                     autoDelete: false,
                                     arguments: null);

                var consumer = new EventingBasicConsumer(channel);
                consumer.Received += (model, ea) =>
                {
                    var body = ea.Body.ToArray();
                    var message = Encoding.UTF8.GetString(body);
                    Console.WriteLine(" [x] Received {0}", message);
                    GameInfo row = JsonSerializer.Deserialize<GameInfo>(message.ToString());
                    AddRowToBD(row);
                };
                channel.BasicConsume(queue: "history",
                                     autoAck: true,
                                     consumer: consumer);

                Console.WriteLine(" Press [enter] to exit.");
                Console.ReadLine();
            }
        }
        private static void AddRowToBD(GameInfo row)
        {
            if (row == null)
                return;
            using (var conn = new NpgsqlConnection(_connStr))
            {
                try
                {
                    conn.Open();

                    string updatePath;
                    if (row.fMoveCount != int.MaxValue)
                    {
                        if (row.winner == null)
                            updatePath = "update set (ftime, fmovecount) = (@ftime, @fmovecount)";
                        else
                            updatePath = "update set (gamestarttime, ftime, fmovecount) = (@gamestarttime, @ftime, @fmovecount)";
                    }
                    else
                    {
                        if (row.winner == null)
                            updatePath = "update set (stime, smovecount) = (@stime, @smovecount)";
                        else
                            updatePath = "update set (gamestarttime, stime, smovecount) = (@gamestarttime, @stime, @smovecount)";
                    }

                    using (var sqlCommand = new NpgsqlCommand
                    {
                        Connection = conn,
                        CommandText = @"insert into history (id, fusername, susername, winusername, gamestarttime, ftime, stime, fmovecount, smovecount)
                            values (default, @fusername, @susername, @winusername, @gamestarttime, @ftime, @stime, @fmovecount, @smovecount)
                            on conflict (fusername, susername, gamestarttime) do " + updatePath
                    })
                    {
                        sqlCommand.Parameters.AddWithValue("@fusername", row.fPlayer.userName);
                        sqlCommand.Parameters.AddWithValue("@susername", row.sPlayer.userName);
                        sqlCommand.Parameters.AddWithValue("@winusername", row.winner == null ? null : row.winner.userName);
                        sqlCommand.Parameters.AddWithValue("@gamestarttime", DateTime.Parse(row.startTime));
                        sqlCommand.Parameters.AddWithValue("@ftime", row.fTime == "" ? DateTime.MinValue : DateTime.Parse(row.fTime));
                        sqlCommand.Parameters.AddWithValue("@stime", row.sTime == "" ? DateTime.MinValue : DateTime.Parse(row.sTime));
                        sqlCommand.Parameters.AddWithValue("@fmovecount", row.fMoveCount == int.MaxValue ? int.MaxValue : row.fMoveCount);
                        sqlCommand.Parameters.AddWithValue("@smovecount", row.sMoveCount == int.MaxValue ? int.MaxValue : row.sMoveCount);

                        try
                        {
                            sqlCommand.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.ToString());
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }
    }
}

using System;
using Grpc.Core;
using Com.Example.Grpc;
using MySql.Data.MySqlClient;

namespace GreeterServer
{
    class Program
    {
        const string Host = "localhost";
        const int Port = 50051;

        static MySqlCommand cmd;

        public static string QueryCommand()
        {
            string sqlData ="";
            cmd.CommandText = "SELECT * FROM article";
            cmd.CommandType = System.Data.CommandType.Text;

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                sqlData += String.Format("{0}, {1}, {2}", reader.GetInt32(0),
                                    reader.GetString(1), reader.GetDouble(2)) + "\n";
            }

            reader.Close();

            return sqlData;
        }

        public static void InsertCommand(string name, double price)
        {
            cmd.CommandText = "append_data";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add(new MySqlParameter("param_name", name));
            cmd.Parameters.Add(new MySqlParameter("param_price", price));

            cmd.ExecuteNonQuery();
        }

        public static void Main(string[] args)
        {
            // Connecting to MySQL DB
            MySqlConnectionStringBuilder connBuilder = new MySqlConnectionStringBuilder();

            connBuilder.Add("Database", "shop");
            connBuilder.Add("Data Source", "localhost");
            connBuilder.Add("User Id", "root");
            connBuilder.Add("Password", "admin#123");
            connBuilder.Add("SslMode", "none");

            MySqlConnection connection = new MySqlConnection(connBuilder.ConnectionString);

            cmd = connection.CreateCommand();

            connection.Open();

            // Build a server
            var server = new Server
            {
                Services = { GreetingService.BindService(new GreeterServiceImpl()) },
                Ports = { new ServerPort(Host, Port, ServerCredentials.Insecure) }
            };

            // Start server
            server.Start();

            Console.WriteLine("GreeterServer listening on port " + Port);
            Console.WriteLine("Press any key to stop the server...");
            Console.ReadKey();

            // Stopping MySql and Server Connection
            connection.Close();
            server.ShutdownAsync().Wait();
        }
    }
}

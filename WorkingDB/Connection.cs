using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using Npgsql;

namespace SchedulingBase
{
    class Connection
    {
        private static Connection instance;
        public static Connection Instance
        {
            get
            {
                if (instance == null)
                    instance = new Connection();
                return instance;
            }
            set
            {
                instance = value;
            }
        }
        private NpgsqlConnection connection;
        public bool connected { get; private set; }
        
        public Connection()
        {
            connected = false;
            instance = this;
        }

        public void Connect(string host, string db, string username, string password)
        {
            if (!connected)
            {
                try
                {
                    NpgsqlConnectionStringBuilder builder = new NpgsqlConnectionStringBuilder();
                    builder.Database = db;
                    builder.Host = host;
                    builder.Username = username;
                    builder.Password = password;
                    connection = new NpgsqlConnection(builder.ConnectionString);
                    connection.Open();
                    connected = true;
                }
                catch (NpgsqlException) { }
            }
        }

        public DataTable SendRequest(string request)
        {
            if (connected)
            {
                DataTable table = new DataTable();
                NpgsqlDataAdapter adapter;
                try
                {
                    NpgsqlCommand command = new NpgsqlCommand(request, connection);
                    adapter = new NpgsqlDataAdapter(command);
                    adapter.Fill(table);
                }
                catch (NpgsqlException e)
                {
                    table.Clear();
                    table.Columns.Add("Error");
                    DataRow row = table.NewRow();
                    row["Error"] = e.Message;
                    table.Rows.Add(row);
                }
                return table;
            }
            else return null;
        }

        public void Disconnect()
        {
            if (connected)
            {
                connected = false;
                connection.Close();
            }
        }
    }
}

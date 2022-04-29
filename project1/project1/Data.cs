using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace project1
{
     class Data
    {
       
            NpgsqlConnection Connection = new NpgsqlConnection(@"Server=localhost;Port=5432;User id=postgres;Password=1234;DataBase=TestBD");
        
        public void openconnection()
        {
            if (Connection.State == System.Data.ConnectionState.Closed)
                Connection.Open();
        }
        public void closeconnection()
        {
            if (Connection.State == System.Data.ConnectionState.Open)
                Connection.Close();
        }
        public NpgsqlConnection GetConnection()
        {
            return Connection;
        }
    }
}


﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoocurs
{
    class DataBase
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;user=root;database=zoo;password=1234;");
        public void opencon()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }
        public void closecon()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }
        public MySqlConnection getconn()
        {
            return connection;
        }
    }
}

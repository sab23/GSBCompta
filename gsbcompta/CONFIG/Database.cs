﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gsbcompta
{
    class Database
    {
        public MySqlConnection Mysql { get; set; }

        public Database()
        {
            this.connect();
        }

        private void connect()
        {
            string connectionString = "SERVER=127.0.0.1; DATABASE=gsb; UID=root; PASSWORD=root";
            this.Mysql = new MySqlConnection(connectionString);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace RibbonDemo.Facade
{
    public class DBConnection
    {
        public MySqlConnection Connection;

        string constring = "server=localhost; database=db_kombong_jamur; uid=root; pwd=;";

        public void ConnectionOpen()
        {
            Connection = new MySqlConnection(constring);
            Connection.Open();
        }
        public void ConnectionClose()
        {
            Connection = new MySqlConnection(constring);
            Connection.Close();
        }
    }
}

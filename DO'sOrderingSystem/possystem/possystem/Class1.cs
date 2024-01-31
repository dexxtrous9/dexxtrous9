using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace possystem
{
    class Connection
    {
        public static MySqlConnection cn = new MySqlConnection();
        static string server = "127.0.0.1;";
        static string database = "posresto;";
        static string Uid = "root;";
        static string password = ";";

        public static MySqlConnection dataSource()
        {
            cn = new MySqlConnection($"server={server} database={database} Uid={Uid} password={password}");
            return cn;
        }
        public void cnOpen()
        {
            dataSource();
            cn.Open();
        }
        public void cnClose() 
        {
            dataSource();
            cn.Close();
        }
    }
}

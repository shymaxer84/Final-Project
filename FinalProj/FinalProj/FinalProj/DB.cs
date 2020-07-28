using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace FinalProj
{
    class DB
    {

        MySqlConnection conDataBase = new MySqlConnection("datasource=localhost;port = 3308;username=root;password=;database=login ");

        public void openConnection()
        {
            if (conDataBase.State == System.Data.ConnectionState.Closed)
            {
                conDataBase.Open();
            }
        }


        public void closeConnection()
        {
            if (conDataBase.State == System.Data.ConnectionState.Open)
            {
                conDataBase.Close();
            }
        }

        public MySqlConnection GetConnection()
        {
            return conDataBase;
        }
    }
}


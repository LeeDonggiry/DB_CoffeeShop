using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_CoffeeShop
{
    class userinfo
    {
        string conn = "Server=49.50.174.201;Database=s5360137;Uid=s5360137;Pwd=s5360137;Charset=utf8";

        private static userinfo instance = new userinfo();

        public static userinfo getinstance()
        {
            return instance;
        }

        public string get_this_userID()
        {
            using (MySqlConnection connection = new MySqlConnection(conn))
            {
                connection.Open();

                string query = "select * from user where valid_using = 1";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader rdr = cmd.ExecuteReader();

                string get_user = null;

                while (rdr.Read())
                {
                    get_user = String.Format("{0}", rdr["userID"]);
                }

                if (get_user == null) return get_user;
                else return get_user;
            }
        }

        public void valid_using_user(string ID,string password) 
        {
            using(MySqlConnection connection = new MySqlConnection(conn))
            {
                connection.Open();

                string query = "update `user` set `valid_using` = 1 where `userID` ='"+ID+"'and userPassword = '"+password+"'";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}

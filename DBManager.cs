using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Tls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_CoffeeShop
{
    class DBManager
    {
        string conn = "Server=49.50.174.201;Database=s5360137;Uid=s5360137;Pwd=s5360137;Charset=utf8";

        private static DBManager instance = new DBManager();

        public static DBManager getinstance()
        {
            return instance;
        }

        public void Login(string ID,string Password)
        {
            string ID_form;
            string Password_form;

            using (MySqlConnection connection = new MySqlConnection(conn))
            {
                connection.Open();

                string login_query = "select * from user";
           
                MySqlCommand cmd = new MySqlCommand(login_query, connection);
                MySqlDataReader rdr = cmd.ExecuteReader();

                
                while (rdr.Read())
                {
                    ID_form = string.Format("{0}",rdr["userID"]);
                    Password_form = string.Format("{0}", rdr["userPassword"]);

                    if (ID.Equals(ID_form) && Password.Equals(Password_form))
                    {
                        MainForm.getinstance().labelLogincheck.Text = ID +  " 계정으로 로그인 되었습니다.";
                    }
                }
                
                rdr.Close();
                connection.Close();
            }
        }

        public void Logout()
        {
            using (MySqlConnection connection = new MySqlConnection(conn))
            {
                connection.Open();

                string query = "update `user` set `valid_using` = 0";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                MainForm.getinstance().labelLogincheck.Text = "로그인을 해주세요";
                cmd.ExecuteNonQuery();
                
                connection.Close();
            }
        }
    }
}

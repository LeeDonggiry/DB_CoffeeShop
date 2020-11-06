using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_CoffeeShop
{
    class coffee
    {
        string conn = "Server=49.50.174.201;Database=s5360137;Uid=s5360137;Pwd=s5360137;Charset=utf8";

        string userid, coffeename, date = null;
        int sellcount = 0;

        private static coffee instance = new coffee();

        public static coffee getinstance()
        {
            return instance;
        }

        public void clicked_coffee(string coffee)
        {
            using (MySqlConnection connection = new MySqlConnection(conn))
            {
                connection.Open();
                string checking_user = userinfo.getinstance().get_this_userID(); // 현재 사용중인 아이디를 가져옴
                string get_date = MainForm.getinstance().DTP;

                string search_query = "select * from casher where userid = '" + checking_user + "' and coffee_name = '" + coffee + "' and date = '" + get_date + "'"; // 가져온 아이디의 casher 테이블을 훑음

                //만약 유저명과 커피, 산 날짜가 다 있다는걸 알아야함.
                // 알 방법은? 1. 세 개의 값을 각각 받아온다.


                MySqlCommand cmd = new MySqlCommand(search_query, connection);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    userid = string.Format("{0}", rdr["userid"]);
                    coffeename = string.Format("{0}", rdr["coffee_name"]);
                    date = string.Format("{0}", rdr["date"]);
                    sellcount = (int)rdr["sellcount"];
                }
                sellcount++;
                rdr.Close();

                
                if (userid == null || coffeename == null || date == null)
                {
                    string insert_query = "insert into casher(userid,date,coffee_name,sellcount,sellsum) values('" + checking_user + "','" + get_date + "','" + coffee + "',1,0)";

                    MySqlCommand cmd3 = new MySqlCommand(insert_query, connection);
                    cmd3.ExecuteNonQuery();
                }
                else if (userid.Equals(checking_user) && coffeename.Equals(coffee) && date.Contains(get_date))
                {
                    string update_query = "update casher set sellcount ='" + sellcount + "' where userid = '" + checking_user + "' and coffee_name = '" + coffee + "' and date = '" + get_date + "'";

                    MySqlCommand cmd2 = new MySqlCommand(update_query, connection);
                    cmd2.ExecuteNonQuery();
                }

                rdr.Close();
            }
        }

        public void everyday_calculate()
        {
            using (MySqlConnection connection = new MySqlConnection(conn))
            {
                connection.Open();
                string checking_user = userinfo.getinstance().get_this_userID(); // 현재 사용중인 아이디를 가져옴
                string get_date = MainForm.getinstance().DTP;

                string query = "select * from selleachuser where date ='" + get_date + "'";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    date = string.Format("{0}", rdr["date"]);
                    
                }
            }
        }
    }
}

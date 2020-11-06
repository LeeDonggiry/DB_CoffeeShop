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
        int sellcount, sellsum = 0;
        string insert_query,update_query;
        int DB_user1_sellsum, DB_user1_sellprice, DB_user2_sellsum, DB_user2_sellprice = 0;

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
                userid = null;
                coffeename = null;
                date = null;

                MySqlCommand cmd = new MySqlCommand(search_query, connection);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    userid = string.Format("{0}", rdr["userid"]); // DB에서 읽어온 테이블값들
                    coffeename = string.Format("{0}", rdr["coffee_name"]);
                    date = string.Format("{0}", rdr["date"]);
                    sellcount = (int)rdr["sellcount"];
                    sellsum = (int)rdr["sellsum"];
                }
                sellcount++;

                switch(coffee)
                {
                    case "americano":
                        sellsum = sellsum + 3500;
                        break;
                    case "cafelatte":
                        sellsum = sellsum + 4000;
                        break;
                    case "cafemocha":
                        sellsum = sellsum + 4000;
                        break;
                }
                rdr.Close();

                //유저명, 커피이름, 날짜 중 하나라도 검색이 안된다면 새 것이기 때문에 insert해 줌.
                if (userid == null || coffeename == null || date == null)
                {
                    //유저명이 1일 때
                    if (checking_user.Equals("user1"))
                    {
                        switch (coffee)
                        {
                            case "americano":
                                //인설트해서 값 넣어주기
                                this.insert_query = "insert into casher(userid,date,coffee_name,sellcount,sellsum) values('" + checking_user + "','" + get_date + "','" + coffee + "',1,3500)";

                                MySqlCommand insert_cmd = new MySqlCommand(this.insert_query, connection);
                                insert_cmd.ExecuteNonQuery();
                                break;
                            case "cafelatte":
                                this.insert_query = "insert into casher(userid,date,coffee_name,sellcount,sellsum) values('" + checking_user + "','" + get_date + "','" + coffee + "',1,4000)";

                                MySqlCommand insert_cmd2 = new MySqlCommand(this.insert_query, connection);
                                insert_cmd2.ExecuteNonQuery();
                                break;
                            case "cafemocha":
                                this.insert_query = "insert into casher(userid,date,coffee_name,sellcount,sellsum) values('" + checking_user + "','" + get_date + "','" + coffee + "',1,4000)";

                                MySqlCommand insert_cmd3 = new MySqlCommand(this.insert_query, connection);
                                insert_cmd3.ExecuteNonQuery();
                                break;
                        }
                    }else if (checking_user.Equals("user2"))
                    {
                        switch (coffee)
                        {
                            case "americano":
                                //인설트해서 값 넣어주기
                                this.insert_query = "insert into casher(userid,date,coffee_name,sellcount,sellsum) values('" + checking_user + "','" + get_date + "','" + coffee + "',1,3500)";

                                MySqlCommand insert_cmd = new MySqlCommand(this.insert_query, connection);
                                insert_cmd.ExecuteNonQuery();
                                break;
                            case "cafelatte":
                                this.insert_query = "insert into casher(userid,date,coffee_name,sellcount,sellsum) values('" + checking_user + "','" + get_date + "','" + coffee + "',1,4000)";

                                MySqlCommand insert_cmd2 = new MySqlCommand(this.insert_query, connection);
                                insert_cmd2.ExecuteNonQuery();
                                break;
                            case "cafemocha":
                                this.insert_query = "insert into casher(userid,date,coffee_name,sellcount,sellsum) values('" + checking_user + "','" + get_date + "','" + coffee + "',1,4000)";

                                MySqlCommand insert_cmd3 = new MySqlCommand(this.insert_query, connection);
                                insert_cmd3.ExecuteNonQuery();
                                break;
                        }
                    }
                }

                //만약에 세개다 겹쳐서 있다는 것이 알게 된다면 커피의 수를 늘려줌
                else if (userid.Equals(checking_user) && coffeename.Equals(coffee) && date.Contains(get_date))
                {
                    // 만약 유저가 1이고 아메리카노면
                    if (checking_user.Equals("user1"))
                    {
                        switch (coffee)
                        {
                            case "americano":
                                this.update_query = "update casher set sellcount ='" + sellcount + "', sellsum = '" + sellsum + "' where userid = '" + checking_user + "' and coffee_name = '" + coffee + "' and date = '" + get_date + "'";
                                
                                MySqlCommand update_cmd = new MySqlCommand(this.update_query, connection);
                                update_cmd.ExecuteNonQuery();
                                break;
                            case "cafelatte":
                                this.update_query = "update casher set sellcount ='" + sellcount + "', sellsum = '" + sellsum + "' where userid = '" + checking_user + "' and coffee_name = '" + coffee + "' and date = '" + get_date + "'";

                                MySqlCommand update_cmd2 = new MySqlCommand(this.update_query, connection);
                                update_cmd2.ExecuteNonQuery();
                                break;
                            case "cafemocha":
                                this.update_query = "update casher set sellcount ='" + sellcount + "', sellsum = '" + sellsum + "' where userid = '" + checking_user + "' and coffee_name = '" + coffee + "' and date = '" + get_date + "'";

                                MySqlCommand update_cmd3 = new MySqlCommand(this.update_query, connection);
                                update_cmd3.ExecuteNonQuery();
                                break;
                        }
                    }
                    else if (checking_user.Equals("user2"))
                    {
                        switch (coffee)
                        {
                            case "americano":
                                this.update_query = "update casher set sellcount ='" + sellcount + "', sellsum = '" + sellsum + "' where userid = '" + checking_user + "' and coffee_name = '" + coffee + "' and date = '" + get_date + "'";

                                MySqlCommand update_cmd = new MySqlCommand(this.update_query, connection);
                                update_cmd.ExecuteNonQuery();
                                break;
                            case "cafelatte":
                                this.update_query = "update casher set sellcount ='" + sellcount + "', sellsum = '" + sellsum + "' where userid = '" + checking_user + "' and coffee_name = '" + coffee + "' and date = '" + get_date + "'";

                                MySqlCommand update_cmd2 = new MySqlCommand(this.update_query, connection);
                                update_cmd2.ExecuteNonQuery();
                                break;
                            case "cafemocha":
                                this.update_query = "update casher set sellcount ='" + sellcount + "', sellsum = '" + sellsum + "' where userid = '" + checking_user + "' and coffee_name = '" + coffee + "' and date = '" + get_date + "'";

                                MySqlCommand update_cmd3 = new MySqlCommand(this.update_query, connection);
                                update_cmd3.ExecuteNonQuery();
                                break;
                        }
                    }
                }
                rdr.Close();
            }
        }

        public void everyday_calculate(string coffee)
        {
            using (MySqlConnection connection = new MySqlConnection(conn))
            {
                connection.Open();

                //커피 클릭했을때 일일 판매량으로 추가하는 방식으로 변경
                //먼저 select로 안에 날짜가 겹치는게 있는지 없는지 검사
                //날짜가 이미 있다면 업데이트문, 날짜가 없다면 insert
                
                string get_date = MainForm.getinstance().DTP;
                string DB_date = null;
                

                //현재 선택된 날짜에 맞게 selleachuser 테이블에도 날짜 저장하기위해 변수 가져옴
                string query = "select * from selleachuser where date ='" + get_date + "'";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader rdr = cmd.ExecuteReader();


                while (rdr.Read())
                {
                    DB_date = string.Format("{0}", rdr["date"]);
                    DB_user1_sellsum = (int)rdr["user1_sellsum"];
                    DB_user1_sellprice = (int)rdr["user1_sellprice"];
                    DB_user2_sellsum = (int)rdr["user2_sellsum"];
                    DB_user2_sellprice = (int)rdr["user2_sellprice"];

                }
                DB_user1_sellsum++;
                switch (coffee)
                {
                    case "americano":
                        DB_user1_sellprice = DB_user1_sellprice + 3500;
                        break;
                    case "cafelatte":
                        DB_user1_sellprice = DB_user1_sellprice + 4000;
                        break;
                    case "cafemocha":
                        DB_user1_sellprice = DB_user1_sellprice + 4000;
                        break;
                }
                DB_user2_sellsum++;
                switch (coffee)
                {
                    case "americano":
                        DB_user2_sellprice = DB_user2_sellprice + 3500;
                        break;
                    case "cafelatte":
                        DB_user2_sellprice = DB_user2_sellprice + 4000;
                        break;
                    case "cafemocha":
                        DB_user2_sellprice = DB_user2_sellprice + 4000;
                        break;
                }
                rdr.Close();

                string insert_query,update_query;
                string checking_user = userinfo.getinstance().get_this_userID();

                if (DB_date == null) // 날짜를 검색했으나 없다면
                {
                    if (checking_user.Equals("user1"))
                    {
                        switch (coffee)
                        {
                            case "americano":
                                insert_query = "insert into selleachuser values('" + get_date + "',1,3500,0,0)";

                                MySqlCommand insert_cmd = new MySqlCommand(insert_query, connection);
                                insert_cmd.ExecuteNonQuery();
                                break;
                            case "cafelatte":
                                insert_query = "insert into selleachuser values('" + get_date + "',1,4000,0,0)";

                                MySqlCommand insert_cmd2 = new MySqlCommand(insert_query, connection);
                                insert_cmd2.ExecuteNonQuery();
                                break;
                            case "cafemocha":
                                insert_query = "insert into selleachuser values('" + get_date + "',1,4000,0,0)";

                                MySqlCommand insert_cmd3 = new MySqlCommand(insert_query, connection);
                                insert_cmd3.ExecuteNonQuery();
                                break;
                        }
                    }else if (checking_user.Equals("user2"))
                    {
                        switch (coffee)
                        {
                            case "americano":
                                insert_query = "insert into selleachuser values('" + get_date + "',0,0,1,3500)";

                                MySqlCommand insert_cmd = new MySqlCommand(insert_query, connection);
                                insert_cmd.ExecuteNonQuery();
                                break;
                            case "cafelatte":
                                insert_query = "insert into selleachuser values('" + get_date + "',0,0,1,4000)";

                                MySqlCommand insert_cmd2 = new MySqlCommand(insert_query, connection);
                                insert_cmd2.ExecuteNonQuery();
                                break;
                            case "cafemocha":
                                insert_query = "insert into selleachuser values('" + get_date + "',0,0,1,4000)";

                                MySqlCommand insert_cmd3 = new MySqlCommand(insert_query, connection);
                                insert_cmd3.ExecuteNonQuery();
                                break;
                        }
                    }
                }
                else// 검색 했는데 날짜가 이미 있다면
                {
                    if (checking_user.Equals("user1"))
                    {
                        switch (coffee)
                        {
                            case "americano":
                                update_query = "update selleachuser set user1_sellsum ='"+ DB_user1_sellsum +"',user1_sellprice = '"+ DB_user1_sellprice+"' where" +
                                    " date ='"+get_date+"'";

                                MySqlCommand update_cmd = new MySqlCommand(update_query, connection);
                                update_cmd.ExecuteNonQuery();
                                break;
                            case "cafelatte":
                                update_query = "update selleachuser set user1_sellsum ='" + DB_user1_sellsum + "',user1_sellprice = '" + DB_user1_sellprice + "' where" +
                                    " date ='" + get_date + "'";

                                MySqlCommand update_cmd2 = new MySqlCommand(update_query, connection);
                                update_cmd2.ExecuteNonQuery();
                                break;
                            case "cafemocha":
                                update_query = "update selleachuser set user1_sellsum ='" + DB_user1_sellsum + "',user1_sellprice = '" + DB_user1_sellprice + "' where" +
                                    " date ='" + get_date + "'";

                                MySqlCommand update_cmd3 = new MySqlCommand(update_query, connection);
                                update_cmd3.ExecuteNonQuery();
                                break;
                        }
                    }else if (checking_user.Equals("user2"))
                    {
                        switch (coffee)
                        {
                            case "americano":
                                update_query = "update selleachuser set user2_sellsum ='" + DB_user2_sellsum + "',user2_sellprice = '" + DB_user2_sellprice + "' where" +
                                    " date ='" + get_date + "'";

                                MySqlCommand update_cmd = new MySqlCommand(update_query, connection);
                                update_cmd.ExecuteNonQuery();
                                break;
                            case "cafelatte":
                                update_query = "update selleachuser set user2_sellsum ='" + DB_user2_sellsum + "',user2_sellprice = '" + DB_user2_sellprice + "' where" +
                                    " date ='" + get_date + "'";

                                MySqlCommand update_cmd2 = new MySqlCommand(update_query, connection);
                                update_cmd2.ExecuteNonQuery();
                                break;
                            case "cafemocha":
                                update_query = "update selleachuser set user2_sellsum ='" + DB_user2_sellsum + "',user2_sellprice = '" + DB_user2_sellprice + "' where" +
                                    " date ='" + get_date + "'";

                                MySqlCommand update_cmd3 = new MySqlCommand(update_query, connection);
                                update_cmd3.ExecuteNonQuery();
                                break;
                        }
                    }
                }
            }
        }
    }
}

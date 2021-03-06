﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_CoffeeShop
{
    class GridView
    {
        string conn = "Server=49.50.174.201;Database=s5360137;Uid=s5360137;Pwd=s5360137;Charset=utf8";

        private static GridView instance = new GridView();

        public static GridView getinstance()
        {
            return instance;
        }

        public void setGridView_days()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("날짜", typeof(string));
            dt.Columns.Add("user1 일일판매량", typeof(string));
            dt.Columns.Add("user1 일일판매액", typeof(string));
            dt.Columns.Add("user2 일일판매량", typeof(string));
            dt.Columns.Add("user2 일일판매액", typeof(string));

            using (MySqlConnection connection = new MySqlConnection(conn))
            {
                connection.Open();

                string date_query = "select date from casher";

                MySqlCommand cmd = new MySqlCommand(date_query, connection);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    string date = string.Format("{0}", rdr["date"]);
                    string user1_sellsum = string.Format("{0}", rdr["user1_sellsum"]);
                    string user1_sellprice = string.Format("{0}", rdr["user1_sellprice"]);
                    string user2_sellsum = string.Format("{0}", rdr["user2_sellsum"]);
                    string user2_sellprice = string.Format("{0}", rdr["user2_sellprice"]);

                    dt.Rows.Add(date, user1_sellsum, user1_sellprice, user2_sellsum, user2_sellprice);
                }


            }
        }
    }
}

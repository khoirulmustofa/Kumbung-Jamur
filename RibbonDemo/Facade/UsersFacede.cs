using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using RibbonDemo.Entity;

namespace RibbonDemo.Facade
{
    public class UsersFacede
    {
        //InitComponent
        MySqlDataAdapter adapter;
        MySqlCommand cmd;
        DBConnection DBCon;
        MySqlDataReader reader;
        DataTable dt;
        string sql;

        public DataTable getAllDataUsersAsTable()
        {
            DBCon = new DBConnection();
            sql = string.Format(@"SELECT
                                  `user_name`,
                                  `full_name`,
                                  `levels`
                                FROM `db_kombong_jamur`.`tb_users`");
            dt = new DataTable();
            try
            {
                DBCon.ConnectionOpen();
                cmd = new MySqlCommand(sql, DBCon.Connection);
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {

            }
            DBCon.ConnectionClose();
            return dt;
        }



        public bool Update(Users oUsers)
        {
            bool result = false;
            try
            {
                DBCon = new DBConnection();
                sql = string.Format(@"UPDATE `db_kombong_jamur`.`tb_users`
                                        SET `passwords` = '{1}',
                                          `full_name` = '{2}',
                                          `levels` = '{3}'
                                        WHERE `user_name` = '{0}'",
                                            oUsers.Username,
                                            oUsers.Passwords,
                                            oUsers.FullName,
                                            oUsers.Levels);
                DBCon.ConnectionOpen();
                cmd = new MySqlCommand(sql, DBCon.Connection);
                result = cmd.ExecuteNonQuery() == 1;
                DBCon.ConnectionClose();
            }
            catch (Exception ex) { }
            return result;
        }

        public bool Insert(Users oUsers)
        {
            bool result = false;
            try
            {
                DBCon = new DBConnection();
                sql = string.Format(@"INSERT INTO `db_kombong_jamur`.`tb_users`
                                                (`user_name`,
                                                 `passwords`,
                                                 `full_name`,
                                                 `levels`)
                                    VALUES ('{0}',
                                            '{1}',
                                            '{2}',
                                            '{3}')",
                                            oUsers.Username,
                                            oUsers.Passwords,
                                            oUsers.FullName,
                                            oUsers.Levels);
                DBCon.ConnectionOpen();
                cmd = new MySqlCommand(sql, DBCon.Connection);
                result = cmd.ExecuteNonQuery() == 1;
                DBCon.ConnectionClose();
            }
            catch (Exception ex) { }
            return result;
        }

        public DataTable GetUserByIdTbl(string userName)
        {
            DBCon = new DBConnection();
            sql = string.Format(@"SELECT
                                      `user_name`,
                                      `passwords`,
                                      `full_name`,
                                      `levels`
                                    FROM `db_kombong_jamur`.`tb_users`
                                    WHERE `user_name` = '{0}'", userName);
            dt = new DataTable();
            try
            {
                DBCon.ConnectionOpen();
                cmd = new MySqlCommand(sql, DBCon.Connection);
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {

            }
            DBCon.ConnectionClose();
            return dt;

        }

        public bool Delete(string userName)
        {
            bool result = false;
            try
            {
                DBCon = new DBConnection();
                sql = string.Format(@"DELETE
                                    FROM `db_kombong_jamur`.`tb_users`
                                    WHERE `user_name` = '{0}'", userName);
                DBCon.ConnectionOpen();
                cmd = new MySqlCommand(sql, DBCon.Connection);
                result = cmd.ExecuteNonQuery() == 1;
                DBCon.ConnectionClose();
            }
            catch (Exception ex)
            {
            }
            return result;
        }


        public DataTable GetUserByIdTbl(string userName, string pass)
        {
            DBCon = new DBConnection();
            sql = string.Format(@"SELECT
                                      `user_name`,
                                      `passwords`,
                                      `full_name`,
                                      `levels`
                                    FROM `db_kombong_jamur`.`tb_users`
                                    WHERE `user_name` = '{0}' AND `passwords` = '{1}'", userName, pass);
            dt = new DataTable();
            try
            {
                DBCon.ConnectionOpen();
                cmd = new MySqlCommand(sql, DBCon.Connection);
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {

            }
            DBCon.ConnectionClose();
            return dt;
        }

        public Users GetUserById(string userName)
        {
            DBCon = new DBConnection();
            sql = string.Format(@"SELECT
                                      `user_name`,
                                      `passwords`,
                                      `full_name`,
                                      `levels`
                                    FROM `db_kombong_jamur`.`tb_users`
                                    WHERE `user_name` = '{0}'", userName);
            DBCon.ConnectionOpen();
            cmd = new MySqlCommand(sql, DBCon.Connection);
            reader = cmd.ExecuteReader();
            Users oUsers = new Users();
            reader.Read();
            oUsers.Username = reader["user_name"].ToString();
            oUsers.Passwords = reader["passwords"].ToString();
            oUsers.FullName = reader["full_name"].ToString();
            oUsers.Levels = reader["levels"].ToString();
            DBCon.ConnectionClose();
            return oUsers;
        }
    }
}

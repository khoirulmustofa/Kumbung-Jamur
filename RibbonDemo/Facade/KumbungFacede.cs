using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using RibbonDemo.Entity;

namespace RibbonDemo.Facade
{
    public class KumbungFacede
    {
        //InitComponent
        MySqlDataAdapter adapter;
        MySqlCommand cmd;
        DBConnection DBCon;
        DataTable dt;
        string sql;

        public bool Insert(Kumbung oKumbung)
        {
            bool result = false;
            try
            {
                DBCon = new DBConnection();
                sql = string.Format(@"INSERT INTO `db_kombong_jamur`.`tb_kumbung`
                                    (`kode_kumbung`,
                                     `nama_kumbung`,
                                     `kapasitas`)
                                    VALUES ('{0}',
                                            '{1}',
                                            '{2}');",
                                            oKumbung.kode_kumbung,
                                            oKumbung.nama_kumbung,
                                            oKumbung.kapasitas);
                DBCon.ConnectionOpen();
                cmd = new MySqlCommand(sql, DBCon.Connection);
                result = cmd.ExecuteNonQuery() == 1;
                DBCon.ConnectionClose();
            }
            catch (Exception ex) { }
            return result;
        }

        public DataTable getAllDataKumbungAsTable()
        {
            DBCon = new DBConnection();
            sql = string.Format(@"SELECT
                                  `kode_kumbung`,
                                  `nama_kumbung`,
                                  `kapasitas`
                                FROM `db_kombong_jamur`.`tb_kumbung`");
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



        public bool Update(Kumbung oKumbung)
        {
            bool result = false;
            try
            {
                DBCon = new DBConnection();
                sql = string.Format(@"UPDATE `db_kombong_jamur`.`tb_kumbung`
                                    SET `nama_kumbung` = '{1}',
                                        `kapasitas` = '{2}'
                                    WHERE `kode_kumbung` = '{0}'",
                                            oKumbung.kode_kumbung,
                                            oKumbung.nama_kumbung,
                                            oKumbung.kapasitas);
                DBCon.ConnectionOpen();
                cmd = new MySqlCommand(sql, DBCon.Connection);
                result = cmd.ExecuteNonQuery() == 1;
                DBCon.ConnectionClose();
            }
            catch (Exception ex) { }
            return result;
        }

        public bool Delete(string KodeKumbung)
        {
            bool result = false;
            try
            {
                DBCon = new DBConnection();
                sql = string.Format(@"DELETE
                                    FROM `db_kombong_jamur`.`tb_kumbung`
                                    WHERE `kode_kumbung` = '{0}'", KodeKumbung);
                DBCon.ConnectionOpen();
                cmd = new MySqlCommand(sql, DBCon.Connection);
                result = cmd.ExecuteNonQuery() == 1;
                DBCon.ConnectionClose();
            }
            catch (Exception ex) { }
            return result;
        }
    }
}

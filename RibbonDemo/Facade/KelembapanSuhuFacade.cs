using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using RibbonDemo.Entity;

namespace RibbonDemo.Facade
{
    public class KelembapanSuhuFacade
    {
        //InitComponent
        MySqlDataAdapter adapter;
        MySqlCommand cmd;
        DBConnection DBCon;
        DataTable dt;
        string sql;

        public DataTable Insert(KelembapanSuhu oKelembapanSuhu)
        {
            DBCon = new DBConnection();
            sql =string.Format(@"INSERT INTO `db_kombong_jamur`.`tb_temperature_humidity`
                                (`kode_setting_kumbung`,
                                 `nilai_kelembapan`,
                                 `nilai_temperature`,
                                 `tanggal`)
                    VALUES ('{0}',
                            '{1}',
                            '{2}',
                            NOW())",oKelembapanSuhu.kode_setting_kumbung,
            oKelembapanSuhu.nilai_kelembapan,
            oKelembapanSuhu.nilai_temperature);
            dt = new DataTable();

            try
            {
                DBCon.ConnectionOpen();
                cmd = new MySqlCommand(sql, DBCon.Connection);
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception)
            {

            }
            DBCon.ConnectionClose();
            return dt;
        }

        public DataTable GetReportKelembapan(string tanggalawal, string tanggalakhir)
        {
            DBCon = new DBConnection();
            sql = string.Format(@"CALL ProcKelembapan('{0}','{1}');", tanggalawal,tanggalakhir);
            dt = new DataTable();

            try
            {
                DBCon.ConnectionOpen();
                cmd = new MySqlCommand(sql, DBCon.Connection);
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception)
            {

            }
            DBCon.ConnectionClose();
            return dt;
        }

        public DataTable GetReportTemperature(string tanggalawal, string tanggalakhir)
        {
            //
            DBCon = new DBConnection();
            sql = string.Format(@"CALL ProcTemperature('{0}','{1}');", tanggalawal, tanggalakhir);
            dt = new DataTable();

            try
            {
                DBCon.ConnectionOpen();
                cmd = new MySqlCommand(sql, DBCon.Connection);
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception)
            {

            }
            DBCon.ConnectionClose();
            return dt;
        }
    }
}

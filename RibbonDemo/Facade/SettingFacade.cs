using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using RibbonDemo.Entity;

namespace RibbonDemo.Facade
{
    public class SettingFacade
    {
        //InitComponent
        MySqlDataAdapter adapter;
        MySqlCommand cmd;
        DBConnection DBCon;
        DataTable dt;
        string sql;



        public bool Insert(SettingKumbung oSettingKumbung)
        {
            bool result = false;
            try
            {
                DBCon = new DBConnection();
                sql = string.Format(@"INSERT INTO `db_kombong_jamur`.`tb_setting_kumbung`
                                                (`kode_setting_kumbung`,
                                                 `kode_kumbung`,
                                                 `setting_temperature_min`,
                                                 `setting_temperature_max`,
                                                 `setting_kelembapan_min`,
                                                 `setting_kelembapan_max`,
                                                 `tanggal_setting`,
                                                 `Keterangan`,
                                                 `user_name`,status)
                                    VALUES ('{0}',
                                            '{1}',
                                            '{2}',
                                            '{3}',
                                            '{4}',
                                            '{5}',
                                            NOW(),
                                            '{6}',
                                            '{7}')",
                                            oSettingKumbung.kode_setting_kumbung,
                                            oSettingKumbung.kode_kumbung,
                                            oSettingKumbung.setting_temperature_min,
                                            oSettingKumbung.setting_temperature_max,
                                            oSettingKumbung.setting_kelembapan_min,
                                            oSettingKumbung.setting_kelembapan_max,
                                            oSettingKumbung.Keterangan,
                                            oSettingKumbung.user_name, oSettingKumbung.status);
                DBCon.ConnectionOpen();
                cmd = new MySqlCommand(sql, DBCon.Connection);
                result = cmd.ExecuteNonQuery() == 1;
                DBCon.ConnectionClose();
            }
            catch (Exception ex) { }
            return result;
        }

        public DataTable getAllDataSettingsAsTable()
        {
            DBCon = new DBConnection();
            sql = string.Format(@"SELECT
`status`,
`kode_setting_kumbung`,
`kode_kumbung`,
`setting_temperature_min`,
`setting_temperature_max`,
`setting_kelembapan_min`,
`setting_kelembapan_max`,
`Keterangan`,
`user_name`
FROM `db_kombong_jamur`.`tb_setting_kumbung`");
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

        public bool Update(SettingKumbung oSettingKumbung)
        {
            bool result = false;
            try
            {
                DBCon = new DBConnection();
                sql = string.Format(@"UPDATE `db_kombong_jamur`.`tb_setting_kumbung`
                                        SET `kode_kumbung` = '{1}',
                                          `setting_temperature_min` = '{2}',
                                          `setting_temperature_max` = '{3}',
                                          `setting_kelembapan_min` = '{4}',
                                          `setting_kelembapan_max` = '{5}',
                                          `tanggal_setting` = NOW(),
                                          `Keterangan` = '{6}',
                                          `user_name` = '{7}',status='{8}'
                                        WHERE `kode_setting_kumbung` = '{0}'",
                                           oSettingKumbung.kode_setting_kumbung,
                                           oSettingKumbung.kode_kumbung,
                                           oSettingKumbung.setting_temperature_min,
                                           oSettingKumbung.setting_temperature_max,
                                           oSettingKumbung.setting_kelembapan_min,
                                           oSettingKumbung.setting_kelembapan_max,
                                           oSettingKumbung.Keterangan,
                                           oSettingKumbung.user_name,oSettingKumbung.status);
                DBCon.ConnectionOpen();
                cmd = new MySqlCommand(sql, DBCon.Connection);
                result = cmd.ExecuteNonQuery() == 1;
                DBCon.ConnectionClose();
            }
            catch (Exception ex) { }
            return result;
        }

        public bool Delete(string KodeSetting)
        {
            bool result = false;
            try
            {
                DBCon = new DBConnection();
                sql = string.Format(@"DELETE
                FROM `db_kombong_jamur`.`tb_setting_kumbung`
                WHERE `kode_setting_kumbung` = '{0}'", KodeSetting);
                DBCon.ConnectionOpen();
                cmd = new MySqlCommand(sql, DBCon.Connection);
                result = cmd.ExecuteNonQuery() == 1;
                DBCon.ConnectionClose();
            }
            catch (Exception ex) { }
            return result;
        }

        public string getkodeSettingKumbung1()
        {
            DBCon = new DBConnection();
            sql = string.Format(@"SELECT
                                `kode_setting_kumbung`,
                                `kode_kumbung`,
                                `status`
                                FROM db_kombong_jamur.`tb_setting_kumbung`
                                WHERE `kode_kumbung` ='Kumbung1' AND `status` ='Aktif'");
            DBCon.ConnectionOpen();
            cmd = new MySqlCommand(sql, DBCon.Connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            
            return reader["kode_setting_kumbung"].ToString();
        }
    }
}

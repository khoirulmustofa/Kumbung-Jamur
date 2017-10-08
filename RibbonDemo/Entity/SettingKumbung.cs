using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RibbonDemo.Entity
{
    public class SettingKumbung
    {
        public string kode_setting_kumbung { get; set; }
        public string kode_kumbung { get; set; }
        public int setting_temperature_min { get; set; }
        public int setting_temperature_max { get; set; }
        public int setting_kelembapan_min { get; set; }
        public int setting_kelembapan_max { get; set; }
        public string tanggal_setting { get; set; }
        public string Keterangan { get; set; }
        public string user_name { get; set; }
        public string status { get; set; }


    }
}

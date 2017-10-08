using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RibbonDemo.Entity
{
    public class KelembapanSuhu
    {
        //public int kode_temperature_humidity{ get; set; }
        public string kode_setting_kumbung { get; set; }
        public double nilai_kelembapan { get; set; }
        public double nilai_temperature { get; set; }
        public DateTime tanggal { get; set; }
    }
}

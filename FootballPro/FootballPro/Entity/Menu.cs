using System;
using System.Data;

namespace FootballPro.Entity
{
    public class Menu
    {
        private string _serName;
        private int count;
        private float _gia;
        private float _tongTien;

        public Menu(string serName, int count, float gia, float tongTien = 0)
        {
            this.serName = serName;
            this.Count = count;
            this.gia = gia;
            this.tongTien = tongTien;
        }

        public Menu(DataRow row)
        {
            this.serName = row["Name"].ToString();
            this.Count = (int)row["Count"];
            this.gia = (float)Convert.ToDouble(row["Gia"].ToString());
            this.tongTien = (float)Convert.ToDouble(row["TongTien"].ToString());
        }

        public string serName { get => serName; set => serName = value; }
        public int Count { get => count; set => count = value; }
        public float gia { get => gia; set => gia = value; }
        public float tongTien { get => tongTien; set => tongTien = value; }
    }
}

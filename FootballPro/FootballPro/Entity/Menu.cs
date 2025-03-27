using System;
using System.Data;

namespace FootballPro.Entity
{
    public class Menu
    {
        private int iD;
        private string name;
        private int _idDanhMuc;
        private float _gia;

        public Menu(int iD, string name, int idDanhMuc, float gia)
        {
            this.ID = iD;
            this.Name = name;
            this.idDanhMuc = idDanhMuc;
            this.gia = gia;
        }

        public Menu(DataRow row)
        {
            this.ID = (int)row["ID"];
            this.Name = row["Name"].ToString();
            this.idDanhMuc = (int)row["idDanhMuc"];
            this.gia = (float)Convert.ToDouble(row["gia"].ToString());
        }

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public int idDanhMuc { get => idDanhMuc; set => idDanhMuc = value; }
        public float gia { get => gia; set => gia = value; }
    }
}

using System;
using System.Data;
using System.Runtime.InteropServices;

namespace FootballPro.Entity
{
    public class Service
    {
        private int _iD;
        private string _name;
        private int _iDdanhmuc;
        private float _gia;

        public Service(int iD, string name, int iDcategory, float gia)
        {
            this._iD = iD;
            this._name = name;
            this._iDdanhmuc = iDcategory;
            this._gia = gia;
        }

        public Service(DataRow row)
        {
            this.ID = (int)row["ID"];
            this.Name = row["Name"].ToString();
            this._iDdanhmuc = (int)row["IDDanhMuc"];
            this.Price = (float)Convert.ToDouble(row["Gia"].ToString());
        }

        public int ID { get => _iD; set => _iD = value; }
        public string Name { get => _name; set => _name = value; }
        public int IDDanhMuc { get => _iDdanhmuc; set => _iDdanhmuc = value; }
        public float Price { get => _gia; set => _gia = value; }
    }
}
using System.Data;

namespace FootballPro.Entity
{
    public class BillInfo
    {
        private int iD;
        private int billID;
        private int _dichvuID;
        private int count;

        public BillInfo() { }

        public BillInfo(int id, int billID, int dichvuID, int count)
        {
            this.ID = id;
            this.BillID = billID;
            this.dichvuID = dichvuID;
            this.Count = count;
        }

        public BillInfo(DataRow row)
        {
            this.ID = (int)row["id"];
            this.BillID = (int)row["idBill"];
            this.dichvuID = (int)row["idDichVu"];
            this.Count = (int)row["count"];
        }

        public int ID { get => iD; set => iD = value; }
        public int BillID { get => billID; set => billID = value; }
        public int dichvuID { get => dichvuID; set => dichvuID = value; }
        public int Count { get => count; set => count = value; }
    }
}

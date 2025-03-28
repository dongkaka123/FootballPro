using FootballPro.Entity;
using System;
using System.Collections.Generic;
using System.Data;

namespace FootballPro.DAL
{
    public class BillDAL
    {
        private static BillDAL instance;

        public static BillDAL Instance
        {
            get { if (instance == null) instance = new BillDAL(); return instance; }
            private set { BillDAL.instance = value; }
        }

        private BillDAL() { }

        // Lấy số lượng bill chưa thanh toán từ idTable truyền vào
        public int GetUnCheckBillIDBySanID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Bill WHERE idSan = " + id + " AND status = 0");

            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID;
            }

            return -1;
        }

        // Lấy danh sách bill chưa thanh toán từ idTable truyền vào
        public List<Bill> GetBillsBySanID(int idSan)
        {
            List<Bill> bills = new List<Bill>();

            string query = "SELECT * FROM Bill WHERE idSan = @idTable AND status = 0";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { idSan });

            foreach (DataRow item in data.Rows)
            {
                Bill bill = new Bill(item);
                bills.Add(bill);
            }

            return bills;
        }

        public List<Bill> GetBillsBySanIDCheckOut(int idTable)
        {
            List<Bill> bills = new List<Bill>();

            string query = "SELECT * FROM Bill WHERE idSan = @idTable ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { idTable });

            foreach (DataRow item in data.Rows)
            {
                Bill bill = new Bill(item);
                bills.Add(bill);
            }

            return bills;
        }

        // Thêm bill vào Database
        public void InsertBill(int id)
        {
            DataProvider.Instance.ExecuteNonQuery("EXEC USP_InsertBill @idTable", new object[] { id });
        }

        // Xóa Bill trong cơ sở dữ liệu
        public void DeleteBill(int idBill)
        {
            string queryDeleteBillInfo = "DELETE FROM BillInfo WHERE idBill = @idBill";
            DataProvider.Instance.ExecuteNonQuery(queryDeleteBillInfo, new object[] { idBill });

            string queryDeleteBill = "DELETE FROM Bill WHERE id = @idBill";
            DataProvider.Instance.ExecuteNonQuery(queryDeleteBill, new object[] { idBill });
        }

        // Lấy danh sách bill từ ngày...đến ngày...
        public DataTable GetBillListByDate(DateTime checkIn, DateTime checkOut)
        {
            return DataProvider.Instance.ExecuteQuery("EXEC USP_GetListBillByDate @checkIn , @checkOut ", new object[] { checkIn, checkOut });
        }

        // Lấy doanh thu theo tháng
        public DataTable GetMonthlyRevenue(DateTime checkIn, DateTime checkOut)
        {
            return DataProvider.Instance.ExecuteQuery("EXEC USP_GetMonthlyRevenue @checkIn , @checkOut",
                                                      new object[] { checkIn, checkOut });
        }

        // Lấy 10 (Số lượng bill trong 1 trang) bill  
        public DataTable GetBillListByDateAndPage(DateTime checkIn, DateTime checkOut, int pageNum)
        {
            return DataProvider.Instance.ExecuteQuery("EXEC USP_GetListBillByDateAndPage @checkIn , @checkOut , @page", new object[] { checkIn, checkOut, pageNum });
        }

        // Lấy số lượng bill 
        public int GetNumBillListByDate(DateTime checkIn, DateTime checkOut)
        {
            return (int)DataProvider.Instance.ExecuteScalar("EXEC USP_GetNumBillByDate @checkIn , @checkOut ", new object[] { checkIn, checkOut });
        }

        // Lấy idBill lớn nhất từ Database 
        public int GetMaxIDBill()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("SELECT MAX(id) FROM Bill");
            }
            catch
            {
                return 1;
            }
        }

        // Thanh toán
        public void CheckOut(int id, int discount, float totalPrice)
        {
            string query = "UPDATE Bill SET dateCheckOut = GETDATE(), status = 1, discount = " + discount + ", totalPrice = " + totalPrice + " WHERE id = " + id;
            DataProvider.Instance.ExecuteNonQuery(query);
        }

    }
}

using FootballPro.Entity;
using System;
using System.Collections.Generic;
using System.Data;

namespace FootballPro.DAL
{
    public class BillInfoDAL
    {
        private static BillInfoDAL instance;

        public static BillInfoDAL Instance
        {
            get 
            { 
                if (instance == null) instance = new BillInfoDAL(); 
                return instance; 
            }
            private set 
            { 
                BillInfoDAL.instance = value; 
            }
        }

        public BillInfoDAL() { }

        // Lấy danh sách BillInfo từ idBill truyền vào
        public List<BillInfo> GetBillInfos(int id)
        {
            List<BillInfo> listBillInfor = new List<BillInfo>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM BillInfo WHERE idBill = " + id);

            foreach (DataRow item in data.Rows)
            {
                BillInfo info = new BillInfo(item);
                listBillInfor.Add(info);
            }

            return listBillInfor;
        }

        // Cập nhật số lượng món ăn trong hóa đơn
        public void UpdateServiceCountInBill(int idBill, int serviceID, int count)
        {
            string query = "UPDATE BillInfo SET count = @count WHERE idBill = @idBill AND idService = @serviceID";

            DataProvider.Instance.ExecuteNonQuery(query, new object[] { count, idBill, serviceID });
        }

        // Lấy số lượng món ăn trong hóa đơn
        public int GetServiceCountInBill(int idBill, int serviceID)
        {
            string query = "SELECT COUNT FROM BillInfo WHERE idBill = @idBill AND idService = @serviceID";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { idBill, serviceID });
            return result == DBNull.Value ? 0 : (int)result;
        }

        // Kiểm tra món ăn có tồn tại trong hóa đơn không
        public bool IsServiceExistsInBill(int idBill, int serviceID)
        {
            string query = "SELECT COUNT(*) FROM BillInfo WHERE idBill = @idBill AND idService = @idService ";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { idBill, serviceID });
            return (int)result > 0;
        }

        // Thêm BillInfo mới
        public void InsertBillInfo(int idBill, int idService, int count)
        {
            DataProvider.Instance.ExecuteQuery("USP_InsertBillInfo @idBill , @idService , @count ", new object[] { idBill, idService, count });
        }

        // Xóa BillInfo từ idService truyền vào
        public void DeleteBillInfoByServiceID(int id)
        {
            DataProvider.Instance.ExecuteQuery("DELETE BillInfo WHERE idDichVu = " + id);
        }
    }
}

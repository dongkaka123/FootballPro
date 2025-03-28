using DevExpress.Internal.WinApi.Windows.UI.Notifications;
using FootballPro.Entity;
using System.Collections.Generic;
using System.Data;
using System.IdentityModel.Metadata;
using System.Windows.Forms;

namespace FootballPro.DAL
{
    public class SanDAL
    {
        private static SanDAL instance;

        public static int SanWidth = 106;
        public static int SanHeight = 106;

        public static SanDAL Instance
        {
            get 
            { 
                if (instance == null) 
                    instance = new SanDAL(); 
                return instance; 
            }
            private set => instance = value;
        }

        public SanDAL() { }
        public List<Entity.San> LoadSanList()
        {
            List<Entity.San> SanList = new List<Entity.San>();
            DataTable TableSan = DataProvider.Instance.ExecuteQuery("USP_GetSanList");
            foreach(DataRow item in TableSan.Rows)
            {
                Entity.San San = new Entity.San(item);
                SanList.Add(San);
            }
            return SanList;
        } 

        public int GetSanCount()
        {
            return (int)DataProvider.Instance.ExecuteScalar("SELECT COUNT(*) FROM San");
        }

        // Lấy ra bàn có id trùng với idSan truyền vào

        public Entity.San GetSanByID(int idSan)
        {
            Entity.San San = null;
            string query = "SELECT * FROM San WHERE id = " + idSan;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                San = new Entity.San(item);
                return San;
            }
            return San;
        }
        // Lấy bàn từ tên bàn

        public Entity.San GetSanByName(string SanName)
        {
            Entity.San San = null;

            string query = "SELECT * FROM San WHERE name=@SanName";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { SanName });

            foreach (DataRow item in data.Rows)
            {
                San = new Entity.San(item);
                return San;
            }
            return San;
        }
        // Thay đổi trạng thái bàn
        public void UpdateSanStatus(int SanID,string status)
        {
            string query = "UPDATE San SET status=@satus WHERE id=@SanID";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { status, SanID });

        }
        // Các hàm thêm, sửa, xóa bàn 
        public bool InsertSan(string name, string status,string location)
        {
            string query=string.Format("INSERT San (name,status,location) VALUES (N'{0}',N'{1}',N'{2}')",name,status,location);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        // Sửa tên bàn 
        public bool UpdateSan(string name,int id,string location)
        {
            string query = string.Format("UPDATE San SET name = N'{0}', location = N'{1}' WHERE id = {2}", name, location, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        // Xóa bàn
        public bool DeleteSan(int idSan)
        {
            Entity.San San = GetSanByID(idSan);
            if (San == null || San.Status == "Co nguoi")
            {
                MessageBox.Show("San dang co nguoi da");
                return false;
            }
            DataProvider.Instance.ExecuteNonQuery(string.Format("DELETE FROM BillInfo WHERE idBill IN (SELECT id FROM Bill WHERE idSan = {0})", idSan));
            DataProvider.Instance.ExecuteNonQuery(string.Format("DELETE FROM Bill WHERE idSan={0}", idSan));
            int result = DataProvider.Instance.ExecuteNonQuery(string.Format("DELETE FROM San WHERE id={0}", idSan));

            return result > 0;
        }
        public List<Entity.San> SearchSanByName(string name)
        {
            List<Entity.San> sans=new List<Entity.San>();

            string query = string.Format("SELECT * FROM San WHERE [dbo].[fuConvertToUnsign1] (name) LIKE N'%' + [dbo].[fuConvertToUnsign1](N'{0}')+ '%'", name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach(DataRow item in data.Rows)
            {
                Entity.San san = new Entity.San(item);
                sans.Add(san);
            }
            return sans;
        }

    }
}

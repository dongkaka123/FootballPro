using System.Collections.Generic;
using System.Data;
using DevExpress.CodeParser;

namespace FootballPro.DAL
{
    public class MenuDAL
    {
        private static MenuDAL instance;

        public static MenuDAL Instance
        {
            get { if (instance == null) instance = new MenuDAL(); return instance; }
            private set { MenuDAL.instance = value; }
        }
        private MenuDAL() { }

        // Lấy ra danh sách gồm: tên thức ăn, số lượng, đơn giá, thành tiền của món ăn đó 
        public List<Entity.Menu> GetListMenuBySan(int id)
        {
            List<Entity.Menu> listMenu = new List<Entity.Menu>();

            string query = "SELECT f.name, bi.count, f.gia, f.gia*bi.count AS TotalPrice FROM BillInfo AS bi, Bill AS b, Service AS f WHERE bi.idBill = b.id AND bi.idDichVu = f.id AND b.status = 0 AND b.idSan = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Entity.Menu menu = new Entity.Menu(item);
                listMenu.Add(menu);
            }

            return listMenu;
        }
    }
}

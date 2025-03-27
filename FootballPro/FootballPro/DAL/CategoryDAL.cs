using FootballPro.DAL;
using FootballPro.Entity;
using System.Collections.Generic;
using System.Data;

namespace FootballPro.DAL
{
    public class CategoryDAL
    {
        private static CategoryDAL instance;

        public static CategoryDAL Instance
        {
            get { if (instance == null) instance = new CategoryDAL(); return instance; }
            private set { CategoryDAL.instance = value; }
        }

        private CategoryDAL() { }

        // Lấy ra danh sách Category 
        public List<Entity.Category> GetListCategory()
        {
            List<Entity.Category> list = new List<Entity.Category>();

            string query = "SELECT id AS [ID], name AS [Name] FROM ServiceCategory";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Entity.Category category = new Category(item);

                list.Add(category);
            }

            return list;
        }

        // Tìm danh mục bằng tên
        public List<Category> SearchCategoryByName(string name)
        {
            List<Category> list = new List<Category>();

            string query = string.Format("SELECT * FROM ServiceCategory WHERE [dbo].[fuConvertToUnsign1] (name) LIKE N'%' + [dbo].[fuConvertToUnsign1](N'{0}') + '%'", name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Category cat = new Category(item);
                list.Add(cat);
            }

            return list;
        }

        // Đếm số lượng danh mục hiện có
        public int GetCategoryCount()
        {
            return (int)DataProvider.Instance.ExecuteScalar("SELECT COUNT(*) FROM ServiceCategory");
        }

        // Lấy ra Category từ idCategory truyền vào
        public Category GetCategoryByID(int id)
        {
            Category category = null;

            string query = "SELECT * FROM ServiceCategory WHERE id = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                category = new Category(item);
                return category;
            }

            return category;
        }

        // Các hàm thêm, sửa, xóa Category 
        public bool InsertCategory(string name)
        {
            string query = string.Format("INSERT ServiceCategory (name) VALUES (N'{0}')", name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        // Đổi tên danh mục
        public bool UpdateCategory(int id, string name)
        {
            string query = string.Format("UPDATE ServiceCategory SET name = N'{0}' WHERE id = {1} ", name, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }


        public bool DeleteCategory(int idCategory)
        {
            List<Entity.Service> foodList = ServiceDAL.Instance.GetServiceByCategoryID(idCategory);

            foreach (Entity.Service item in foodList)
            {
                BillInfoDAL.Instance.DeleteBillInfoByServiceID(item.ID);
            }

            ServiceDAL.Instance.DeteleServiceByCategoryID(idCategory);

            string query = string.Format("DELETE ServiceCategory WHERE id = {0}", idCategory);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}

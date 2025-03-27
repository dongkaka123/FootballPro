using System.Collections.Generic;
using System.Data;
using FootballPro.Entity;

namespace FootballPro.DAL
{
    partial class ServiceDAL
    {
        private ServiceDAL() { }
        private static ServiceDAL instance;
        public static ServiceDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new ServiceDAL();
                return instance;
            }
            private set
            {
                ServiceDAL.instance = value;
            }
        }

        public List<Entity.Service> GetListService()
        {
            List<Entity.Service> services = new List<Entity.Service>();
            string query = "SELECT id AS [ID], name AS [Name], idDanhMuc AS [IDDanhMuc], gia AS [Gia] FROM Service";

            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in dt.Rows)
            {
                Entity.Service sv = new Entity.Service(item);
                services.Add(sv);
            }
            return services;
        }

        public List<Entity.Service> GetServiceByCategoryID(int id)
        {
            List<Entity.Service> services = new List<Entity.Service>();

            string query = "SELECT * FROM Service WHERE idDanhMuc = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Entity.Service SV = new Entity.Service(item);
                services.Add(SV);
            }

            return services;
        }

        public Entity.Service GetServiceByName(string name)
        {
            string query = "SELECT TOP 1 * FROM Service WHERE name LIKE @name";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { '%' + name + '%' });

            if (dt.Rows.Count > 0)
            {
                return new Entity.Service(dt.Rows[0]);
            }
            return null;
        }
        public Entity.Service GetServiceByID(int id)
        {
            string query = "SELECT TOP 1 * FROM Service WHERE id = @id ";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { id });

            if (dt.Rows.Count > 0)
            {
                return new Entity.Service(dt.Rows[0]);
            }
            return null;
        }
        public int GetServiceCount()
        {
            return (int)DataProvider.Instance.ExecuteScalar("SELECT COUNT(*) FROM Service");
        }

        public bool InsertService(string name,int id,float price)
        {
            string query = string.Format("INSERT Service(name,idDanhMuc,gia) VALUES (N'{0}','{1}', '{2}')", name, id, price);
            int result=DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateService(int idService,string name,int idDanhMuc,float price)
        {
            string query = string.Format("UPDATE Service SET name=N'{0}', idDanhMuc = {1}, gia = {2} WHERE id = {3}", name, idDanhMuc, price, idService);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteService(int idService)
        {
            string query = string.Format("DELETE FROM Service WHERE id={0}", idService);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public List<Entity.Service> SearchServiceByName(string nameSer)
        {
            List<Entity.Service> sers = new List<Entity.Service>();
            string query = string.Format("SELECT * FROM Service WHERE [dbo].[fuConvertToUnsign1] (name) LIKE N'%' + [dbo].[fuConvertToUnsign1](N'{0}')+ '%'\"", nameSer);

            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in dt.Rows)
            {
                Entity.Service ser = new Entity.Service(item);
                sers.Add(ser);
            }
            return sers;
        }
        public void DeteleServiceByCategoryID(int categoryID)
        {
            DataProvider.Instance.ExecuteQuery("DELETE Service WHERE Service.idDanhMuc = " + categoryID);
        }
    }
}


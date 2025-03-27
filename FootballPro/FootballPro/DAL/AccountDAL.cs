using FootballPro.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Drawing;

namespace FootballPro.DAL
{
    public class AccountDAL
    {
        private static AccountDAL instance;

        private AccountDAL() { }

        public static AccountDAL Instance
        {
            get { if (instance == null) instance = new AccountDAL(); return instance; }
            private set { instance = value; }
        }

        public List<int> GetListAccountType()
        {
            List<int> list = new List<int>();

            string query = "SELECT DISTINCT type FROM Account";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                int accountType = Convert.ToInt32(row["type"]);
                list.Add(accountType);
            }

            return list;
        }
        public int GetAccountType(string name)
        {
            string query = string.Format("SELECT type FROM Account WHERE UserName= '{0}'",name);

            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            if (result.Rows.Count > 0)
            {
                return Convert.ToInt32(result.Rows[0]["type"]);

            }
            return -1;
        }
        public List<Account> SearchAccountByDisplayName(string displayName)
        {
            List<Account> list = new List<Account>();

            string query = string.Format("SELECT * FROM Account WHERE [dbo].[fuConvertToUnsign1] (displayName) LIKE N'%' + [dbo].[fuConvertToUnsign1](N'{0}') + '%'", displayName);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Account acc = new Account(item);
                list.Add(acc);
            }

            return list;
        }
        public bool Login(string userName, string passWord)
        {
            string query = "USP_Login @userName , @passWord";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, passWord /**/});

            return result.Rows.Count > 0;
        }

        public bool UpdateAccount(string userName, string displayName, string pass, string newPass)
        {
            string query = "EXEC USP_UpdateAccount @userName , @displayName , @password , @newPassword ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { userName, displayName, pass, newPass });

            return result > 0;
        }

        public bool CheckAccountExists(string userName)
        {
            string query = "SELECT COUNT(*) FROM Account WHERE UserName = @userName";
            int result = (int)DataProvider.Instance.ExecuteScalar(query, new object[] { userName });
            return result > 0;
        }

        public DataTable GetListAccount()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT UserName, DisplayName, Password, Type FROM Account");
        }

        public int GetAccountCount()
        {
            return (int)DataProvider.Instance.ExecuteScalar("SELECT COUNT(*) FROM Account WHERE type = 0");
        }

        public Account GetAccountByUserName(string userName)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM ACCOUNT WHERE userName = '" + userName + "'");

            foreach (DataRow item in data.Rows)
            {
                return new Account(item);
            }

            return null;
        }

        public bool InsertAccount(string userName, string displayName, string password, int type)
        {
            string query = string.Format("INSERT Account (userName, displayName, type, passWord) VALUES (N'{0}', N'{1}', {2}, N'{3}')", userName, displayName, type, password);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateAccount(string userName, string displayName, int type)
        {
            string query = string.Format("UPDATE Account SET displayName = N'{1}', type = {2} WHERE UserName = N'{0}' ", userName, displayName, type);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteAccount(string name)
        {
            string query = string.Format("DELETE Account WHERE UserName = N'{0}'", name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool ResetPassword(string name, string displayName)
        {
            string query = string.Format("Update Account SET passWord = N'2025' WHERE userName = N'{0}' AND displayName = N'{1}'", name, displayName);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}

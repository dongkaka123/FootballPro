using FootballPro.DAL;
using FootballPro.Entity;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace FootballPro
{
    public partial class Account_Information : Form
    {
        public static Account userName;
        private Label lblDisplayName;
        public Account_Information(Account userNameLogin, Label displayNameLabel)
        {
            InitializeComponent();
            userName = userNameLogin;
            lblDisplayName = displayNameLabel;
            LoadInfo();
            LoadAccountInformation();
        }

        // Load dữ liệu lên form
        void LoadInfo()
        {
        }

        // Thoát form
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Cập nhật thông cá nhân
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            UpdateAccountInfo();
        }

        // Hàm cập nhật dữ liệu thay đổi vào database
        void UpdateAccountInfo()
        {
            string displayName = txbDisplayName.Text;
            string password = txbPassword.Text;
            string newpass = txbNewPassword.Text;
            string reenterPass = txbRePassword.Text;
            string userName = txbUserName.Text;

            if (!newpass.Equals(reenterPass))
            {
                MessageBox.Show("Mật khẩu mới không trùng khớp!");
            }
            else
            {
                if (password == reenterPass && password == newpass && password != "")
                {
                    MessageBox.Show("Mật khẩu mới trùng với mật khẩu cũ!");
                    return;
                }
                bool result = AccountDAL.Instance.UpdateAccount(userName, displayName, password, newpass);
                if (result)
                {
                    UIHelper.userNameFromLogin.DisPlayName = displayName;
                    lblDisplayName.Text = displayName;
                    MessageBox.Show("Cập nhật thành công!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đúng mật khẩu!");
                }
            }
        }

        // Load dữ liệu của tài khoản lên form
        private void Account_Information_Load(object sender, EventArgs e)
        {
            Account acc = UIHelper.userNameFromLogin;
            txbUserName.Text = acc.UserName;
            txbDisplayName.Text = acc.DisPlayName;
        }

        // Lấy tài khoản từ lớp UIHelper
        private void LoadAccountInformation()
        {
            string userName = UIHelper.userNameFromLogin.UserName;
        }

        private void txbUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

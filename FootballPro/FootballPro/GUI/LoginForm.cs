using FootballPro.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FootballPro.Entity;

namespace FootballPro
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            UIHelper.RestoreFormPosition(this);
        }

        private void lblHiden_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        bool Login(string userName, string passWord)
        {
            return AccountDAL.Instance.Login(userName, passWord);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            string passWord = txbPassword.Text;

            if (Login(userName, passWord))
            {
                int accType = AccountDAL.Instance.GetAccountType(userName);
                Account loginAccount = AccountDAL.Instance.GetAccountByUserName(userName);
                UIHelper.userNameFromLogin = loginAccount;

                UIHelper.SaveFormPosition(this);
                this.Hide();
                Home homeForm = new Home(accType);
                UIHelper.RestoreFormPosition(homeForm);
                homeForm.Show();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Thông báo");
            }
        }

        private void lblFogetPassword_Click(object sender, EventArgs e)
        {
            ForgetPassword f = new ForgetPassword();
            f.ShowDialog();
        }

        private void txbUserName_Click(object sender, EventArgs e)
        {
        }

        private void txbPassword_Click(object sender, EventArgs e)
        {
        }

        private void pnlLogin_MouseDown(object sender, MouseEventArgs e)
        {
            UIHelper.MoveWindow(this, e);
        }

        private void txbUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                this.SelectNextControl(ActiveControl,true,true,true,true);
            }
        }
    }
}

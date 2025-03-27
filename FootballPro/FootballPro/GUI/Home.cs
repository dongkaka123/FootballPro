using FootballPro.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FootballPro.DAL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FootballPro
{
    public partial class Home : Form
    {
        private int accType;
        public Home(int accountType)
        {
            InitializeComponent();
            this.accType = accountType;
            LoadInfo();
            
        }
        void LoadInfo()
        {
            Account acc = UIHelper.userNameFromLogin;
            pnlHome.BackColor = Color.FromArgb(255, 102, 196);
            lblDisplayName.Text = acc.DisPlayName;
        }
        private void Home_Load(object sender, EventArgs e)
        {
            if (accType == 0)
            {
                pnlAdmin.Visible = false;
                //flowLayoutPanel1.Visible = false;
            }
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            UIHelper.MoveWindow(this, e);
        }

        private void Form02_Load(object sender, EventArgs e)
        {
            lblNumOfBan.Text = SanDAL.Instance.GetSanCount().ToString();
            lblNumOfThucUong.Text = ServiceDAL.Instance.GetServiceCount().ToString();
            lblNumOfPhanLoai.Text = CategoryDAL.Instance.GetCategoryCount().ToString();
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

        private void lblLogOut_Click(object sender, EventArgs e)
        {
            UIHelper.SaveFormPosition(this);
            this.Hide();
            LoginForm loginForm = new LoginForm();
            UIHelper.RestoreFormPosition(loginForm);
            loginForm.Show();
        }

        private void lblAcountInfo_Click(object sender, EventArgs e)
        {
            Account_Information f = new Account_Information(UIHelper.userNameFromLogin, lblDisplayName);
            f.ShowDialog();
        }

        private void ChangeForm_Click(object sender, EventArgs e)
        {
            List<Panel> panels = new List<Panel> { pnlHome, pnlAdmin, pnlUser, pnlOrder, pnlCheckOut, pnlHelp };

            UIHelper.ChangePanelColor(sender, panels, UIHelper.userNameFromLogin, this);
        }

        private void pbIconNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void pnlNhanVien_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblNumOfNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void pnlHome_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlBan_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pbBan_Click(object sender, EventArgs e)
        {

        }

        private void lblNumOfBan_Click(object sender, EventArgs e)
        {

        }

        private void pnlAdmin_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void pbIconPhanLoai_Click(object sender, EventArgs e)
        {

        }

        private void pbIconThucUong_Click(object sender, EventArgs e)
        {

        }

        private void lblNumOfThucUong_Click(object sender, EventArgs e)
        {

        }

        private void pnlThucUong_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblDichVu_Click(object sender, EventArgs e)
        {
            Service fS = new Service();
            this.Hide();
            fS.Show();
        }

        private void lblSan_Click(object sender, EventArgs e)
        {
            San table = new San();

            this.Hide();
            table.Show();
        }

        private void lblNhanVien_Click(object sender, EventArgs e)
        {
            AccountForm fr1 = new AccountForm();
            this.Hide();
            fr1.Show();
        }

        private void lblPhanLoai_Click(object sender, EventArgs e)
        {
            CategoryForm fC = new CategoryForm();
            this.Hide();
            fC.Show();
        }

    }
}

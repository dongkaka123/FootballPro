using FootballPro.DAL;
using FootballPro.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootballPro
{
    public partial class San : Form
    {
        BindingSource SanList = new BindingSource();
        public San()
        {
            InitializeComponent();
            UIHelper.RestoreFormPosition(this);
            LoadInfo();
        }

        void LoadInfo()
        {
            loadListSan();
            dtgvTable.DataSource = SanList;
            AddTableBinding();
            pnlAdmin.BackColor = Color.FromArgb(255, 102, 196);

            Account acc = UIHelper.userNameFromLogin;
            lblDisplayName.Text = acc.DisPlayName;
            if (acc.Type == 0)
            {
                lblAdminName.Text = "Nhân viên";
                lblAdmin.Enabled = false;
                pnlAdmin.Enabled = false;
                pnlAdmin.BackColor = Color.DarkGray;
            }
            else
            {
                lblAdminName.Text = "Admin";
            }
            lblDisplayName.Text = acc.DisPlayName;
        }

        void loadListSan()
        {
            SanList.DataSource = SanDAL.Instance.LoadSanList();
        }

        void AddTableBinding()
        {
            txbID.DataBindings.Add(new Binding("Text", dtgvTable.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txbTenBan.DataBindings.Add(new Binding("Text", dtgvTable.DataSource, "Name", true, DataSourceUpdateMode.Never));
            cbTrangThai.DataBindings.Add(new Binding("Text", dtgvTable.DataSource, "Status", true, DataSourceUpdateMode.Never));
        }

        private void lblHiden_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ChangeForm_Click(object sender, EventArgs e)
        {
            List<Panel> panels = new List<Panel> { pnlHome, pnlAdmin, pnlUser, pnlOrder, pnlCheckOut, pnlHelp };

            UIHelper.ChangePanelColor(sender, panels, UIHelper.userNameFromLogin, this);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            UIHelper.SaveFormPosition(this);
            Account acc = UIHelper.userNameFromLogin;
            Home home = new Home(acc.Type);
            UIHelper.RestoreFormPosition(home);
            home.Show();
            this.Close();
        }

        private event EventHandler insertTable;
        public event EventHandler InsertTable
        {
            add { insertTable += value; }
            remove { insertTable -= value; }
        }

        private event EventHandler deleteTable;
        public event EventHandler DeleteTable
        {
            add { deleteTable += value; }
            remove { deleteTable -= value; }
        }

        private event EventHandler updateTable;
        public event EventHandler UpdateTable
        {
            add { updateTable += value; }
            remove { updateTable -= value; }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string name = txbTenBan.Text;
            string status = "Trống";

            if (SanDAL.Instance.InsertSan(name, status))
            {
                MessageBox.Show("Thêm sân thành công!");
                loadListSan();
                if (insertTable != null)
                {
                    insertTable(this, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm sân!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string name = txbTenBan.Text;
            int id = Convert.ToInt32(txbID.Text);

            if (SanDAL.Instance.UpdateSan(name, id))
            {
                MessageBox.Show("Sửa sân thành công!");
                loadListSan();
                if (updateTable != null)
                {
                    updateTable(this, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa sân!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Việc xóa sân này sẽ xóa tất cả các bill liên quan. Bạn có chắc chắn muốn xóa?",
                                      "Cảnh báo",
                                      MessageBoxButtons.YesNo,
                                      MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                int id = Convert.ToInt32(txbID.Text);

                if (SanDAL.Instance.DeleteSan(id))
                {
                    MessageBox.Show("Xóa sân thành công!");
                    loadListSan();
                    if (deleteTable != null)
                    {
                        deleteTable(this, new EventArgs());
                    }
                }
                else
                {
                    MessageBox.Show("Có lỗi khi xóa sân!");
                }
            }
            else
            {
                MessageBox.Show("Đã hủy thao tác này", "Thông báo");
            }


        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            UIHelper.MoveWindow(this, e);
        }

        private void Table_FormClosing(object sender, FormClosingEventArgs e)
        {
            UIHelper.SaveFormPosition(this);
        }

        private void txbFind_TextChanged(object sender, EventArgs e)
        {
            SanList.DataSource = SearchTableFoodByName(txbFind.Text);
        }

        List<Entity.San> SearchTableFoodByName(string name)
        {
            List<Entity.San> listTable = SanDAL.Instance.SearchSanByName(name);

            return listTable;
        }

        private void lblHiden_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblExit_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dtgvTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

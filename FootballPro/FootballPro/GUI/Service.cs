using FootballPro.DAL;
using FootballPro.Entity;
using FootballPro;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraPrinting.Native;

namespace FootballPro
{
    public partial class Service : Form
    {
        BindingSource ServiceList = new BindingSource();
        public Service()
        {
            InitializeComponent();
            UIHelper.RestoreFormPosition(this);
            LoadInfo();
        }

        void LoadInfo()
        {
            LoadListDrinks();
            LoadCategoryIntoCombobox(cbDanhMuc);
            dtgvDrinks.DataSource = ServiceList;
            AddDrinksBinding();
            pnlAdmin.BackColor = Color.FromArgb(255, 102, 196);
            Account acc = UIHelper.userNameFromLogin;

            lblDisplayName.Text = acc.DisPlayName;
        }

        void LoadListDrinks()
        {
            ServiceList.DataSource = ServiceDAL.Instance.GetListService();
        }

        void LoadCategoryIntoCombobox(ComboBox cb)
        {
            cb.DataSource = CategoryDAL.Instance.GetListCategory();
            cb.DisplayMember = "Name";
            cb.ValueMember = "ID";
        }

        private void lblHiden_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        void AddDrinksBinding()
        {
            txbID.DataBindings.Add(new Binding("Text", dtgvDrinks.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txbTenMon.DataBindings.Add(new Binding("Text", dtgvDrinks.DataSource, "Name", true, DataSourceUpdateMode.Never));
            txbGia.DataBindings.Add(new Binding("Text", dtgvDrinks.DataSource, "Price", true, DataSourceUpdateMode.Never));
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pnlTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            UIHelper.MoveWindow(this, e);
        }

        private void ChangeForm_Click(object sender, EventArgs e)
        {
            List<Panel> panels = new List<Panel> { pnlHome, pnlAdmin, pnlUser, pnlOrder, pnlCheckOut, pnlHelp };

            UIHelper.ChangePanelColor(sender, panels, UIHelper.userNameFromLogin, this);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            UIHelper.SaveFormPosition(this);
            Account acc =UIHelper.userNameFromLogin;
            Home home = new Home(acc.Type);
            UIHelper.RestoreFormPosition(home);
            home.Show();
            this.Close();
        }

        private void txbID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dtgvDrinks.SelectedCells.Count > 0)
                {
                    var selectedRow = dtgvDrinks.SelectedCells[0].OwningRow;
                    if (selectedRow.Cells["IDcategory"].Value != null)
                    {
                        int id = (int)selectedRow.Cells["IDcategory"].Value;

                        Category category = CategoryDAL.Instance.GetCategoryByID(id);
                        cbDanhMuc.SelectedItem = category;

                        int index = -1;
                        int i = 0;

                        foreach (Category item in cbDanhMuc.Items)
                        {
                            if (item.Id == category.Id)
                            {
                                index = i;
                                break;
                            }
                            i++;
                        }

                        cbDanhMuc.SelectedIndex = index;
                    }
                }
            }
            catch
            {
                return;
            }
        }

        private void txbFind_TextChanged(object sender, EventArgs e)
        {
            ServiceList.DataSource = SearchServiceByName(txbFind.Text);
        }

        List<Entity.Service> SearchServiceByName(string name)
        {
            List<Entity.Service> listService = ServiceDAL.Instance.SearchServiceByName(name);

            return listService;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string name = txbTenMon.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Vui lòng nhập tên món!");
                return;
            }

            if (!(cbDanhMuc.SelectedItem is Category selectedCategory))
            {
                MessageBox.Show("Vui lòng chọn danh mục!");
                return;
            }

            if (!float.TryParse(txbGia.Text, out float price) || price < 0)
            {
                MessageBox.Show("Vui lòng nhập giá hợp lệ!");
                return;
            }

            int categoryID = selectedCategory.Id;

            if (ServiceDAL.Instance.InsertService(name, categoryID, price))
            {
                MessageBox.Show("Thêm món thành công!");
                LoadListDrinks();

                insertDrinks?.Invoke(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm món!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txbTenMon.Text.Trim();

                if (cbDanhMuc.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng chọn danh mục!");
                    return;
                }

                int CategoryID = (cbDanhMuc.SelectedItem as Category).Id;

                if (!float.TryParse(txbGia.Text.Trim(), out float price))
                {
                    MessageBox.Show("Giá không hợp lệ. Vui lòng nhập số!");
                    return;
                }

                if (!int.TryParse(txbID.Text.Trim(), out int idService))
                {
                    MessageBox.Show("ID không hợp lệ. Vui lòng kiểm tra lại!");
                    return;
                }

                if (ServiceDAL.Instance.UpdateService(idService, name, CategoryID, price))
                {
                    MessageBox.Show("Sửa món thành công!");
                    LoadListDrinks();

                    if (updateDrinks != null)
                    {
                        updateDrinks(this, new EventArgs());
                    }
                }
                else
                {
                    MessageBox.Show("Có lỗi khi sửa thức ăn!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Việc này sẽ xóa tất cả dịch vụ trong các hóa đơn và trong các sân hiện tại. Bạn có chắc chắn muốn xóa?",
                                      "Cảnh báo",
                                      MessageBoxButtons.YesNo,
                                      MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                int idService = Convert.ToInt32(txbID.Text);

                if (ServiceDAL.Instance.DeleteService(idService))
                {
                    MessageBox.Show("Xóa dv thành công!");
                    LoadListDrinks();
                    if (deleteDrinks != null)
                    {
                        deleteDrinks(this, new EventArgs());
                    }
                }
                else
                {
                    MessageBox.Show("Có lỗi khi xóa!");
                }
            }
            else
            {
                MessageBox.Show("Đã hủy thao tác này", "Thông báo");
            }
        }

        private event EventHandler insertDrinks;
        public event EventHandler InsertDrinks
        {
            add { insertDrinks += value; }
            remove { insertDrinks -= value; }
        }

        private event EventHandler deleteDrinks;
        public event EventHandler DeleteDrinks
        {
            add { deleteDrinks += value; }
            remove { deleteDrinks -= value; }
        }

        private event EventHandler updateDrinks;
        public event EventHandler UpdateDrinks
        {
            add { updateDrinks += value; }
            remove { updateDrinks -= value; }
        }

        private void Drinks_FormClosing(object sender, FormClosingEventArgs e)
        {
            UIHelper.SaveFormPosition(this);
        }

        private void cbDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtgvDrinks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvDrinks.Rows[e.RowIndex];

                // Lấy ID danh mục từ DataGridView
                int categoryId = Convert.ToInt32(row.Cells["idDanhMuc"].Value);

                // Tìm danh mục trong ComboBox và chọn
                cbDanhMuc.SelectedValue = categoryId;
            }
        }
    }
}

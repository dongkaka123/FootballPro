using FootballPro.DAL;
using FootballPro.Entity;
using DevExpress.XtraRichEdit.Import.Html;
using FootballPro;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using Menu = FootballPro.Entity.Menu;

namespace FootballPro
{
    public partial class OrderService : Form
    {
        public List<Service> serList;
        public OrderService()
        {
            InitializeComponent();
            UIHelper.RestoreFormPosition(this);
            LoadInfo();
        }

        void LoadInfo()
        {
            lblTenBanDatMon.Text = SanDAL.Instance.GetSanByID(UIHelper.sanIDDatSan).Name;
            ShowBill();
            LoadDrinks();
            pnlOrder.BackColor = Color.FromArgb(255, 102, 196);
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
        }

        void LoadDrinks()
        {
            dtgvDrinks.DataSource = ServiceDAL.Instance.GetListService();
        }

        private void ChangeForm_Click(object sender, EventArgs e)
        {
            List<Panel> panels = new List<Panel> { pnlHome, pnlAdmin, pnlUser, pnlOrder, pnlCheckOut, pnlHelp };

            UIHelper.ChangePanelColor(sender, panels, UIHelper.userNameFromLogin, this);
        }

        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            dtgvDrinks.DataSource = SearchDrinksByName(txbSearch.Text);
        }

        List<Entity.Service> SearchDrinksByName(string name)
        {
            List<Entity.Service> listService = ServiceDAL.Instance.SearchServiceByName(name);

            return listService;
        }

        private void dtgvDatMon_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            TinhTongTien();
        }

        private void dtgvDatMon_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            TinhTongTien();
        }

        private void dtgvDatMon_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            TinhTongTien();
        }


        private void TinhTongTien()
        {
            decimal tongTien = 0;

            foreach (DataGridViewRow row in dtgvDatMon.Rows)
            {
                if (row.Cells["ThanhTien"].Value != null)
                {
                    tongTien += Convert.ToDecimal(row.Cells["ThanhTien"].Value);
                }
            }
            CultureInfo culture = new CultureInfo("vi-VN");

            lblTongTienVND.Text = tongTien.ToString("c", culture);
        }

        void ShowBill()
        {
            dtgvDatMon.Rows.Clear();
            float totalPrice = 0;

            List<Menu> listBillInfo = MenuDAL.Instance.GetListMenuBySan(UIHelper.sanIDDatSan);

            foreach (Menu item in listBillInfo)
            {
                int rowIndex = dtgvDatMon.Rows.Add();

                DataGridViewRow row = dtgvDatMon.Rows[rowIndex];

                row.Cells["TenMon"].Value = item.serName;
                row.Cells["SoLuong"].Value = item.Count;
                row.Cells["DonGia"].Value = item.gia;
                row.Cells["ThanhTien"].Value = item.tongTien;

                totalPrice += item.tongTien;
            }

            CultureInfo culture = new CultureInfo("vi-VN");
            lblTongTienVND.Text = totalPrice.ToString("c", culture);
        }


        private void btnDatMon_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn order những món này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (dtgvDatMon.Rows.Count == 0)
                {
                    SanDAL.Instance.UpdateSanStatus(UIHelper.sanIDDatSan, "Trống");

                    Entity.San san = SanDAL.Instance.GetSanByID(UIHelper.sanIDDatSan);
                    int idBill = BillDAL.Instance.GetUnCheckBillIDBySanID(san.ID);

                    if (idBill != -1)
                    {
                        BillDAL.Instance.DeleteBill(idBill);
                    }
                }
                UIHelper.SaveFormPosition(this);
                Form f = new Order();
                UIHelper.RestoreFormPosition(f);
                f.Show();
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void OrderService_Load(object sender, EventArgs e)
        {
            UIHelper.GlobalTimer.Tick += UpdateTimeLabel;
        }

        private void UpdateTimeLabel(object sender, EventArgs e)
        {
            lblTime.Text = UIHelper.CurrentTime;
        }

        private void dtgvDrinks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dtgvDrinks.ClearSelection();
                dtgvDrinks.Rows[e.RowIndex].Selected = true;
                string tenMon = dtgvDrinks.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                decimal donGia = Convert.ToDecimal(dtgvDrinks.Rows[e.RowIndex].Cells["Price"].Value);

                bool isExists = false;

                foreach (DataGridViewRow row in dtgvDatMon.Rows)
                {
                    if (row.Cells["TenMon"].Value.ToString() == tenMon)
                    {
                        int soLuong = Convert.ToInt32(row.Cells["SoLuong"].Value);
                        soLuong++;
                        row.Cells["SoLuong"].Value = soLuong;
                        row.Cells["ThanhTien"].Value = soLuong * donGia;
                        isExists = true;
                        break;
                    }
                }

                if (!isExists)
                {
                    int soLuong = 1;
                    dtgvDatMon.Rows.Add(tenMon, soLuong, donGia, soLuong * donGia);
                }
                Entity.San san = SanDAL.Instance.GetSanByID(UIHelper.sanIDDatSan);
                string ServiceName = dtgvDrinks.Rows[e.RowIndex].Cells["Name"].Value.ToString();

                int idBill = BillDAL.Instance.GetUnCheckBillIDBySanID(san.ID);
                int ServiceID = ServiceDAL.Instance.GetServiceByName(ServiceName).ID;
                int count = 0;

                foreach (DataGridViewRow row in dtgvDatMon.Rows)
                {
                    if (row.Cells["TenMon"].Value.ToString() == ServiceName)
                    {
                        count = Convert.ToInt32(row.Cells["SoLuong"].Value);
                        break;
                    }
                }

                bool ServiceExistsInBill = BillInfoDAL.Instance.IsServiceExistsInBill(idBill, ServiceID);

                if (ServiceExistsInBill)
                {
                    BillInfoDAL.Instance.UpdateServiceCountInBill(idBill, ServiceID, count);
                }
                else
                {
                    if (idBill == -1)
                    {
                        BillDAL.Instance.InsertBill(san.ID);
                        BillInfoDAL.Instance.InsertBillInfo(BillDAL.Instance.GetMaxIDBill(), ServiceID, count);
                    }
                    else
                    {
                        BillInfoDAL.Instance.InsertBillInfo(idBill, ServiceID, count);
                    }
                }
            }
        }

        private void panel9_MouseDown(object sender, MouseEventArgs e)
        {
            UIHelper.MoveWindow(this, e);
        }

        private void OrderService_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dtgvDatMon.Rows.Count == 0)
            {
                SanDAL.Instance.UpdateSanStatus(UIHelper.sanIDDatSan, "Trống");
            }

            UIHelper.SaveFormPosition(this);
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

        private void dtgvDrinks_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dtgvDrinks.ClearSelection();
                dtgvDrinks.Rows[e.RowIndex].Selected = true;

                cmsDatNhieuMon.Show(Cursor.Position);
            }
        }

        private void ChonNhieuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ServiceID = Convert.ToInt32(dtgvDrinks.SelectedRows[0].Cells[0].Value);
            Entity.Service Service = ServiceDAL.Instance.GetServiceByID(ServiceID);
            //AddMoreDrinks f = new AddMoreDrinks(Service, dtgvDatMon);
            //f.Show();
        }

        private void dtgvDatMon_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dtgvDatMon.ClearSelection();
                dtgvDatMon.Rows[e.RowIndex].Selected = true;

                cmsChinhSua.Show(Cursor.Position);
            }
        }

        private void XoaMonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dtgvDatMon.SelectedRows.Count > 0)
            {
                string tenMon = dtgvDatMon.SelectedRows[0].Cells["TenMon"].Value.ToString();
                int soLuong = Convert.ToInt32(dtgvDatMon.SelectedRows[0].Cells["SoLuong"].Value);
                float donGia = Convert.ToSingle(dtgvDatMon.SelectedRows[0].Cells["DonGia"].Value);

                Entity.San san = SanDAL.Instance.GetSanByID(UIHelper.sanIDDatSan);
                int idBill = BillDAL.Instance.GetUnCheckBillIDBySanID(san.ID);
                int ServiceID = ServiceDAL.Instance.GetServiceByName(tenMon).ID;

                dtgvDatMon.Rows.Remove(dtgvDatMon.SelectedRows[0]);

                bool ServiceExistsInBill = BillInfoDAL.Instance.IsServiceExistsInBill(idBill, ServiceID);
                if (ServiceExistsInBill)
                {
                    int currentCount = BillInfoDAL.Instance.GetServiceCountInBill(idBill, ServiceID);
                    int newCount = currentCount - soLuong;

                    if (newCount <= 0)
                    {
                        BillInfoDAL.Instance.DeleteBillInfoByServiceID(ServiceID);
                    }
                    else
                    {
                        BillInfoDAL.Instance.UpdateServiceCountInBill(idBill, ServiceID, newCount);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn món cần xóa!");
            }
        }

        private void dtgvDatMon_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dtgvDatMon.Columns["SoLuong"].Index)
            {
                DataGridViewRow row = dtgvDatMon.Rows[e.RowIndex];

                if (row.Cells["DonGia"].Value != null && row.Cells["SoLuong"].Value != null)
                {
                    decimal donGia = Convert.ToDecimal(row.Cells["DonGia"].Value);
                    int soLuong = Convert.ToInt32(row.Cells["SoLuong"].Value);

                    row.Cells["ThanhTien"].Value = donGia * soLuong;

                    string tenMon = row.Cells["TenMon"].Value.ToString();
                    Entity.San san = SanDAL.Instance.GetSanByID(UIHelper.sanIDDatSan);
                    int idBill = BillDAL.Instance.GetUnCheckBillIDBySanID(san.ID);
                    int ServiceID = ServiceDAL.Instance.GetServiceByName(tenMon).ID;

                    if (idBill != -1)
                    {
                        if (soLuong > 0)
                        {
                            BillInfoDAL.Instance.UpdateServiceCountInBill(idBill, ServiceID, soLuong);
                        }
                        else
                        {
                            BillInfoDAL.Instance.DeleteBillInfoByServiceID(ServiceID);
                        }
                    }
                }
            }

            TinhTongTien();
        }
    }
}

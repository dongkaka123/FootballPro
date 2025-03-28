using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using FootballPro.DAL;
using FootballPro.Entity;
using Menu = FootballPro.Entity.Menu;

namespace FootballPro
{
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
            LoadInfo();
            LoadTable();
        }

        private void ChangeForm_Click(object sender, EventArgs e)
        {
            List<Panel> panels = new List<Panel> { pnlHome, pnlAdmin, pnlUser, pnlOrder, pnlCheckOut, pnlHelp };

            UIHelper.ChangePanelColor(sender, panels, UIHelper.userNameFromLogin, this);
        }

        void LoadInfo()
        {
            Account acc = UIHelper.userNameFromLogin;
            lblDisplayName.Text = acc.DisPlayName.ToString();
            pnlOrder.BackColor = Color.FromArgb(255, 102, 196);
        }

        void LoadTable()
        {
            flpTable.Controls.Clear();
            List<FootballPro.Entity.San> sanList = SanDAL.Instance.LoadSanList();

            foreach (FootballPro.Entity.San item in sanList)
            {
                Button btn = new Button() { Width = SanDAL.SanWidth, Height = SanDAL.SanHeight };

                btn.Text = item.Name + Environment.NewLine + item.Status;

                btn.Click += Btn_Click;
                btn.Tag = item;

                if (item.Status == "Trống")
                {
                    btn.BackColor = Color.FromArgb(195, 202, 209);
                }
                else
                {
                    btn.BackColor = Color.FromArgb(232, 145, 157);
                }

                btn.Font = new Font("Paytone One", 10, FontStyle.Regular);
                flpTable.Controls.Add(btn);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            int sanID = ((sender as Button).Tag as FootballPro.Entity.San).ID;
            UIHelper.sanIDDatSan = sanID;
            lsvBill.Tag = (sender as Button).Tag;

            ShowBill(sanID);
        }

        void ShowBill(int id)
        {
            lsvBill.Items.Clear();
            float totalPrice = 0;
            List<Entity.Menu> listBillInfo = MenuDAL.Instance.GetListMenuBySan(id);
            foreach (Menu item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.serName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.gia.ToString());
                lsvItem.SubItems.Add(item.tongTien.ToString());

                totalPrice += item.tongTien;

                lsvBill.Items.Add(lsvItem);

            }
            CultureInfo culture = new CultureInfo("vi-VN");

            lblTotalPrice.Text = totalPrice.ToString("c", culture);
        }

        private void Order_Load(object sender, EventArgs e)
        {
            UIHelper.GlobalTimer.Tick += UpdateTimeLabel;
        }

        private void UpdateTimeLabel(object sender, EventArgs e)
        {
            lblTime.Text = UIHelper.CurrentTime;
        }

        private void Order_FormClosing(object sender, FormClosingEventArgs e)
        {
            UIHelper.GlobalTimer.Tick -= UpdateTimeLabel;
        }

        private void panel9_MouseDown(object sender, MouseEventArgs e)
        {
            UIHelper.MoveWindow(this, e);
        }

        private void label16_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label15_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnDatMon_Click(object sender, EventArgs e)
        {
            San table = lsvBill.Tag as San;

            if (table == null)
            {
                MessageBox.Show("Vui lòng chọn sân!", "Thông báo");
                return;
            }

            UIHelper.SaveFormPosition(this);
            OrderService f = new OrderService();
            UIHelper.RestoreFormPosition(f);
            f.Show();
            this.Close();
        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGopBan_Click(object sender, EventArgs e)
        {

        }
    }
}

using DevExpress.CodeParser;

namespace FootballPro
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblExit = new System.Windows.Forms.Label();
            this.lblHiden = new System.Windows.Forms.Label();
            this.lblLogOut = new System.Windows.Forms.Label();
            this.lblAcountInfo = new System.Windows.Forms.Label();
            this.lblDisplayName = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlHome = new System.Windows.Forms.Panel();
            this.lblHome = new System.Windows.Forms.Label();
            this.pnlAdmin = new System.Windows.Forms.Panel();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.pnlUser = new System.Windows.Forms.Panel();
            this.lblUser = new System.Windows.Forms.Label();
            this.pnlOrder = new System.Windows.Forms.Panel();
            this.lblOrder = new System.Windows.Forms.Label();
            this.pnlCheckOut = new System.Windows.Forms.Panel();
            this.lblCheckOut = new System.Windows.Forms.Label();
            this.pnlHelp = new System.Windows.Forms.Panel();
            this.lblHelp = new System.Windows.Forms.Label();
            this.pnlBan = new System.Windows.Forms.Panel();
            this.lblNumOfBan = new System.Windows.Forms.Label();
            this.lblSan = new System.Windows.Forms.Label();
            this.fpnlInfo = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlThucUong = new System.Windows.Forms.Panel();
            this.lblNumOfThucUong = new System.Windows.Forms.Label();
            this.lblDichVu = new System.Windows.Forms.Label();
            this.pnlPhanLoai = new System.Windows.Forms.Panel();
            this.lblNumOfPhanLoai = new System.Windows.Forms.Label();
            this.lblPhanLoai = new System.Windows.Forms.Label();
            this.fpnlPictureShop = new System.Windows.Forms.FlowLayoutPanel();
            this.pbPictureShopLeft = new System.Windows.Forms.PictureBox();
            this.pbPictureShopRight = new System.Windows.Forms.PictureBox();
            this.pnlHeader.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnlHome.SuspendLayout();
            this.pnlAdmin.SuspendLayout();
            this.pnlUser.SuspendLayout();
            this.pnlOrder.SuspendLayout();
            this.pnlCheckOut.SuspendLayout();
            this.pnlHelp.SuspendLayout();
            this.pnlBan.SuspendLayout();
            this.fpnlInfo.SuspendLayout();
            this.pnlThucUong.SuspendLayout();
            this.pnlPhanLoai.SuspendLayout();
            this.fpnlPictureShop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPictureShopLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPictureShopRight)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(80)))));
            this.pnlHeader.Controls.Add(this.lblExit);
            this.pnlHeader.Controls.Add(this.lblHiden);
            this.pnlHeader.Controls.Add(this.lblLogOut);
            this.pnlHeader.Controls.Add(this.lblAcountInfo);
            this.pnlHeader.Controls.Add(this.lblDisplayName);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1710, 200);
            this.pnlHeader.TabIndex = 0;
            this.pnlHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // lblExit
            // 
            this.lblExit.Font = new System.Drawing.Font("Paytone One", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.Color.White;
            this.lblExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblExit.Location = new System.Drawing.Point(1616, -7);
            this.lblExit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(46, 74);
            this.lblExit.TabIndex = 13;
            this.lblExit.Text = "x";
            this.lblExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // lblHiden
            // 
            this.lblHiden.Font = new System.Drawing.Font("Paytone One", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHiden.ForeColor = System.Drawing.Color.White;
            this.lblHiden.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblHiden.Location = new System.Drawing.Point(1555, 0);
            this.lblHiden.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHiden.Name = "lblHiden";
            this.lblHiden.Size = new System.Drawing.Size(63, 60);
            this.lblHiden.TabIndex = 12;
            this.lblHiden.Text = "—";
            this.lblHiden.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblHiden.Click += new System.EventHandler(this.lblHiden_Click);
            // 
            // lblLogOut
            // 
            this.lblLogOut.Font = new System.Drawing.Font("Paytone One", 12F);
            this.lblLogOut.ForeColor = System.Drawing.Color.White;
            this.lblLogOut.Image = ((System.Drawing.Image)(resources.GetObject("lblLogOut.Image")));
            this.lblLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLogOut.Location = new System.Drawing.Point(1212, 104);
            this.lblLogOut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogOut.Name = "lblLogOut";
            this.lblLogOut.Size = new System.Drawing.Size(351, 77);
            this.lblLogOut.TabIndex = 9;
            this.lblLogOut.Text = "Đăng xuất";
            this.lblLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLogOut.Click += new System.EventHandler(this.lblLogOut_Click);
            // 
            // lblAcountInfo
            // 
            this.lblAcountInfo.Font = new System.Drawing.Font("Paytone One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcountInfo.ForeColor = System.Drawing.Color.White;
            this.lblAcountInfo.Image = ((System.Drawing.Image)(resources.GetObject("lblAcountInfo.Image")));
            this.lblAcountInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAcountInfo.Location = new System.Drawing.Point(1212, 0);
            this.lblAcountInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAcountInfo.Name = "lblAcountInfo";
            this.lblAcountInfo.Size = new System.Drawing.Size(439, 77);
            this.lblAcountInfo.TabIndex = 6;
            this.lblAcountInfo.Text = "Thông tin tài khoản";
            this.lblAcountInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAcountInfo.Click += new System.EventHandler(this.lblAcountInfo_Click);
            // 
            // lblDisplayName
            // 
            this.lblDisplayName.Font = new System.Drawing.Font("Paytone One", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(196)))));
            this.lblDisplayName.Image = ((System.Drawing.Image)(resources.GetObject("lblDisplayName.Image")));
            this.lblDisplayName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDisplayName.Location = new System.Drawing.Point(-1, 4);
            this.lblDisplayName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDisplayName.Name = "lblDisplayName";
            this.lblDisplayName.Size = new System.Drawing.Size(475, 70);
            this.lblDisplayName.TabIndex = 5;
            this.lblDisplayName.Text = "Tống Văn Đông";
            this.lblDisplayName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDisplayName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.pnlHome);
            this.flowLayoutPanel1.Controls.Add(this.pnlAdmin);
            this.flowLayoutPanel1.Controls.Add(this.pnlUser);
            this.flowLayoutPanel1.Controls.Add(this.pnlOrder);
            this.flowLayoutPanel1.Controls.Add(this.pnlCheckOut);
            this.flowLayoutPanel1.Controls.Add(this.pnlHelp);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 200);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(279, 758);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // pnlHome
            // 
            this.pnlHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(147)))), ((int)(((byte)(250)))));
            this.pnlHome.Controls.Add(this.lblHome);
            this.pnlHome.Font = new System.Drawing.Font("Impact", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlHome.Location = new System.Drawing.Point(2, 2);
            this.pnlHome.Margin = new System.Windows.Forms.Padding(2);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(273, 122);
            this.pnlHome.TabIndex = 4;
            this.pnlHome.Click += new System.EventHandler(this.ChangeForm_Click);
            this.pnlHome.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHome_Paint);
            // 
            // lblHome
            // 
            this.lblHome.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblHome.Location = new System.Drawing.Point(44, 8);
            this.lblHome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(171, 88);
            this.lblHome.TabIndex = 0;
            this.lblHome.Text = "Trang chủ";
            this.lblHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblHome.Click += new System.EventHandler(this.ChangeForm_Click);
            // 
            // pnlAdmin
            // 
            this.pnlAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(147)))), ((int)(((byte)(250)))));
            this.pnlAdmin.Controls.Add(this.lblAdmin);
            this.pnlAdmin.Location = new System.Drawing.Point(2, 128);
            this.pnlAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.pnlAdmin.Name = "pnlAdmin";
            this.pnlAdmin.Size = new System.Drawing.Size(273, 124);
            this.pnlAdmin.TabIndex = 3;
            this.pnlAdmin.Click += new System.EventHandler(this.ChangeForm_Click);
            this.pnlAdmin.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAdmin_Paint);
            // 
            // lblAdmin
            // 
            this.lblAdmin.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAdmin.Location = new System.Drawing.Point(76, 0);
            this.lblAdmin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(124, 88);
            this.lblAdmin.TabIndex = 5;
            this.lblAdmin.Text = "Admin";
            this.lblAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblAdmin.Click += new System.EventHandler(this.ChangeForm_Click);
            // 
            // pnlUser
            // 
            this.pnlUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(147)))), ((int)(((byte)(250)))));
            this.pnlUser.Controls.Add(this.lblUser);
            this.pnlUser.Location = new System.Drawing.Point(2, 256);
            this.pnlUser.Margin = new System.Windows.Forms.Padding(2);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(273, 117);
            this.pnlUser.TabIndex = 4;
            this.pnlUser.Click += new System.EventHandler(this.ChangeForm_Click);
            // 
            // lblUser
            // 
            this.lblUser.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUser.Location = new System.Drawing.Point(53, 9);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(147, 88);
            this.lblUser.TabIndex = 6;
            this.lblUser.Text = "Biểu đồ";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblUser.Click += new System.EventHandler(this.ChangeForm_Click);
            // 
            // pnlOrder
            // 
            this.pnlOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(147)))), ((int)(((byte)(250)))));
            this.pnlOrder.Controls.Add(this.lblOrder);
            this.pnlOrder.Location = new System.Drawing.Point(2, 377);
            this.pnlOrder.Margin = new System.Windows.Forms.Padding(2);
            this.pnlOrder.Name = "pnlOrder";
            this.pnlOrder.Size = new System.Drawing.Size(273, 128);
            this.pnlOrder.TabIndex = 4;
            this.pnlOrder.Click += new System.EventHandler(this.ChangeForm_Click);
            // 
            // lblOrder
            // 
            this.lblOrder.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblOrder.Location = new System.Drawing.Point(53, 19);
            this.lblOrder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(147, 79);
            this.lblOrder.TabIndex = 3;
            this.lblOrder.Text = "Đặt sân";
            this.lblOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblOrder.Click += new System.EventHandler(this.ChangeForm_Click);
            // 
            // pnlCheckOut
            // 
            this.pnlCheckOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(147)))), ((int)(((byte)(250)))));
            this.pnlCheckOut.Controls.Add(this.lblCheckOut);
            this.pnlCheckOut.Location = new System.Drawing.Point(2, 509);
            this.pnlCheckOut.Margin = new System.Windows.Forms.Padding(2);
            this.pnlCheckOut.Name = "pnlCheckOut";
            this.pnlCheckOut.Size = new System.Drawing.Size(273, 122);
            this.pnlCheckOut.TabIndex = 4;
            this.pnlCheckOut.Click += new System.EventHandler(this.ChangeForm_Click);
            // 
            // lblCheckOut
            // 
            this.lblCheckOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(147)))), ((int)(((byte)(250)))));
            this.lblCheckOut.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCheckOut.Location = new System.Drawing.Point(36, -2);
            this.lblCheckOut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCheckOut.Name = "lblCheckOut";
            this.lblCheckOut.Size = new System.Drawing.Size(208, 123);
            this.lblCheckOut.TabIndex = 2;
            this.lblCheckOut.Text = "Thanh toán";
            this.lblCheckOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCheckOut.Click += new System.EventHandler(this.ChangeForm_Click);
            // 
            // pnlHelp
            // 
            this.pnlHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(147)))), ((int)(((byte)(250)))));
            this.pnlHelp.Controls.Add(this.lblHelp);
            this.pnlHelp.Location = new System.Drawing.Point(2, 635);
            this.pnlHelp.Margin = new System.Windows.Forms.Padding(2);
            this.pnlHelp.Name = "pnlHelp";
            this.pnlHelp.Size = new System.Drawing.Size(273, 123);
            this.pnlHelp.TabIndex = 4;
            this.pnlHelp.Click += new System.EventHandler(this.ChangeForm_Click);
            // 
            // lblHelp
            // 
            this.lblHelp.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblHelp.Location = new System.Drawing.Point(37, 9);
            this.lblHelp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(163, 88);
            this.lblHelp.TabIndex = 1;
            this.lblHelp.Text = "Trợ giúp";
            this.lblHelp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblHelp.Click += new System.EventHandler(this.ChangeForm_Click);
            // 
            // pnlBan
            // 
            this.pnlBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(23)))), ((int)(((byte)(235)))));
            this.pnlBan.Controls.Add(this.lblNumOfBan);
            this.pnlBan.Controls.Add(this.lblSan);
            this.pnlBan.Location = new System.Drawing.Point(33, 8);
            this.pnlBan.Margin = new System.Windows.Forms.Padding(33, 8, 8, 8);
            this.pnlBan.Name = "pnlBan";
            this.pnlBan.Size = new System.Drawing.Size(426, 80);
            this.pnlBan.TabIndex = 3;
            this.pnlBan.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBan_Paint);
            // 
            // lblNumOfBan
            // 
            this.lblNumOfBan.Font = new System.Drawing.Font("Paytone One", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOfBan.ForeColor = System.Drawing.Color.White;
            this.lblNumOfBan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNumOfBan.Location = new System.Drawing.Point(322, 4);
            this.lblNumOfBan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumOfBan.Name = "lblNumOfBan";
            this.lblNumOfBan.Size = new System.Drawing.Size(100, 56);
            this.lblNumOfBan.TabIndex = 19;
            this.lblNumOfBan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNumOfBan.Click += new System.EventHandler(this.lblNumOfBan_Click);
            // 
            // lblSan
            // 
            this.lblSan.Font = new System.Drawing.Font("Palatino Linotype", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblSan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSan.Location = new System.Drawing.Point(97, 6);
            this.lblSan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSan.Name = "lblSan";
            this.lblSan.Size = new System.Drawing.Size(217, 58);
            this.lblSan.TabIndex = 15;
            this.lblSan.Text = "Sân bóng";
            this.lblSan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSan.Click += new System.EventHandler(this.lblSan_Click);
            // 
            // fpnlInfo
            // 
            this.fpnlInfo.BackColor = System.Drawing.Color.White;
            this.fpnlInfo.Controls.Add(this.pnlBan);
            this.fpnlInfo.Controls.Add(this.pnlThucUong);
            this.fpnlInfo.Controls.Add(this.pnlPhanLoai);
            this.fpnlInfo.Location = new System.Drawing.Point(281, 210);
            this.fpnlInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fpnlInfo.Name = "fpnlInfo";
            this.fpnlInfo.Size = new System.Drawing.Size(1429, 103);
            this.fpnlInfo.TabIndex = 4;
            // 
            // pnlThucUong
            // 
            this.pnlThucUong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(23)))), ((int)(((byte)(235)))));
            this.pnlThucUong.Controls.Add(this.lblNumOfThucUong);
            this.pnlThucUong.Controls.Add(this.lblDichVu);
            this.pnlThucUong.Location = new System.Drawing.Point(500, 8);
            this.pnlThucUong.Margin = new System.Windows.Forms.Padding(33, 8, 8, 8);
            this.pnlThucUong.Name = "pnlThucUong";
            this.pnlThucUong.Size = new System.Drawing.Size(426, 80);
            this.pnlThucUong.TabIndex = 4;
            this.pnlThucUong.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlThucUong_Paint);
            // 
            // lblNumOfThucUong
            // 
            this.lblNumOfThucUong.Font = new System.Drawing.Font("Paytone One", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOfThucUong.ForeColor = System.Drawing.Color.White;
            this.lblNumOfThucUong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNumOfThucUong.Location = new System.Drawing.Point(319, 3);
            this.lblNumOfThucUong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumOfThucUong.Name = "lblNumOfThucUong";
            this.lblNumOfThucUong.Size = new System.Drawing.Size(94, 56);
            this.lblNumOfThucUong.TabIndex = 18;
            this.lblNumOfThucUong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNumOfThucUong.Click += new System.EventHandler(this.lblNumOfThucUong_Click);
            // 
            // lblDichVu
            // 
            this.lblDichVu.Font = new System.Drawing.Font("Palatino Linotype", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDichVu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblDichVu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDichVu.Location = new System.Drawing.Point(78, 5);
            this.lblDichVu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDichVu.Name = "lblDichVu";
            this.lblDichVu.Size = new System.Drawing.Size(233, 60);
            this.lblDichVu.TabIndex = 16;
            this.lblDichVu.Text = "Dịch vụ";
            this.lblDichVu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDichVu.Click += new System.EventHandler(this.lblDichVu_Click);
            // 
            // pnlPhanLoai
            // 
            this.pnlPhanLoai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(23)))), ((int)(((byte)(235)))));
            this.pnlPhanLoai.Controls.Add(this.lblNumOfPhanLoai);
            this.pnlPhanLoai.Controls.Add(this.lblPhanLoai);
            this.pnlPhanLoai.Location = new System.Drawing.Point(967, 8);
            this.pnlPhanLoai.Margin = new System.Windows.Forms.Padding(33, 8, 8, 8);
            this.pnlPhanLoai.Name = "pnlPhanLoai";
            this.pnlPhanLoai.Size = new System.Drawing.Size(416, 80);
            this.pnlPhanLoai.TabIndex = 4;
            // 
            // lblNumOfPhanLoai
            // 
            this.lblNumOfPhanLoai.Font = new System.Drawing.Font("Paytone One", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOfPhanLoai.ForeColor = System.Drawing.Color.White;
            this.lblNumOfPhanLoai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNumOfPhanLoai.Location = new System.Drawing.Point(334, 4);
            this.lblNumOfPhanLoai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumOfPhanLoai.Name = "lblNumOfPhanLoai";
            this.lblNumOfPhanLoai.Size = new System.Drawing.Size(68, 55);
            this.lblNumOfPhanLoai.TabIndex = 17;
            this.lblNumOfPhanLoai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPhanLoai
            // 
            this.lblPhanLoai.Font = new System.Drawing.Font("Palatino Linotype", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhanLoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblPhanLoai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPhanLoai.Location = new System.Drawing.Point(89, 2);
            this.lblPhanLoai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhanLoai.Name = "lblPhanLoai";
            this.lblPhanLoai.Size = new System.Drawing.Size(230, 62);
            this.lblPhanLoai.TabIndex = 17;
            this.lblPhanLoai.Text = "Danh mục";
            this.lblPhanLoai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPhanLoai.Click += new System.EventHandler(this.lblPhanLoai_Click);
            // 
            // fpnlPictureShop
            // 
            this.fpnlPictureShop.BackColor = System.Drawing.Color.White;
            this.fpnlPictureShop.Controls.Add(this.pbPictureShopLeft);
            this.fpnlPictureShop.Controls.Add(this.pbPictureShopRight);
            this.fpnlPictureShop.Location = new System.Drawing.Point(281, 311);
            this.fpnlPictureShop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fpnlPictureShop.Name = "fpnlPictureShop";
            this.fpnlPictureShop.Size = new System.Drawing.Size(1429, 647);
            this.fpnlPictureShop.TabIndex = 5;
            // 
            // pbPictureShopLeft
            // 
            this.pbPictureShopLeft.Image = global::FootballPro.Properties.Resources._64b00d51_99ca_4dbe_9eec_560a2db3eb1b;
            this.pbPictureShopLeft.Location = new System.Drawing.Point(4, 5);
            this.pbPictureShopLeft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbPictureShopLeft.Name = "pbPictureShopLeft";
            this.pbPictureShopLeft.Size = new System.Drawing.Size(724, 623);
            this.pbPictureShopLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPictureShopLeft.TabIndex = 0;
            this.pbPictureShopLeft.TabStop = false;
            // 
            // pbPictureShopRight
            // 
            this.pbPictureShopRight.Image = global::FootballPro.Properties.Resources._3834_HYc_viYn_KY_thuYt_Quan___Sao_chép__2_;
            this.pbPictureShopRight.Location = new System.Drawing.Point(736, 5);
            this.pbPictureShopRight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbPictureShopRight.Name = "pbPictureShopRight";
            this.pbPictureShopRight.Size = new System.Drawing.Size(659, 623);
            this.pbPictureShopRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPictureShopRight.TabIndex = 1;
            this.pbPictureShopRight.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(1710, 958);
            this.Controls.Add(this.fpnlPictureShop);
            this.Controls.Add(this.fpnlInfo);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sân bóng";
            this.Load += new System.EventHandler(this.Form02_Load);
            this.pnlHeader.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnlHome.ResumeLayout(false);
            this.pnlAdmin.ResumeLayout(false);
            this.pnlUser.ResumeLayout(false);
            this.pnlOrder.ResumeLayout(false);
            this.pnlCheckOut.ResumeLayout(false);
            this.pnlHelp.ResumeLayout(false);
            this.pnlBan.ResumeLayout(false);
            this.fpnlInfo.ResumeLayout(false);
            this.pnlThucUong.ResumeLayout(false);
            this.pnlPhanLoai.ResumeLayout(false);
            this.fpnlPictureShop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPictureShopLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPictureShopRight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel pnlHome;
        private System.Windows.Forms.Panel pnlAdmin;
        private System.Windows.Forms.Panel pnlUser;
        private System.Windows.Forms.Panel pnlOrder;
        private System.Windows.Forms.Panel pnlCheckOut;
        private System.Windows.Forms.Panel pnlHelp;
        private System.Windows.Forms.Panel pnlBan;
        private System.Windows.Forms.FlowLayoutPanel fpnlInfo;
        private System.Windows.Forms.Panel pnlThucUong;
        private System.Windows.Forms.Panel pnlPhanLoai;
        private System.Windows.Forms.FlowLayoutPanel fpnlPictureShop;
        private System.Windows.Forms.PictureBox pbPictureShopLeft;
        private System.Windows.Forms.PictureBox pbPictureShopRight;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.Label lblCheckOut;
        private System.Windows.Forms.Label lblHelp;
        //private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox4;
        private System.Windows.Forms.Label lblLogOut;
        //private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox3;
        //private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox2;
        private System.Windows.Forms.Label lblAcountInfo;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label lblHiden;
        //private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox6;
        //private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox5;
        //private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox7;
        //private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox8;
        private System.Windows.Forms.Label lblNumOfBan;
        private System.Windows.Forms.Label lblSan;
        private System.Windows.Forms.Label lblNumOfThucUong;
        private System.Windows.Forms.Label lblDichVu;
        private System.Windows.Forms.Label lblNumOfPhanLoai;
        private System.Windows.Forms.Label lblPhanLoai;
        private System.Windows.Forms.Label lblDisplayName;
        private System.Windows.Forms.Label lblUser;
    }
}


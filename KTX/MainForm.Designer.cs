
namespace KTX
{
    partial class MainForm
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnMiximize = new FontAwesome.Sharp.IconButton();
            this.btnMaximize = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.btnDangXuat = new FontAwesome.Sharp.IconButton();
            this.labelNV = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btnBaoTri = new FontAwesome.Sharp.IconButton();
            this.btnCTViPham = new FontAwesome.Sharp.IconButton();
            this.btnLoaiViPham = new FontAwesome.Sharp.IconButton();
            this.btnQuanLyViPham = new FontAwesome.Sharp.IconButton();
            this.btnThietBi = new FontAwesome.Sharp.IconButton();
            this.btnDienNuoc = new FontAwesome.Sharp.IconButton();
            this.btnChiTietPhong = new FontAwesome.Sharp.IconButton();
            this.btnThietBiPhong = new FontAwesome.Sharp.IconButton();
            this.iconButton6 = new FontAwesome.Sharp.IconButton();
            this.btnQuanLyHopDong = new FontAwesome.Sharp.IconButton();
            this.btnQuanLyPhong = new FontAwesome.Sharp.IconButton();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.PaleVioletRed;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(216, 82);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1344, 715);
            this.panelMain.TabIndex = 1;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelHeader.Controls.Add(this.btnMiximize);
            this.panelHeader.Controls.Add(this.btnMaximize);
            this.panelHeader.Controls.Add(this.btnExit);
            this.panelHeader.Controls.Add(this.btnDangXuat);
            this.panelHeader.Controls.Add(this.labelNV);
            this.panelHeader.Controls.Add(this.iconPictureBox1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(216, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1344, 82);
            this.panelHeader.TabIndex = 2;
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
            // 
            // btnMiximize
            // 
            this.btnMiximize.BackColor = System.Drawing.Color.Transparent;
            this.btnMiximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMiximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMiximize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMiximize.IconColor = System.Drawing.Color.Black;
            this.btnMiximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMiximize.Location = new System.Drawing.Point(1113, 0);
            this.btnMiximize.Name = "btnMiximize";
            this.btnMiximize.Size = new System.Drawing.Size(77, 82);
            this.btnMiximize.TabIndex = 3;
            this.btnMiximize.UseVisualStyleBackColor = false;
            this.btnMiximize.Click += new System.EventHandler(this.btnMiximize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaximize.IconColor = System.Drawing.Color.Black;
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximize.Location = new System.Drawing.Point(1190, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(77, 82);
            this.btnMaximize.TabIndex = 3;
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnExit.IconColor = System.Drawing.Color.Red;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.Location = new System.Drawing.Point(1267, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(77, 82);
            this.btnExit.TabIndex = 3;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.Transparent;
            this.btnDangXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangXuat.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.btnDangXuat.IconColor = System.Drawing.Color.Red;
            this.btnDangXuat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDangXuat.Location = new System.Drawing.Point(395, 0);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(172, 82);
            this.btnDangXuat.TabIndex = 2;
            this.btnDangXuat.Text = "Đăng Xuất";
            this.btnDangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // labelNV
            // 
            this.labelNV.AutoEllipsis = true;
            this.labelNV.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNV.Location = new System.Drawing.Point(88, 0);
            this.labelNV.Name = "labelNV";
            this.labelNV.Size = new System.Drawing.Size(307, 82);
            this.labelNV.TabIndex = 1;
            this.labelNV.Text = "label1";
            this.labelNV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelNV.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.iconPictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 82;
            this.iconPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(88, 82);
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelMenu.Controls.Add(this.iconButton1);
            this.panelMenu.Controls.Add(this.btnBaoTri);
            this.panelMenu.Controls.Add(this.btnCTViPham);
            this.panelMenu.Controls.Add(this.btnLoaiViPham);
            this.panelMenu.Controls.Add(this.btnQuanLyViPham);
            this.panelMenu.Controls.Add(this.btnThietBi);
            this.panelMenu.Controls.Add(this.btnDienNuoc);
            this.panelMenu.Controls.Add(this.btnChiTietPhong);
            this.panelMenu.Controls.Add(this.btnThietBiPhong);
            this.panelMenu.Controls.Add(this.iconButton6);
            this.panelMenu.Controls.Add(this.btnQuanLyHopDong);
            this.panelMenu.Controls.Add(this.btnQuanLyPhong);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(216, 797);
            this.panelMenu.TabIndex = 3;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Transparent;
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.ChartPie;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 869);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(195, 79);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.Tag = "CV01,CV02";
            this.iconButton1.Text = "Thống kê";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // btnBaoTri
            // 
            this.btnBaoTri.BackColor = System.Drawing.Color.Transparent;
            this.btnBaoTri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBaoTri.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBaoTri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaoTri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoTri.IconChar = FontAwesome.Sharp.IconChar.ChartPie;
            this.btnBaoTri.IconColor = System.Drawing.Color.Black;
            this.btnBaoTri.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBaoTri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaoTri.Location = new System.Drawing.Point(0, 790);
            this.btnBaoTri.Name = "btnBaoTri";
            this.btnBaoTri.Size = new System.Drawing.Size(195, 79);
            this.btnBaoTri.TabIndex = 0;
            this.btnBaoTri.Tag = "CV01,CV02,CV05";
            this.btnBaoTri.Text = "Bảo trì";
            this.btnBaoTri.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBaoTri.UseVisualStyleBackColor = false;
            this.btnBaoTri.Click += new System.EventHandler(this.btnBaoTri_Click);
            // 
            // btnCTViPham
            // 
            this.btnCTViPham.BackColor = System.Drawing.Color.Transparent;
            this.btnCTViPham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCTViPham.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCTViPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCTViPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCTViPham.IconChar = FontAwesome.Sharp.IconChar.ChartPie;
            this.btnCTViPham.IconColor = System.Drawing.Color.Black;
            this.btnCTViPham.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCTViPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCTViPham.Location = new System.Drawing.Point(0, 711);
            this.btnCTViPham.Name = "btnCTViPham";
            this.btnCTViPham.Size = new System.Drawing.Size(195, 79);
            this.btnCTViPham.TabIndex = 0;
            this.btnCTViPham.Tag = "CV01,CV05";
            this.btnCTViPham.Text = "Chi tiết vi phạm";
            this.btnCTViPham.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCTViPham.UseVisualStyleBackColor = false;
            this.btnCTViPham.Click += new System.EventHandler(this.btnCTViPham_Click);
            // 
            // btnLoaiViPham
            // 
            this.btnLoaiViPham.BackColor = System.Drawing.Color.Transparent;
            this.btnLoaiViPham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoaiViPham.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLoaiViPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoaiViPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoaiViPham.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.btnLoaiViPham.IconColor = System.Drawing.Color.Black;
            this.btnLoaiViPham.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLoaiViPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoaiViPham.Location = new System.Drawing.Point(0, 632);
            this.btnLoaiViPham.Name = "btnLoaiViPham";
            this.btnLoaiViPham.Size = new System.Drawing.Size(195, 79);
            this.btnLoaiViPham.TabIndex = 0;
            this.btnLoaiViPham.Tag = "CV01,CV05";
            this.btnLoaiViPham.Text = "Loại vi phạm";
            this.btnLoaiViPham.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoaiViPham.UseVisualStyleBackColor = false;
            this.btnLoaiViPham.Click += new System.EventHandler(this.btnLoaiViPham_Click);
            // 
            // btnQuanLyViPham
            // 
            this.btnQuanLyViPham.BackColor = System.Drawing.Color.Transparent;
            this.btnQuanLyViPham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuanLyViPham.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuanLyViPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyViPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyViPham.IconChar = FontAwesome.Sharp.IconChar.Clipboard;
            this.btnQuanLyViPham.IconColor = System.Drawing.Color.Black;
            this.btnQuanLyViPham.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQuanLyViPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyViPham.Location = new System.Drawing.Point(0, 553);
            this.btnQuanLyViPham.Name = "btnQuanLyViPham";
            this.btnQuanLyViPham.Size = new System.Drawing.Size(195, 79);
            this.btnQuanLyViPham.TabIndex = 0;
            this.btnQuanLyViPham.Tag = "CV01,CV05";
            this.btnQuanLyViPham.Text = "Quản lý vi phạm";
            this.btnQuanLyViPham.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuanLyViPham.UseVisualStyleBackColor = false;
            this.btnQuanLyViPham.Click += new System.EventHandler(this.btnQuanLyViPham_Click);
            // 
            // btnThietBi
            // 
            this.btnThietBi.BackColor = System.Drawing.Color.Transparent;
            this.btnThietBi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThietBi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThietBi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThietBi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThietBi.IconChar = FontAwesome.Sharp.IconChar.Briefcase;
            this.btnThietBi.IconColor = System.Drawing.Color.Black;
            this.btnThietBi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThietBi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThietBi.Location = new System.Drawing.Point(0, 474);
            this.btnThietBi.Name = "btnThietBi";
            this.btnThietBi.Size = new System.Drawing.Size(195, 79);
            this.btnThietBi.TabIndex = 0;
            this.btnThietBi.Tag = "CV01,CV05,CV03";
            this.btnThietBi.Text = "Quản lý thiết bị";
            this.btnThietBi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThietBi.UseVisualStyleBackColor = false;
            this.btnThietBi.Click += new System.EventHandler(this.btnThietBi_Click);
            // 
            // btnDienNuoc
            // 
            this.btnDienNuoc.BackColor = System.Drawing.Color.Transparent;
            this.btnDienNuoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDienNuoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDienNuoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDienNuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDienNuoc.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            this.btnDienNuoc.IconColor = System.Drawing.Color.Black;
            this.btnDienNuoc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDienNuoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDienNuoc.Location = new System.Drawing.Point(0, 395);
            this.btnDienNuoc.Name = "btnDienNuoc";
            this.btnDienNuoc.Size = new System.Drawing.Size(195, 79);
            this.btnDienNuoc.TabIndex = 0;
            this.btnDienNuoc.Tag = "CV01,CV05,CV02";
            this.btnDienNuoc.Text = "Điện nước";
            this.btnDienNuoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDienNuoc.UseVisualStyleBackColor = false;
            this.btnDienNuoc.Click += new System.EventHandler(this.btnDienNuoc_Click);
            // 
            // btnChiTietPhong
            // 
            this.btnChiTietPhong.BackColor = System.Drawing.Color.Transparent;
            this.btnChiTietPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChiTietPhong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChiTietPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChiTietPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChiTietPhong.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.btnChiTietPhong.IconColor = System.Drawing.Color.Black;
            this.btnChiTietPhong.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnChiTietPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChiTietPhong.Location = new System.Drawing.Point(0, 316);
            this.btnChiTietPhong.Name = "btnChiTietPhong";
            this.btnChiTietPhong.Size = new System.Drawing.Size(195, 79);
            this.btnChiTietPhong.TabIndex = 0;
            this.btnChiTietPhong.Tag = "CV01,CV05";
            this.btnChiTietPhong.Text = "Chi tiết phòng";
            this.btnChiTietPhong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChiTietPhong.UseVisualStyleBackColor = false;
            this.btnChiTietPhong.Click += new System.EventHandler(this.btnChiTietPhong_Click);
            // 
            // btnThietBiPhong
            // 
            this.btnThietBiPhong.BackColor = System.Drawing.Color.Transparent;
            this.btnThietBiPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThietBiPhong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThietBiPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThietBiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThietBiPhong.IconChar = FontAwesome.Sharp.IconChar.DollyFlatbed;
            this.btnThietBiPhong.IconColor = System.Drawing.Color.Black;
            this.btnThietBiPhong.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThietBiPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThietBiPhong.Location = new System.Drawing.Point(0, 237);
            this.btnThietBiPhong.Name = "btnThietBiPhong";
            this.btnThietBiPhong.Size = new System.Drawing.Size(195, 79);
            this.btnThietBiPhong.TabIndex = 0;
            this.btnThietBiPhong.Tag = "CV01,CV05";
            this.btnThietBiPhong.Text = "Thiết bị phòng";
            this.btnThietBiPhong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThietBiPhong.UseVisualStyleBackColor = false;
            this.btnThietBiPhong.Click += new System.EventHandler(this.btnThietBiPhong_Click);
            // 
            // iconButton6
            // 
            this.iconButton6.BackColor = System.Drawing.Color.Transparent;
            this.iconButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton6.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton6.IconChar = FontAwesome.Sharp.IconChar.CreativeCommonsBy;
            this.iconButton6.IconColor = System.Drawing.Color.Black;
            this.iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton6.Location = new System.Drawing.Point(0, 158);
            this.iconButton6.Name = "iconButton6";
            this.iconButton6.Size = new System.Drawing.Size(195, 79);
            this.iconButton6.TabIndex = 0;
            this.iconButton6.Tag = "CV01,CV05";
            this.iconButton6.Text = "Quản lý sinh viên";
            this.iconButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton6.UseVisualStyleBackColor = false;
            // 
            // btnQuanLyHopDong
            // 
            this.btnQuanLyHopDong.BackColor = System.Drawing.Color.Transparent;
            this.btnQuanLyHopDong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuanLyHopDong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuanLyHopDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyHopDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyHopDong.IconChar = FontAwesome.Sharp.IconChar.FileContract;
            this.btnQuanLyHopDong.IconColor = System.Drawing.Color.Black;
            this.btnQuanLyHopDong.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQuanLyHopDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyHopDong.Location = new System.Drawing.Point(0, 79);
            this.btnQuanLyHopDong.Name = "btnQuanLyHopDong";
            this.btnQuanLyHopDong.Size = new System.Drawing.Size(195, 79);
            this.btnQuanLyHopDong.TabIndex = 0;
            this.btnQuanLyHopDong.Tag = "CV01,CV05,CV02";
            this.btnQuanLyHopDong.Text = "Quản lý hợp đồng";
            this.btnQuanLyHopDong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuanLyHopDong.UseVisualStyleBackColor = false;
            // 
            // btnQuanLyPhong
            // 
            this.btnQuanLyPhong.BackColor = System.Drawing.Color.Transparent;
            this.btnQuanLyPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuanLyPhong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuanLyPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyPhong.IconChar = FontAwesome.Sharp.IconChar.Procedures;
            this.btnQuanLyPhong.IconColor = System.Drawing.Color.Black;
            this.btnQuanLyPhong.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQuanLyPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyPhong.Location = new System.Drawing.Point(0, 0);
            this.btnQuanLyPhong.Name = "btnQuanLyPhong";
            this.btnQuanLyPhong.Size = new System.Drawing.Size(195, 79);
            this.btnQuanLyPhong.TabIndex = 0;
            this.btnQuanLyPhong.Tag = "CV01,CV05";
            this.btnQuanLyPhong.Text = "Quản lý phòng";
            this.btnQuanLyPhong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuanLyPhong.UseVisualStyleBackColor = false;
            this.btnQuanLyPhong.Click += new System.EventHandler(this.btnQuanLyPhong_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1560, 797);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelHeader;
        private FontAwesome.Sharp.IconButton btnMiximize;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnDangXuat;
        private System.Windows.Forms.Label labelNV;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnQuanLyViPham;
        private FontAwesome.Sharp.IconButton btnThietBi;
        private FontAwesome.Sharp.IconButton btnDienNuoc;
        private FontAwesome.Sharp.IconButton btnQuanLyHopDong;
        private FontAwesome.Sharp.IconButton btnQuanLyPhong;
        private FontAwesome.Sharp.IconButton iconButton6;
        private FontAwesome.Sharp.IconButton btnChiTietPhong;
        private FontAwesome.Sharp.IconButton btnThietBiPhong;
        private FontAwesome.Sharp.IconButton btnCTViPham;
        private FontAwesome.Sharp.IconButton btnLoaiViPham;
        public System.Windows.Forms.Panel panelMain;
        private FontAwesome.Sharp.IconButton btnBaoTri;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}
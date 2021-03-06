using FontAwesome.Sharp;
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
using DAL;
using BLL;

namespace KTX
{
    public partial class MainForm : Form
    {
        NhanVienBLL NhanVienBus = new NhanVienBLL();
        NHANVIEN nvhientai;
        
        ChucVuBLL ChucVuBus = new ChucVuBLL();        
        

        IconButton currentButton = null;
        Panel leftBorder = null;
        Form currentForm = null;

        //string tk;
        public MainForm(NHANVIEN nv)
        {
            InitializeComponent();
            leftBorder = new Panel();
            leftBorder.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorder);
            reset();
            this.nvhientai = nv;
            
        }
        
        struct myColors
        {
            public static Color color1 = Color.FromArgb(24, 161, 251);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
        }
        void activeButton(object sender, Color color)
        {
            if (sender != null)
            {

                DisableButton();

                currentButton = sender as IconButton;
                currentButton.BackColor = panelMenu.BackColor;
                currentButton.ForeColor = color;
                currentButton.IconColor = color;
                currentButton.TextAlign = ContentAlignment.MiddleCenter;
                currentButton.ImageAlign = ContentAlignment.MiddleRight;
                currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;


                leftBorder.Height = currentButton.Height;
                leftBorder.BackColor = color;
                leftBorder.Location = new Point(0, currentButton.Location.Y);
                leftBorder.Visible = true;
                leftBorder.BringToFront();
            }
        }

        private void DisableButton()
        {
            if (currentButton != null)
            {
                currentButton.BackColor = panelMenu.BackColor;
                currentButton.IconColor = Color.Black;
                currentButton.ForeColor = Color.Black;
                currentButton.TextAlign = ContentAlignment.MiddleLeft;
                currentButton.ImageAlign = ContentAlignment.MiddleLeft;
                currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                leftBorder.Visible = false;

            }
        }
        void reset()
        {
            panelMenu.VerticalScroll.Value = 0;
            DisableButton();
            if (currentForm != null)
                currentForm.Close();

        }
        private void openForm(Form form)
        {
            if (currentForm != null)
                currentForm.Close();
            currentForm = form;
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            panelMain.Controls.Add(form);
            form.Show();
            form.BringToFront();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
            else
                WindowState = FormWindowState.Maximized;
        }

        private void btnMiximize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void dangNhap()
        {
            //DangNhapForm f = new DangNhapForm();
            //f.go = getData;
            //this.Hide();
            //if (f.ShowDialog() == DialogResult.No)
            //{
            //    this.Close();
            //}
            //else
            //{
                this.Show();
                labelNV.Text = nvhientai.TenNV;                

                CHUCVU cv = ChucVuBus.layChucVuNhanVien(nvhientai.MaCV);
                if (cv.MaCV != "cv01")
                {
                    foreach (Control ctrl in panelMenu.Controls)
                    {
                        if (ctrl.Tag != null)
                        {
                            if (ctrl.Tag.ToString().Contains(cv.MaCV.ToString()))
                            {
                                ctrl.Visible = true;
                            }
                            else
                            {
                                ctrl.Visible = false;
                            }
                        }

                    }
                }
                else
                {
                    foreach (Control ctrl in panelMenu.Controls)
                    {
                        ctrl.Visible = true;
                    }
                }
                leftBorder.Visible = false;
            //}
        }

        private void btnQuanLyPhong_Click(object sender, EventArgs e)
        {
            activeButton(sender, myColors.color1);
            openForm(new PhongForm());
        }

        private void btnChiTietPhong_Click(object sender, EventArgs e)
        {
            activeButton(sender, myColors.color2);
            openForm(new CTPhongForm());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Show();
            labelNV.Text = nvhientai.TenNV;

            CHUCVU cv = ChucVuBus.layChucVuNhanVien(nvhientai.MaCV);
            if (cv.MaCV != "cv01")
            {
                foreach (Control ctrl in panelMenu.Controls)
                {
                    if (ctrl.Tag != null)
                    {
                        if (ctrl.Tag.ToString().Contains(cv.MaCV.ToString()))
                        {
                            ctrl.Visible = true;
                        }
                        else
                        {
                            ctrl.Visible = false;
                        }
                    }

                }
            }
            else
            {
                foreach (Control ctrl in panelMenu.Controls)
                {
                    ctrl.Visible = true;
                }
            }
            leftBorder.Visible = false;
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DangNhapForm d = new DangNhapForm();
            d.Show();
            this.Close();
            //if ((MessageBox.Show("Bạn có muốn đăng xuất", "Đăng xuất?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.OK)
            //{
            //    DangNhapForm d = new DangNhapForm();
            //    d.Show();
            //    this.Close();
            //}
        }

        private void btnThietBi_Click(object sender, EventArgs e)
        {
            activeButton(sender, myColors.color3);
            openForm(new ThietBiForm());
        }

        private void btnThietBiPhong_Click(object sender, EventArgs e)
        {
            activeButton(sender, myColors.color3);
            openForm(new ThietBiPhongForm());
        }

        private void btnLoaiViPham_Click(object sender, EventArgs e)
        {
            activeButton(sender, myColors.color4);
            openForm(new LoaiViPhamForm());
        }

        private void btnQuanLyViPham_Click(object sender, EventArgs e)
        {
            activeButton(sender, myColors.color1);
            openForm(new QuanLyViPhamForm(nvhientai));
        }

        private void btnCTViPham_Click(object sender, EventArgs e)
        {
            activeButton(sender, myColors.color2);
            openForm(new NienKhoaForm());
        }

        private void btnBaoTri_Click(object sender, EventArgs e)
        {
            activeButton(sender, myColors.color3);
            openForm(new BaoTriForm(nvhientai));
        }

        private void btnDienNuoc_Click(object sender, EventArgs e)
        {
            activeButton(sender, myColors.color3);
            openForm(new DienNuocForm(nvhientai));
        }

        private void btnQuanLyHopDong_Click(object sender, EventArgs e)
        {
            activeButton(sender, myColors.color2);
            openForm(new HopDongForm(nvhientai));
        }

        private void btnQuanLySinhVien_Click(object sender, EventArgs e)
        {
            activeButton(sender, myColors.color3);
            openForm(new SinhVienForm());
        }

        private void btnQuanLyGuiXe_Click(object sender, EventArgs e)
        {
            activeButton(sender, myColors.color3);
            openForm(new QuanLyGuiXeForm());
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;
using System.Runtime.InteropServices;

namespace KTX
{    
    public partial class DangNhapForm : Form
    {
        NhanVienBLL NhanVienBus = new NhanVienBLL();
        public delegate void getnv(NHANVIEN nv);
        public getnv go;        
        
        public DangNhapForm()
        {
            InitializeComponent();
        }
        
        

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);        

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "" || txtMatKhau.Text == "")
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin");
            }
            else if (NhanVienBus.ktDangNhap(txtTaiKhoan.Text, txtMatKhau.Text))
            {
                                                
                if (chboxNhoTaiKhoan.Checked)
                {
                    Properties.Settings.Default.taikhoan = txtTaiKhoan.Text;
                    Properties.Settings.Default.matkhau = txtMatKhau.Text;
                }
                else
                {
                    Properties.Settings.Default.taikhoan = string.Empty;
                    Properties.Settings.Default.matkhau = string.Empty;
                }
                MainForm m = new MainForm(NhanVienBus.layNhanVien(txtTaiKhoan.Text));
                //go(NhanVienBus.layNhanVien(txtTaiKhoan.Text));
                m.Show();
                Properties.Settings.Default.Save();
                //this.Close();
                this.Hide();

                
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu");
                txtTaiKhoan.Focus();
            }
        }        

        private void DangNhapForm_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.taikhoan != string.Empty)
            {
                txtTaiKhoan.Text = Properties.Settings.Default.taikhoan;
                txtMatKhau.Text = Properties.Settings.Default.matkhau;
                chboxNhoTaiKhoan.Checked = true;
            }
        }

        private void DangNhapForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

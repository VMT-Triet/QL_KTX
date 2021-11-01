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

namespace KTX
{
    public partial class ThietBiPhongForm : Form
    {
        ThietBiPhongBLL ThietBiPhongBus = new ThietBiPhongBLL();
        PhongBLL PhongBus = new PhongBLL();
        ThietBiBLL ThietBiBus = new ThietBiBLL();
        DataTable dtThietBi;
        DataTable dtPhong;
        DataTable dtTBPhong;
        bool isEdit = false;
        public ThietBiPhongForm()
        {
            InitializeComponent();
            btnLuu.Enabled = false;
            cbMaTB.Enabled = false;
            cbSoPhong.Enabled = false;
            txtSoLuong.Enabled = false;
        }
        public void LoadDSTBPhong()
        {
            dtTBPhong = ThietBiPhongBus.layDSTBPhong();
            dtPhong = PhongBus.layDSPhong();
            dtThietBi = ThietBiBus.layDSThietBi();
            dgv_ThietBiPhong.DataSource = dtTBPhong;
        }
        public void LoadCB()
        {
            cbMaTB.DataSource = dtThietBi;
            cbMaTB.DisplayMember = "TenTB";
            cbMaTB.ValueMember = "MaTB";

            cbSoPhong.DataSource = dtPhong;
            cbSoPhong.DisplayMember = "SoPhong";
            cbSoPhong.ValueMember = "SoPhong";
        }

        private void ThietBiPhongForm_Load(object sender, EventArgs e)
        {
            LoadDSTBPhong();
            LoadCB();
        }

        private void dgv_ThietBiPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgv_ThietBiPhong.Rows[e.RowIndex];
                cbMaTB.Text = row.Cells[0].Value.ToString();
                cbSoPhong.Text = row.Cells[1].Value.ToString();
                txtSoLuong.Text = (row.Cells[2].Value).ToString();
            }
            catch (Exception)
            {
                return;
            }
                  
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            isEdit = false;
            btnLuu.Enabled = true;
            cbMaTB.Enabled = true;
            cbSoPhong.Enabled = true;
            txtSoLuong.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            isEdit = true;
            btnLuu.Enabled = true;
            cbMaTB.Enabled = true;
            cbSoPhong.Enabled = true;
            txtSoLuong.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
                        
            if (txtSoLuong.TextLength == 0)
            {
                MessageBox.Show("Chưa nhập số lượng");
                txtSoLuong.Focus();
                return;
            }
            else
            {
                THIETBIPHONG tbp = new THIETBIPHONG();
                tbp.MaTB = cbMaTB.SelectedValue.ToString();
                tbp.SoPhong = cbSoPhong.SelectedValue.ToString();
                tbp.SoLuong = int.Parse(txtSoLuong.Text);                
                if (isEdit)
                {
                    if (ThietBiPhongBus.suaThietBiPhong(tbp))
                    {
                        MessageBox.Show("Sửa thiết bị phòng thành công", "Thông báo");
                        LoadDSTBPhong();
                        btnLuu.Enabled = false;
                        cbMaTB.Enabled = false;
                        cbSoPhong.Enabled = false;
                        txtSoLuong.Enabled = false;
                    }
                    else
                        MessageBox.Show("Sửa thiết bị phòng thất bại", "Thông báo");
                }
                else
                {
                    if (ThietBiPhongBus.themThietBiPhong(tbp))
                    {
                        MessageBox.Show("Thêm thiết bị phòng thành công", "Thông báo");
                        LoadDSTBPhong();
                        btnLuu.Enabled = false;
                        cbMaTB.Enabled = false;
                        cbSoPhong.Enabled = false;
                        txtSoLuong.Enabled = false;
                    }
                    else
                        MessageBox.Show("Thêm thiết bị phòng thất bại", "Thông báo");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (ThietBiPhongBus.xoaThietBiPhong(cbMaTB.SelectedValue.ToString()))
            {
                MessageBox.Show("Xóa thành công");
                LoadDSTBPhong();
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }
    }
}

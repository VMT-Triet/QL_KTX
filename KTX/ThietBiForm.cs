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
    public partial class ThietBiForm : Form
    {
        ThietBiBLL ThietBiBus = new ThietBiBLL();
        DataTable dtTB;
        bool isEdit = false;
        public ThietBiForm()
        {
            InitializeComponent();
            btnLuu.Enabled = false;
            txtMaTB.Enabled = false;
            txtTenTB.Enabled = false;
            txtSoLuong.Enabled = false;
            txtGia.Enabled = false;
        }
        public void LoadDSThietBi()
        {
            dtTB = ThietBiBus.layDSThietBi();
            dgv_ThietBi.DataSource = dtTB;
        }

        private void ThietBiForm_Load(object sender, EventArgs e)
        {
            LoadDSThietBi();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaTB.TextLength == 0)
            {
                MessageBox.Show("Chưa nhập mã thiết bị");
                txtMaTB.Focus();
                return;
            }
            else if (txtTenTB.TextLength == 0)
            {
                MessageBox.Show("Chưa nhập tên thiết bị");
                txtTenTB.Focus();
                return;
            }
            if (txtGia.TextLength == 0)
            {
                MessageBox.Show("Chưa nhập giá thiết bị");
                txtGia.Focus();
                return;
            }
            else
            {
                THIETBI tb = new THIETBI();
                tb.MaTB = txtMaTB.Text;
                tb.TenTB = txtTenTB.Text;
                tb.SoLuong = int.Parse((txtSoLuong.Text == "") ? "0" : txtSoLuong.Text);
                tb.GiaTB = float.Parse(txtGia.Text);
                if (isEdit)
                {
                    if (ThietBiBus.suaThietBi(tb))
                    {
                        MessageBox.Show("Sửa thiết bị thành công", "Thông báo");
                        LoadDSThietBi();
                        btnLuu.Enabled = false;
                        txtMaTB.Enabled = false;
                        txtTenTB.Enabled = false;
                        txtSoLuong.Enabled = false;
                        txtGia.Enabled = false;
                    }
                    else
                        MessageBox.Show("Sửa thiết bị thất bại", "Thông báo");
                }
                else
                {
                    if (ThietBiBus.themThietBi(tb))
                    {
                        MessageBox.Show("Thêm thiết bị thành công", "Thông báo");
                        LoadDSThietBi();
                        btnLuu.Enabled = false;
                        txtMaTB.Enabled = false;
                        txtTenTB.Enabled = false;
                        txtSoLuong.Enabled = false;
                        txtGia.Enabled = false;
                    }
                    else
                        MessageBox.Show("Thêm thiết bị thất bại", "Thông báo");
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            isEdit = false;
            btnLuu.Enabled = true;
            txtMaTB.Enabled = true;
            txtTenTB.Enabled = true;
            txtSoLuong.Enabled = false;
            txtGia.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            isEdit = true;
            btnLuu.Enabled = true;
            txtMaTB.Enabled = false;
            txtTenTB.Enabled = true;
            txtSoLuong.Enabled = false;
            txtGia.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (ThietBiBus.xoaThietBi(txtMaTB.Text))
            {
                MessageBox.Show("Xóa thành công");
                LoadDSThietBi();
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }
        private void timkiemThietBiDGV(DataTable dt)
        {
            string filter = "MaTB LIKE '%{0}%'";
            dt.DefaultView.RowFilter = string.Format(filter, txtSearch.Text);
            txtSearch.Text = "";
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            timkiemThietBiDGV(dtTB);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dtTB.DefaultView.RowFilter = "";

            txtMaTB.Clear();
            txtTenTB.Clear();
            txtSoLuong.Clear();
            txtGia.Clear();
        }

        private void dgv_ThietBi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgv_ThietBi.Rows[e.RowIndex];
                txtMaTB.Text = row.Cells[0].Value.ToString();
                txtTenTB.Text = row.Cells[1].Value.ToString();
                txtSoLuong.Text = (row.Cells[2].Value).ToString();
                txtGia.Text = (row.Cells[3].Value).ToString();
            }
            catch (Exception)
            {
                return;
            }
            
        }
    }
}

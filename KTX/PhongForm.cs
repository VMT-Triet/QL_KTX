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
    public partial class PhongForm : Form
    {
        PhongBLL PhongBus = new PhongBLL();
        DataTable dtPhong;
        public PhongForm()
        {
            InitializeComponent();
            btnLuu.Enabled = false;
            txtSoPhong.Enabled = false;
            txtSoLuong.Enabled = false;
            chboxTinhTrang.Enabled = false;
            txtDien.Enabled = false;
            txtNuoc.Enabled = false;
        }
        //private void hienthiThongTin(DataGridViewRow row)
        //{
        //    txtSoPhong.Text = row.Cells["SOPHONG"].Value.ToString();
        //    txtSoLuong.Text = row.Cells["SOLUONG"].Value.ToString();
        //    chboxTinhTrang.Checked = (bool)row.Cells["TINHTRANG"].Value;
        //    txtDien.Text = row.Cells["DONGHODIEN"].Value.ToString();
        //    txtNuoc.Text = row.Cells["DONGHONUOC"].Value.ToString();
        //}
        public void LoadDSPhong()
        {
            dtPhong = PhongBus.layDSPhong();
            dgv_Phong.DataSource = dtPhong;
        }
        private void PhongForm_Load(object sender, EventArgs e)
        {

            LoadDSPhong();

            //DataColumn[] key = new DataColumn[1];
            //key[0] = dtPhong.Columns["SoPhong"];
            //dtPhong.PrimaryKey = key;
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgv_Phong_CellClick(object sender, DataGridViewCellEventArgs e)
        {            
            DataGridViewRow row = new DataGridViewRow();
            try
            {
                row = dgv_Phong.Rows[e.RowIndex];
                txtSoPhong.Text = row.Cells[0].Value.ToString();
                txtSoLuong.Text = row.Cells[1].Value.ToString();
                chboxTinhTrang.Checked = (bool)row.Cells[2].Value;
                txtDien.Text = row.Cells[3].Value.ToString();
                txtNuoc.Text = row.Cells[4].Value.ToString();
            }
            catch(Exception)
            {
                return;
            }
            
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtSoPhong.Enabled = true;
            btnLuu.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (PhongBus.xoaPhong(txtSoPhong.Text))
            {
                MessageBox.Show("Xóa thành công");
                LoadDSPhong();
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }
        private void timkiemPhongDGV(DataTable dt)
        {
            string filter = "SoPhong LIKE '%{0}%'";
            dt.DefaultView.RowFilter = string.Format(filter, txtSearch.Text);
            txtSearch.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            timkiemPhongDGV(dtPhong);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dtPhong.DefaultView.RowFilter = "";
            txtSoPhong.Clear();
            txtSoLuong.Clear();
            chboxTinhTrang.Checked = false;
            txtDien.Clear();
            txtNuoc.Clear();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtSoPhong.TextLength == 0)
            {
                MessageBox.Show("Chưa nhập số phòng");
                return;
            }
            PHONG p = new PHONG();
            p.SoPhong = txtSoPhong.Text;
            p.SoLuong = 0;
            p.TinhTrang = false;
            p.DongHoDien = 0;
            p.DongHoNuoc = 0;
            if (PhongBus.themPhong(p))
            {
                MessageBox.Show("Thêm phòng thành công", "Thông báo");
                LoadDSPhong();
            }
            else
                MessageBox.Show("Thêm phòng thất bại", "Thông báo");
        }
        
    }
}

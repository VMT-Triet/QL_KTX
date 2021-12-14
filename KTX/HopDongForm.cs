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
    public partial class HopDongForm : Form
    {
        HopDongBLL HopDongBus = new HopDongBLL();
        NienKhoaBLL NienKhoaBus = new NienKhoaBLL();
        DataTable dtHopDong, dtNienKhoa;
        
        bool isEdit;
        NHANVIEN nvhientai;
        public HopDongForm(NHANVIEN nv)
        {
            InitializeComponent();
            btnLuu.Enabled = false;
            txtMaHD.Enabled = false;
            txtMaSV.Enabled = false;
            txtNV.Enabled = false;
            txtTongTien.Enabled = false;
            groupBox1.Enabled = false;

            this.nvhientai = nv;
        }
        public void LoadDS()
        {
            dtHopDong = HopDongBus.layDSHopDong();
            dgv_HopDong.DataSource = dtHopDong;
        }
        public void LoadCB()
        {
            dtNienKhoa = NienKhoaBus.layDSNienKhoa();
            cbNienKhoa.DataSource = dtNienKhoa;
            cbNienKhoa.DisplayMember = "NamHoc";
            cbNienKhoa.ValueMember = "MaNK";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            isEdit = false;
            btnLuu.Enabled = true;
            txtMaHD.Enabled = true;
            txtMaSV.Enabled = true;
            groupBox1.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            isEdit = true;
            btnLuu.Enabled = true;
            txtMaHD.Enabled = true;
            txtMaSV.Enabled = true;
            groupBox1.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string tinhtrang = "";
            if (radioButtonChamDut.Checked)
            {
                tinhtrang = "Chấm dứt";
            }
            if (radioButtonChuaChamDut.Checked)
            {
                tinhtrang = "Chưa chấm dứt";
            }
            if (txtMaHD.TextLength == 0 || txtMaSV.TextLength == 0)
            {
                MessageBox.Show("Chưa nhập đủ thông tin", "Thông báo");
                txtMaHD.Focus();
                return;
            }
            else
            {
                HOPDONG hd = new HOPDONG();
                hd.MaHopDong = txtMaHD.Text;
                hd.NgayLap = dateNgayLap.Value;
                hd.MaSV = txtMaSV.Text;
                hd.MaNV = nvhientai.MaNV;
                hd.MaNK = cbNienKhoa.SelectedValue.ToString();
                hd.TongTien = int.Parse((txtTongTien.Text == "") ? "0" : txtTongTien.Text);
                hd.TinhTrang = tinhtrang;
                if (isEdit)
                {
                    if (HopDongBus.suaHopHong(hd))
                    {
                        MessageBox.Show("Sửa hợp đồng thành công", "Thông báo");
                        LoadDS();
                        btnLuu.Enabled = false;
                        txtMaHD.Enabled = false;
                        txtMaSV.Enabled = false;
                        groupBox1.Enabled = false;

                        txtMaHD.Clear();
                        txtMaSV.Clear();
                        txtNV.Clear();
                        txtTongTien.Clear();
                        radioButtonChamDut.Checked = false;
                        radioButtonChuaChamDut.Checked = false;
                        dateNgayLap.Value = DateTime.Now;
                    }
                    else
                        MessageBox.Show("Sửa hợp đồng thất bại", "Thông báo");
                }
                else
                {
                    if (HopDongBus.themHopDong(hd))
                    {
                        MessageBox.Show("Thêm hợp đồng thành công", "Thông báo");
                        LoadDS();
                        btnLuu.Enabled = false;
                        txtMaHD.Enabled = false;
                        txtMaSV.Enabled = false;
                        groupBox1.Enabled = false;

                        txtMaHD.Clear();
                        txtMaSV.Clear();                        
                        txtNV.Clear();
                        txtTongTien.Clear();
                        radioButtonChamDut.Checked = false;
                        radioButtonChuaChamDut.Checked = false;
                        dateNgayLap.Value = DateTime.Now;
                    }
                    else
                        MessageBox.Show("Thêm hợp đồng thất bại", "Thông báo");
                }
            }
        }

        private void dgv_HopDong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgv_HopDong.Rows[e.RowIndex];
                txtMaHD.Text = row.Cells[0].Value.ToString();
                dateNgayLap.Value = DateTime.Parse(row.Cells[1].Value.ToString());
                txtMaSV.Text = row.Cells[2].Value.ToString();
                txtNV.Text = row.Cells[3].Value.ToString();
                cbNienKhoa.Text = row.Cells[4].Value.ToString();
                txtTongTien.Text = row.Cells[5].Value.ToString();
                if (row.Cells[6].Value.ToString() == "Chấm dứt")
                {
                    radioButtonChamDut.Checked = true;
                }
                if (row.Cells[6].Value.ToString() == "Chưa chấm dứt")
                {
                    radioButtonChuaChamDut.Checked = true;
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //if (HopDongBus.xoaHopDong(txtMaHD.Text))
            //{
            //    MessageBox.Show("Xóa thành công");
            //    LoadDS();
            //}
            //else
            //{
            //    MessageBox.Show("Xóa thất bại");
            //}
        }

        private void HopDongForm_Load(object sender, EventArgs e)
        {
            LoadDS();
            LoadCB();
        }
    }
}

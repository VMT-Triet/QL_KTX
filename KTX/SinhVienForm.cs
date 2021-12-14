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
    public partial class SinhVienForm : Form
    {
        SinhVienBLL SinhVienBus = new SinhVienBLL();
        NienKhoaBLL NienKhoaBus = new NienKhoaBLL();
        DataTable dtSV, dtNienKhoa;

        bool isEdit;
        public SinhVienForm()
        {
            InitializeComponent();
            btnLuu.Enabled = false;
            txtMaSV.Enabled = false;
            txtTenSV.Enabled = false;
            txtDiaChi.Enabled = false;
            txtSDT.Enabled = false;
            cbNamHoc.Enabled = false;
            dateNamSinh.Enabled = false;
            groupBox1.Enabled = false;
        }
        public void LoadDS()
        {
            dtSV = SinhVienBus.layDSSinhVien();
            dgv_SinhVien.DataSource = dtSV;
        }
        public void LoadCB()
        {
            dtNienKhoa = NienKhoaBus.layDSNienKhoa();
            cbNamHoc.DataSource = dtNienKhoa;
            cbNamHoc.DisplayMember = "NamHoc";
            cbNamHoc.ValueMember = "MaNK";
        }

        private void SinhVienForm_Load(object sender, EventArgs e)
        {
            LoadDS();
            LoadCB();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            isEdit = false;
            btnLuu.Enabled = true;
            txtMaSV.Enabled = true;
            txtTenSV.Enabled = true;
            txtDiaChi.Enabled = true;
            txtSDT.Enabled = true;
            cbNamHoc.Enabled = true;
            dateNamSinh.Enabled = true;
            groupBox1.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            isEdit = true;
            btnLuu.Enabled = true;
            txtMaSV.Enabled = true;
            txtTenSV.Enabled = true;
            txtDiaChi.Enabled = true;
            txtSDT.Enabled = true;
            cbNamHoc.Enabled = true;
            dateNamSinh.Enabled = true;
            groupBox1.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (SinhVienBus.xoaSinhVien(txtMaSV.Text))
            {
                MessageBox.Show("Xóa thành công");
                LoadDS();
                btnLuu.Enabled = false;
                txtMaSV.Enabled = false;
                txtTenSV.Enabled = false;
                txtDiaChi.Enabled = false;
                txtSDT.Enabled = false;
                cbNamHoc.Enabled = false;
                dateNamSinh.Enabled = false;
                groupBox1.Enabled = false;

                txtMaSV.Clear();
                txtTenSV.Clear();
                txtDiaChi.Clear();
                txtSDT.Clear();
                radioButtonNam.Checked = false;
                radioButtonNu.Checked = false;
                dateNamSinh.Value = DateTime.Now;
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

        private void dgv_SinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgv_SinhVien.Rows[e.RowIndex];
                txtMaSV.Text = row.Cells[0].Value.ToString();
                txtTenSV.Text = row.Cells[1].Value.ToString();
                if (row.Cells[2].Value.ToString() == "Nam")
                {
                    radioButtonNam.Checked = true;
                }
                if (row.Cells[2].Value.ToString() == "Nữ")
                {
                    radioButtonNu.Checked = true;
                }
                dateNamSinh.Value = DateTime.Parse(row.Cells[3].Value.ToString());
                txtDiaChi.Text = row.Cells[4].Value.ToString();
                txtSDT.Text = row.Cells[5].Value.ToString();
                cbNamHoc.Text = row.Cells[6].Value.ToString();                
            }
            catch (Exception)
            {
                return;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string gioitinh = "";
            if (radioButtonNam.Checked)
            {
                gioitinh = "Nam";                
            }
            if (radioButtonNu.Checked)
            {
                gioitinh = "Nữ";
            }
            if (txtMaSV.TextLength == 0 || txtTenSV.TextLength == 0 || txtSDT.TextLength == 0 || txtDiaChi.TextLength == 0)
            {
                MessageBox.Show("Chưa nhập đủ thông tin", "Thông báo");
                txtMaSV.Focus();
                return;
            }
            else
            {
                SINHVIEN sv = new SINHVIEN();
                sv.MaSV = txtMaSV.Text;
                sv.TenSV = txtTenSV.Text;
                sv.GioiTinh = gioitinh;
                sv.NamSinh = dateNamSinh.Value;
                sv.DiaChi = txtDiaChi.Text;
                sv.SDT = int.Parse(txtSDT.Text);
                sv.MaNK = cbNamHoc.SelectedValue.ToString();
                if (isEdit)
                {
                    if (SinhVienBus.suaSinhVien(sv))
                    {
                        MessageBox.Show("Sửa sinh viên thành công", "Thông báo");
                        LoadDS();
                        btnLuu.Enabled = false;
                        txtMaSV.Enabled = false;
                        txtTenSV.Enabled = false;
                        txtDiaChi.Enabled = false;
                        txtSDT.Enabled = false;
                        cbNamHoc.Enabled = false;
                        dateNamSinh.Enabled = false;
                        groupBox1.Enabled = false;

                        txtMaSV.Clear();
                        txtTenSV.Clear();
                        txtDiaChi.Clear();
                        txtSDT.Clear();
                        radioButtonNam.Checked = false;
                        radioButtonNu.Checked = false;
                        dateNamSinh.Value = DateTime.Now;
                    }
                    else
                        MessageBox.Show("Sửa sinh viên thất bại", "Thông báo");
                }
                else
                {
                    if (SinhVienBus.themSinhVien(sv))
                    {
                        MessageBox.Show("Thêm sinh viên thành công", "Thông báo");
                        LoadDS();
                        btnLuu.Enabled = false;
                        txtMaSV.Enabled = false;
                        txtTenSV.Enabled = false;
                        txtDiaChi.Enabled = false;
                        txtSDT.Enabled = false;
                        cbNamHoc.Enabled = false;
                        dateNamSinh.Enabled = false;
                        groupBox1.Enabled = false;

                        txtMaSV.Clear();
                        txtTenSV.Clear();
                        txtDiaChi.Clear();
                        txtSDT.Clear();
                        radioButtonNam.Checked = false;
                        radioButtonNu.Checked = false;
                        dateNamSinh.Value = DateTime.Now;
                    }
                    else
                        MessageBox.Show("Thêm sinh viên thất bại", "Thông báo");
                }
            }
        }
    }
}

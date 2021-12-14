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
    public partial class NienKhoaForm : Form
    {
        NienKhoaBLL NienKhoaBus = new NienKhoaBLL();
        DataTable dtNienKhoa;

        bool isEdit;
        public NienKhoaForm()
        {
            InitializeComponent();
            btnLuu.Enabled = false;
            txtMaNK.Enabled = false;
            txtNamHoc.Enabled = false;
            txtPhiThue.Enabled = false;
        }
        public void LoadDS()
        {
            dtNienKhoa = NienKhoaBus.layDSNienKhoa();
            dgv_NienKhoa.DataSource = dtNienKhoa;
        }       

        private void NienKhoaForm_Load(object sender, EventArgs e)
        {
            LoadDS();           
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            isEdit = false;
            btnLuu.Enabled = true;
            txtMaNK.Enabled = true;
            txtNamHoc.Enabled = true;
            txtPhiThue.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            isEdit = true;
            btnLuu.Enabled = true;
            txtMaNK.Enabled = true;
            txtNamHoc.Enabled = true;
            txtPhiThue.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaNK.TextLength == 0 || txtNamHoc.TextLength == 0 || txtPhiThue.TextLength == 0)
            {
                MessageBox.Show("Chưa nhập đủ thông tin", "Thông báo");
                txtMaNK.Focus();
                return;
            }
            else
            {
                NIENKHOA nk = new NIENKHOA();
                nk.MaNK = txtMaNK.Text;
                nk.NamHoc = txtNamHoc.Text;
                nk.NgayBD = dateNgayBD.Value;
                nk.NgayKT = dateNgayKT.Value;
                nk.PhiThue = float.Parse(txtPhiThue.Text);  
                if (isEdit)
                {
                    if (NienKhoaBus.suaNienKhoa(nk))
                    {
                        MessageBox.Show("Sửa niên khóa thành công", "Thông báo");
                        LoadDS();
                        btnLuu.Enabled = false;
                        txtMaNK.Enabled = false;
                        txtNamHoc.Enabled = false;
                        txtPhiThue.Enabled = false;

                        txtMaNK.Clear();
                        txtNamHoc.Clear();
                        txtPhiThue.Clear();
                        dateNgayBD.Value = DateTime.Now;
                        dateNgayKT.Value = DateTime.Now;
                    }
                    else
                        MessageBox.Show("Sửa niên khóa thất bại", "Thông báo");
                }
                else
                {
                    if (NienKhoaBus.themNienKhoa(nk))
                    {
                        MessageBox.Show("Thêm niên khóa thành công", "Thông báo");
                        LoadDS();
                        btnLuu.Enabled = false;
                        txtMaNK.Enabled = false;
                        txtNamHoc.Enabled = false;
                        txtPhiThue.Enabled = false;

                        txtMaNK.Clear();
                        txtNamHoc.Clear();
                        txtPhiThue.Clear();
                        dateNgayBD.Value = DateTime.Now;
                        dateNgayKT.Value = DateTime.Now;
                    }
                    else
                        MessageBox.Show("Thêm niên khóa thất bại", "Thông báo");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (NienKhoaBus.xoaNienKhoa(txtMaNK.Text))
            {
                MessageBox.Show("Xóa thành công");
                LoadDS();
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

        private void dgv_NienKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgv_NienKhoa.Rows[e.RowIndex];
                txtMaNK.Text = row.Cells[0].Value.ToString();
                txtNamHoc.Text = row.Cells[1].Value.ToString();
                dateNgayBD.Value = DateTime.Parse(row.Cells[2].Value.ToString());
                dateNgayKT.Value = DateTime.Parse(row.Cells[3].Value.ToString());
                txtPhiThue.Text = row.Cells[4].Value.ToString();
            }
            catch (Exception)
            {
                return;
            }
        }
    }
}

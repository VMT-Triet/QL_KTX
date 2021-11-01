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
    public partial class LoaiViPhamForm : Form
    {
        LoaiViPhamBLL LoaiViPhamBus = new LoaiViPhamBLL();
        DataTable dtLoaiViPham;
        bool isEdit = false;
        public LoaiViPhamForm()
        {
            InitializeComponent();
            btnLuu.Enabled = false;
            txtMaLoaiViPham.Enabled = false;
            txtTenLoaiViPham.Enabled = false;
            txtMucDo.Enabled = false;
        }
        public void LoadDS()
        {
            dtLoaiViPham = LoaiViPhamBus.layDSLoaiViPham();
            dgv_LoaiViPham.DataSource = dtLoaiViPham;
        }

        private void LoaiViPhamForm_Load(object sender, EventArgs e)
        {
            LoadDS();
        }

        private void dgv_LoaiViPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgv_LoaiViPham.Rows[e.RowIndex];
                txtMaLoaiViPham.Text = row.Cells[0].Value.ToString();
                txtTenLoaiViPham.Text = row.Cells[1].Value.ToString();
                txtMucDo.Text = row.Cells[2].Value.ToString();
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
            txtMaLoaiViPham.Enabled = true;
            txtTenLoaiViPham.Enabled = true;
            txtMucDo.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            isEdit = true;
            btnLuu.Enabled = true;
            txtMaLoaiViPham.Enabled = true;
            txtTenLoaiViPham.Enabled = true;
            txtMucDo.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaLoaiViPham.TextLength == 0)
            {
                MessageBox.Show("Chưa nhập mã loại vi phạm");
                return;
            }
            if (txtTenLoaiViPham.TextLength == 0)
            {
                MessageBox.Show("Chưa nhập tên loại vi phạm");
                return;
            }
            if (txtMucDo.TextLength == 0)
            {
                MessageBox.Show("Chưa nhập mức độ loại vi phạm");
                return;
            }
            else
            {
                LOAIVIPHAM lvp = new LOAIVIPHAM();
                lvp.MaLoaiVP = txtMaLoaiViPham.Text;
                lvp.TenLoaiVP = txtTenLoaiViPham.Text;
                lvp.MucDo = int.Parse(txtMucDo.Text);
                if (isEdit)
                {
                    if (LoaiViPhamBus.suaLoaiViPham(lvp))
                    {
                        MessageBox.Show("Sửa loại vi phạm thành công", "Thông báo");
                        LoadDS();
                        btnLuu.Enabled = false;
                        txtMaLoaiViPham.Enabled = false;
                        txtTenLoaiViPham.Enabled = false;
                        txtMucDo.Enabled = false;
                    }
                    else
                        MessageBox.Show("Sửa loại vi phạm thất bại", "Thông báo");
                }
                else
                {
                    if (LoaiViPhamBus.themLoaiVipham(lvp))
                    {
                        MessageBox.Show("Thêm loại vi phạm thành công", "Thông báo");
                        LoadDS();
                        btnLuu.Enabled = false;
                        txtMaLoaiViPham.Enabled = false;
                        txtTenLoaiViPham.Enabled = false;
                        txtMucDo.Enabled = false;
                    }
                    else
                        MessageBox.Show("Thêm loại vi phạm thất bại", "Thông báo");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (LoaiViPhamBus.xoaLoaiViPham(txtMaLoaiViPham.Text))
            {
                MessageBox.Show("Xóa thành công");
                LoadDS();
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }
        private void timkiemLoaiViPhamDGV(DataTable dt)
        {
            string filter = "MaLoaiVP LIKE '%{0}%'";
            dt.DefaultView.RowFilter = string.Format(filter, txtSearch.Text);
            txtSearch.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            timkiemLoaiViPhamDGV(dtLoaiViPham);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dtLoaiViPham.DefaultView.RowFilter = "";

            txtMaLoaiViPham.Clear();
            txtMucDo.Clear();
            txtTenLoaiViPham.Clear();
        }
    }
}

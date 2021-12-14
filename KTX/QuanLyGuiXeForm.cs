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
    public partial class QuanLyGuiXeForm : Form
    {
        GuiXeBLL GuiXeBus = new GuiXeBLL();
        CTGuiXeBLL CTGuiXeBus = new CTGuiXeBLL();
        DataTable dtGX, dtCTGX;

        bool isEdit;
        public QuanLyGuiXeForm()
        {
            InitializeComponent();
            btnLuu.Enabled = false;
            txtGX.Enabled = false;
            txtMaSV.Enabled = false;
            txtTongTien.Enabled = false;

            btnLuuCT.Enabled = false;
            txtCTMaGX.Enabled = false;
            dateNgayBD.Enabled = false;
            dateNgayKT.Enabled = false;
            txtCTGiaTien.Enabled = false;
        }
        private void dongCTGuiXe()
        {
            this.panelCTGuiXe.Dock = DockStyle.Right;
            this.panelCTGuiXe.Size = new Size(0, this.panelCTGuiXe.Size.Height);

            this.panelGuiXe.Dock = DockStyle.Fill;
        }
        private void moCTGuiXe()
        {
            this.panelGuiXe.Dock = DockStyle.Left;
            this.panelGuiXe.Size = new Size(0, this.panelGuiXe.Size.Height);

            this.panelCTGuiXe.Dock = DockStyle.Fill;
        }
        public void LoadDS()
        {
            dtGX = GuiXeBus.layDSGuiXe();
            dgv_GuiXe.DataSource = dtGX;
        }

        private void QuanLyGuiXeForm_Load(object sender, EventArgs e)
        {
            dongCTGuiXe();
            LoadDS();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            isEdit = false;
            btnLuu.Enabled = true;
            txtGX.Enabled = true;
            txtMaSV.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            isEdit = true;
            btnLuu.Enabled = true;
            txtGX.Enabled = true;
            txtMaSV.Enabled = true;
        }

        private void dgv_GuiXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgv_GuiXe.Rows[e.RowIndex];
                txtGX.Text = row.Cells[0].Value.ToString();                
                txtMaSV.Text = row.Cells[1].Value.ToString();                
                txtTongTien.Text = row.Cells[2].Value.ToString();
            }
            catch (Exception)
            {
                return;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtGX.TextLength == 0 || txtMaSV.TextLength == 0)
            {
                MessageBox.Show("Chưa nhập đủ thông tin", "Thông báo");
                txtGX.Focus();
                return;
            }
            else
            {
                PHIEUGUIXE gx = new PHIEUGUIXE();
                gx.MaPGX = txtGX.Text;
                gx.MaSV = txtMaSV.Text;
                gx.TongTien = int.Parse((txtTongTien.Text == "") ? "0" : txtTongTien.Text);
                if (isEdit)
                {
                    if (GuiXeBus.suaGuiXe(gx))
                    {
                        MessageBox.Show("Sửa phiếu gửi xe thành công", "Thông báo");
                        LoadDS();
                        btnLuu.Enabled = false;
                        txtGX.Enabled = false;
                        txtMaSV.Enabled = false;

                        txtGX.Clear();
                        txtMaSV.Clear();
                        txtTongTien.Clear();
                    }
                    else
                        MessageBox.Show("Sửa phiếu gửi xe thất bại", "Thông báo");
                }
                else
                {
                    if (GuiXeBus.themGuiXe(gx))
                    {
                        MessageBox.Show("Thêm phiếu gửi xe thành công", "Thông báo");
                        LoadDS();
                        btnLuu.Enabled = false;
                        txtGX.Enabled = false;
                        txtMaSV.Enabled = false;

                        txtGX.Clear();
                        txtMaSV.Clear();
                        txtTongTien.Clear();
                    }
                    else
                        MessageBox.Show("Thêm phiếu gửi xe thất bại", "Thông báo");
                }
            }
        }

        private void dgv_CTGuiXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgv_CTGuiXe.Rows[e.RowIndex];
                txtCTMaGX.Text = row.Cells[0].Value.ToString();
                dateNgayBD.Value = DateTime.Parse(row.Cells[1].Value.ToString());
                dateNgayKT.Value = DateTime.Parse(row.Cells[2].Value.ToString());
                txtCTGiaTien.Text = row.Cells[3].Value.ToString();
            }
            catch (Exception)
            {
                return;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            dongCTGuiXe();
            LoadDS();
            txtCTMaGX.Clear();
            txtCTMaGX.Clear();
            dateNgayBD.Value = DateTime.Now;
            dateNgayKT.Value = DateTime.Now;
        }

        private void btnThemCT_Click(object sender, EventArgs e)
        {
            isEdit = false;
            btnLuuCT.Enabled = true;
            dateNgayBD.Enabled = true;
            dateNgayKT.Enabled = true;
            txtCTGiaTien.Enabled = true;
        }

        private void btnSuaCT_Click(object sender, EventArgs e)
        {
            isEdit = true;
            btnLuuCT.Enabled = true;
            dateNgayBD.Enabled = true;
            dateNgayKT.Enabled = true;
            txtCTGiaTien.Enabled = true;
        }

        private void btnLuuCT_Click(object sender, EventArgs e)
        {
            if (txtCTGiaTien.TextLength == 0)
            {
                MessageBox.Show("Chưa nhập đủ thông tin", "Thông báo");
                txtCTGiaTien.Focus();
                return;
            }
            else
            {
                CTPHIEUGUIXE ctgx = new CTPHIEUGUIXE();
                ctgx.MaPGX = txtGX.Text;
                ctgx.NgayBD = dateNgayBD.Value;
                ctgx.NgayKT = dateNgayKT.Value;
                ctgx.GiaTien = int.Parse(txtCTGiaTien.Text);
                if (isEdit)
                {
                    if (CTGuiXeBus.suaCTGuiXe(ctgx))
                    {
                        MessageBox.Show("Sửa phiếu chi tiết gửi xe thành công", "Thông báo");
                        dtCTGX = CTGuiXeBus.layDSCTGuiXe(txtGX.Text);
                        this.dgv_CTGuiXe.DataSource = dtCTGX;
                        btnLuuCT.Enabled = false;
                        dateNgayBD.Enabled = false;
                        dateNgayKT.Enabled = false;
                        txtCTGiaTien.Enabled = false;

                        txtCTGiaTien.Clear();
                        dateNgayBD.Value = DateTime.Now;
                        dateNgayKT.Value = DateTime.Now;
                    }
                    else
                        MessageBox.Show("Sửa phiếu chi tiết gửi xe thất bại", "Thông báo");
                }
                else
                {
                    if (CTGuiXeBus.themCTGuiXe(ctgx))
                    {
                        MessageBox.Show("Thêm phiếu chi tiết gửi xe thành công", "Thông báo");
                        dtCTGX = CTGuiXeBus.layDSCTGuiXe(txtGX.Text);
                        this.dgv_CTGuiXe.DataSource = dtCTGX;
                        btnLuuCT.Enabled = false;
                        dateNgayBD.Enabled = false;
                        dateNgayKT.Enabled = false;
                        txtCTGiaTien.Enabled = false;

                        txtCTGiaTien.Clear();
                        dateNgayBD.Value = DateTime.Now;
                        dateNgayKT.Value = DateTime.Now;
                    }
                    else
                        MessageBox.Show("Thêm phiếu chi tiết gửi xe thất bại", "Thông báo");
                }
            }
        }

        private void btnCTGuiXe_Click(object sender, EventArgs e)
        {
            if (txtGX.Text != null)
            {
                moCTGuiXe();
                dtCTGX = CTGuiXeBus.layDSCTGuiXe(txtGX.Text);
                this.dgv_CTGuiXe.DataSource = dtCTGX;
                txtCTMaGX.Text = txtGX.Text;
            }
        }
    }
}

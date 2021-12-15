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
    public partial class CTPhongForm : Form
    {
        PhongBLL PhongBus = new PhongBLL();
        CTPhongBLL CTPhongBus = new CTPhongBLL();
        DataTable dtCTPhong;
        DataTable dtPhong;
        bool isEdit = false;
        public CTPhongForm()
        {
            InitializeComponent();
            btnLuu.Enabled = false;
            cbSoPhong.Enabled = false;
            txtMaSV.Enabled = false;
            chboxGuiXe.Enabled = false;
        }
        public void LoadCBSoPhong()
        {
            dtPhong = PhongBus.layDSPhong();
            cbSoPhong.DataSource = dtPhong;
            cbSoPhong.DisplayMember = "SoPhong";
            cbSoPhong.ValueMember = "SoPhong";
        }
        public void LoadDSCTPhong()
        {
            dtCTPhong = CTPhongBus.layDSCTPhong();
            dgv_CTPhong.DataSource = dtCTPhong;
        }

        private void CTPhongForm_Load(object sender, EventArgs e)
        {
            LoadDSCTPhong();
            LoadCBSoPhong();
        }

        private void dgv_CTPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgv_CTPhong.Rows[e.RowIndex];
                cbSoPhong.Text = row.Cells[0].Value.ToString();
                txtMaSV.Text = row.Cells[1].Value.ToString();
                chboxGuiXe.Checked = (bool)row.Cells[2].Value;
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
            cbSoPhong.Enabled = true;
            txtMaSV.Enabled = true;
            chboxGuiXe.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (CTPhongBus.xoaCTPhong(txtMaSV.Text))
            {
                MessageBox.Show("Xóa thành công");
                LoadDSCTPhong();
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            isEdit = true;
            btnLuu.Enabled = true;
            cbSoPhong.Enabled = true;
            txtMaSV.Enabled = true;
            chboxGuiXe.Enabled = true;
        }
        private void timkiemCTPhongDGV(DataTable dt)
        {
            string filter = "MaSV LIKE '%{0}%'";
            dt.DefaultView.RowFilter = string.Format(filter, txtSearch.Text);
            txtSearch.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            timkiemCTPhongDGV(dtCTPhong);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dtCTPhong.DefaultView.RowFilter = "";
            
            txtMaSV.Clear();
            chboxGuiXe.Checked = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaSV.TextLength == 0)
            {
                MessageBox.Show("Chưa nhập mã sinh viên");
                return;
            }
            else
            {
                CTPHONG ctp = new CTPHONG();
                ctp.SoPhong = int.Parse(cbSoPhong.Text);
                ctp.MaSV = txtMaSV.Text;
                ctp.GuiXe = chboxGuiXe.Checked;
                if (isEdit)
                {
                    if (CTPhongBus.suaCTPhong(ctp))
                    {
                        MessageBox.Show("Sửa chi tiết phòng thành công", "Thông báo");
                        LoadDSCTPhong();
                        btnLuu.Enabled = false;
                        cbSoPhong.Enabled = false;
                        txtMaSV.Enabled = false;
                        chboxGuiXe.Enabled = false;
                    }
                    else
                        MessageBox.Show("Sửa chi tiét phòng thất bại", "Thông báo");
                }
                else
                {
                    if (CTPhongBus.themCTPhong(ctp))
                    {
                        MessageBox.Show("Thêm chi tiết phòng thành công", "Thông báo");
                        LoadDSCTPhong();
                        btnLuu.Enabled = false;
                        cbSoPhong.Enabled = false;
                        txtMaSV.Enabled = false;
                        chboxGuiXe.Enabled = false;
                    }
                    else
                        MessageBox.Show("Thêm chi tiét phòng thất bại", "Thông báo");
                }
            }
            
        }
    }
}

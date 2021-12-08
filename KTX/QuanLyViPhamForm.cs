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
using FontAwesome.Sharp;

namespace KTX
{
    public partial class QuanLyViPhamForm : Form
    {
        ViPhamBLL ViPhamBus = new ViPhamBLL();
        LoaiViPhamBLL LoaiViPhamBus = new LoaiViPhamBLL();
        CTViPhamBLL CTViPhamBus = new CTViPhamBLL();

        DataTable dtViPham, dtLoaiVP, dtCTVP;

        NHANVIEN nvHienTai;
        
        bool isEdit = false;
       
        public QuanLyViPhamForm(NHANVIEN nv)
        {
            InitializeComponent();
            btnLuu.Enabled = false;
            txtMaViPham.Enabled = false;
            txtNV.Enabled = false;
            txtTenLoaiViPham.Enabled = false;
            txtSV.Enabled = false;
            txtSoLan.Enabled = false;
            this.nvHienTai = nv;

            txtMaVPCT.Enabled = false;
            btnLuuCT.Enabled = false;
            txtGhiChu.Enabled = false;
            dateNgayLap.Enabled = false;
           
        }
        private void dongCTViPham()
        {
            this.panelCTViPham.Dock = DockStyle.Right;
            this.panelCTViPham.Size = new Size(0, this.panelCTViPham.Size.Height);

            this.panelViPham.Dock = DockStyle.Fill;
        }
        private void moCTViPham()
        {
            this.panelViPham.Dock = DockStyle.Left;
            this.panelViPham.Size = new Size(0, this.panelViPham.Size.Height);

            this.panelCTViPham.Dock = DockStyle.Fill;
        }
        public void LoadDS()
        {
            dtViPham = ViPhamBus.layDSViPham();            
            dgv_ViPham.DataSource = dtViPham;
        }
        public void LoadCB()
        {
            dtLoaiVP = LoaiViPhamBus.layDSLoaiViPham();            

            cbMaLoaiVP.DataSource = dtLoaiVP;
            cbMaLoaiVP.DisplayMember = "TenLoaiVP";
            cbMaLoaiVP.ValueMember = "MaLoaiVP";            
            
        }
        private void QuanLyViPhamForm_Load(object sender, EventArgs e)
        {
            dongCTViPham();            
            LoadDS();
            LoadCB();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            isEdit = false;
            btnLuu.Enabled = true;
            txtMaViPham.Enabled = true;                        
            txtSV.Enabled = true;

            txtMaViPham.Clear();
            txtNV.Clear();
            txtSV.Clear();
            txtSoLan.Clear();
            txtTenLoaiViPham.Clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            isEdit = true;
            btnLuu.Enabled = true;
            txtMaViPham.Enabled = true;
            txtSV.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (ViPhamBus.xoaViPham(txtMaViPham.Text))
            {
                MessageBox.Show("Xóa thành công");
                LoadDS();

                txtMaViPham.Clear();
                txtNV.Clear();
                txtSV.Clear();
                txtSoLan.Clear();
                txtTenLoaiViPham.Clear();
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

        private void dgv_ViPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgv_ViPham.Rows[e.RowIndex];
                txtMaViPham.Text = row.Cells[0].Value.ToString();
                txtTenLoaiViPham.Text = row.Cells[1].Value.ToString();
                txtNV.Text = row.Cells[2].Value.ToString();
                txtSV.Text = row.Cells[3].Value.ToString();
                txtSoLan.Text = row.Cells[4].Value.ToString();
            }
            catch (Exception)
            {
                return;
            }
        }

        private void txtTenLoaiViPham_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            dongCTViPham();
            LoadDS();

            txtMaVPCT.Enabled = false;
            btnLuuCT.Enabled = false;
            txtGhiChu.Enabled = false;
            dateNgayLap.Enabled = false;
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThemCT_Click(object sender, EventArgs e)
        {
            isEdit = false;
            btnLuuCT.Enabled = true;
            txtGhiChu.Enabled = true;
            dateNgayLap.Enabled = true;

            txtGhiChu.Clear();
            dateNgayLap.Value = DateTime.Now;
        }

        private void btnSuaCT_Click(object sender, EventArgs e)
        {
            isEdit = true;
            btnLuuCT.Enabled = true;
            txtGhiChu.Enabled = true;
            dateNgayLap.Enabled = true;
        }

        private void btnXoaCT_Click(object sender, EventArgs e)
        {
            if (CTViPhamBus.xoaCTViPham(txtMaVPCT.Text))
            {
                MessageBox.Show("Xóa thành công");
                dtCTVP = CTViPhamBus.layDSCTViPham(txtMaViPham.Text);
                this.dgv_CTViPham.DataSource = dtCTVP;
                txtGhiChu.Clear();
                dateNgayLap.Value = DateTime.Now;
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

        private void btnLuuCT_Click(object sender, EventArgs e)
        {
            
            if (txtGhiChu.TextLength == 0)
            {
                MessageBox.Show("Chưa nhập ghi chú");
                return;
            }
            else
            {
                CTVIPHAM ct = new CTVIPHAM();
                ct.MaVP = txtMaVPCT.Text;
                ct.NgayLap = dateNgayLap.Value;
                ct.GhiChu = txtGhiChu.Text;           
                if (isEdit)
                {
                    //if (CTViPhamBus.suaCTViPham(ctvp))
                    //{
                    //    MessageBox.Show("Sửa chi tiết vi phạm thành công", "Thông báo");
                    //    dtCTVP = CTViPhamBus.layDSCTViPham(txtMaViPham.Text);
                    //    this.dgv_CTViPham.DataSource = dtCTVP;
                    //    txtGhiChu.Clear();
                    //    dateNgayLap.Value = DateTime.Now;
                    //    btnLuuCT.Enabled = false;
                    //    txtGhiChu.Enabled = false;
                    //    dateNgayLap.Enabled = false;
                    //}
                    //else
                    //    MessageBox.Show("Sửa chi tiết vi phạm thất bại", "Thông báo");
                }
                else
                {
                    if (dateNgayLap.Value.Day < DateTime.Now.Day)
                    {
                        MessageBox.Show("Ngày lập phải là ngày hôm nay");
                        return;
                    }
                    if (CTViPhamBus.themCTViPham(ct))
                    {                                                   
                        MessageBox.Show("Thêm chi tiết vi phạm thành công", "Thông báo");
                        dtCTVP = CTViPhamBus.layDSCTViPham(txtMaViPham.Text);
                        this.dgv_CTViPham.DataSource = dtCTVP;
                        txtGhiChu.Clear();
                        dateNgayLap.Value = DateTime.Now;
                        btnLuuCT.Enabled = false;
                        txtGhiChu.Enabled = false;
                        dateNgayLap.Enabled = false;
                    }
                    else
                        MessageBox.Show("Thêm chi tiết vi phạm thất bại", "Thông báo");
                }
            }
        }

        private void dgv_CTViPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgv_CTViPham.Rows[e.RowIndex];
                txtMaVPCT.Text = row.Cells[0].Value.ToString();
                dateNgayLap.Value = DateTime.Parse(row.Cells[1].Value.ToString());
                txtGhiChu.Text = row.Cells[2].Value.ToString();                
            }
            catch (Exception)
            {
                return;
            }
        }
        private void timkiemViPhamDGV(DataTable dt)
        {
            string filter = "MaVP LIKE '%{0}%'";
            dt.DefaultView.RowFilter = string.Format(filter, txtSearch.Text);
            txtSearch.Text = "";
        }        
        private void btnSearch_Click(object sender, EventArgs e)
        {
            timkiemViPhamDGV(dtViPham);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dtViPham.DefaultView.RowFilter = "";

            txtMaViPham.Clear();
            txtNV.Clear();
            txtSV.Clear();
            txtSoLan.Clear();
            txtTenLoaiViPham.Clear();
        }

        private void btnSearchCT_Click(object sender, EventArgs e)
        {

        }

        private void btnCTViPham_Click(object sender, EventArgs e)
        {
            if (txtMaViPham.Text != null)
            {
                moCTViPham();
                dtCTVP = CTViPhamBus.layDSCTViPham(txtMaViPham.Text);
                this.dgv_CTViPham.DataSource = dtCTVP;
                txtMaVPCT.Text = txtMaViPham.Text;
            }


        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaViPham.TextLength == 0)
            {
                MessageBox.Show("Chưa nhập mã vi phạm");
                return;
            }            
            if (txtSV.TextLength == 0)
            {
                MessageBox.Show("Chưa nhập mã sinh viên");
                return;
            }
            else
            {
                VIPHAM vp = new VIPHAM();
                vp.MaVP = txtMaViPham.Text;
                vp.MaLoaiVP = cbMaLoaiVP.SelectedValue.ToString();
                vp.MaNV = nvHienTai.MaNV;
                vp.MaSV = txtSV.Text;
                vp.SoLan = int.Parse((txtSoLan.Text == "") ? "0" : txtSoLan.Text);
                if (isEdit)
                {
                    if (ViPhamBus.suaViPham(vp))
                    {
                        MessageBox.Show("Sửa vi phạm thành công", "Thông báo");
                        LoadDS();
                        btnLuu.Enabled = false;
                        btnLuu.Enabled = false;
                        txtMaViPham.Enabled = false;
                        txtSV.Enabled = false;

                        txtMaViPham.Clear();
                        txtNV.Clear();
                        txtSV.Clear();
                        txtSoLan.Clear();
                        txtTenLoaiViPham.Clear();
                    }
                    else
                        MessageBox.Show("Sửa vi phạm thất bại", "Thông báo");
                }
                else
                {
                    if (ViPhamBus.themViPham(vp))
                    {
                        MessageBox.Show("Thêm vi phạm thành công", "Thông báo");
                        LoadDS();
                        btnLuu.Enabled = false;
                        btnLuu.Enabled = false;
                        txtMaViPham.Enabled = false;
                        txtSV.Enabled = false;

                        txtMaViPham.Clear();
                        txtNV.Clear();
                        txtSV.Clear();
                        txtSoLan.Clear();
                        txtTenLoaiViPham.Clear();
                    }
                    else
                        MessageBox.Show("Thêm vi phạm thất bại", "Thông báo");
                }
            }
        }
    }
}

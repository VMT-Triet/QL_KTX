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
    public partial class DienNuocForm : Form
    {
        HoaDonDienNuocBLL HoaDonDienNuocBus = new HoaDonDienNuocBLL();
        CTHoaDonDienNuocBLL CTHoaDonDienNuocBus = new CTHoaDonDienNuocBLL();
        PhongBLL PhongBus = new PhongBLL();
        DataTable dtHDDN, dtPhong, dtCTHDDN;
        bool isEdit = false;
        NHANVIEN nvhientai;
        public DienNuocForm(NHANVIEN nv)
        {
            InitializeComponent();

            this.nvhientai = nv;

            txtMaHD.Enabled = false;
            dateNgayLap.Enabled = false;
            txtNV.Enabled = false;
            txtDongHoDien.Enabled = false;
            txtDongHoNuoc.Enabled = false;
            txtTongTIen.Enabled = false;
            btnLuu.Enabled = false;

            txtCTMaHD.Enabled = false;
            txtCTSoDienCu.Enabled = false;
            txtCTSoNuocCu.Enabled = false;
            txtCTSoDienMoi.Enabled = false;
            txtCTSoNuocMoi.Enabled = false;
            btnLuuCT.Enabled = false;
        }
        public double TienDien(double sodien)
        {
            if (sodien <= 40)
            {
                return 0;
            }
            return (sodien - 40) * 3500;
        }

        public double TienNuoc(double sonuoc)
        {
            if (sonuoc <= 5)
            {
                return 0;
            }
            return (sonuoc - 5) * 11000;
        }
        public void LoadCB()
        {
            dtPhong = PhongBus.layDSPhong();

            cbSoPhong.DataSource = dtPhong;
            cbSoPhong.DisplayMember = "SoPhong";
            cbSoPhong.ValueMember = "SoPhong";
        }
        private void dongCTHoaDon()
        {
            this.panelCTHoaDon.Dock = DockStyle.Right;
            this.panelCTHoaDon.Size = new Size(0, this.panelCTHoaDon.Size.Height);

            this.panelHoaDon.Dock = DockStyle.Fill;
        }
        private void moCTHoaDon()
        {
            this.panelHoaDon.Dock = DockStyle.Left;
            this.panelHoaDon.Size = new Size(0, this.panelHoaDon.Size.Height);

            this.panelCTHoaDon.Dock = DockStyle.Fill;
        }
        public void LoadDS()
        {
            dtHDDN = HoaDonDienNuocBus.layDSHoaDonDienNuoc();
            dgv_HoaDon.DataSource = dtHDDN;
        }

        private void dgv_HoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgv_HoaDon.Rows[e.RowIndex];
                txtMaHD.Text = row.Cells[0].Value.ToString();
                dateNgayLap.Text = row.Cells[1].Value.ToString();
                cbSoPhong.Text = row.Cells[2].Value.ToString();
                txtDongHoDien.Text = row.Cells[3].Value.ToString();
                txtDongHoNuoc.Text = row.Cells[4].Value.ToString();
                txtTongTIen.Text = row.Cells[5].Value.ToString();
                txtNV.Text = row.Cells[6].Value.ToString();
            }
            catch (Exception)
            {
                return;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            isEdit = false;
            txtMaHD.Enabled = true;
            dateNgayLap.Enabled = true;            
            btnLuu.Enabled = true;

            txtMaHD.Clear();
            txtNV.Clear();
            txtDongHoDien.Clear();
            txtDongHoNuoc.Clear();
            txtTongTIen.Clear();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            HOADONDIENNUOC hd = new HOADONDIENNUOC();
            hd.MaHD = txtMaHD.Text;
            hd.NgayLap = dateNgayLap.Value;
            hd.MaNV = nvhientai.MaNV;
            hd.SoPhong = cbSoPhong.SelectedValue.ToString();
            hd.SoDien = int.Parse((txtDongHoDien.Text == "") ? "0" : txtDongHoDien.Text);
            hd.SoNuoc = int.Parse((txtDongHoNuoc.Text == "") ? "0" : txtDongHoNuoc.Text);
            hd.TongTien = int.Parse((txtTongTIen.Text == "") ? "0" : txtTongTIen.Text);
            hd.TinhTrang = chbTinhTrang.Checked;
            if (isEdit)
            {
                //if (dateNgaySua.Value.Date != DateTime.Now.Date)
                //{
                //    MessageBox.Show("Ngày sửa phải là ngày hôm nay", "Thông báo");
                //    return;
                //}
                ////CTBAOTRI ctbt = new CTBAOTRI();
                ////ctbt.TinhTrang = chbTinhTrang.Checked;
                ////ctbt.NgaySua = DateTime.Now;


                if (HoaDonDienNuocBus.suaHoaDon(hd))
                {
                    MessageBox.Show("Sửa hóa đơn thành công", "Thông báo");
                    LoadDS();
                    btnLuu.Enabled = false;

                    
                }
                else
                    MessageBox.Show("Sửa hóa đơn thất bại", "Thông báo");
            }
            else
            {
                //CTBAOTRI ctbt = new CTBAOTRI();
                //ctbt.MaBT = txtMaBTCT.Text;
                //ctbt.MaSV = txtMaSV.Text;
                //ctbt.MaTB = cbThietBi.SelectedValue.ToString();
                //ctbt.SoLuong = int.Parse(txtSoLuong.Text);
                //ctbt.ThanhTien = double.Parse(txtGiaBan.Text) * double.Parse(txtSoLuong.Text);

                if (HoaDonDienNuocBus.themHoaDon(hd))
                {
                    MessageBox.Show("Thêm hóa đơn thành công", "Thông báo");
                    LoadDS();
                    txtMaHD.Enabled = false;
                    dateNgayLap.Enabled = false;
                    btnLuu.Enabled = false;

                    txtMaHD.Clear();
                    txtNV.Clear();
                    txtDongHoDien.Clear();
                    txtDongHoNuoc.Clear();
                    txtTongTIen.Clear();                    
                }
                else
                    MessageBox.Show("Thêm hóa đơn thất bại", "Thông báo");
            }
        }

        private void panelCTHoaDon_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgv_CTHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgv_CTHoaDon.Rows[e.RowIndex];
                txtMaHD.Text = row.Cells[0].Value.ToString();
                txtCTSoDienCu.Text = row.Cells[1].Value.ToString();
                txtCTSoNuocCu.Text = row.Cells[2].Value.ToString();
                txtCTSoDienMoi.Text = row.Cells[3].Value.ToString();
                txtCTSoNuocMoi.Text = row.Cells[4].Value.ToString();
                txtCTTienDien.Text = row.Cells[5].Value.ToString();
                txtCTTienNuoc.Text = row.Cells[6].Value.ToString();
            }
            catch (Exception)
            {
                return;
            }
        }

        private void btnThemCT_Click(object sender, EventArgs e)
        {
            isEdit = false;
            txtCTSoDienMoi.Enabled = true;
            txtCTSoNuocMoi.Enabled = true;
            btnLuuCT.Enabled = true;
        }

        private void btnLuuCT_Click(object sender, EventArgs e)
        {
            CTHOADONDIENNUOC cthd = new CTHOADONDIENNUOC();
            //double sd = cthd.SoDienMoi + cthd.SoDienCu;
            //double sn = cthd.SoNuocMoi + cthd.SoNuocCu;
            cthd.MaHD = txtCTMaHD.Text;
            cthd.SoDienCu = (CTHoaDonDienNuocBus.laySoDienCu(cbSoPhong.SelectedValue.ToString()));
            cthd.SoNuocCu = (CTHoaDonDienNuocBus.laySoNuocCu(cbSoPhong.SelectedValue.ToString()));
            cthd.SoDienMoi = int.Parse(txtCTSoDienMoi.Text);
            cthd.SoNuocMoi = int.Parse(txtCTSoNuocMoi.Text);
            cthd.TienDien = int.Parse((txtCTTienDien.Text == "") ? "0" : txtCTTienDien.Text);
            cthd.TienNuoc = int.Parse((txtCTTienNuoc.Text == "") ? "0" : txtCTTienNuoc.Text);
            if (isEdit)
            {
                //if (dateNgaySua.Value.Date != DateTime.Now.Date)
                //{
                //    MessageBox.Show("Ngày sửa phải là ngày hôm nay", "Thông báo");
                //    return;
                //}
                //CTBAOTRI ctbt = new CTBAOTRI();
                //ctbt.TinhTrang = chbTinhTrang.Checked;
                //ctbt.NgaySua = DateTime.Now;


                //if (HoaDonDienNuocBus.suaHoaDon(ctbt))
                //{
                //    MessageBox.Show("Sửa chi tiết bảo trì thành công", "Thông báo");
                //    dtCTBT = CTBaoTriBus.layDSCTBaoTri(txtMaBTCT.Text);
                //    this.dgv_CTBaoTri.DataSource = dtCTBT;
                //    btnLuuCT.Enabled = false;
                //    chbTinhTrang.Enabled = true;
                //    dateNgaySua.Enabled = false;

                //    txtMaSV.Clear();
                //    txtSoLuong.Clear();
                //    txtGhiChu.Clear();
                //}
                //else
                //    MessageBox.Show("Sửa chi tiết bảo trì thất bại", "Thông báo");
            }
            else
            {
                //CTBAOTRI ctbt = new CTBAOTRI();
                //ctbt.MaBT = txtMaBTCT.Text;
                //ctbt.MaSV = txtMaSV.Text;
                //ctbt.MaTB = cbThietBi.SelectedValue.ToString();
                //ctbt.SoLuong = int.Parse(txtSoLuong.Text);
                //ctbt.ThanhTien = double.Parse(txtGiaBan.Text) * double.Parse(txtSoLuong.Text);

                if (CTHoaDonDienNuocBus.themCTHoaDoDienNuoc(cthd))
                {
                    MessageBox.Show("Thêm chi tiết hóa đơn thành công", "Thông báo");
                    dtCTHDDN = CTHoaDonDienNuocBus.layDSCTHoaDon(txtMaHD.Text);
                    this.dgv_CTHoaDon.DataSource = dtCTHDDN;
                    txtCTSoDienMoi.Enabled = false;
                    txtCTSoNuocMoi.Enabled = false;
                    btnLuuCT.Enabled = false;

                    
                    txtCTSoDienCu.Clear();
                    txtCTSoNuocCu.Clear();
                    txtCTSoDienMoi.Clear();
                    txtCTSoNuocMoi.Clear();
                    txtCTTienDien.Clear();
                    txtCTTienNuoc.Clear();
                }
                else
                    MessageBox.Show("Thêm chi tiết hóa đơn thất bại", "Thông báo");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            dongCTHoaDon();
            LoadDS();
            LoadCB();

            txtCTSoDienCu.Clear();
            txtCTSoNuocCu.Clear();
            txtCTSoDienMoi.Clear();
            txtCTSoNuocMoi.Clear();
            txtCTTienDien.Clear();
            txtCTTienNuoc.Clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            isEdit = true;
            btnLuu.Enabled = true;
        }

        private void btnCTHoaDon_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text != null)
            {
                moCTHoaDon();
                dtCTHDDN = CTHoaDonDienNuocBus.layDSCTHoaDon(txtMaHD.Text);
                this.dgv_CTHoaDon.DataSource = dtCTHDDN;
                txtCTMaHD.Text = txtMaHD.Text;
                
            }
        }

        private void DienNuocForm_Load(object sender, EventArgs e)
        {
            dongCTHoaDon();
            LoadDS();
            LoadCB();
        }
    }
}

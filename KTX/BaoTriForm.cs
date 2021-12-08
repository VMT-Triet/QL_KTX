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
    public partial class BaoTriForm : Form
    {
        BaoTriBLL BaoTriBus = new BaoTriBLL();
        CTBaoTriBLL CTBaoTriBus = new CTBaoTriBLL();
        ThietBiBLL ThietBiBus = new ThietBiBLL();
        PhongBLL PhongBus = new PhongBLL();

        DataTable dtBT, dtCTBT, dtTB, dtPhong;
        bool isEdit = false;
        NHANVIEN nvhientai;
        public BaoTriForm(NHANVIEN nv)
        {
            InitializeComponent();
            btnLuu.Enabled = false;
            txtMaBT.Enabled = false;
            cbSoPhong.Enabled = false;
            dateNgayLap.Enabled = false;
            txtNV.Enabled = false;
            txtTongTien.Enabled = false;

            btnLuuCT.Enabled = false;
            txtMaBTCT.Enabled = false;
            txtMaSV.Enabled = false;
            txtSoLuong.Enabled = false;
            cbThietBi.Enabled = false;
            txtGhiChu.Enabled = false;
            chbTinhTrang.Enabled = false;
            dateNgaySua.Enabled = false;
            txtThanhTien.Enabled = false;

            this.nvhientai = nv;
        }
        public void LoadCB()
        {
            dtTB = ThietBiBus.layDSThietBi();
            dtPhong = PhongBus.layDSPhong();

            cbThietBi.DataSource = dtTB;
            cbThietBi.DisplayMember = "TenTB";
            cbThietBi.ValueMember = "MaTB";

            cbSoPhong.DataSource = dtPhong;
            cbSoPhong.DisplayMember = "SoPhong";
            cbSoPhong.ValueMember = "SoPhong";

            txtGiaBan.DataBindings.Clear();

            txtGiaBan.DataBindings.Add("Text", dtTB, "GIA");
        }
        public void LoadDS()
        {
            dtBT = BaoTriBus.layDSBaoTri();
            dgv_BaoTri.DataSource = dtBT;           
        }
        public float ThanhTien(float giatb, float soluong)
        {
            return giatb * soluong;
        }
        private void dongCTBaoTri()
        {
            this.panelCTBaoTri.Dock = DockStyle.Right;
            this.panelCTBaoTri.Size = new Size(0, this.panelCTBaoTri.Size.Height);

            this.panelBaoTri.Dock = DockStyle.Fill;
        }
        private void moCTBaoTri()
        {
            this.panelBaoTri.Dock = DockStyle.Left;
            this.panelBaoTri.Size = new Size(0, this.panelBaoTri.Size.Height);

            this.panelCTBaoTri.Dock = DockStyle.Fill;
        }
        private void BaoTriForm_Load(object sender, EventArgs e)
        {
            dongCTBaoTri();
            LoadDS();
            LoadCB();

           
        }

        private void dgv_BaoTri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgv_BaoTri.Rows[e.RowIndex];
                txtMaBT.Text = row.Cells[0].Value.ToString();
                dateNgayLap.Text = row.Cells[1].Value.ToString();
                cbSoPhong.Text = row.Cells[2].Value.ToString();
                txtNV.Text = row.Cells[3].Value.ToString();
                txtTongTien.Text = row.Cells[4].Value.ToString();
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
            txtMaBT.Enabled = true;
            cbSoPhong.Enabled = true;
            dateNgayLap.Enabled = true;
            txtNV.Enabled = false;
            txtTongTien.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            isEdit = true;
            btnLuu.Enabled = true;
            txtMaBT.Enabled = false;
            cbSoPhong.Enabled = true;
            dateNgayLap.Enabled = true;
            txtNV.Enabled = false;
            txtTongTien.Enabled = true;
        }

        private void btnThemCT_Click(object sender, EventArgs e)
        {
            isEdit = false;
            btnLuuCT.Enabled = true;
            txtMaSV.Enabled = true;
            txtSoLuong.Enabled = true;
            cbThietBi.Enabled = true;
            txtGhiChu.Enabled = true;

            chbTinhTrang.Checked = false;            
        }

        private void btnSuaCT_Click(object sender, EventArgs e)
        {
            isEdit = true;
            btnLuuCT.Enabled = true;
            chbTinhTrang.Enabled = true;
            dateNgaySua.Enabled = true;
        }

        private void btnLuuCT_Click(object sender, EventArgs e)
        {
            CTBAOTRI ctbt = new CTBAOTRI();
            ctbt.MaBT = txtMaBTCT.Text;
            ctbt.MaSV = txtMaSV.Text;
            ctbt.MaTB = cbThietBi.SelectedValue.ToString();
            ctbt.SoLuong = int.Parse(txtSoLuong.Text);
            ctbt.ThanhTien = double.Parse(txtGiaBan.Text) * double.Parse(txtSoLuong.Text);
            ctbt.TinhTrang = chbTinhTrang.Checked;
            ctbt.NgaySua = dateNgaySua.Value;

            if (isEdit)
            {
                if (dateNgaySua.Value.Date != DateTime.Now.Date)
                {
                    MessageBox.Show("Ngày sửa phải là ngày hôm nay", "Thông báo");
                    return;
                }
                //CTBAOTRI ctbt = new CTBAOTRI();
                //ctbt.TinhTrang = chbTinhTrang.Checked;
                //ctbt.NgaySua = DateTime.Now;
                

                if (CTBaoTriBus.suaCTBaoTri(ctbt))
                {
                    MessageBox.Show("Sửa chi tiết bảo trì thành công", "Thông báo");
                    dtCTBT = CTBaoTriBus.layDSCTBaoTri(txtMaBTCT.Text);
                    this.dgv_CTBaoTri.DataSource = dtCTBT;
                    btnLuuCT.Enabled = false;
                    chbTinhTrang.Enabled = true;
                    dateNgaySua.Enabled = false;

                    txtMaSV.Clear();
                    txtSoLuong.Clear();
                    txtGhiChu.Clear();
                }
                else
                    MessageBox.Show("Sửa chi tiết bảo trì thất bại", "Thông báo");
            }
            else
            {
                //CTBAOTRI ctbt = new CTBAOTRI();
                //ctbt.MaBT = txtMaBTCT.Text;
                //ctbt.MaSV = txtMaSV.Text;
                //ctbt.MaTB = cbThietBi.SelectedValue.ToString();
                //ctbt.SoLuong = int.Parse(txtSoLuong.Text);
                //ctbt.ThanhTien = double.Parse(txtGiaBan.Text) * double.Parse(txtSoLuong.Text);

                if (CTBaoTriBus.themCTBaoTri(ctbt))
                {
                    MessageBox.Show("Thêm chi tiết bảo trì thành công", "Thông báo");
                    dtCTBT = CTBaoTriBus.layDSCTBaoTri(txtMaBTCT.Text);
                    this.dgv_CTBaoTri.DataSource = dtCTBT;
                    btnLuuCT.Enabled = false;
                    txtMaSV.Enabled = false;
                    txtSoLuong.Enabled = false;
                    cbThietBi.Enabled = false;
                    txtGhiChu.Enabled = false;

                    txtMaSV.Clear();
                    txtSoLuong.Clear();
                    txtGhiChu.Clear();                    
                }
                else
                    MessageBox.Show("Thêm chi tiết bảo trì thất bại", "Thông báo");
            }
        }

        private void dgv_CTBaoTri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgv_CTBaoTri.Rows[e.RowIndex];
                txtMaBTCT.Text = row.Cells[0].Value.ToString();
                txtMaSV.Text = row.Cells[1].Value.ToString();
                cbThietBi.Text = row.Cells[2].Value.ToString();
                txtGhiChu.Text = row.Cells[3].Value.ToString();
                txtSoLuong.Text = row.Cells[4].Value.ToString();
                txtGiaBan.Text= row.Cells[5].Value.ToString();
                chbTinhTrang.Checked = bool.Parse(row.Cells[6].Value.ToString());
                dateNgaySua.Value = DateTime.Parse(row.Cells[7].Value.ToString());
                txtThanhTien.Text = row.Cells[8].Value.ToString();
            }
            catch (Exception)
            {
                return;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaBT.TextLength == 0)
            {
                MessageBox.Show("Chưa nhập mã bảo trì", "Thông báo");
                return;
            }
            else
            {
                BAOTRI bt = new BAOTRI();
                bt.MaBT = txtMaBT.Text;
                bt.SoPhong = cbSoPhong.SelectedValue.ToString();
                bt.MaNV = nvhientai.MaNV;
                bt.NgayLap = dateNgayLap.Value;
                bt.TongTien = int.Parse((txtTongTien.Text == "") ? "0" : txtTongTien.Text);
                if (isEdit)
                {
                    //if (ViPhamBus.suaViPham(vp))
                    //{
                    //    MessageBox.Show("Sửa vi phạm thành công", "Thông báo");
                    //    LoadDS();
                    //    btnLuu.Enabled = false;
                    //    btnLuu.Enabled = false;
                    //    txtMaViPham.Enabled = false;
                    //    txtSV.Enabled = false;

                    //    txtMaViPham.Clear();
                    //    txtNV.Clear();
                    //    txtSV.Clear();
                    //    txtSoLan.Clear();
                    //    txtTenLoaiViPham.Clear();
                    //}
                    //else
                    //    MessageBox.Show("Sửa vi phạm thất bại", "Thông báo");
                }
                else
                {
                    if (BaoTriBus.themBaoTri(bt))
                    {
                        MessageBox.Show("Thêm bảo trì thành công", "Thông báo");
                        LoadDS();
                        btnLuu.Enabled = false;
                        txtMaBT.Enabled = false;
                        cbSoPhong.Enabled = false;
                        dateNgayLap.Enabled = false;
                        txtNV.Enabled = false;
                        txtTongTien.Enabled = false;

                        txtMaBT.Clear();
                        txtNV.Clear();
                        txtTongTien.Clear();
                        dateNgayLap.Value = DateTime.Now;                        
                    }
                    else
                        MessageBox.Show("Thêm bảo trì thất bại", "Thông báo");
                }
            }
           
        }        

        private void btnCTBaoTri_Click(object sender, EventArgs e)
        {
            if (txtMaBT.Text != null)
            {
                moCTBaoTri();
                dtCTBT = CTBaoTriBus.layDSCTBaoTri(txtMaBT.Text);
                this.dgv_CTBaoTri.DataSource = dtCTBT;
                txtMaBTCT.Text = txtMaBT.Text;
            }
        }
    }
}

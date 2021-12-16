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
    public partial class ReportDienNuocForm : Form
    {
        HoaDonDienNuocBLL HoaDonDienNuocBus = new HoaDonDienNuocBLL();
        public ReportDienNuocForm()
        {
            InitializeComponent();
        }

        private void btnDaThanhToan_Click(object sender, EventArgs e)
        {
            DataTable dtRPDienNuocDaDong = HoaDonDienNuocBus.layRPDSHoaDonDienNuocDaDong(dateTimePicker1.Value.Month, dateTimePicker1.Value.Year);
            CrystalReportDienNuoc baocao = new CrystalReportDienNuoc();
            baocao.SetDataSource(dtRPDienNuocDaDong);
            
            crystalReportViewer1.ReportSource = baocao;            
        }

        private void btnChuaThanhToan_Click(object sender, EventArgs e)
        {
            DataTable dtRPDienNuocChuaDong = HoaDonDienNuocBus.layRPDSHoaDonDienNuocChuaDong(dateTimePicker1.Value.Month, dateTimePicker1.Value.Year);
            CrystalReportDienNuoc baocao = new CrystalReportDienNuoc();
            baocao.SetDataSource(dtRPDienNuocChuaDong);

            crystalReportViewer1.ReportSource = baocao;
        }
    }
}

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
    public partial class ReportPhongForm : Form
    {
        PhongBLL PhongBus = new PhongBLL();
        
        public ReportPhongForm()
        {
            InitializeComponent();
        }
        

        private void ReportPhongForm_Load(object sender, EventArgs e)
        {

        }

        private void btnNu_Click(object sender, EventArgs e)
        {

            DataTable dtRPPhongNu = PhongBus.layRPDSPhongNu();
            CrystalReportPhongNu baocao = new CrystalReportPhongNu();
            baocao.SetDataSource(dtRPPhongNu);

            crystalReportViewer1.ReportSource = baocao;
        }

        private void btnNam_Click(object sender, EventArgs e)
        {
            DataTable dtRPPhongNam = PhongBus.layRPDSPhongNam();
            CrystalReportPhongNam baocao = new CrystalReportPhongNam();
            baocao.SetDataSource(dtRPPhongNam);

            crystalReportViewer1.ReportSource = baocao;
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            DataTable dtRPPhongAll = PhongBus.layRPDSPhongAll();
            CrystalReportPhongNu baocao = new CrystalReportPhongNu();
            baocao.SetDataSource(dtRPPhongAll);

            crystalReportViewer1.ReportSource = baocao;
        }
    }
}

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
    public partial class CTViPhamForm : Form
    {
        CTViPhamBLL CTViPhamBus = new CTViPhamBLL();

        
        public CTViPhamForm()
        {
            InitializeComponent();
        }

        private void CTViPhamForm_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }
    }
}

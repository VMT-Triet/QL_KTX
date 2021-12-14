using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class GuiXeBLL
    {
        KTXDataContext db = new KTXDataContext();
        public DataTable layDSGuiXe()
        {
            DataTable dt = new DataTable();
            var linq = from gx in db.PHIEUGUIXEs
                       select new
                       {
                           MAPGX = gx.MaPGX,
                           MASV = gx.MaSV,
                           TONGTIEN = gx.TongTien
                       };
            SqlCommand cmd = db.GetCommand(linq) as SqlCommand;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
        public bool themGuiXe(PHIEUGUIXE gx)
        {
            try
            {
                db.PHIEUGUIXEs.InsertOnSubmit(gx);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool xoaGuiXe(string magx)
        {
            try
            {
                PHIEUGUIXE gx = db.PHIEUGUIXEs.Where(x => x.MaPGX == magx).FirstOrDefault();
                db.PHIEUGUIXEs.DeleteOnSubmit(gx);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool suaGuiXe(PHIEUGUIXE gx)
        {
            try
            {
                PHIEUGUIXE t = db.PHIEUGUIXEs.Where(x => x.MaPGX == gx.MaPGX).FirstOrDefault();
                t.MaSV = gx.MaSV;                
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}

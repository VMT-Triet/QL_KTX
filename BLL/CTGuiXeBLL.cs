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
     public class CTGuiXeBLL
    {
        KTXDataContext db = new KTXDataContext();
        public DataTable layDSCTGuiXe(string magx)
        {
            DataTable dt = new DataTable();
            var linq = from ctgx in db.CTPHIEUGUIXEs
                       where ctgx.MaPGX == magx
                       select new
                       {
                           MAPGX = ctgx.MaPGX,
                           NGAYBD = ctgx.NgayBD,
                           NGAYKT = ctgx.NgayKT,
                           GIATIEN = ctgx.GiaTien
                       };
            SqlCommand cmd = db.GetCommand(linq) as SqlCommand;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
        public bool themCTGuiXe(CTPHIEUGUIXE ctgx)
        {
            try
            {
                db.CTPHIEUGUIXEs.InsertOnSubmit(ctgx);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool xoaCTGuiXe(string magx)
        {
            try
            {
                CTPHIEUGUIXE ctgx = db.CTPHIEUGUIXEs.Where(x => x.MaPGX == magx).FirstOrDefault();
                db.CTPHIEUGUIXEs.DeleteOnSubmit(ctgx);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool suaCTGuiXe(CTPHIEUGUIXE ctgx)
        {
            try
            {
                CTPHIEUGUIXE t = db.CTPHIEUGUIXEs.Where(x => x.MaPGX == ctgx.MaPGX).FirstOrDefault();
                t.NgayBD = ctgx.NgayBD;
                t.NgayKT = ctgx.NgayKT;
                t.GiaTien = ctgx.GiaTien;
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

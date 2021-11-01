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
    public class ThietBiBLL
    {
        KTXDataContext db = new KTXDataContext();
        public DataTable layDSThietBi()
        {
            DataTable dt = new DataTable();
            var linq = from tb in db.THIETBIs
                       select new
                       {
                           MATB = tb.MaTB,
                           TENTB = tb.TenTB,
                           SOLUONG = tb.SoLuong,
                           GIA = tb.GiaTB
                       };
            SqlCommand cmd = db.GetCommand(linq) as SqlCommand;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
        public bool themThietBi(THIETBI tb)
        {
            try
            {
                db.THIETBIs.InsertOnSubmit(tb);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool xoaThietBi(string matb)
        {
            try
            {
                THIETBI tb = db.THIETBIs.Where(x => x.MaTB == matb).FirstOrDefault();
                db.THIETBIs.DeleteOnSubmit(tb);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool suaThietBi(THIETBI tb)
        {
            try
            {
                THIETBI t = db.THIETBIs.Where(x => x.MaTB == tb.MaTB).FirstOrDefault();               
                t.TenTB = tb.TenTB;
                t.SoLuong = tb.SoLuong;
                t.GiaTB = tb.GiaTB;
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

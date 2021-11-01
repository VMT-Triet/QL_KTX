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
    public class ThietBiPhongBLL
    {
        KTXDataContext db = new KTXDataContext();
        public DataTable layDSTBPhong()
        {
            DataTable dt = new DataTable();
            var linq = from tbp in db.THIETBIPHONGs
                       join tb in db.THIETBIs on tbp.MaTB equals tb.MaTB
                       join p in db.PHONGs on tbp.SoPhong equals p.SoPhong                       
                       select new
                       {
                           MATB = tb.TenTB,
                           SOPHONG = p.SoPhong,                           
                           SOLUONG = tbp.SoLuong
                       };
            SqlCommand cmd = db.GetCommand(linq) as SqlCommand;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
        public bool themThietBiPhong(THIETBIPHONG tbp)
        {
            try
            {
                db.THIETBIPHONGs.InsertOnSubmit(tbp);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool xoaThietBiPhong(string matb)
        {
            try
            {
                THIETBIPHONG tbp = db.THIETBIPHONGs.Where(x => x.MaTB == matb).FirstOrDefault();
                db.THIETBIPHONGs.DeleteOnSubmit(tbp);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool suaThietBiPhong(THIETBIPHONG tbp)
        {
            try
            {
                THIETBIPHONG t = db.THIETBIPHONGs.Where(x => x.MaTB == tbp.MaTB).FirstOrDefault();
                t.SoPhong = tbp.SoPhong;
                t.SoLuong = tbp.SoLuong;                
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

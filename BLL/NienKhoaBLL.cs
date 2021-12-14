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
    public class NienKhoaBLL
    {
        KTXDataContext db = new KTXDataContext();
        public DataTable layDSNienKhoa()
        {
            DataTable dt = new DataTable();
            var linq = from nk in db.NIENKHOAs                       
                       select new
                       {
                           MANK = nk.MaNK,
                           NAMHOC = nk.NamHoc,
                           NGAYBD = nk.NgayBD,
                           NGAYKT = nk.NgayKT,
                           PHITHUE = nk.PhiThue                           
                       };
            SqlCommand cmd = db.GetCommand(linq) as SqlCommand;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
        public bool themNienKhoa(NIENKHOA nk)
        {
            try
            {
                db.NIENKHOAs.InsertOnSubmit(nk);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool xoaNienKhoa(string mank)
        {
            try
            {
                NIENKHOA nk = db.NIENKHOAs.Where(x => x.MaNK == mank).FirstOrDefault();
                db.NIENKHOAs.DeleteOnSubmit(nk);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool suaNienKhoa(NIENKHOA nk)
        {
            try
            {
                NIENKHOA t = db.NIENKHOAs.Where(x => x.MaNK == nk.MaNK).FirstOrDefault();
                t.NamHoc = nk.NamHoc;
                t.NgayBD = nk.NgayBD;
                t.NgayKT = nk.NgayKT;
                t.PhiThue = nk.PhiThue;
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

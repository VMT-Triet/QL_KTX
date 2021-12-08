using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL;

namespace BLL
{
    public class CTViPhamBLL
    {
        KTXDataContext db = new KTXDataContext();
        public DataTable layDSCTViPham(string MAVP)
        {
            DataTable dt = new DataTable();
            var linq = from ctvp in db.CTVIPHAMs
                       where ctvp.MaVP == MAVP                           
                       select new
                       {
                           MAVP = ctvp.MaVP,
                           NGAYLAP = ctvp.NgayLap,
                           GHICHU = ctvp.GhiChu
                       };
            SqlCommand cmd = db.GetCommand(linq) as SqlCommand;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
        public bool themCTViPham(CTVIPHAM ctvp)
        {
            try
            {                
                db.CTVIPHAMs.InsertOnSubmit(ctvp);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool xoaCTViPham(string mavp)
        {
            try
            {
                CTVIPHAM ctvp = db.CTVIPHAMs.Where(x => x.MaVP == mavp).FirstOrDefault();
                db.CTVIPHAMs.DeleteOnSubmit(ctvp);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        //public bool suaCTViPham(CTVIPHAM ctvp)
        //{
        //    try
        //    {
        //        CTVIPHAM ct = db.CTVIPHAMs.Where(x => x.MaVP == ctvp.MaVP).FirstOrDefault();
        //        ct.MaVP = ctvp.MaVP;
        //        ct.NgayLap = ctvp.NgayLap;
        //        ct.GhiChu = ctvp.GhiChu;
        //        db.SubmitChanges();
        //        return true;
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }
        //}
    }
}

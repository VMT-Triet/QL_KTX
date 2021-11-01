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
    public class CTPhongBLL
    {
        KTXDataContext db = new KTXDataContext();
        public DataTable layDSCTPhong()
        {
            DataTable dt = new DataTable();
            var linq = from ctp in db.CTPHONGs
                       join sv in db.SINHVIENs on ctp.MaSV equals sv.MaSV
                       join p in db.PHONGs on ctp.SoPhong equals p.SoPhong
                       join pgx in db.PHIEUGUIXEs on ctp.MaSV equals pgx.MaSV
                       select new
                       {
                           SOPHONG = p.SoPhong,
                           MASV = sv.MaSV,
                           GUIXE = ctp.GuiXe                           
                       };
            SqlCommand cmd = db.GetCommand(linq) as SqlCommand;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
        public bool themCTPhong(CTPHONG ctp)
        {
            try
            {
                db.CTPHONGs.InsertOnSubmit(ctp);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool xoaCTPhong(string masv)
        {
            try
            {
                CTPHONG ctp = db.CTPHONGs.Where(x => x.MaSV == masv).FirstOrDefault();
                db.CTPHONGs.DeleteOnSubmit(ctp);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool suaCTPhong(CTPHONG ctp)
        {
            try
            {
                CTPHONG ct = db.CTPHONGs.Where(x => x.MaSV == ctp.MaSV).FirstOrDefault();
                ct.SoPhong = ctp.SoPhong;               
                ct.GuiXe = ctp.GuiXe;
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

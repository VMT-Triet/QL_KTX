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
    public class CTBaoTriBLL
    {
        KTXDataContext db = new KTXDataContext();
        public DataTable layDSCTBaoTri(string MABT)
        {
            DataTable dt = new DataTable();
            var linq = from ctbt in db.CTBAOTRIs
                       join tb in db.THIETBIs on ctbt.MaTB equals tb.MaTB
                       where ctbt.MaBT == MABT
                       select new
                       {
                           MABT = ctbt.MaBT,
                           MASV = ctbt.MaSV,
                           THIETBI = tb.TenTB,
                           GHICHU = ctbt.GhiChu,
                           SOLUONG = ctbt.SoLuong,
                           GIATB = tb.GiaTB,
                           TINHTRANG = ctbt.TinhTrang,
                           NGAYSUA = ctbt.NgaySua,
                           THANHTIEN = ctbt.ThanhTien                           
                       };
            SqlCommand cmd = db.GetCommand(linq) as SqlCommand;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
        public bool themCTBaoTri(CTBAOTRI ctbt)
        {
            try
            {
                db.CTBAOTRIs.InsertOnSubmit(ctbt);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        //public bool xoaCTPhong(string masv)
        //{
        //    try
        //    {
        //        CTPHONG ctp = db.CTPHONGs.Where(x => x.MaSV == masv).FirstOrDefault();
        //        db.CTPHONGs.DeleteOnSubmit(ctp);
        //        db.SubmitChanges();
        //        return true;
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }
        //}
        public bool suaCTBaoTri(CTBAOTRI ctbt)
        {
            try
            {
                CTBAOTRI ct = db.CTBAOTRIs.Where(x => x.MaBT == ctbt.MaBT).FirstOrDefault();
                ct.TinhTrang = ctbt.TinhTrang;
                ct.NgaySua = ctbt.NgaySua;
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

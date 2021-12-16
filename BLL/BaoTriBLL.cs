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
    public class BaoTriBLL
    {
        KTXDataContext db = new KTXDataContext();
        public DataTable layDSBaoTri()
        {
            DataTable dt = new DataTable();
            var linq = from bt in db.BAOTRIs                           
                       select new
                       {
                           MABT = bt.MaBT,
                           NGAYLAP = bt.NgayLap,
                           SOPHONG = bt.SoPhong,
                           MANV = bt.MaNV,
                           TONGTIEN = bt.TongTien
                       };
            SqlCommand cmd = db.GetCommand(linq) as SqlCommand;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
        public bool themBaoTri(BAOTRI bt)
        {
            try
            {
                db.BAOTRIs.InsertOnSubmit(bt);
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
        public DataTable layRPBaoTriDaThanhToan(int thang,int nam)
        {
            var query = from bt in db.BAOTRIs
                        join ctbt in db.CTBAOTRIs on bt.MaBT equals ctbt.MaBT
                        where (bt.NgayLap.Value.Year == nam && bt.NgayLap.Value.Month == thang && ctbt.TinhTrang == true)
                        select new
                        {
                            NGAYLAP = bt.NgayLap,
                            SOPHONG = bt.SoPhong,
                            TONGTIEN = bt.TongTien,
                            MASV = ctbt.MaSV,
                            GHICHU = ctbt.GhiChu,
                            SOLUONG = ctbt.SoLuong,
                            NGAYSUA = ctbt.NgaySua,
                            THANHTIEN = ctbt.ThanhTien
                        };
            DataTable dt = new DataTable();
            SqlCommand cmd = db.GetCommand(query) as SqlCommand;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
    }
}

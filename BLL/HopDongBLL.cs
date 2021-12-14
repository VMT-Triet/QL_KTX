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
    public class HopDongBLL
    {
        KTXDataContext db = new KTXDataContext();
        public DataTable layDSHopDong() 
        {
            DataTable dt = new DataTable();
            var linq = from hd in db.HOPDONGs
                       join nv in db.NHANVIENs on hd.MaNV equals nv.MaNV
                       join nk in db.NIENKHOAs on hd.MaNK equals nk.MaNK
                       select new
                       {
                           MAHD = hd.MaHopDong,
                           NGAYLAP = hd.NgayLap,
                           MASV = hd.MaSV,
                           NV = nv.TenNV,
                           NAMHOC = nk.NamHoc,
                           TONGTIEN = hd.TongTien,
                           TINHTRANG = hd.TinhTrang
                       };
            SqlCommand cmd = db.GetCommand(linq) as SqlCommand;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
        public bool themHopDong(HOPDONG hd)
        {
            try
            {
                db.HOPDONGs.InsertOnSubmit(hd);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool xoaHopDong(string mahd)
        {
            try
            {
                HOPDONG hd = db.HOPDONGs.Where(x => x.MaHopDong == mahd).FirstOrDefault();
                db.HOPDONGs.DeleteOnSubmit(hd);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool suaHopHong(HOPDONG hd)
        {
            try
            {
                HOPDONG t = db.HOPDONGs.Where(x => x.MaHopDong == hd.MaHopDong).FirstOrDefault();
                t.MaSV = hd.MaSV;
                t.MaNK = hd.MaNK;
                t.TongTien = hd.TongTien;
                t.TinhTrang = hd.TinhTrang;
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

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
    public class HoaDonDienNuocBLL
    {
        KTXDataContext db = new KTXDataContext();
        public DataTable layDSHoaDonDienNuoc()
        {
            DataTable dt = new DataTable();
            var linq = from hddc in db.HOADONDIENNUOCs
                       join nv in db.NHANVIENs on hddc.MaNV equals nv.MaNV
                       select new
                       {
                           MAHD = hddc.MaHD,
                           NGAYLAP = hddc.NgayLap,
                           SOPHONG = hddc.SoPhong,
                           SODIEN = hddc.SoDien,
                           SONUOC = hddc.SoNuoc,
                           TONGTIEN = hddc.TongTien,
                           MANV = nv.TenNV,
                           TINHTRANG = hddc.TinhTrang
                       };
            SqlCommand cmd = db.GetCommand(linq) as SqlCommand;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
        public bool themHoaDon(HOADONDIENNUOC hd)
        {
            try
            {
                db.HOADONDIENNUOCs.InsertOnSubmit(hd);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool suaHoaDon(HOADONDIENNUOC hd)
        {
            try
            {
                HOADONDIENNUOC h = db.HOADONDIENNUOCs.Where(x => x.MaHD == hd.MaHD).FirstOrDefault();
                h.TinhTrang = hd.TinhTrang;                
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

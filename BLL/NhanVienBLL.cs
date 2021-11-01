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
    public class NhanVienBLL
    {
        KTXDataContext db = new KTXDataContext();

        public DataTable layDSNhanVien()
        {
            var linq = from nv in db.NHANVIENs
                       join cv in db.CHUCVUs on nv.MaCV equals cv.MaCV
                       where nv.MaCV != "CV01"
                       select new
                       {
                           MaNV = nv.MaNV,
                           TenNV = nv.TenNV,
                           GioiTinh = nv.GioiTinh,
                           NamSinh = nv.NamSinh,
                           DiaChi = nv.DiaChi,
                           MatKhau = nv.MatKhau,
                           SDT = nv.SDT,
                           MaCV = nv.MaCV,
                           TenCV = cv.TenCV
                       };
            DataTable dt = new DataTable();
            SqlCommand cmd = db.GetCommand(linq) as SqlCommand;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }

        public bool ktDangNhap(string taikhoan, string matkhau)
        {
            if (db.NHANVIENs.Any(x => x.MaNV == taikhoan && x.MatKhau == matkhau))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public NHANVIEN layNhanVien(string manv)
        {
            return db.NHANVIENs.Where(x => x.MaNV == manv).FirstOrDefault();
        }
    }
}

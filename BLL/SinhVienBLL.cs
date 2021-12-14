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
    public class SinhVienBLL
    {
        KTXDataContext db = new KTXDataContext();
        public DataTable layDSSinhVien()
        {
            DataTable dt = new DataTable();
            var linq = from sv in db.SINHVIENs
                       join nk in db.NIENKHOAs on sv.MaNK equals nk.MaNK
                       select new
                       {
                           MASV = sv.MaSV,
                           TENSV = sv.TenSV,
                           GIOITINH = sv.GioiTinh,
                           NAMSINH = sv.NamSinh,
                           DIACHI = sv.DiaChi,
                           SDT = sv.SDT,
                           NAMHOC = nk.NamHoc
                       };
            SqlCommand cmd = db.GetCommand(linq) as SqlCommand;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
        public bool themSinhVien(SINHVIEN sv)
        {
            try
            {
                db.SINHVIENs.InsertOnSubmit(sv);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool xoaSinhVien(string masv)
        {
            try
            {
                SINHVIEN sv = db.SINHVIENs.Where(x => x.MaSV == masv).FirstOrDefault();
                db.SINHVIENs.DeleteOnSubmit(sv);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool suaSinhVien(SINHVIEN sv)
        {
            try
            {
                SINHVIEN t = db.SINHVIENs.Where(x => x.MaSV == sv.MaSV).FirstOrDefault();
                t.TenSV = sv.TenSV;
                t.GioiTinh = sv.GioiTinh;
                t.NamSinh = sv.NamSinh;
                t.DiaChi = sv.DiaChi;
                t.SDT = sv.SDT;
                t.MaNK = sv.MaNK;
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

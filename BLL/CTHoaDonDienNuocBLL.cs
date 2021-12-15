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
    public class CTHoaDonDienNuocBLL
    {
        KTXDataContext db = new KTXDataContext();
        public DataTable layDSCTHoaDon(string mahd)
        {
            DataTable dt = new DataTable();
            var linq = from cthd in db.CTHOADONDIENNUOCs
                       join hd in db.HOADONDIENNUOCs on cthd.MaHD equals hd.MaHD
                       join p in db.PHONGs on hd.SoPhong equals p.SoPhong
                       where cthd.MaHD == mahd
                       select new
                       {
                           MAHD = cthd.MaHD,
                           SODIENCU = p.DongHoDien,
                           SONUOCCU = p.DongHoNuoc,
                           SODIENMOI = cthd.SoDienMoi,
                           SONUOCMOI = cthd.SoNuocMoi,
                           TIENDIEN = cthd.TienDien,
                           TIENNUOC = cthd.TienNuoc
                       };
            SqlCommand cmd = db.GetCommand(linq) as SqlCommand;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
        public bool themCTHoaDoDienNuoc(CTHOADONDIENNUOC cthd)
        {
            try
            {
                db.CTHOADONDIENNUOCs.InsertOnSubmit(cthd);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public double laySoDienCu(int sp)
        {
            double d;
            PHONG p = new PHONG();
            p = db.PHONGs.Where(n => n.SoPhong == sp).SingleOrDefault();
            d = p.DongHoDien;
            return d;
        }

        public double laySoNuocCu(int sp)
        {
            double n;
            PHONG p = new PHONG();
            p = db.PHONGs.Where(x => x.SoPhong == sp).SingleOrDefault();
            n = p.DongHoNuoc;
            return n;
        }
    }
}

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
    public class ViPhamBLL
    {
        KTXDataContext db = new KTXDataContext();
        public DataTable layDSViPham()
        {
            DataTable dt = new DataTable();
            var linq = from vp in db.VIPHAMs
                       join lvp in db.LOAIVIPHAMs on vp.MaLoaiVP equals lvp.MaLoaiVP
                       join nv in db.NHANVIENs on vp.MaNV equals nv.MaNV
                       //join pgx in db.PHIEUGUIXEs on ctp.MaSV equals pgx.MaSV
                       select new
                       {
                           MAVP = vp.MaVP,
                           TENLOAIVP = lvp.TenLoaiVP,
                           TENNV = nv.TenNV,
                           MASV = vp.MaSV,
                           SOLAN = vp.SoLan
                       };
            SqlCommand cmd = db.GetCommand(linq) as SqlCommand;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
        public bool themViPham(VIPHAM vp)
        {
            try
            {
                db.VIPHAMs.InsertOnSubmit(vp);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool xoaViPham(string mavp)
        {
            try
            {
                VIPHAM vp = db.VIPHAMs.Where(x => x.MaVP == mavp).FirstOrDefault();
                db.VIPHAMs.DeleteOnSubmit(vp);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool suaViPham(VIPHAM vp)
        {
            try
            {
                VIPHAM vpp = db.VIPHAMs.Where(x => x.MaVP == vp.MaVP).FirstOrDefault();
                vpp.MaLoaiVP = vp.MaLoaiVP;
                vpp.MaNV = vp.MaNV;
                vpp.MaSV = vp.MaSV;
                vpp.SoLan = vp.SoLan;
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

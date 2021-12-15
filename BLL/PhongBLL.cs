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
    public class PhongBLL
    {
        KTXDataContext db = new KTXDataContext();
        public DataTable layDSPhong()
        {
            DataTable dt = new DataTable();
            var linq = from p in db.PHONGs
                       select new
                       {
                           SOPHONG = p.SoPhong,
                           SOLUONG = p.SoLuong,
                           TINHTRANG = p.TinhTrang,
                           DONGHODIEN = p.DongHoDien,
                           DONGHONUOC = p.DongHoNuoc
                       };
            SqlCommand cmd = db.GetCommand(linq) as SqlCommand;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
        public bool themPhong(PHONG p)
        {
            try
            {
                db.PHONGs.InsertOnSubmit(p);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool xoaPhong(int sophong)
        {
            try
            {
                PHONG p = db.PHONGs.Where(x => x.SoPhong == sophong).FirstOrDefault();
                db.PHONGs.DeleteOnSubmit(p);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public DataTable layRPDSPhongNam()
        {
            DataTable dt = new DataTable();            
            
            var linq = from p in db.PHONGs                       
                       where  Convert.ToInt64(p.SoPhong.ToString().Substring(0,1)) >= 7 && p.TinhTrang == false 
                       group new {p.SoPhong,p.SoLuong}by Convert.ToInt64(p.SoPhong.ToString().Substring(0, 1)) >= 7 into g
                       select new
                       {   
                           
                           SOLUONG = g.Sum(x=>10 - x.SoLuong)
                       };
            SqlCommand cmd = db.GetCommand(linq) as SqlCommand;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
        public DataTable layRPDSPhongNu()
        {
            DataTable dt = new DataTable();

            var linq = from p in db.PHONGs
                       where Convert.ToInt64(p.SoPhong.ToString().Substring(0, 1)) < 7 && p.TinhTrang == false
                       group new { p.SoPhong, p.SoLuong } by Convert.ToInt64(p.SoPhong.ToString().Substring(0, 1)) < 7 into g
                       select new
                       {

                           SOLUONG = g.Sum(x => 10 - x.SoLuong)
                       };
            SqlCommand cmd = db.GetCommand(linq) as SqlCommand;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
        public DataTable layRPDSPhongAll()
        {
            DataTable dt = new DataTable();

            var linq = from p in db.PHONGs
                       where p.TinhTrang == false
                       group new { p.SoPhong, p.SoLuong } by Convert.ToInt64(p.SoPhong.ToString().Substring(0, 1)) > 0 into g
                       select new
                       {

                           SOLUONG = g.Sum(x => 10 - x.SoLuong)
                       };
            SqlCommand cmd = db.GetCommand(linq) as SqlCommand;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
    }
}

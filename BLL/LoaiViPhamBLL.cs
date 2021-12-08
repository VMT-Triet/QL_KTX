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
    public class LoaiViPhamBLL
    {
        KTXDataContext db = new KTXDataContext();
        public DataTable layDSLoaiViPham()
        {
            DataTable dt = new DataTable();
            var linq = from lvp in db.LOAIVIPHAMs
                       select new
                       {
                           MALOAIVP = lvp.MaLoaiVP,
                           TENLOAIVP = lvp.TenLoaiVP,
                           MUCDO = lvp.MucDo                           
                       };
            SqlCommand cmd = db.GetCommand(linq) as SqlCommand;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
        public bool themLoaiVipham(LOAIVIPHAM lvp)
        {
            try
            {
                db.LOAIVIPHAMs.InsertOnSubmit(lvp);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool xoaLoaiViPham(string malvp)
        {
            try
            {
                LOAIVIPHAM lvp = db.LOAIVIPHAMs.Where(x => x.MaLoaiVP == malvp).FirstOrDefault();
                db.LOAIVIPHAMs.DeleteOnSubmit(lvp);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool suaLoaiViPham(LOAIVIPHAM lvp)
        {
            try
            {
                LOAIVIPHAM lvp1 = db.LOAIVIPHAMs.Where(x => x.MaLoaiVP == lvp.MaLoaiVP).FirstOrDefault();
                lvp1.TenLoaiVP = lvp.TenLoaiVP;
                lvp1.MucDo = lvp.MucDo;                
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public LOAIVIPHAM layMucDo(string maloai)
        {
            return db.LOAIVIPHAMs.Where(x => x.MaLoaiVP == maloai).FirstOrDefault();
        }
    }
}

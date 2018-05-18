using QL_HoaDon.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_HoaDon.DAO
{
    class HangHoaDAL
    {
        public static DataTable TraCuuHHTheoTen(string keyword)
        {
            string sql = string.Format("select * from DMHangHoa where TenHang like N'%{0}%'", keyword);
            DataTable kq = DBConnection.ExecuteQuery(sql);
            return kq;
        }
        public static DataTable LayDSHH()
        {
            string sql = "select * from DMHangHoa";
            DataTable dt = DBConnection.ExecuteQuery(sql);
            return dt;
        }
        public static bool ThemHH(HangHoa hh)
        {
            string sql = string.Format("insert into DMHangHoa values ('{0}', '{1}', '{2}', {3}, '{4}')", hh.MaHang, hh.TenHang, hh.DVT, hh.DonGia, hh.GhiChu);
            bool kq = DBConnection.ExecuteNonQuery(sql);
            return kq;
        }
        public static bool XoaHHTheoMa(string maHH)
        {
            string sql = "delete QuanLyHoaDon.dbo.DMHangHoa where MaHang = '"+ maHH+"'";
            bool kq = DBConnection.ExecuteNonQuery(sql);
            return kq;
        }
        public static bool UpdateHH(HangHoa hh)
        {
            string sql = string.Format("UPDATE DMHangHoa SET TenHang = '" +hh.TenHang+ "', DVT = '" + hh.DVT + "' , DonGia = " +hh.DonGia+  ", GhiChu = '" + hh.GhiChu + "'WHERE MaHang = '" + hh.MaHang +"'");
            bool kq = DBConnection.ExecuteNonQuery(sql);
            return kq;
        }
        public static List<String> LayListHH()
        {
            List<String> _ds = new List<String>();
            string sql = "select * from DMHangHoa";
            DataTable dt = DBConnection.ExecuteQuery(sql);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                _ds.Add(dt.Rows[i]["MaHang"].ToString().Trim());
            }
            return _ds;
        }
        public static DataTable LayDuLieuChoTB(string maHH)
        {
            string sql = string.Format("select * from DMHangHoa where MaHang like N'%{0}%'", maHH);
            DataTable dt = DBConnection.ExecuteQuery(sql);
            return dt;
        }

    }
}

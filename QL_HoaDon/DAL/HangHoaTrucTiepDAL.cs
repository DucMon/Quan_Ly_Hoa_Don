using QL_HoaDon.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_HoaDon.DAO
{
    class CTHoaDonDAL
    {
        public static DataTable LayDSHHTT(string maHD)
        {
            string sql = string.Format("select * from CTHoaDon where SoHD like N'%{0}%'", maHD);
            DataTable dt = DBConnection.ExecuteQuery(sql);
            return dt;
        }
        public static bool ThemHHVaoHD(CTHoaDon hhtt)
        {
            string sql = string.Format("insert into CTHoaDon(SoHD,MaHang,TenHang,DVT,SoLuong,DonGia,ThanhTien) values ({0}, '{1}', '{2}', '{3}', {4}, {5}, {6})", hhtt.SoHD, hhtt.MaHang, hhtt.TenHang, hhtt.DVT, hhtt.SoLuong, hhtt.DonGia, hhtt.ThanhTien);
            bool kq = DBConnection.ExecuteNonQuery(sql);
            return kq;
        }
        public static bool XoaHHTTTheoMa(string maHH,int maHD)
        {
            string sql = "delete QuanLyHoaDon.dbo.CTHoaDon where MaHang = '" + maHH + "' and SoHD = " + maHD;
            bool kq = DBConnection.ExecuteNonQuery(sql);
            return kq;
        }
    }
}

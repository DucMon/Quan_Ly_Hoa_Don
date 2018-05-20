using QL_HoaDon.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_HoaDon.DAO
{
    class HoaDonDAL
    {
        public static DataTable LayDSHD()
        {
            string sql = "select * from HoaDonBan";
            DataTable dt = DBConnection.ExecuteQuery(sql);
            return dt;
        }
        public static bool ThemHD(HoaDon hd)
        {
            string sql = string.Format("set dateformat DMY insert into HoaDonBan(SoHDBan, KyHieu, MDVMH, TenDonViMuaHang, NguoiMuaHang, MaSoThueMua, DiaChiMua, STKMua, NgayHD, HinhThucThanhToan, ThueSuat, TongTien) values ({0}, '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', {9}, {10}, {11})", hd.SHD, hd.KyHieu, hd.MDVMH, hd.TenDonViMuaHang, hd.NguoiMuaHang, hd.MaSoThueMua, hd.DiaChiMua, hd.STKMua, hd.NgayHD, hd.HinhThucThanhToan, hd.ThueSuat, hd.TongTien);
            bool kq = DBConnection.ExecuteNonQuery(sql);
            return kq;
        }
        public static bool XoaHDTheoMa(string sHD)
        {
            string sql = "delete QuanLyHoaDon.dbo.CTHoaDon where SoHD = " + sHD;
            bool kq = DBConnection.ExecuteNonQuery(sql);
            sql = "delete HoaDonBan where SoHDBan = " + sHD;
            kq = DBConnection.ExecuteNonQuery(sql);
            return kq;
        }
        public static DataTable TraCuuHDTheoKyHieu(string keyword)
        {
            string sql = string.Format("select * from HoaDonBan where KyHieu like N'%{0}%'", keyword);
            DataTable kq = DBConnection.ExecuteQuery(sql);
            return kq;
        }
        public static bool UpdateHD(HoaDon hd)
        {
            string sql = "UPDATE HoaDonBan SET ThueSuat = '" + hd.ThueSuat +"', TongTien = '" + hd.TongTien + "' WHERE SoHDBan = " + hd.SHD;
            bool kq = DBConnection.ExecuteNonQuery(sql);
            return kq;
        }
    }
}

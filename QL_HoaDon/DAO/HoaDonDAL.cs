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
            string sql = string.Format("set dateformat DMY insert into HoaDonBan(SoHDBan, KyHieu, MDVMH, TenDonViMuaHang, NguoiMuaHang, MaSoThueMua, DiaChiMua, STKMua, NgayHD, HinhThucThanhToan, ThueSuat, TongTien) values ({0}, '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', {9}, {10}, {11})", hd.SHD, hd.KyHieu, hd.MDVMH, hd.TenDonViMuaHang, hd.NguoiMuaHang, hd.MaSoThueMua, hd.DiaChiMua, hd.STKMua, hd.NgayHD, hd.HinhThucThanhToan, hd.ThueSuat, 0);
            bool kq = DBConnection.ExecuteNonQuery(sql);
            return kq;
        }

        public static DataTable GetHDListByDate(DateTime fromDate, DateTime toDate)
        {
            return DBConnection.ExecuteQuery("exec USP_GetHDByDate @fromDate , @toDate", new object[] { fromDate, toDate });
        }
        public static DataTable GetCustomer()
        {
            return DBConnection.ExecuteQuery("SELECT DISTINCT NguoiMuaHang FROM dbo.HoaDonBan");
        }

        public static DataTable GetHDListByCustomer(string name)
        {
            return DBConnection.ExecuteQuery("exec USP_GetDSbyCustomer @NameCustomer", new object[] { name });
        }

    }
}

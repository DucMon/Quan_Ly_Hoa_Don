using QL_HoaDon.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_HoaDon.DAO
{
    class DVMHDAL
    {
        public static DataTable LayDSDVMH()
        {
            string sql = "select * from DonViMuaHang";
            DataTable dt = DBConnection.ExecuteQuery(sql);
            return dt;
        }
        public static bool ThemKH(DVMH kh)
        {
            string sql = string.Format("insert into DonViMuaHang values ('{0}', '{1}', '{2}', '{3}', {4}, '{5}')", kh.MDVMH, kh.TenDVMH, kh.MSTMua, kh.DiaChiMua, kh.STKMua, kh.SDTMua);
            bool kq = DBConnection.ExecuteNonQuery(sql);
            return kq;
        }
        public static bool XoaKHTheoMa(string maKH)
        {
            string sql = "delete DonViMuaHang where MDVMH = '" + maKH + "'";
            bool kq = DBConnection.ExecuteNonQuery(sql);
            return kq;
        }
        public static bool UpdateKH(DVMH kh)
        {
            string sql = string.Format("UPDATE DonViMuaHang SET TenDonViMuaHang = '" + kh.TenDVMH + "' , DiaChiMua = '" + kh.DiaChiMua + "', MaSoThueMua = '" + kh.MSTMua + "', STKMua = '" + kh.STKMua + "', SDTMua = '" + kh.SDTMua + "'WHERE MDVMH = '" + kh.MDVMH + "'");
            bool kq = DBConnection.ExecuteNonQuery(sql);
            return kq;
        }
    }
}

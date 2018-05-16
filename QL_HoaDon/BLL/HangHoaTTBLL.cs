using QL_HoaDon.DAO;
using QL_HoaDon.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_HoaDon.BLL
{
    class HangHoaTTBLL
    {
        public static DataTable LayDSHHTT(string maHD)
        {
            DataTable dt = HangHoaTrucTiepDAL.LayDSHHTT(maHD);
            return dt;
        }
        
        public static bool ThemHHVaoHD(HangHoaTrucTiep hhtt)
        {
            bool kq = HangHoaTrucTiepDAL.ThemHHVaoHD(hhtt);
            return kq;
        }
        public static bool XoaHHTTTheoMa(string maHH,int maHD)
        {
            bool kq = HangHoaTrucTiepDAL.XoaHHTTTheoMa(maHH,maHD);
            return kq;
        }
    }
}

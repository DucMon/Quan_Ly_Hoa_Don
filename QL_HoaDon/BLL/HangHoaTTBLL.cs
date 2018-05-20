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
            DataTable dt = CTHoaDonDAL.LayDSHHTT(maHD);
            return dt;
        }
        
        public static bool ThemHHVaoHD(CTHoaDon hhtt)
        {
            bool kq = CTHoaDonDAL.ThemHHVaoHD(hhtt);
            return kq;
        }
        public static bool XoaHHTTTheoMa(string maHH,int maHD)
        {
            bool kq = CTHoaDonDAL.XoaHHTTTheoMa(maHH,maHD);
            return kq;
        }
    }
}

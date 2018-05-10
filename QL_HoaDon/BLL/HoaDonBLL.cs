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
    class HoaDonBLL
    {
        public static DataTable LayDSHD()
        {
            DataTable dt = HoaDonDAL.LayDSHD();
            return dt;
        }
        public static bool ThemHD(HoaDon hd)
        {
            bool kq = HoaDonDAL.ThemHD(hd);
            return kq;
        }
    }
}

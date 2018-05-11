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
        public static DataTable LoadDSHDbyDate(DateTime fromDate, DateTime toDate)
        {
            return HoaDonDAL.GetHDListByDate(fromDate, toDate);
        }
        public static DataTable LoadCustomer()
        {
            return HoaDonDAL.GetCustomer();
        }
        public static DataTable LoadDSHDbyCustomer(string Name)
        {
            return HoaDonDAL.GetHDListByCustomer(Name);
        }

    }
}

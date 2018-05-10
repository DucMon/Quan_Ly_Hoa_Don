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
    class HangHoaBLL
    {
        public static DataTable LayDSHH()
        {
            DataTable dt = HangHoaDAL.LayDSHH();
            return dt;
        }
        public static bool UpdateHH(HangHoa hh)
        {
            bool kq = HangHoaDAL.UpdateHH(hh);
            return kq;
        }
        public static bool ThemHH(HangHoa hh)
        {
            bool kq = HangHoaDAL.ThemHH(hh);
            return kq;
        }
        public static bool XoaHHTheoMa(string maHH)
        {
            bool kq = HangHoaDAL.XoaHHTheoMa(maHH);
            return kq;
        }
        public static DataTable TraCuuHHTheoTen(string keyword)
        {
            DataTable kq = HangHoaDAL.TraCuuHHTheoTen(keyword);
            return kq;
        }
    }
}

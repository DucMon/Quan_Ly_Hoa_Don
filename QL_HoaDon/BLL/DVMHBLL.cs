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
    class DVMHBLL
    {
        public static DataTable LayDSDVMH()
        {
            DataTable dt = DVMHDAL.LayDSDVMH();
            return dt;
        }
        public static bool ThemKH(DVMH kh)
        {
            bool kq = DVMHDAL.ThemKH(kh);
            return kq;
        }
        public static bool XoaKHTheoMa(string maKH)
        {
            bool kq = DVMHDAL.XoaKHTheoMa(maKH);
            return kq;
        }
        public static bool UpdateKH(DVMH kh)
        {
            bool kq = DVMHDAL.UpdateKH(kh);
            return kq;
        }
    }
}

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
        private HoaDonDAL hoadonDAL;
        public HoaDonBLL()
        {
            hoadonDAL = new HoaDonDAL();
        }
        public static DataTable Verify()
        {
            DataTable dt = HoaDonDAL.LayDSUser();
            return dt;
        }
    }
}

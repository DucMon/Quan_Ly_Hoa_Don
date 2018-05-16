using QL_HoaDon.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_HoaDon.BLL
{
    class HinhThucTTBLL
    {
        public static DataTable LayListHTTT()
        {
            DataTable dt = HinhThucTTDAL.LayListHTTT();
            return dt;
        }
    }
}

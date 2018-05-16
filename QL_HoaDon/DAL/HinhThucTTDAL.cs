using QL_HoaDon.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_HoaDon.DAO
{
    class HinhThucTTDAL
    {
        public static DataTable LayListHTTT()
        {
            string sql = "select * from HinhThucTT";
            DataTable dt = DBConnection.ExecuteQuery(sql);
            return dt;
        }
    }
}

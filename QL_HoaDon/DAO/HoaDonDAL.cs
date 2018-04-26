using QL_HoaDon.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_HoaDon.DAO
{
    class HoaDonDAL
    {
        public DBConnection conn = new DBConnection();
        public HoaDonDAL()
        {
            conn = new DBConnection();
        }
        public static DataTable LayDSUser()
        {
            string sql = "select * from [User]";
            DataTable dt = DBConnection.ExecuteQuery(sql);
            return dt;
        }
    }
}

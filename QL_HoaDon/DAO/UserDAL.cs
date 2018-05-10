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
    class UserDAL
    {
        public DBConnection conn = new DBConnection();
        public UserDAL()
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

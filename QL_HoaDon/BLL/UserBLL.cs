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
    class UserBLL
    {
        private UserDAL userDAL;
        public UserBLL()
        {
            userDAL = new UserDAL();
        }
        public static DataTable Verify()
        {
            DataTable dt = UserDAL.LayDSUser();
            return dt;
        }

    }
}

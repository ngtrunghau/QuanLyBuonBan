using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using System.Data;
using System.Data.SqlClient;


namespace BUS
{
   public class BUS_HANGHOA
    {
        DAO_HANGHOA daoHANGHOA = new DAO_HANGHOA();
        public DataTable hienthi()
        {
            return daoHANGHOA.hienthi();
        }
    }
}

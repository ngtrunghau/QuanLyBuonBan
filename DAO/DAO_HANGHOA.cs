using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class DAO_HANGHOA
    {
        SqlConnection conn;
        public void OpenConnection()
        {
            string strConnect = @"Data Source=DESKTOP-0V0P3E5;Initial Catalog=QL_BuonBan1;Integrated Security=True";
            conn = new SqlConnection(strConnect);
            conn.Open();
        }
        public void CloseConnection()
        {
            conn.Close();
        }
        
        public DataTable hienthi()
        {
            OpenConnection();
            DataTable dt = new DataTable();
            string ht = "select*from HANGHOA";
            SqlCommand cmd = new SqlCommand(ht, conn);
            dt.Load(cmd.ExecuteReader());
            CloseConnection();
            return dt;
        }
    }
}

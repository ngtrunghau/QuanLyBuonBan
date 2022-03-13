using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
using System.Data;
namespace DAO
{
    public class DAO_NHACUNGCAP
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
        public void themNHACUNGCAP(DTO_NHACUNGCAP ncc)
        {
            OpenConnection();
            string insert = "insert into NHACUNGCAP values(@MSNCC,@TENNCC,@DIACHINCC,@SDTNCC)";
            SqlCommand cmd = new SqlCommand(insert, conn);
            cmd.Parameters.Add(new SqlParameter("@MSNCC", ncc.MSNCC));
            cmd.Parameters.Add(new SqlParameter("@TENNCC", ncc.TENNCC));
            cmd.Parameters.Add(new SqlParameter("@DIACHINCC", ncc.DIACHINCC));
            cmd.Parameters.Add(new SqlParameter("@SDTNCC", ncc.SDTNCC));
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
        public void suaNHACUNGCAP(DTO_NHACUNGCAP ncc)
        {
            OpenConnection();
            string edit = "update NHACUNGCAP set TENNCC=@TENNCC,DIACHINCC=@DIACHINCC,SDTNCC=@SDTNCC Where MSNCC=@MSNCC ";
            SqlCommand cmd = new SqlCommand(edit, conn);
            cmd.Parameters.Add(new SqlParameter("@MSNCC", ncc.MSNCC));
            cmd.Parameters.Add(new SqlParameter("@TENNCC", ncc.TENNCC));
            cmd.Parameters.Add(new SqlParameter("@DIACHINCC", ncc.DIACHINCC));
            cmd.Parameters.Add(new SqlParameter("@SDTNCC", ncc.SDTNCC));
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
        public void xoaNHACUNGCAP(string ncc)
        {
            OpenConnection();
            string delete = "delete from NHACUNGCAP where MSNCC=@MSNCC";
            SqlCommand cmd = new SqlCommand(delete, conn);
            cmd.Parameters.Add(new SqlParameter("@MSNCC", ncc));
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
        public DataTable hienthi()
        {
            OpenConnection();
            DataTable dt = new DataTable();
            string ht = "select*from NHACUNGCAP";
            SqlCommand cmd = new SqlCommand(ht, conn);
            dt.Load(cmd.ExecuteReader());
            CloseConnection();
            return dt;
        }
    }
}

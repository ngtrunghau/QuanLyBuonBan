using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using System.Data;

namespace BUS
{

    public class BUS_NHACUNGCAP
    {
        DAO_NHACUNGCAP daoNHACUNGCAP = new DAO_NHACUNGCAP();
        public void themNHACUNGCAP(DTO_NHACUNGCAP ncc)
        {
             daoNHACUNGCAP.themNHACUNGCAP(ncc);
        }
        public void suaNHACUNGCAP(DTO_NHACUNGCAP ncc)
        {
            daoNHACUNGCAP.suaNHACUNGCAP(ncc);
        }
        public void xoaNHACUNGCAP(string ncc)
        {
            daoNHACUNGCAP.xoaNHACUNGCAP(ncc);
        }
        public DataTable hienthi()
        {
            return daoNHACUNGCAP.hienthi();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_NHACUNGCAP
    {
   
        private string _MSNCC;

        public string MSNCC
        {
            get { return _MSNCC; }
            set { _MSNCC = value; }
        }

        private string _TENNCC;

        public string TENNCC
        {
            get { return _TENNCC; }
            set { _TENNCC = value; }
        }
        private string _DIACHINCC;

        public string DIACHINCC
        {
            get { return _DIACHINCC; }
            set { _DIACHINCC = value; }
        }
        private string _SDTNCC;

        public string SDTNCC
        {
            get { return _SDTNCC; }
            set { _SDTNCC = value; }
        }
        public DTO_NHACUNGCAP(string MSNCC,string TENNCC,string DIACHINCC,string SDTNCC)
        {
            this._MSNCC = MSNCC;
            this._TENNCC = TENNCC;
            this._DIACHINCC = DIACHINCC;
            this._SDTNCC = SDTNCC;
        }
    }
}

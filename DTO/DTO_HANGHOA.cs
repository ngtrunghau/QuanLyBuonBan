using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_HANGHOA
    {
        private String _MSHH;

        public String MSHH
        {
            get { return _MSHH; }
            set { _MSHH = value; }
        }
        private String _MSNCC;

        public String MSNCC
        {
            get { return _MSNCC; }
            set { _MSNCC = value; }
        }
        private String _MSNV;

        public String MSNV
        {
            get { return _MSNV;; }
            set { _MSNV = value; }
        }

        private String _TENHH;

        public String TENHH
        {
            get { return _TENHH; }
            set { _TENHH = value; }
        }
        private int _DONGIA;

        public int DONGIA
        {
            get { return _DONGIA; }
            set { _DONGIA = value; }
        }
        private String _DONVITINH;

        public String DONVITINH
        {
            get { return _DONVITINH; }
            set { _DONVITINH = value; }
        }
        public DTO_HANGHOA(String MSHH,String MSNCC, String MSNV,String TENHH,int DONGIA,String DONVITINH)
        {
            this._MSHH = MSHH;
            this._MSNCC = MSNCC;
            this._MSNV = MSNV;
            this._TENHH = TENHH;
            this._DONGIA = DONGIA;
            this._DONVITINH = DONVITINH;
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace QL_BUON_BAN
{
    
    public partial class frmHANGHOA : Form
    {
        BUS_HANGHOA busHANGHOA = new BUS_HANGHOA();
        public frmHANGHOA()
        {
            InitializeComponent();
        }

        private void frmHANGHOA_Load(object sender, EventArgs e)
        {
            DataTable dt = busHANGHOA.hienthi();
            dgvHANGHOA.DataSource = dt;
        }
    }
}

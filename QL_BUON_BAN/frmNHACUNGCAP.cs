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
using DTO;
using System.Data;

namespace QL_BUON_BAN
{
    public partial class frmNHACUNGCAP : Form
    {
        BUS_NHACUNGCAP busNHACUNGCAP = new BUS_NHACUNGCAP();
        public frmNHACUNGCAP()
        {
            InitializeComponent();
        }

        private void frmMAIN_Load(object sender, EventArgs e)
        {
            DataTable dt = busNHACUNGCAP.hienthi();
            dgvNHACUNGCAP.DataSource = dt;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
          
            DTO_NHACUNGCAP ncc = new DTO_NHACUNGCAP(txtMSNCC.Text, txtTENNCC.Text, txtDIACHINCC.Text, txtSDTNCC.Text);
            try
            { if ((txtMSNCC.Text == "") || (txtTENNCC.Text == "")) MessageBox.Show("Lỗi nhập dữ liệu!", "Thông báo");
                else
                {
                    busNHACUNGCAP.themNHACUNGCAP(ncc);
                    DataTable dt = busNHACUNGCAP.hienthi();
                    dgvNHACUNGCAP.DataSource = dt;
                    txtTENNCC.Clear();
                    txtSDTNCC.Clear();
                    txtMSNCC.Clear();
                    txtDIACHINCC.Clear();
                    MessageBox.Show("Thêm thành công!", "Thông báo");
                }
            }
            catch
            {
                MessageBox.Show("Thêm không thành công!", "Thông báo");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtMSNCC.Text == "") || (txtTENNCC.Text == "")) MessageBox.Show("Lỗi nhập dữ liệu!", "Thông báo");
                else
                {
                    busNHACUNGCAP.xoaNHACUNGCAP(txtMSNCC.Text);
                    DataTable dt = busNHACUNGCAP.hienthi();
                    dgvNHACUNGCAP.DataSource = dt;
                    txtTENNCC.Clear();
                    txtSDTNCC.Clear();
                    txtMSNCC.Clear();
                    txtDIACHINCC.Clear();

                    MessageBox.Show("Xóa thành công!", "Thông báo");
                }
            }
            catch
            {
                MessageBox.Show("Xóa không thành công", "Thông báo");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DTO_NHACUNGCAP ncc = new DTO_NHACUNGCAP(txtMSNCC.Text, txtTENNCC.Text, txtDIACHINCC.Text, txtSDTNCC.Text);
            try
            {
                if ((txtMSNCC.Text == "") || (txtTENNCC.Text == "")) MessageBox.Show("Lỗi nhập dữ liệu!", "Thông báo");
                else
                {
                    busNHACUNGCAP.suaNHACUNGCAP(ncc);
                    DataTable dt = busNHACUNGCAP.hienthi();
                    dgvNHACUNGCAP.DataSource = dt;
                    txtTENNCC.Clear();
                    txtSDTNCC.Clear();
                    txtMSNCC.Clear();
                    txtDIACHINCC.Clear();
                    MessageBox.Show("Sửa thành công!", "Thông báo");
                }
            }
            catch
            {
                MessageBox.Show("Sửa không thành công!", "Thông báo");
            }
        }

        private void dgvNHACUNGCAP_Click(object sender, EventArgs e)
        {
            int n = dgvNHACUNGCAP.CurrentRow.Index;
            txtMSNCC.Text = dgvNHACUNGCAP.Rows[n].Cells[0].Value.ToString();
            txtTENNCC.Text = dgvNHACUNGCAP.Rows[n].Cells[1].Value.ToString();
            txtDIACHINCC.Text = dgvNHACUNGCAP.Rows[n].Cells[2].Value.ToString();
            txtSDTNCC.Text = dgvNHACUNGCAP.Rows[n].Cells[3].Value.ToString();
        }
    }
}

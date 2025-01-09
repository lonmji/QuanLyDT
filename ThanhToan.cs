using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ba_form;

namespace QuanLyDT
{
    public partial class Thanhtoan : Form
    {
        public Thanhtoan()
        {
            InitializeComponent();
        }
        private Dataprovider data = new Dataprovider();

        private void Thanhtoan_Load(object sender, EventArgs e)
        {
            loadthanhtoan();
            btnluu.Enabled = false;
        }
        public void loadthanhtoan()
        {
            string sql = "SELECT maPT,pthuc FROM ThanhToan";
            DataTable dt = new DataTable();
            dt = data.Readdata(sql);
            if (dt != null)
            {
                dtgthanhtoan.DataSource = dt;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnluu.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            cleardata();
        }
        public void cleardata()
        {
            txtMathanhtoan.Text = string.Empty;
            txtTenthanhtoan.Text = string.Empty;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string Mathanhtoan = txtMathanhtoan.Text;
            string Tenthanhtoan = txtTenthanhtoan.Text;
            if (Tenthanhtoan == "")
            {
                label7.Text = "không đc để trống";
                txtTenthanhtoan.Focus();
            }
            else
            {
                string sql = "";
                sql = "UPDATE ThanhToan SET ";
                sql += "pthuc = N'" + Tenthanhtoan + "' ";
                sql += "WHERE maPT = " + Mathanhtoan + ";";
                int rowweffect = data.WriteData(sql);
                if (rowweffect > 0)
                {
                    MessageBox.Show("Sửa thành công");
                    loadthanhtoan();
                }
                else
                {
                    MessageBox.Show("Lỗi dữ liệu");
                }
                cleardata();
            }
        }

        private void dtgthanhtoan_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtMathanhtoan.Text = this.dtgthanhtoan.CurrentRow.Cells[0].Value.ToString();
            txtTenthanhtoan.Text = this.dtgthanhtoan.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string Mathanhtoan = txtMathanhtoan.Text;
            string Tenthanhtoan = txtTenthanhtoan.Text;
            if (Mathanhtoan == "")
            {
                label6.Text = "ko đc để trống";
                txtMathanhtoan.Focus();
            }
            else
            {
                string sql = "INSERT INTO ThanhToan VALUES(N'" + Mathanhtoan + "',N'" + Tenthanhtoan + "');";
                int rowweffect = data.WriteData(sql);
                if (rowweffect > 0)
                {
                    MessageBox.Show("thêm Phương thức thành công");
                    loadthanhtoan();
                }
                else
                {
                    MessageBox.Show("thêm Phương thức không thành công");
                }
                cleardata();
            }
            btnluu.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            cleardata();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string Mathanhtoan = txtMathanhtoan.Text;
            if (Mathanhtoan != "")
            {
                DialogResult rs = MessageBox.Show("bạn có muốn xóa dũ liệu", "cảnh báo", MessageBoxButtons.YesNo);
                if (rs == DialogResult.Yes)
                {
                    string sql = "DELETE FROM ThanhToan WHERE maPT = " + Mathanhtoan;
                    int rowweffect = data.WriteData(sql);
                    if (rowweffect > 0)
                    {
                        MessageBox.Show("xóa dữ liệu thành công");
                        loadthanhtoan();
                    }
                    else
                    {
                        MessageBox.Show("đã xảy ra lỗi");
                    }
                }
            }
        }
    }
}

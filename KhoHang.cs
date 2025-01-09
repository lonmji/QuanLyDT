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
    public partial class khohang : Form
    {
        public khohang()
        {
            InitializeComponent();
        }
        private Dataprovider data = new Dataprovider();

        private void khohang_Load(object sender, EventArgs e)
        {
            loaddtgkho();
            btnsave.Enabled = false;
        }
        public void loaddtgkho()
        {
            string sql = "SELECT maKho, tenKho,CONVERT(varchar,NgayNhap,103) as NgayNhap,giaNhap FROM KhoHang";
            DataTable dt = new DataTable();
            dt = data.Readdata(sql);
            if (dt != null)
            {
                dtgkho.DataSource = dt;
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            btnsave.Enabled = true;
            btnfix.Enabled = false;
            btndelete.Enabled = false;
            cleardata();
        }
        public void cleardata()
        {
            txtgianhap.Text = string.Empty;
            txtmaxkho.Text = string.Empty;
            txttenkho.Text = string.Empty;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string tenkho = txttenkho.Text;        
            string ngaynhap = dtpngaynhap.Text;
            string makho = txtmaxkho.Text;
            string gianhap = txtgianhap.Text;
            if (tenkho == "")
            {
                label6.Text = "ko đc để trống";
                txttenkho.Focus();
            }
            else
            {
                string sql = "INSERT INTO KhoHang VALUES(N'" + makho + "',N'" + tenkho + "', CONVERT(date, '" + ngaynhap + "', 103), " + gianhap + ");";
                int rowweffect = data.WriteData(sql);
                if (rowweffect > 0)
                {
                    MessageBox.Show("thêm vào kho thành công");
                    loaddtgkho();
                }
                else
                {
                    MessageBox.Show("thêm vào kho không thành công");
                }
                cleardata();
            }
            btnsave.Enabled = false;
            btnfix.Enabled = true;
            btndelete.Enabled = true;
        }

        private void btnfix_Click(object sender, EventArgs e)
        {
            string tenkho = txttenkho.Text;
            string ngaynhap = dtpngaynhap.Text;
            string makho = txtmaxkho.Text;
            string gianhap = txtgianhap.Text;
            if (tenkho == "")
            {
                label6.Text = "không đc để trống";
                txttenkho.Focus();
            }
            else
            {
                string sql = "";
                sql = "UPDATE KhoHang SET ";
                sql += "tenKho = '" + tenkho + "', "; 
                sql += "NgayNhap = CONVERT(varchar, '" + ngaynhap + "', 103), ";
                sql += "giaNhap = '" + gianhap + "' "; 
                sql += "WHERE maKho = " + makho + ";"; 

                int rowweffect = data.WriteData(sql);
                if (rowweffect > 0)
                {
                    MessageBox.Show("Sửa dữ liệu tành công");
                    loaddtgkho();
                }
                else
                {
                    MessageBox.Show("không thêm được dữ liệu");
                }
                cleardata();
            }
        }

        private void dtgkho_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            txtmaxkho.Text = this.dtgkho.CurrentRow.Cells[0].Value.ToString();
            txttenkho.Text = this.dtgkho.CurrentRow.Cells[1].Value.ToString();
            DateTime datetime = DateTime.Parse((string)this.dtgkho.CurrentRow.Cells[2].Value);
            dtpngaynhap.Value = datetime;
            txtgianhap.Text = this.dtgkho.CurrentRow.Cells[3].Value.ToString();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string makho = txtmaxkho.Text;
            if (makho != "")
            {
                DialogResult rs = MessageBox.Show("bạn có muốn xóa dũ liệu", "cảnh báo", MessageBoxButtons.YesNo);
                if (rs == DialogResult.Yes)
                {
                    string sql = "DELETE FROM KhoHang WHERE maKho = " + makho;
                    int rowweffect = data.WriteData(sql);
                    if (rowweffect > 0)
                    {
                        MessageBox.Show("xóa dữ liệu thành công");
                        loaddtgkho();
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

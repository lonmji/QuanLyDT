using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ba_form;

namespace QuanLyDT
{
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
        }
        private Dataprovider data = new Dataprovider();

        private void KhachHang_Load(object sender, EventArgs e)
        {
            Loaddata();
        }

        private void Loaddata()
        {
            String query = "select *, case When Gioitinh = 0 then N'nữ' else 'Nam' ";
            query += "end as GT from KhachHang;";
            DataTable dt = data.Readdata(query);
            GridV.DataSource = dt;
        }

        private void ClearData()
        {
            TbID.Text = "";
            TbDC.Text = "";
            TbName.Text = "";
            TbSDT.Text = "";
            TBEmail.Text = "";
        }

        private void Btnadd_Click(object sender, EventArgs e)
        {
            TbID.ReadOnly = false;
            Btnsave.Enabled = true;
            BtnDL.Enabled = false;
        }

        private void Btnsave_Click(object sender, EventArgs e)
        {
            String id = TbID.Text;
            if(id != "")
            {
                String name = TbName.Text;
                String dc = TbDC.Text;
                String sdt = TbSDT.Text;
                String em = TBEmail.Text;
                int gt = 0;
                if(Ra_Nam.Checked = true) { gt = 1; }

                String query = "Insert into KhachHang values ";
                query += "(@id, @name, @em, @sdt, @dc, @gt)";
                List<SqlParameter> sp = new List<SqlParameter>()
                {
                    new SqlParameter("@id", id),
                    new SqlParameter("@name", name),
                    new SqlParameter("@em", em),
                    new SqlParameter("@sdt", sdt),
                    new SqlParameter("@dc", dc),
                    new SqlParameter("@gt", gt),
                };
                int rowef = data.WriteData(query, sp);
                if(rowef > 0 )
                {
                    MessageBox.Show("Them Thanh cong");
                    Loaddata();
                }
            }
            else
            {
                MessageBox.Show("Mã tài khoản không được để chống");
            }
            ClearData();
            TbID.ReadOnly = true;
            Btnsave.Enabled = false;
            BtnDL.Enabled = true;
        }

        private void BtnDL_Click(object sender, EventArgs e)
        {
            String id = GridV.CurrentRow.Cells[0].Value.ToString();
            if(id != "")
            {
                String query = "Delete from KhachHang Where maKH = " + id;
                int rowef = data.WriteData(query);
                if(rowef > 0)
                {
                    MessageBox.Show("Xoa Thanh cong");
                    Loaddata();
                }
            }
        }
    }
}

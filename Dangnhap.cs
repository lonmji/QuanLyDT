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
    public partial class Dangnhap : Form
    {
        public Dangnhap()
        {
            InitializeComponent();
        }
        private Dataprovider data = new Dataprovider();

        private void Dangnhap_Load(object sender, EventArgs e)
        {

        }

        private void BtnDN_Click(object sender, EventArgs e)
        {
            String name = Tb_TK.Text;
            String mk = Tb_MK.Text;
            String query = "Select * from TaiKhoan where userName  = @name and passWord = @pw";
            List<SqlParameter> sqlParameters = new List<SqlParameter>()
            {
                new SqlParameter("@name", name),
                new SqlParameter("@pw", mk),
            };
            DataTable dt = new DataTable();
            dt = data.Readdata(query, sqlParameters);
            if (dt.Rows.Count > 0)
            {
                Menu mn = new Menu();
                mn.Dangxuat += Mn_Dangxuat;
                this.Hide();
                mn.Show();
            }
            else
            {
                MessageBox.Show("Sai mat khau hoac tai khoan");
            }
        }

        private void Mn_Dangxuat(object sender, EventArgs e)
        {
            this.Show();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Dangnhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có chắc muốn thoát không", "Warning", MessageBoxButtons.YesNo);
            if (dl == DialogResult.Yes)
            {

            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}

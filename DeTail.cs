using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ba_form;

namespace QuanLyDT
{
    public partial class DeTail : Form
    {
        public DeTail(String id)
        {
            InitializeComponent();
            LoadData(id);
        }
        private Dataprovider data = new Dataprovider();

        private void DeTail_Load(object sender, EventArgs e)
        {

        }

        private void LoadData(String id)
        {
            String query = "Select * From SanPham " ;
            query += "Inner Join KhoHang on KhoHang.maKho = SanPham.maKho";
            query += " where maSP = " + id;
            DataTable dt = data.Readdata(query);

            lblBH.Text = dt.Rows[0]["baoHanh"].ToString();
            lblDATE.Text = dt.Rows[0]["NgayNhap"].ToString();
            lblGia.Text = dt.Rows[0]["giaBan"].ToString();
            lblGiaNhap.Text = dt.Rows[0]["giaNhap"].ToString();
            lblID.Text = dt.Rows[0]["maSP"].ToString();
            lblMT.Text = dt.Rows[0]["mota"].ToString();
            lblName.Text = dt.Rows[0]["tenSP"].ToString();
            lblTenkho.Text = dt.Rows[0]["tenKho"].ToString();
            lblTH.Text = dt.Rows[0]["thuongHieu"].ToString();

            if (dt.Rows[0]["imagee"] != DBNull.Value)
            {
                byte[] imageData = (byte[])dt.Rows[0]["imagee"];
                using (MemoryStream mm = new MemoryStream(imageData))
                {
                    PicBox.Image = Image.FromStream(mm);
                }
            }
            else
            {
                PicBox.Image = null; 
            }
        }

        private void DeTail_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}

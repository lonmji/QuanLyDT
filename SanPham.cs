using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ba_form;

namespace QuanLyDT
{
    public partial class SanPham : Form
    {
        public SanPham()
        {
            InitializeComponent();
        }
        private Dataprovider data = new Dataprovider();
        private void BtnADD_Click(object sender, EventArgs e)
        {
            ClearData();
            TbID.ReadOnly = false;
            BtnSAVE.Enabled = true; 
            BtnChange.Enabled = false;
            Btndelete.Enabled = false;
        }

        private void BtnSAVE_Click(object sender, EventArgs e)
        {
            String id = TbID.Text; 
            if(id != "")
            {
                String name = TbTenSP.Text;
                String gia = TbGia.Text;
                String bh = TbBH.Text;
                String th = TbTH.Text;
                String mt = TbMT.Text;
                String kho = CbKho.SelectedValue.ToString();

                String query = "Insert into SanPham values ";
                query += "(@id, @name, @gia, @th, @bh, @im, @mt, @kho)";

                List<SqlParameter> sqlParameters = new List<SqlParameter>()
                {
                    new SqlParameter("@id", id),
                    new SqlParameter("@name", name),
                    new SqlParameter("@gia", gia),
                    new SqlParameter("@th", th),
                    new SqlParameter("@bh", bh),
                    new SqlParameter("@im", getPhoto()),
                    new SqlParameter("@mt", mt),
                    new SqlParameter("@kho", kho),
                };

                int rowef = data.WriteData(query, sqlParameters);
                if(rowef > 0)
                {
                    MessageBox.Show("Them thanh cong");
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Mã sản phẩm không được để chống");
            }
            ClearData();
            TbID.ReadOnly = true;
            BtnSAVE.Enabled = false;
            BtnChange.Enabled = true;
            Btndelete.Enabled = true;
        }

        private void SanPham_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadKho();
        }

        private void ClearData()
        {
            TbID.Text = "";
            TbTenSP.Text = "";
            TbGia.Text = "";
            TbBH.Text = "";
            TbTH.Text = "";
            TbMT.Text = "";
        }

        private void LoadData()
        {
            String query = "Select maSP, tenSP, thuongHieu, giaBan from SanPham";
            DataTable dt = new DataTable();
            dt = data.Readdata(query);
            GridSP.DataSource = dt;
        }

        private void LoadKho()
        {
            String query = "Select * from KhoHang";
            DataTable dt = new DataTable();
            dt = data.Readdata(query);
            CbKho.DataSource = dt;
            CbKho.DisplayMember = "tenKho";
            CbKho.ValueMember = "maKho";
        }

        private void BtnAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if(open.ShowDialog() == DialogResult.OK)
            {
                PicSP.Image = new Bitmap(open.FileName);
            }
        }

        private byte[] getPhoto()
        {
            MemoryStream memory = new MemoryStream();
            PicSP.Image.Save(memory, PicSP.Image.RawFormat);
            return memory.GetBuffer();
        }

        private void BtnChange_Click(object sender, EventArgs e)
        {
            String id = GridSP.CurrentRow.Cells[0].Value.ToString();
            if(id != "")
            {
                String name = TbTenSP.Text;
                String gia = TbGia.Text;
                String bh = TbBH.Text;
                String th = TbTH.Text;
                String mt = TbMT.Text;
                String kho = CbKho.SelectedValue.ToString();

                String query = "Update SanPham Set tenSP = @name, giaBan = @gia, ";
                query += "thuongHieu = @th, baoHanh = @bh, imagee = @im, mota = @mt, maKho = @kho where maSP = @id";

                List<SqlParameter> sqlParameters = new List<SqlParameter>()
                {
                    new SqlParameter("@id", id),
                    new SqlParameter("@name", name),
                    new SqlParameter("@gia", gia),
                    new SqlParameter("@th", th),
                    new SqlParameter("@bh", bh),
                    new SqlParameter("@im", getPhoto()),
                    new SqlParameter("@mt", mt),
                    new SqlParameter("@kho", kho),
                };

                int rowef = data.WriteData(query, sqlParameters);
                if(rowef > 0)
                {
                    MessageBox.Show("Sửa thành công");
                    LoadData();                   
                } 
            }
            ClearData();
        }

        private void GridSP_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            String id = GridSP.CurrentRow.Cells[0].Value.ToString();
            if(id != "")
            {
                String query = "Select * from SanPham Where maSP = " + id;
                DataTable dt = new DataTable();
                dt = data.Readdata(query);

                TbTenSP.Text = dt.Rows[0]["tenSP"].ToString();
                TbGia.Text = dt.Rows[0]["giaBan"].ToString();
                TbBH.Text = dt.Rows[0]["baoHanh"].ToString();
                TbTH.Text = dt.Rows[0]["thuongHieu"].ToString();
                TbMT.Text = dt.Rows[0]["mota"].ToString();
                CbKho.Text = dt.Rows[0]["maKho"].ToString();

                byte[] imageData = (byte[])dt.Rows[0]["imagee"];
                using (MemoryStream mm = new MemoryStream(imageData))
                {
                    PicSP.Image = Image.FromStream(mm);
                }                  
            }
        }

        private void Btndelete_Click(object sender, EventArgs e)
        {
            String id = GridSP.CurrentRow.Cells[0].Value.ToString();
            if(id != "")
            {
                String query = "Delete from SanPham Where maSP = " + id;
                int rowef = data.WriteData(query);
                if(rowef > 0)
                {
                    MessageBox.Show("Xoá thành công");
                    LoadData();
                }
            }
            ClearData();
        }

        private void GridSP_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            String id = GridSP.CurrentRow.Cells[0].Value.ToString();
            if(id != "")
            {
                DeTail dt = new DeTail(id);
                dt.ShowDialog();
            }
        }

        private void TBTK_TextChanged(object sender, EventArgs e)
        {
            String name = TBTK.Text.Trim();
            if(name == "")
            {
                LoadData();
            }
            else
            {
                String query = "Select maSP, tenSP, thuongHieu, giaBan from SanPham ";
                query += "Where tenSP like @name";
                List<SqlParameter> parameters = new List<SqlParameter>()
                {
                    new SqlParameter("@name", "%" + name + "%"),
                };
                DataTable dt = data.Readdata(query, parameters);
                GridSP.DataSource = dt;
            }
        }
    }
}

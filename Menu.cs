using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDT
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        private Form Curreentform = null;
        public event EventHandler Dangxuat;
        private bool log_out = false;

        private void BtnSlide_Click(object sender, EventArgs e)
        {
            if (MenuSideBar.Width == 250)
            {
                MenuSideBar.Width = 50;
            }
            else MenuSideBar.Width = 250;
        }

        private void Pexiit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Openchildform(Form Child)
        {
            if(Curreentform != null)
            {
                Curreentform.Close();
            }
            Curreentform = Child;
            Child.TopLevel = false;
            MenuConntent.Controls.Add(Child);
            MenuConntent.Tag = Child;
            Child.Show();
        }

        private void BtnKhohang_Click(object sender, EventArgs e)
        {
            Openchildform(new khohang());
        }

        private void BtnThanhToan_Click(object sender, EventArgs e)
        {
            Openchildform(new Thanhtoan());
        }

        private void BtnSP_Click(object sender, EventArgs e)
        {
            Openchildform(new SanPham());
        }

        private void BtnDangXuat_Click(object sender, EventArgs e)
        {
            log_out = true;
            Dangxuat.Invoke(this, new EventArgs());
            this.Close();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!log_out)
            {
                Application.Exit();
            }
        }

        private void MenuConntent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnKH_Click(object sender, EventArgs e)
        {
            Openchildform(new KhachHang());
        }
    }
}

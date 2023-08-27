using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
namespace QuanLy_KhachSan
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form a = new quanly.Staff_manager();
            a.MdiParent = this;
            a.Show();
        }

        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form a = new quanly.Account_Manager();
            a.MdiParent = this;
            a.Show();
        }

        private void đToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form a = new dangnhap.Repass();
            a.MdiParent = this;
            a.Show();
        }

        private void menu_ql_khach_Click(object sender, EventArgs e)
        {
            Form a = new quanly.Customer_Manager();
            a.MdiParent = this;
            a.Show();
        }

        private void menu_phuthu_Click(object sender, EventArgs e)
        {
            Form a = new quanly.Phuthu_Manager();
            a.MdiParent = this;
            a.Show();
        }

        private void menu_qly_phong_Click(object sender, EventArgs e)
        {
            Form a = new quanly.Room_manager();
            a.MdiParent = this;
            a.Show();
        }

        private void menu_qly_sp_Click(object sender, EventArgs e)
        {
            Form a = new quanly.Warehouse_Manager();
            a.MdiParent = this;
            a.Show();
        }

        private void menu_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất tài khoản ? ", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
                dangnhap.Login a = new dangnhap.Login();
                a.Show();
            }
        }

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chăn muốn thoát không ? ", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Main_chinh a = new Main_chinh();
                a.Show();
                this.Close();
            }
        }

        private void báoCaoToolStripMenuItem_Click(object sender, EventArgs e)
        {

           // Process.Start(@"C:\Users\T\Desktop\Hotel_manager\QuanLy_KhachSan\test.xlsx");
            
        }

        private void tìmKiếmThôngTinNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form a = new timkiem.Search_nhanvien();
            a.MdiParent = this;
            a.Show();
        }

  

        private void đặtPhòngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form a = new quanly_dat_thue_phong.Dat_phong();
            a.MdiParent = this;
            a.Show();

        }

        private void thuêPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form a = new quanly_dat_thue_phong.Thue_phong();
            a.MdiParent = this;
            a.Show();
        }

        private void trảPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form a = new quanly_dat_thue_phong.Tra_phong();
            a.MdiParent = this;
            a.Show();
        }

        private void timKiếmThôngTinKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form a = new timkiem.Search_khachhang();
            a.MdiParent = this;
            a.Show();
        }

        private void tìmKiếmThôngTinPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form a = new timkiem.Search_phong();
            a.MdiParent = this;
            a.Show();
        }

        private void tìmKiếmThôngTinKhoHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form a = new timkiem.Search_kho();
            a.MdiParent = this;
            a.Show();
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String tt = "";
            tt += "Phần mềm : Quản lý Khách sạn \n";
            tt += " Học phần : Công nghệ .Net";
            tt += "\t";
            tt += " ____Đồ án____ ";
            tt += "\n";
            tt += "\nSinh viên thực hiện : ";
            tt += "\n- Ngô Nguyễn Phát Thịnh - 2001202258";
            tt += "\n- Dương Phạm Anh Duy - 2001202060";
            tt += "\n- Lê Quốc Việt - 2001207153";

            MessageBox.Show("" + tt, "Thông tin phần mềm", MessageBoxButtons.OK);
        }

        private void quảnLýLoạiPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form a = new quanly.Kindofroom_Manager();
            a.MdiParent = this;
            a.Show();
        }

        private void thốngKêThuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form a = new Thongke.ThongKe_DoanhThu();
            a.MdiParent = this;
            a.Show();
        }

        private void quảnLýKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form a = new hoadon.nhap_kho();
            a.MdiParent = this;
            a.Show();
        }

        private void thốngKêNhậpKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form a = new Thongke.thongke_hoadon_kho();
            a.MdiParent = this;
            a.Show();

        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("excel");
        }

        private void wordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("winword");
        }

        private void paintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("mspaint");
        }
    }
}

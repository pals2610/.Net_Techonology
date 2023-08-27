using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLy_KhachSan
{
    public partial class Main_chinh : Form
    {
        public Main_chinh()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            dangnhap.Login a = new dangnhap.Login();
           
            a.Show();
            this.Hide();
        }

        private void Registratuion_Click(object sender, EventArgs e)
        {

            dangnhap.Registration a1 = new dangnhap.Registration();
            
            a1.Show();
            this.Hide();
        }

        private void lbform_Click(object sender, EventArgs e)
        {

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

        private void đăngNhậpHệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dangnhap.Login a = new dangnhap.Login();

            a.Show();
            this.Hide();
        }

        private void đăngKýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dangnhap.Registration a1 = new dangnhap.Registration();

            a1.Show();
            this.Hide();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chăn muốn thoát không ? ", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
              
                this.Close();
            }
        }
    }
}

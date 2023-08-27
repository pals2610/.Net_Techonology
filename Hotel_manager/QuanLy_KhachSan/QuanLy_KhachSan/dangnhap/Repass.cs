using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLy_KhachSan.dangnhap
{
    public partial class Repass : Form
    {
        public Repass()
        {
            InitializeComponent();
        }

        private void Btn_Repass_Click(object sender, EventArgs e)
        {
            string sql1 = "Select count(*) from DangNhap where Taikhoan='" + txt_tk.Text.Trim() + "' ";

            if (txt_newmk.Text.Length < 6)
            {
                MessageBox.Show("Mat khẩu bạn nhập ít nhất phải dài 6 ký tự", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                chuoiketnoi.ktratk(txt_tk.Text, txt_newmk.Text, txt_remk.Text, sql1);
                if (MessageBox.Show("Bạn đổi thành công mật khẩu, bạn có muốn đăng nhập lại không", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    dangnhap.Login a = new dangnhap.Login();
                    a.Show();
                    this.Hide();
                
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chăn muốn thoát không ? ", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}

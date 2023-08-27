using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLy_KhachSan.dangnhap
{
    public partial class Login : Form
    {
        public static string sqlcon = chuoiketnoi.sqlcon;
        public static SqlConnection mycon;
        public static SqlCommand com;
        public static string full_name = "";
        public static int sate = 0, sai = 5;
        public Login()
        {
            InitializeComponent();
       
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string sql1 = "Select count(*) from DangNhap where Taikhoan='" + txt_tk.Text.Trim() + "' and Matkhau='" + txt_mk.Text.Trim() + "' and phanquyen = 1  ";
            string sql2 = "Select count(*) from DangNhap where Taikhoan ='" + txt_tk.Text + "'and Matkhau ='" + txt_mk.Text + "' and phanquyen = 2  ";
            string sql3 = "Select count(*) from DangNhap where Taikhoan='" + txt_tk.Text + "' and Matkhau ='" + txt_mk.Text + "' and phanquyen = 3  ";
            string chuoi4 = "Select FullName from DangNhap where Taikhoan ='" + txt_tk.Text.Trim() + "'";
            string chuoi5 = "Select trangthai from DangNhap where Taikhoan ='" + txt_tk.Text.Trim() + "'";

            if (txt_tk.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên tài khoản ", "Thông báo", MessageBoxButtons.OK);
            }
            else if (txt_mk.Text == "")
                MessageBox.Show("Bạn chưa nhập Mật khẩu  ", "Thông báo", MessageBoxButtons.OK);
            else
            {
                if (sai > 0)
                {

                    int a = 0, b = 0, c = 0;
                    mycon = new SqlConnection(chuoiketnoi.sqlcon);
                    mycon.Open();


                    com = new SqlCommand(sql1, mycon);
                    a = (int)com.ExecuteScalar();

                    SqlCommand com1 = new SqlCommand(sql2, mycon);

                    b = (int)com1.ExecuteScalar();

                    SqlCommand com2 = new SqlCommand(sql3, mycon);
                    c = (int)com2.ExecuteScalar();


                    if (a > 0)
                    {
                        int trangthai = chuoiketnoi.check_key(chuoi5, sate);

                        if (trangthai == 0)
                        {
                            MessageBox.Show("Tài khoản của bạn đang bị khóa , hay liên lạc với Admin để được mở khóa ! xin cảm ơn.", "Thông Báo ", MessageBoxButtons.OK);
                        }
                        else
                        {
                            string tendaydu = chuoiketnoi.load(chuoi4, full_name);
                            MessageBox.Show("Ban dang nhap vao tai khoan Admin", "Thong bao ", MessageBoxButtons.OK);
                            Home a1 = new Home();
                            a1.Show();
                            this.Hide();
                            a1.lb_name.Text = "Xin Chào : " + tendaydu;
                            a1.lb_quyen.Text = "Quyền sử dụng : Admin";
                          //  a1.taikhoan_Tooltip.Visible = true;
                        }
                    }
                    else if (b > 0)
                    {
                        int trangthai = chuoiketnoi.check_key(chuoi5, sate);
                        if (trangthai == 0)
                        {
                            MessageBox.Show("Tài khoản của bạn đang bị khóa , hay liên lạc với Admin để được mở khóa ! xin cảm ơn.", "Thông Báo ", MessageBoxButtons.OK);
                        }
                        else
                        {
                            string tendaydu = chuoiketnoi.load(chuoi4, full_name);
                            MessageBox.Show("Ban dang nhap vao tai khoan quản lý", "Thong bao ", MessageBoxButtons.OK);
                            Home a2 = new Home();
                            a2.Show();
                            this.Hide();
                            a2.lb_name.Text = "Xin Chào : " + tendaydu;
                            a2.lb_quyen.Text = "Quyền sử dụng : Quản lý";
                           // a2.taikhoan_Tooltip.Visible = true;
                        }
                    }

                    else if (c > 0)
                    {
                        int trangthai = chuoiketnoi.check_key(chuoi5, sate);
                        if (trangthai == 0)
                        {
                            MessageBox.Show("Tài khoản của bạn đang bị khóa , hay liên lạc với Admin để được mở khóa ! xin cảm ơn.", "Thông Báo ", MessageBoxButtons.OK);
                        }
                        else
                        {
                            string tendaydu = chuoiketnoi.load(chuoi4, full_name);
                            MessageBox.Show("Ban dang nhap vao quyền người dùng ", "Thong bao ", MessageBoxButtons.OK);
                            Home a2 = new Home();
                            a2.Show();
                            a2.lb_name.Text = "Xin Chào : " + tendaydu;
                            a2.lb_quyen.Text = "Quyền sử dụng : Nhân viên";
                            a2.menu_quanlytk.Visible = false;
                            a2.menu_account_manager.Visible = false;
                            a2.menu_qly_phong.Visible = false;

                           // a2.taikhoan_Tooltip.Visible = false;

                        }

                    }
                    if (a == 0 && b == 0 && c == 0)
                    {
                        sai--;
                        string t = ("Username hoặc password sai !,Bạn vui lòng kiểm tra lại, bạn còn " + sai + " lần đăng nhập");
                        MessageBox.Show((t), "thong báo", MessageBoxButtons.OK);
                        txt_tk.Text = "";
                        txt_mk.Text = "";
                        txt_tk.Focus();
                    }


                }

                else
                {

                    int trangthai = 0;
                    string sql = "Update DangNhap set trangthai='" + trangthai + "'  where Taikhoan = '" + txt_tk.Text + "'";


                    chuoiketnoi.Rekey(sql);
                    MessageBox.Show("do đăng nhập sai quá nhiều lần , tài khoản bạn đã bị khóa! vui lòng liên lạc với ADMIN để mở tài khoản ", "Thông báo", MessageBoxButtons.OK);

                    sai = 5;
                }
            }

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox1.Checked)
            {
                txt_mk.UseSystemPasswordChar = true;

            }
            else
                txt_mk.UseSystemPasswordChar = false;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không ? ", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
                Main_chinh a = new Main_chinh();
                a.Show();
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
            dangnhap.Registration a = new dangnhap.Registration();
            a.Show();
        }
    }
}

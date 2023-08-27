using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace QuanLy_KhachSan.dangnhap
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }
        // Hàm check lỗi Gmail
        public static bool isEmail(string inputEmail)
        {
            inputEmail = inputEmail ?? string.Empty;
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }

        private void bt_dangky_Click(object sender, EventArgs e)
        {
            string tk = txt_tk.Text.ToString().Trim();
            string mk = txt_mk.Text.ToString().Trim();
            string remk = txt_remk.Text.ToString().Trim();
            string fullname = txt_fullname.Text.ToString().Trim();
            string mail = txt_Mail.Text.ToString().Trim();

            if (tk == "" || mk == "" || remk == "" || mail == "" || fullname == "")
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {

                if (isEmail(mail) == false)
                {
                    MessageBox.Show("Mail không hợp lệ ! vui lòng kiểm tra lại. ", "Error", MessageBoxButtons.OK);
                    txt_Mail.Text = "";
                    txt_Mail.Focus();
                }
                else
                {
                    string sql = "Select count(*) from DangNhap where Taikhoan ='" + tk + "'";
                    string sql1 = "Insert into DangNhap values('" + tk + "','" + mk + "',N'" + fullname + "','" + mail + "',3,1)";
                    if (mk == remk)
                    {
                        if (mk.Length < 6)
                        {
                            MessageBox.Show("Mat khẩu bạn nhập ít nhất phải dài 6 ký tự", "Thông báo", MessageBoxButtons.OK);
                        }
                        else
                        {
                            chuoiketnoi.Themdangky(sql, tk, mk, sql1);
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Phần Nhập lại và phần mật khẩu không trùng khớp", "Thông báo", MessageBoxButtons.OK);
                    }

                }
            }
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chăn muốn thoát không ? ", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Main_chinh a1 = new Main_chinh();
                a1.Show();
                this.Close();

            }
        }
    }
}

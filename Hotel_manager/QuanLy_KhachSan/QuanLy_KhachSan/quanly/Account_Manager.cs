using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace QuanLy_KhachSan.quanly
{
    public partial class Account_Manager : Form
    {
        int index = 0;
        int last = 0;
        public static string chuoi = "Select  * From DangNhap";
        public Account_Manager()
        {
            InitializeComponent();
            chuoiketnoi.Chuoiketnoi(chuoi, data_Account);
            Namecolumn();
        }
        private void Namecolumn()
        {

            data_Account.Columns[0].HeaderText = "Tài khoản"; data_Account.Columns[0].Width = 110;
            data_Account.Columns[1].HeaderText = "Mật khẩu"; data_Account.Columns[1].Width = 120;
            data_Account.Columns[2].HeaderText = "Họ và tên"; data_Account.Columns[2].Width = 100;
            data_Account.Columns[3].HeaderText = "Email"; data_Account.Columns[3].Width = 120;
            data_Account.Columns[4].HeaderText = "Phân Quyền"; data_Account.Columns[4].Width = 120;
            data_Account.Columns[5].HeaderText = "Trạng Thái"; data_Account.Columns[5].Width = 120;
            int sc = data_Account.Rows.Count;
            index = 0;
            last = sc - 1;
            lbl_solg.Text = "Số lượng bản ghi : " + (sc - 1);
            btn_xoa.Enabled = true;
            btn_sua.Enabled = true;
        }

        private void PopulateData(int curow)
        {
            string quyen = "";
            string trangthai = "";
            txt_tk.Text = data_Account.Rows[curow].Cells[0].Value.ToString();
            txt_mk.Text = data_Account.Rows[curow].Cells[1].Value.ToString();
            txt_fullname.Text = data_Account.Rows[curow].Cells[2].Value.ToString();
            txt_email.Text = data_Account.Rows[curow].Cells[3].Value.ToString();
            quyen = data_Account.Rows[curow].Cells[4].Value.ToString();
            trangthai = data_Account.Rows[curow].Cells[5].Value.ToString();
            if (quyen == "1") cb_quyen.Text = "Admin";
            if (quyen == "2") cb_quyen.Text = "Quan ly";
            if (quyen == "3") cb_quyen.Text = "Nguoi dung";
            if (trangthai == "1")
            {
                cb_trangthai.Text = "Hoat dong";
                btn_khoa.Enabled = true;
                btn_mokhoa.Enabled = false;
            }

            if (trangthai == "0")
            {
                cb_trangthai.Text = "Khoa";

                btn_khoa.Enabled = false;
                btn_mokhoa.Enabled = true;

            }
            txt_tk.Enabled = false;
            btn_them.Enabled = false;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;

        }

        private void Account_Manager_Load(object sender, EventArgs e)
        {

        }

        private void data_Account_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = data_Account.CurrentRow.Index;
            PopulateData(index);
        }
        // Hàm check Gmail
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

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (txt_mk.Text == "" || txt_tk.Text == "" || txt_email.Text == "" || txt_fullname.Text == "")
            {
                MessageBox.Show("Ban chưa nhập đầy đủ thông Tin !", "Error", MessageBoxButtons.OK);
            }
            else
            {
                string username = txt_tk.Text.Trim();
                string password = txt_mk.Text.Trim();
                string fullname = txt_fullname.Text.Trim();
                string mail = txt_email.Text.Trim(); ;
                string quyen = cb_quyen.Text;
                string trangthai = cb_trangthai.Text;
                string q1 = check_quyen(quyen);
                string t1 = check_trangthai(trangthai);
                if (username.Length > 20)
                {
                    MessageBox.Show("tên tài khoản quá dài ! chỉ nhập nhiều nhất 15 ký tự", "Error", MessageBoxButtons.OK);
                    txt_tk.Text = "";
                    txt_tk.Focus();

                }
                else if (isEmail(txt_email.Text) == false)
                {
                    MessageBox.Show("Định dạng mail sai vui lòng kiểm tra lại ", "Error", MessageBoxButtons.OK);
                    txt_email.Text = "";
                    txt_email.Focus();
                }
                else
                {
                    string sql = "Select count(*) from DangNhap where Taikhoan ='" + username + "'";
                    string sql1 = "Insert into DangNhap values(N'" + username + "',N'" + password + "',";
                    sql1 += "N'" + fullname + "','" + mail + "','" + q1 + "','" + t1 + "')";
                    chuoiketnoi.them(sql, sql1, data_Account);
                    chuoiketnoi.Chuoiketnoi(chuoi, data_Account);
                    Namecolumn();
                    Clear();
                }
            }
        }

        // hàm trả về quyền sử dung admin, quản lý, người dùng.
        string check_quyen(string quyen)
        {
            string quyenq = "";
            if (quyen.ToString() == "Admin") quyenq = "1";
            if (quyen.ToString() == "Quan ly") quyenq = "2";
            if (quyen.ToString() == "Nguoi Dung" || quyen.ToString() == "") quyenq = "3";
            return quyenq;
        }
        // hàm trả về trạng thái sử dụng
        string check_trangthai(string quyen1)
        {
            string tt = "";
            if (quyen1.ToString() == "Hoat dong") tt = "1";
            if (quyen1.ToString() == "Khoa") tt = "0";
            return tt;
        }
        // Làm mới textbox
        private void Clear()
        {
            txt_tk.Enabled = true;
            txt_mk.Text = "";
            txt_fullname.Text = "";
            txt_email.Text = "";
            txt_tk.Text = "";
            txt_search.Text = "";
            btn_xoa.Enabled = false;
            btn_sua.Enabled = false;
            btn_them.Enabled = true;
            btn_mokhoa.Enabled = false;
            txt_tk.Focus();

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (isEmail(txt_email.Text) == false)
            {
                MessageBox.Show("Định dạng mail sai vui lòng kiểm tra lại ", "Error", MessageBoxButtons.OK);
                txt_email.Text = "";
                txt_email.Focus();
            }
            else
            {
                string username = txt_tk.Text.Trim();
                string password = txt_mk.Text.Trim();
                string fullname = txt_fullname.Text.Trim();
                string mail = txt_email.Text.Trim();
                string quyen = cb_quyen.Text;
                string trangthai = cb_trangthai.Text;
                string q1 = "", t1 = "";
                q1 = check_quyen(quyen);
                t1 = check_trangthai(trangthai);
                string sql = "Update DangNhap set Matkhau = N'" + password + "',";
                sql += "FullName = N'" + fullname + "',Email = '" + mail + "',";
                sql += "phanquyen = '" + q1 + "', trangthai='" + t1 + "'  where Taikhoan = '" + username + "'";
                chuoiketnoi.Sua(sql);
                chuoiketnoi.Chuoiketnoi(chuoi, data_Account);
                Namecolumn();
                Clear();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete from DangNhap where Taikhoan = N'" + txt_tk.Text + "'";
            chuoiketnoi.Xoa(sql);
            chuoiketnoi.Chuoiketnoi(chuoi, data_Account);
            Namecolumn();
            Clear();
        }

        private void btn_khoa_Click(object sender, EventArgs e)
        {
            int trangthai = 0;
            string sql = "Update DangNhap set trangthai='" + trangthai + "'  where Taikhoan = '" + txt_tk.Text + "'";
            if (MessageBox.Show("Bạn có chắc chăn muốn khóa tài khoản này ? ", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                chuoiketnoi.Rekey(sql);
                MessageBox.Show("Bạn khóa thành công ! tài khoản sẽ không thế đăng nhập được ", "Thông báo", MessageBoxButtons.OK);
                chuoiketnoi.Chuoiketnoi(chuoi, data_Account);
                Namecolumn();
                Clear();
            }
        }

        private void btn_mokhoa_Click(object sender, EventArgs e)
        {

            int trangthai = 1;
            if (MessageBox.Show("Bạn có chắc chăn muốn mở khóa tài khoản này ? ", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string sql = "Update DangNhap set trangthai='" + trangthai + "'  where Taikhoan = '" + txt_tk.Text + "'";
                chuoiketnoi.Rekey(sql);
                MessageBox.Show("Bạn mở khóa thành công ! tài khoản hoạt động bình thường ", "Thông báo", MessageBoxButtons.OK);
                chuoiketnoi.Chuoiketnoi(chuoi, data_Account);
                Namecolumn();
                Clear();
            }
        }

        private void btn_nhaplai_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string tukhoa = txt_search.Text;
            String chuoi1 = "";
            if (cb_luachon.Text == "Tài khoản" || cb_luachon.SelectedItem == null)
            {
                chuoi1 = "Select * from DangNhap where Taikhoan like '%" + tukhoa + "%'";
            }
            else if (cb_luachon.SelectedItem == "Họ và Tên")
            {
                chuoi1 = "Select * from DangNhap where FullName like '%" + tukhoa + "%'";
            }


            chuoiketnoi.timkiem(chuoi1, data_Account);
            Namecolumn();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không ? ", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}

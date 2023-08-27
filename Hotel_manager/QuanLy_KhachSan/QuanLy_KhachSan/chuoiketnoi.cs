using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace QuanLy_KhachSan
{
    class chuoiketnoi
    {
        public static string sqlcon = @"Data Source=PAOPAO\SQLEXPRESS;Initial Catalog=Hotel_Manager_Data;Integrated Security=True";
        private static SqlConnection mycon;

        public static SqlConnection Mycon
        {
            get { return chuoiketnoi.mycon; }
            set { chuoiketnoi.mycon = value; }
        }
        public static SqlCommand com;
        public static SqlDataAdapter ad;
        public static DataTable dt;
        // DataTable table;
        public static BindingSource code;
        public static SqlCommandBuilder bd;


        // hàm kết nối
        public static void Chuoiketnoi(string chuoi, DataGridView db1)
        {
            try
            {

                ad = new SqlDataAdapter(chuoi, sqlcon);
                dt = new DataTable();
                bd = new SqlCommandBuilder(ad);
                ad.Fill(dt);
                db1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể kết nối " + ex, "Thông báo ! ");

            }
        }

        // Hàm Tìm kiếm
        public static void timkiem(string chuoi, DataGridView db2)
        {
            try
            {
                ad = new SqlDataAdapter(chuoi, sqlcon);
                dt = new DataTable();
                bd = new SqlCommandBuilder(ad);
                ad.Fill(dt);
                db2.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

        }

        // hàm xử lý combobox
        public static void xulycbx(string chuoi, ComboBox cbx)
        {
            ad = new SqlDataAdapter(chuoi, sqlcon);
            dt = new DataTable();

            ad.Fill(dt);
            cbx.DataSource = dt;
        }

        // hàm thêm dữ liệu

        public static void them_dl(string sql1, DataGridView dt)
        {
            try
            {
                mycon = new SqlConnection(sqlcon);
                mycon.Open();
                com = new SqlCommand(sql1, mycon);
                ad = new SqlDataAdapter(com);
                DataTable tb = new DataTable();
                ad.Fill(tb);
                dt.DataSource = tb;
                MessageBox.Show("Them Thanh công !", "Thong báo ");
                mycon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "" + ex);
            }

        }

        // hàm xóa dữ liệu
        public static void Xoa(string sql)
        {
            if (MessageBox.Show("Bạn có chắc chăn muốn Xóa không ? ", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    mycon = new SqlConnection(sqlcon);
                    mycon.Open();
                    com = new SqlCommand(sql, mycon);
                    com.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Tài khoản bạn sửa trùng với tài khoản đã có ! Vui lòng ktra lại ");
                }
            }
        }


        // hàm sửa 
        public static void Sua(string sql)
        {
            if (MessageBox.Show("Bạn có chắc chăn muốn sửa không ? ", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                try
                {
                    mycon = new SqlConnection(sqlcon);
                    mycon.Open();
                    com = new SqlCommand(sql, mycon);
                    com.ExecuteNonQuery();
                    mycon.Close();
                    MessageBox.Show("Bạn sửa thành công ! ", "Thông báo", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);

                }
            }
        }

        // update số lượng kho
        public static void update_solg(string sql)
        {
           
                try
                {
                    mycon = new SqlConnection(sqlcon);
                    mycon.Open();
                    com = new SqlCommand(sql, mycon);
                    com.ExecuteNonQuery();
                    mycon.Close();
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);

                }
            
        }
        // lấy ra ho tên đầy đủ
        public static string load(string chuoi, string hoten)
        {
            mycon = new SqlConnection(sqlcon);
            ad = new SqlDataAdapter(chuoi, sqlcon);

            dt = new DataTable("trang");
            ad.Fill(dt);
            code = new BindingSource();

            foreach (DataRow anh in dt.Rows)
            {
                code.Add(anh);
            }

            DataRow curent = (DataRow)code.Current;
            hoten = curent["FullName"].ToString();
            return hoten;
        }
        // lấy ra tên khách
        public static string load_tenkhach(string chuoi, string hoten)
        {
            mycon = new SqlConnection(sqlcon);
            ad = new SqlDataAdapter(chuoi, sqlcon);

            dt = new DataTable("trang");
            ad.Fill(dt);
            code = new BindingSource();

            foreach (DataRow anh in dt.Rows)
            {
                code.Add(anh);
            }

            DataRow curent = (DataRow)code.Current;
            hoten = curent["Tenkh"].ToString();
            return hoten;
        }
        // lấy ra ho tên đầy đủ
        public static string load_Tennv(string chuoi, string hoten)
        {
            mycon = new SqlConnection(sqlcon);
            ad = new SqlDataAdapter(chuoi, sqlcon);

            dt = new DataTable("trang");
            ad.Fill(dt);
            code = new BindingSource();

            foreach (DataRow anh in dt.Rows)
            {
                code.Add(anh);
            }

            DataRow curent = (DataRow)code.Current;
            hoten = curent["Tennv"].ToString();
            return hoten;
        }

        // ham mo khoa tai khoan
        public static void Rekey(string sql)
        {

            try
            {
                mycon = new SqlConnection(sqlcon);
                mycon.Open();
                com = new SqlCommand(sql, mycon);
                com.ExecuteNonQuery();
                mycon.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);

            }

        }


        // check tài khoản bị khóa
        public static int check_key(string chuoi, int trangthai)
        {
            mycon = new SqlConnection(sqlcon);
            ad = new SqlDataAdapter(chuoi, sqlcon);

            dt = new DataTable("trang");
            ad.Fill(dt);
            code = new BindingSource();

            foreach (DataRow anh in dt.Rows)
            {
                code.Add(anh);
            }

            DataRow curent = (DataRow)code.Current;
            trangthai = Convert.ToInt32(curent["trangthai"].ToString());
            return trangthai;
        }

        public static void Execute(string sql)
        {
            if (MessageBox.Show("Bạn có chắc chăn muốn xóa không ? ", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                try
                {
                    mycon = new SqlConnection(sqlcon);
                    mycon.Open();
                    com = new SqlCommand(sql, mycon);
                    com.ExecuteNonQuery();
                    mycon.Close();
                    MessageBox.Show("Bạn xóa thành công ! ", "Thông báo", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);

                }
            }
        }
        // kiem tra trung ID
        public static void them(string select, String sql1, DataGridView dt)
        {
            int i;
            mycon = new SqlConnection(sqlcon);
            mycon.Open();
            string sql = select;
            com = new SqlCommand(sql, mycon);
            i = (int)com.ExecuteScalar();


            if (i != 0)
            {
                MessageBox.Show("Mã đã tồn tại, vui lòng nhập mã mới ! ", "Error", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    them_dl(sql1, dt);
                }
                catch
                {
                    MessageBox.Show("Tài khoản đã tồn tại", "Thông báo");
                }
            }
        }

        public static void luu(string sql)
        {


            try
            {
                mycon = new SqlConnection(sqlcon);
                mycon.Open();
                com = new SqlCommand(sql, mycon);
                com.ExecuteNonQuery();
                mycon.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);

            }

        }

        // Đăng ký tài khoản
        public static void Themdangky(string select, String tk, String pass, String sql1)
        {
            int i;
            mycon = new SqlConnection(sqlcon);
            mycon.Open();
            string sql = select;
            com = new SqlCommand(sql, mycon);
            i = (int)com.ExecuteScalar();


            if (i != 0)
            {
                MessageBox.Show("Tài khoản đã tồn tại ! ", "Error", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    luu(sql1);


                    if (MessageBox.Show("Đăng ký thành công !Bạn có muốn đăng nhập luôn không ?", "Thông Báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        dangnhap.Login dt = new dangnhap.Login();
                        dt.Show();
                        dangnhap.Registration a = new dangnhap.Registration();
                        a.Close();
                    }
                   // mycon.Close();
                }
                catch
                {
                    MessageBox.Show("Tài khoản đã tồn tại", "Thông báo");
                }
            }
        }



        // kta ton tai tai khoan
        public static void ktratk(string tk, string newmk, string repass, string sql1)
        {
            int a = 0, b = 0, c = 0;
            mycon = new SqlConnection(sqlcon);
            mycon.Open();
            if (tk == "")
            {
                MessageBox.Show("Bạn chưa nhập tên tài khoản ", "Thông báo", MessageBoxButtons.OK);
            }

            else
            {
                com = new SqlCommand(sql1, mycon);
                a = (int)com.ExecuteScalar();
                // tra ve 0 hoac 1 
                // neu tra ve ten nguoi dung da ton tai va ta co the doi mk
                // tra ve 0 thi tai khoan ko ton tai nen ko doi dc mk
                if (a > 0)
                {
                    if (newmk == repass)
                    {
                        string sql4 = "update DangNhap set Matkhau = '" + newmk + "' where Taikhoan='" + tk + "'";
                        luu(sql4);

                    }
                    else
                    {
                        MessageBox.Show("Phần mật khẩu mới và nhập lại không trùng khớp ! Vui lòng kiểm tra lại", "Thông Báo", MessageBoxButtons.OK);
                    }
                }

                else
                {
                    string t = "Tai khoản này không tồn tại !,Bạn vui lòng kiểm tra lại ";
                    MessageBox.Show((t), "thong báo", MessageBoxButtons.OK);

                }

            }
        }
        public static void them_dl1(string sql1)
        {
            try
            {
                mycon = new SqlConnection(sqlcon);
                mycon.Open();
                com = new SqlCommand(sql1, mycon);
                ad = new SqlDataAdapter(com);
                DataTable tb = new DataTable();
                ad.Fill(tb);

                mycon.Close();
            }
            catch (Exception)
            {
                //MessageBox.Show("");
            }

        }


    }
}

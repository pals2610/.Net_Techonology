using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace QuanLy_KhachSan.hamhotro
{
    class ouput_colum_data
    {
        public static string sqlcon = chuoiketnoi.sqlcon;
        private static SqlConnection mycon;
        public static SqlCommand com;
        public static SqlDataAdapter ad;
        public static DataTable dt;
        // DataTable table;
        public static BindingSource code;
        public static SqlCommandBuilder bd;

        public static string load_one_colums(string chuoi, string ten,string colums)
        {
            try
            {
                mycon = new SqlConnection(sqlcon);
                ad = new SqlDataAdapter(chuoi, sqlcon);

                dt = new DataTable("hiep");
                ad.Fill(dt);
                code = new BindingSource();

                foreach (DataRow anh in dt.Rows)
                {
                    code.Add(anh);
                }

                DataRow curent = (DataRow)code.Current;
                ten = curent[colums.ToString()].ToString();
                return ten;

            }
            catch (Exception ex)
            {
                return ten;
            }
        }

        //public static string load_one_colums_nv(string chuoi, string ten, string colums)
        //{
        //    mycon = new SqlConnection(sqlcon);
        //    ad = new SqlDataAdapter(chuoi, sqlcon);

        //    dt = new DataTable("hiep");
        //    ad.Fill(dt);
        //    code = new BindingSource();

        //    foreach (DataRow anh in dt.Rows)
        //    {
        //        code.Add(anh);
        //    }

        //    DataRow curent = (DataRow)code.Current;
        //    ten = curent[colums.ToString()].ToString();
        //    return ten;
        //}
        // lấy ra số lương sản phầm trong kho
        public static string load_soluongkho(string chuoi, string soluong)
        {
            mycon = new SqlConnection(sqlcon);
            ad = new SqlDataAdapter(chuoi, sqlcon);

            dt = new DataTable("hiep");
            ad.Fill(dt);
            code = new BindingSource();

            foreach (DataRow anh in dt.Rows)
            {
                code.Add(anh);
            }

            DataRow curent = (DataRow)code.Current;
            soluong = curent["soluong"].ToString();
            return soluong;
        }

        // lấy ra têm sảm phẩm 
      
        public static string load_tensp(string chuoi, string tensp)
        {
            mycon = new SqlConnection(sqlcon);
            ad = new SqlDataAdapter(chuoi, sqlcon);

            dt = new DataTable("hiep");
            ad.Fill(dt);
            code = new BindingSource();

            foreach (DataRow anh in dt.Rows)
            {
                code.Add(anh);
            }

            DataRow curent = (DataRow)code.Current;
            tensp = curent["TenItem"].ToString();
            return tensp;
        }
        public static void update(string sql)
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
        //
    }
}

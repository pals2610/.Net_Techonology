using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace QuanLy_KhachSan.hoadon
{
    public partial class nhap_kho : Form
    {
        public double a = 0;
        public double y = 0;
        public static string chuoi = "Select Maitem,TenItem,giaban,soluong  From Khohang";
        public nhap_kho()
        {
            InitializeComponent();
            chuoiketnoi.Chuoiketnoi(chuoi, db1);
            Namecolumn1();
            // lbl_solg.Text = "Số lượng bản ghi : " + (sc - 1);
            btn_Add.Enabled = true;
            btn_Xoa.Enabled = true;
        }
        //Maitem,TenItem,gianhap,giaban,soluong
        private void Namecolumn1()
        {

            db1.Columns[0].HeaderText = "Mã Sản phẩm"; db1.Columns[0].Width = 110;
            db1.Columns[1].HeaderText = "Tên sản phẩm"; db1.Columns[1].Width = 120;
            db1.Columns[2].HeaderText = "Gía bán"; db1.Columns[2].Width = 80;
            db1.Columns[3].HeaderText = "Số lượng"; db1.Columns[3].Width = 80;
            
            int sc = db1.Rows.Count;

           
        }
        private void nhap_kho_Load(object sender, EventArgs e)
        {

        }

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            string load1 = "Select Maitem,TenItem,giaban,soluong from Khohang where TenItem like N'%" + txt_timkiem.Text + "%' ";
            chuoiketnoi.timkiem(load1, db1);
            Namecolumn1();

        }

        private void db1_Click(object sender, EventArgs e)
        {
            int curow = db1.CurrentRow.Index;
            txt_ma.Text = db1.Rows[curow].Cells[0].Value.ToString();
            txt_tensp.Text = db1.Rows[curow].Cells[1].Value.ToString();
            txt_gianhap.Text = db1.Rows[curow].Cells[2].Value.ToString();
            txt_spkho.Text = db1.Rows[curow].Cells[3].Value.ToString();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if ( txt_gianhap.Text == "" || txt_ma.Text == "" || txt_tensp.Text == "" || txt_spkho.Text == "" || txt_slgnhap.Text == "")
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin ", "Thông Báo", MessageBoxButtons.OK);
            else
            {
                int a = int.Parse(txt_gianhap.Text);
                int b = int.Parse(txt_slgnhap.Text);
                int d = int.Parse(txt_spkho.Text);
                if (txt_chietKhau.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập chiết khấu ! ", "Thông báo", MessageBoxButtons.OK);

                }
                else if (txt_slgnhap.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập So lg bán ! ", "Thông báo", MessageBoxButtons.OK);
                }

                else
                {
                    int x = d + b;

                    int s = a * b;
                    int n = dta2.Rows.Add();
                    double thanhtien = 0;
                    dta2.Rows[n].Cells[0].Value = txt_ma.Text;
                    dta2.Rows[n].Cells[1].Value = txt_tensp.Text;
                    dta2.Rows[n].Cells[2].Value = txt_gianhap.Text;
                    dta2.Rows[n].Cells[3].Value = txt_slgnhap.Text;
                    dta2.Rows[n].Cells[4].Value = s.ToString();
                 
                    string sql1 = "Update Khohang set soluong ='" + x.ToString() + "'   WHERE Maitem ='" + dta2.Rows[n].Cells[0].Value.ToString() + "'";
                    chuoiketnoi.luu(sql1);
                    string load1 = "Select Maitem,TenItem,giaban,soluong from Khohang where  Maitem ='" + dta2.Rows[n].Cells[0].Value.ToString() + "' ";
                    chuoiketnoi.Chuoiketnoi(load1, db1);
                    Namecolumn1();
                    txt_gianhap.Text = "";
                    txt_ma.Text = "";
                    txt_tensp.Text = "";
                    txt_spkho.Text = "";
                    txt_slgnhap.Text = "";
                    int sc = dta2.Rows.Count;
                    for (int i = 0; i < sc - 1; i++)
                    {

                        thanhtien += float.Parse(dta2.Rows[i].Cells[4].Value.ToString());


                    }
                    double g = double.Parse(txt_chietKhau.Text.ToString());
                    double m = thanhtien + thanhtien * g / 100;
                    lb_tien.Text = m.ToString();
                    txt_tienchu.Text = "" + hamhotro.chuyenso_thanhchu.So_chu(m);
                }
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                //Maitem,TenItem,gianhap,giaban,soluong

                double h = a - y;
                string sql1 = "Update Khohang set soluong ='" + h.ToString() + "'   WHERE Maitem ='" + txt_ma.Text + "'";
                chuoiketnoi.Execute(sql1);
                string load1 = "Select  Maitem,TenItem,giaban,soluong from Khohang where  Maitem ='" + txt_ma.Text + "' ";
                chuoiketnoi.Chuoiketnoi(load1, db1);
                Namecolumn1();
                int seleRow = dta2.CurrentCell.RowIndex;
                dta2.Rows.RemoveAt(seleRow);
                double thanhtien = 0;
                int sc = dta2.Rows.Count;
               
                txt_gianhap.Text = "";
                txt_ma.Text = "";
                txt_tensp.Text = "";
                txt_spkho.Text = "";
                txt_slgnhap.Text = "";
                btn_Xoa.Enabled = false;

                for (int i = 0; i < sc - 1; i++)
                {

                    thanhtien += float.Parse(dta2.Rows[i].Cells[4].Value.ToString());


                }
                btn_Add.Enabled = true;
                txt_slgnhap.Enabled = true;
                btn_Xoa.Enabled = false;
                double g = double.Parse(txt_chietKhau.Text.ToString());
                double m = thanhtien + thanhtien * g / 100;
                lb_tien.Text = m.ToString();
                txt_tienchu.Text = ""+hamhotro.chuyenso_thanhchu.So_chu(m);
            }
            catch
            {
                MessageBox.Show("Ban chua chọn thuoc sản phẩm để xóa ! ", "Thong bao", MessageBoxButtons.OK);
            }
        }

        private void dta2_Click(object sender, EventArgs e)
        {
            try
            {
                btn_Add.Enabled = false;
                txt_slgnhap.Enabled = false;
                btn_Xoa.Enabled = true;
                int curow = dta2.CurrentRow.Index;

                txt_ma.Text = dta2.Rows[curow].Cells[0].Value.ToString();
                txt_tensp.Text = dta2.Rows[curow].Cells[1].Value.ToString();
               
                txt_gianhap.Text = dta2.Rows[curow].Cells[2].Value.ToString();
                txt_slgnhap.Text = dta2.Rows[curow].Cells[3].Value.ToString();
                y = int.Parse(txt_slgnhap.Text);
                string full_name = "";
                //Maitem,TenItem,gianhap,giaban,soluong
                string chuoix = "Select soluong from Khohang where Maitem ='" + txt_ma.Text + "'";
                string solg = hamhotro.ouput_colum_data.load_one_colums(chuoix, full_name, "soluong");
                a = Convert.ToDouble(solg.Trim());
                

            }
            catch
            {
                MessageBox.Show("Trong ! ", "Thong bao", MessageBoxButtons.OK);
            }
        }

        private void txt_mathuoc_TextChanged(object sender, EventArgs e)
        {
            string full_name = "";
            //Maitem,TenItem,gianhap,giaban,soluong
            string chuoix = "Select soluong from Khohang where Maitem ='" + txt_ma.Text + "'";
            txt_spkho.Text = hamhotro.ouput_colum_data.load_one_colums(chuoix, full_name, "soluong");
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txt_gianhap.Text = "";
            txt_ma.Text = "";
            txt_tensp.Text = "";
            txt_spkho.Text = "";
            txt_slgnhap.Text = "";
            btn_Xoa.Enabled = false;
            txt_slgnhap.Enabled = true;
            btn_Add.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không ? ", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void TongTien_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_mahd.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập mã hóa đơn  ! ", "Thông báo", MessageBoxButtons.OK);
                    txt_mahd.Focus();
                }
                else
                {
                    double thanhtien = 0;
                    string s = "";
                    int sc = dta2.Rows.Count;
                    for (int i = 0; i < sc - 1; i++)
                    {

                        s += dta2.Rows[i].Cells[1].Value.ToString() + " : " + dta2.Rows[i].Cells[3].Value.ToString() + "    ,   ";
                        thanhtien += double.Parse(dta2.Rows[i].Cells[4].Value.ToString());

                    }
                    double g = double.Parse(txt_chietKhau.Text.ToString());
                    double m = thanhtien + thanhtien * g / 100;

                    string str1 = "Insert into NhapKho Values(N'"+txt_mahd.Text.ToString()+"',N'" + s.ToString() + "',N'" + date1.Value.ToString("yyyy-MM-dd HH:mm:ss")+ "','" + m.ToString() + "')";
                    chuoiketnoi.them_dl1(str1);
                  
                    string tenfile = txt_mahd.Text.ToString();
                    string duongdan = @"C:\Users\T\Desktop\Hotel_manager\excel\nhapkho\";
                    string tien = lb_tien.Text.Trim();
                    string tienchu = txt_tienchu.Text.Trim();
                    string ngaythang = date1.Value.ToString();
                    string tenbang = "HÓA ĐƠN NHẬP HÀNG NGÀY : " + date1.Value;
                    hamhotro.Xuat_Excel.nhapkho(dta2, duongdan, tien, tenfile, tenbang, ngaythang, tienchu);
                    string mofile = duongdan + tenfile + ".xlsx";
                    Process.Start(@"" + mofile);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lb_tien_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}

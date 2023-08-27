using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace QuanLy_KhachSan.Thongke
{
    public partial class thongke_hoadon_kho : Form
    {
        public string sqll = "select * from NhapKho";
        public thongke_hoadon_kho()
        {
            InitializeComponent();
            chuoiketnoi.Chuoiketnoi(sqll,data_phong);
            Namecolumn();
        }

        private void Namecolumn()
        {
            //id_hoadon,MaPhong,Makh,Manv,Ngaydatphong,Ngaynhanphong,Ngaytraphong,soluongnguoi,phiphong,phiphuthu,thanhtien,trangthai
            data_phong.Columns[0].HeaderText = "ID hóa đơn"; data_phong.Columns[0].Width = 130;
            data_phong.Columns[1].HeaderText = "Thông tin sản phẩm nhập "; data_phong.Columns[1].Width = 500;
            data_phong.Columns[2].HeaderText = "Ngày nhập "; data_phong.Columns[2].Width = 120;
            data_phong.Columns[3].HeaderText = "Thành tiền"; data_phong.Columns[3].Width = 120;
           
            int sc = data_phong.Rows.Count;
            double thanhtien = 0;
            for (int i = 0; i < sc - 1; i++)
            {

                thanhtien += float.Parse(data_phong.Rows[i].Cells[3].Value.ToString());


            }

            lb_tongtien.Text = thanhtien.ToString() + " (VNĐ) ";
            lb_chu.Text = hamhotro.chuyenso_thanhchu.So_chu(thanhtien).ToString();


        }
        private void thongke_hoadon_kho_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string chuoi = "SELECT * FROM NhapKho WHERE ngaynhap BETWEEN '" + date_batdau.Value.ToString("yyyy-MM-dd HH:mm:ss")+ "' AND '" + date_ketthuc.Value.ToString("yyyy-MM-dd HH:mm:ss")+ "'";
            chuoiketnoi.Chuoiketnoi(chuoi, data_phong);
            Namecolumn();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txt_tenfile.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên file ! xin vui lòng kiểm tra lại.", "Thông báo", MessageBoxButtons.OK);
                txt_tenfile.Focus();
            }
            else
            {

                string tenbang = " BẢNG THÔNG KÊ NHẬP KHO TỪ NGÀY  " + date_batdau.Value.ToString("yyyy-MM-dd HH:mm:ss")+ " ĐẾN NGÀY : " + date_ketthuc.Value;
                string tenfile = txt_tenfile.Text.Trim();
                string duongdan = @"E:\Study\HUFI\Năm 3 (2022-2023)\CNdotnet\CNdotnet\Nhom12_DoAn\HotelDesktop\Hotel_manager\QuanLy_KhachSan\QuanLy_KhachSan\bin\excel\";
                string s = lb_tongtien.Text.Trim();
                string tien_chu = lb_chu.Text.Trim();
                hamhotro.Xuat_Excel.thongke_kho(data_phong, duongdan, s, tenfile, tenbang, tien_chu);
                string mofile = duongdan + tenfile + ".xlsx";
                Process.Start(@"" + mofile);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chăn muốn thoát không ? ", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

    }
}

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
    public partial class ThongKe_DoanhThu : Form
    {   public string sql_traphong = "Select * from Hoadon  where trangthai = N'Đã thanh toán'";
     
        public ThongKe_DoanhThu()
        {
            InitializeComponent();
            chuoiketnoi.Chuoiketnoi(sql_traphong, data_phong);
            Namecolumn();
        }

        private void Namecolumn()
        {
            //id_hoadon,MaPhong,Makh,Manv,Ngaydatphong,Ngaynhanphong,Ngaytraphong,soluongnguoi,phiphong,phiphuthu,thanhtien,trangthai
            data_phong.Columns[0].HeaderText = "ID"; data_phong.Columns[0].Width = 130;
            data_phong.Columns[1].HeaderText = "Mã phòng"; data_phong.Columns[1].Width = 130;
            data_phong.Columns[2].HeaderText = "Mã khách "; data_phong.Columns[2].Width = 120;
            data_phong.Columns[3].HeaderText = "Mã nhân viên"; data_phong.Columns[3].Width = 120;
            data_phong.Columns[4].HeaderText = "Ngày đặt "; data_phong.Columns[4].Width = 120;
            data_phong.Columns[5].HeaderText = "Ngày nhận "; data_phong.Columns[5].Width = 120;
            data_phong.Columns[6].HeaderText = "Ngày trả "; data_phong.Columns[6].Width = 120;
            data_phong.Columns[7].HeaderText = "Số người"; data_phong.Columns[6].Width = 120;
            data_phong.Columns[8].HeaderText = "Phí phòng"; data_phong.Columns[6].Width = 120;
            data_phong.Columns[9].HeaderText = "Phí phị thu"; data_phong.Columns[6].Width = 120;
            data_phong.Columns[10].HeaderText = "Thành tiền"; data_phong.Columns[6].Width = 120;
            data_phong.Columns[11].HeaderText = "Trạng thái"; data_phong.Columns[6].Width = 120;
            int sc = data_phong.Rows.Count;
            double thanhtien = 0;
            for (int i = 0; i < sc - 1; i++)
            {

                thanhtien += float.Parse(data_phong.Rows[i].Cells[10].Value.ToString());


            }

            lb_tongtien.Text = thanhtien.ToString()+ " (VNĐ) " ;
            lb_chu.Text = hamhotro.chuyenso_thanhchu.So_chu(thanhtien).ToString();
            
            
        }
        private void ThongKe_DoanhThu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string chuoi = "SELECT * FROM Hoadon WHERE Ngaytraphong BETWEEN '" + date_batdau.Value.ToString("yyyy-MM-dd HH:mm:ss")+ "' AND '" + date_ketthuc.Value.ToString("yyyy-MM-dd HH:mm:ss")+ "'";
            chuoiketnoi.Chuoiketnoi(chuoi, data_phong);
            Namecolumn();
        }

        private void label5_Click(object sender, EventArgs e)
        {
           

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

                string tenbang = " BẢNG THÔNG KÊ THU NHẬP TỪ NGÀY  " + date_batdau.Value.ToString("yyyy-MM-dd HH:mm:ss")+ " ĐẾN NGÀY : " + date_ketthuc.Value;
                string tenfile = txt_tenfile.Text.Trim();
                string duongdan = @"E:\Study\HUFI\Năm 3 (2022-2023)\CNdotnet\CNdotnet\Nhom12_DoAn\HotelDesktop\Hotel_manager\QuanLy_KhachSan\QuanLy_KhachSan\bin\excel\";
                string s = lb_tongtien.Text.Trim();
                string tien_chu = lb_chu.Text.Trim();
                hamhotro.Xuat_Excel.thongke(data_phong, duongdan, s, tenfile, tenbang, tien_chu);
                string mofile = duongdan + tenfile + ".xlsx";
                Process.Start(@"" + mofile);
            }
        }

        private void date_batdau_ValueChanged(object sender, EventArgs e)
        {

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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace QuanLy_KhachSan.quanly_dat_thue_phong
{
    public partial class Tra_phong : Form
    {
      //  public string chuoi = "Select MaKh,TenItem,gia,soluong,thanhtien from Phuthu,Khohang where hoadon.Maitem = Khohang.Maitem ";
        public string sql_traphong = "Select * from Hoadon  where trangthai = N'Đang thuê' or trangthai = N'Đã thanh toán'";
        public double phiphong = 1;
        public double song =  0;
        public string phuthu = "0";
        public string thanhtien = "0";
        public double tien_phuthu = 0;
       // string id_phong_old = "";
        public string trangthai = "Đã đặt";
        public string trangthai1 = "";
        public Tra_phong()
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

        }
        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void Tra_phong_Load(object sender, EventArgs e)
        {

        }

        private void data_phong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //id_hoadon,MaPhong,Makh,Manv,Ngaydatphong,Ngaynhanphong,Ngaytraphong,soluongnguoi,phiphong,phiphuthu,thanhtien,trangthai
            string name = "";
             int curow = data_phong.CurrentRow.Index;
             txt_id_hd.Text = data_phong.Rows[curow].Cells[0].Value.ToString();
             txt_id_phong.Text = data_phong.Rows[curow].Cells[1].Value.ToString();
             txt_id_khach.Text = data_phong.Rows[curow].Cells[2].Value.ToString();
             txt_id_nv.Text = data_phong.Rows[curow].Cells[3].Value.ToString();
             date_dat.Text = data_phong.Rows[curow].Cells[4].Value.ToString();
             date_thue.Text = data_phong.Rows[curow].Cells[5].Value.ToString();
             date_traphong.Text = data_phong.Rows[curow].Cells[6].Value.ToString();
             txt_song.Text = data_phong.Rows[curow].Cells[7].Value.ToString();
             trangthai1 = data_phong.Rows[curow].Cells[11].Value.ToString();
             lb_name_phieu.Text = lb_tenkhach.Text + "_" + lb_tenphong.Text;
             if (String.Compare(trangthai1, "Đã thanh toán", true) == 0)
             {
                 button1.Enabled = false;
                 txt_phiphong.Text = data_phong.Rows[curow].Cells[8].Value.ToString();
                 txt_phuthu.Text = data_phong.Rows[curow].Cells[9].Value.ToString();
                 txt_tongtien.Text = data_phong.Rows[curow].Cells[10].Value.ToString();
             }
             else
             {
                 button1.Enabled = true;
             }

             if (txt_song.Text == "")
                 song = 0;
             else
                song = Convert.ToDouble(txt_song.Text);


          
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (String.Compare("Trống", trangthai1, true) == 0 || trangthai1 =="")
          {
              MessageBox.Show("Phòng này chưa thuê , Bạn không thể thanh toán ,Xin vui lòng kiểm tra lại ! ", "Thông báo", MessageBoxButtons.OK);
          
          }
          else

          {
            string id_phong = txt_id_phong.Text.Trim();
           
            string sql = "Update Hoadon set Ngaytraphong='" + date_traphong.Value.ToString("yyyy-MM-dd HH:mm:ss")+ "',phiphong='" + txt_phiphong.Text + "',phiphuthu='" + txt_phuthu.Text + "',thanhtien='"+txt_tongtien.Text+"',trangthai = N'Đã thanh toán' where id_hoadon = '" + txt_id_hd.Text + "'";
     
            String sql2 = "Update Phong set Trangthai = N'Trống' where MaPhong = '" + id_phong + "'";
            if (MessageBox.Show("Bạn có muốn thanh toán không ?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
              
                hamhotro.ouput_colum_data.update(sql);
                hamhotro.ouput_colum_data.update(sql2);
                MessageBox.Show("Bạn đã thanh toán thành công ! ", "Thông báo ", MessageBoxButtons.OK);
                chuoiketnoi.Chuoiketnoi(sql_traphong, data_phong);
                Namecolumn();
            }
          }
            
        }
         

        private void txt_id_phong_TextChanged(object sender, EventArgs e)
        {
            string a = txt_id_phong.Text.ToString();
            string full_name = "";
            string gia1 = "";
            string cot = "TenPhong";
            string cot1 = "giaphong";
            if (txt_id_phong.Text != "")
            {

                string id = txt_id_phong.Text.ToString(); //Select MaKh from Khachhang
                string chuoi4 = "Select TenPhong from Phong where MaPhong ='" + a.Trim() + "'";
                string tendaydu = hamhotro.ouput_colum_data.load_one_colums(chuoi4, full_name, cot);
                string chuoi5 = " Select loaiphong from Phong where MaPhong ='" + a.Trim() + "'";
                string loaiphong1 = hamhotro.ouput_colum_data.load_one_colums(chuoi5, gia1, "loaiphong");
                string chuoi6 = " Select giaphong from LPhong where loaiphong ='" + loaiphong1.Trim() + "'";
                string giaphong = hamhotro.ouput_colum_data.load_one_colums(chuoi6, gia1, cot1);
                gia_p.Text =""+giaphong +" VNĐ" ;
                lb_tenphong.Text = "" + tendaydu;
                phiphong = Convert.ToDouble(giaphong);
            }
            
        }
        private void Name_colums_phuthu()
        {
            //MaKh,tensp,gia,soluong,thanhtien
            int sc = data_phuthu.Rows.Count;
            data_phuthu.Columns[0].HeaderText = "Mã khách"; data_phong.Columns[0].Width = 130;
            data_phuthu.Columns[1].HeaderText = "Tên sản phẩm"; data_phong.Columns[1].Width = 130;
            data_phuthu.Columns[2].HeaderText = "Giá "; data_phong.Columns[2].Width = 120;
            data_phuthu.Columns[3].HeaderText = "Số lượng"; data_phong.Columns[3].Width = 120;
            data_phuthu.Columns[4].HeaderText = "Thành tiền "; data_phong.Columns[4].Width = 120;
           
            for (int i = 0; i < sc - 1; i++)
            {

                tien_phuthu += Double.Parse(data_phuthu.Rows[i].Cells[4].Value.ToString());


            }
            txt_phuthu.Text = "" + tien_phuthu;
           

        }
        private void txt_id_khach_TextChanged(object sender, EventArgs e)
        {
            string a = txt_id_khach.Text.ToString();
            string full_name = "";
            string cot = "Tenkh";
            if (txt_id_khach.Text != "")
            {

                string id = txt_id_khach.Text.ToString(); //Select MaKh from Khachhang
                string chuoi4 = "Select Tenkh from Khachhang where MaKh ='" + a.Trim() + "'";
                string tendaydu = hamhotro.ouput_colum_data.load_one_colums(chuoi4, full_name, cot);
                lb_tenkhach.Text = "" + tendaydu;
            }
            string chuoi1 = "Select MaKh,tensp,gia,soluong,thanhtien from Phuthu where MaKh = N'" + a + "' "; //MaKh,TenItem,gia,soluong,thanhtien from Phuthu,Khohang where hoadon.Maitem = Khohang.Maitem
            chuoiketnoi.timkiem(chuoi1, data_phuthu);
            Name_colums_phuthu();
        
        }

        private void txt_id_nv_TextChanged(object sender, EventArgs e)
        {
            string a = txt_id_nv.Text.ToString();
            string full_name = "";
            string cot = "Tennv";
            if (txt_id_nv.Text != "")
            {

                string id = txt_id_nv.Text.ToString(); //Select MaKh from Khachhang
                string chuoi4 = "Select Tennv from Nhanvien where Manv ='" + a.Trim() + "'";
                string tendaydu = hamhotro.ouput_colum_data.load_one_colums(chuoi4, full_name, cot);
                lb_ten_nv.Text = "" + tendaydu;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void date_traphong_ValueChanged(object sender, EventArgs e)
        {
            DateTime ngaymuon = Convert.ToDateTime(date_thue.Value);
            DateTime ngaytra = Convert.ToDateTime(date_traphong.Value);
            TimeSpan Time = ngaytra - ngaymuon;
            
            int TongSoNgay = Time.Days;
           
            double tien =(double) phiphong * TongSoNgay * song;
            double tongtien = tien_phuthu + tien;
            lb_ngaythue.Text = "" + TongSoNgay;
            txt_phiphong.Text = "" + tien;
            txt_tongtien.Text = "" + tongtien;
            

        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {

            string tukhoa = txt_search.Text;
            String chuoi1 = "";
            if (String.Compare(cb_luachon.Text, "Mã phòng", true) == 0 || cb_luachon.SelectedItem == null)
            {
                chuoi1 = "Select * from Hoadon where MaPhong like N'%" + tukhoa + "%'";
            }
            else if (String.Compare(cb_luachon.Text, "Mã khách", true) == 0)
            {
                chuoi1 = "Select * from Hoadon where MaKh like N'%" + tukhoa + "%'";
            }
            else
            {
                chuoi1 = "Select * from Hoadon where trangthai like N'%" + tukhoa + "%'";
            }

            chuoiketnoi.timkiem(chuoi1, data_phong);
            Namecolumn();
        }

        private void btn_thoat1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chăn muốn thoát không ? ", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //DataGridView g, string tenkhach, string ngaythue, string ngaytra, string giaphong, string songaythue, string songuoi, string phiphong,string phuthu,string tongtien
            string tenkhach = lb_tenkhach.Text;
            string ngaythue = date_thue.Value.ToString();
            string ngaytra = date_traphong.Value.ToString();
            string giaphong = gia_p.Text;
            string songaythue = lb_ngaythue.Text;
            string songuoi = txt_song.Text;
            string phiphong = txt_phiphong.Text;
            string phuthu = txt_phuthu.Text;
            string tongtien = txt_tongtien.Text;
            string duongdan = @"E:\Study\HUFI\Năm 3 (2022-2023)\CNdotnet\CNdotnet\Nhom12_DoAn\HotelDesktop\Hotel_manager\QuanLy_KhachSan\QuanLy_KhachSan\bin\excel\";
            string tenfile = lb_name_phieu.Text.Trim();
            hamhotro.Xuat_Excel.Export_Hoadon(data_phuthu, tenkhach,ngaythue,ngaytra,giaphong,songaythue,songuoi,phiphong,phuthu,tongtien,duongdan,tenfile);
            string mofile = duongdan + tenfile + ".xlsx";
            Process.Start(@"" + mofile);

        }
    }
}

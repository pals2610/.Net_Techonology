using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLy_KhachSan.quanly_dat_thue_phong
{
    public partial class Dat_phong : Form
    {

        public string chuoi = "Select * from phong where trangthai =N'Trống' ";
        public string sql_datphong = "Select id_hoadon,MaPhong,Makh,Manv,Ngaydatphong,soluongnguoi,trangthai from Hoadon ";
        public string phiphong = "0";
        public string phuthu = "0";
        public string thanhtien = "0";
        string id_phong_old = "";
        public string trangthai = "Đã đặt";
        public Dat_phong()
        {
            InitializeComponent();
            chuoiketnoi.Chuoiketnoi(chuoi, data_phong);
            Namecolumn();
            chuoiketnoi.Chuoiketnoi(sql_datphong, data_datphong);
            Name_colums_datphong();
            load_makh();
            load_nv();
            btn_sua.Enabled = false;
            btn_delete.Enabled = false;
        }

        private void Namecolumn()
        {

            data_phong.Columns[0].HeaderText = "Mã phòng"; data_phong.Columns[0].Width = 130;
            data_phong.Columns[1].HeaderText = "Tên phòng"; data_phong.Columns[1].Width = 130;
            data_phong.Columns[2].HeaderText = "Loại phòng"; data_phong.Columns[2].Width = 120;
            data_phong.Columns[3].HeaderText = "Mô tả"; data_phong.Columns[3].Width = 120;
            data_phong.Columns[4].HeaderText = "Số người tối đa"; data_phong.Columns[4].Width = 140;
            
            data_phong.Columns[5].HeaderText = "Trạng Thái"; data_phong.Columns[5].Width = 120;
            int sc = data_phong.Rows.Count;
           
        }
        //Hoadon (id_hoadon,MaPhong,Makh,Manv,Ngaydatphong,Ngaynhanphong,Ngaytraphong,soluongnguoi,phiphong,phiphuthu,thanhtien,trangthai)
        private void Name_colums_datphong()
        {

            data_datphong.Columns[0].HeaderText = "ID"; data_datphong.Columns[0].Width = 130;
            data_datphong.Columns[1].HeaderText = "Mã phòng"; data_datphong.Columns[1].Width = 130;
            data_datphong.Columns[2].HeaderText = "Mã khách"; data_datphong.Columns[2].Width = 120;
            data_datphong.Columns[3].HeaderText = "Mã nhân viên"; data_datphong.Columns[3].Width = 120;
            data_datphong.Columns[4].HeaderText = "Ngày đặt phòng"; data_datphong.Columns[4].Width = 140;
            data_datphong.Columns[5].HeaderText = "Số lương người"; data_datphong.Columns[5].Width = 140;
            data_datphong.Columns[6].HeaderText = "Trạng Thái"; data_datphong.Columns[6].Width = 120;
            int sc = data_phong.Rows.Count;

        }
        private void Dat_phong_Load(object sender, EventArgs e)
        {

        }
        private void load_makh()
        {

            string load_makhach = "Select MaKh from Khachhang";
            chuoiketnoi.xulycbx(load_makhach, txt_id_khach);
            txt_id_khach.DisplayMember = "MaKh";
            txt_id_khach.ValueMember = "MaKh";

        }
        //Hoadon (id_hoadon,MaPhong,Makh,Manv,Ngaydatphong,Ngaynhanphong,Ngaytraphong,soluongnguoi,phiphong,phiphuthu,thanhtien,trangthai)
        private void load_nv()
        {

            string load_nhanvien = "Select Manv from Nhanvien";
            chuoiketnoi.xulycbx(load_nhanvien, txt_id_nv);
            txt_id_nv.DisplayMember = "Manv";
            txt_id_nv.ValueMember = "Manv";

        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {

            string tukhoa = txt_search.Text;
            String chuoi1 = "";
            if (String.Compare(cb_luachon.Text, "Mã phòng", true) == 0 || cb_luachon.SelectedItem == null)
            {
                chuoi1 = "Select * from Phong where MaPhong like N'%" + tukhoa + "%'";
            }
            else if (String.Compare(cb_luachon.Text, "Tên phòng", true) == 0)
            {
                chuoi1 = "Select * from Phong where TenPhong like N'%" + tukhoa + "%'";
            }
            else if (String.Compare(cb_luachon.Text, "Loại phòng", true) == 0)
            {
                chuoi1 = "Select * from Phong where loaiphong like N'%" + tukhoa + "%'";
            }
            else if (String.Compare(cb_luachon.Text, "Mô tả phòng", true) == 0)
            {
                chuoi1 = "Select * from Phong where Mota like N'%" + tukhoa + "%'";
            }
            else if (String.Compare(cb_luachon.Text, "Số người tối đa", true) == 0)
            {
                chuoi1 = "Select * from Phong where songtoida like N'%" + tukhoa + "%'";
            }
            else if (String.Compare(cb_luachon.Text, "Giá phòng", true) == 0)
            {
                chuoi1 = "Select * from Phong where giaphong like N'%" + tukhoa + "%'";
            }
            else
            {
                chuoi1 = "Select * from Phong where trangthai like N'%" + tukhoa + "%'";
            }

            chuoiketnoi.timkiem(chuoi1, data_phong);
            Namecolumn();
        }

        private void txt_id_khach_TextChanged(object sender, EventArgs e)
        {
            string a = txt_id_khach.SelectedValue.ToString();
            string full_name = "";
            string cot = "Tenkh";
            if (txt_id_khach.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                
                string id = txt_id_khach.SelectedValue.ToString(); //Select MaKh from Khachhang
                string chuoi4 = "Select Tenkh from Khachhang where MaKh ='" + id.Trim() + "'";
                string tendaydu = hamhotro.ouput_colum_data.load_one_colums(chuoi4, full_name, cot);
                lb_khach.Text = "Tên: " + tendaydu;
            }
            else
            {
                string id = "kh01"; //Select MaKh from Khachhang
                string chuoi4 = "Select Tenkh from Khachhang where MaKh ='" + id.Trim() + "'";
                string tendaydu = hamhotro.ouput_colum_data.load_one_colums(chuoi4, full_name,cot);
                lb_khach.Text = "Tên: " + tendaydu;

            }
        }

        private void txt_id_nv_TextChanged(object sender, EventArgs e)
        {
            string a = txt_id_nv.SelectedValue.ToString();
            string full_name = "";
            string cot = "Tennv";
            if (txt_id_nv.SelectedValue.ToString() != "System.Data.DataRowView")
            {

                string id = txt_id_nv.SelectedValue.ToString(); //Select MaKh from Khachhang
                string chuoi4 = "Select Tennv from Nhanvien where Manv ='" + id.Trim() + "'";
                string tendaydu = hamhotro.ouput_colum_data.load_one_colums(chuoi4, full_name, cot);
                lb_nhanvien.Text = "Tên: " + tendaydu;
            }
            else
            {
                string id = "nv01"; //Select MaKh from Khachhang
                string chuoi4 = "Select Tennv from Nhanvien where Manv ='" + id.Trim() + "'";
                string tendaydu = hamhotro.ouput_colum_data.load_one_colums(chuoi4, full_name, cot);
                lb_nhanvien.Text = "Tên: " + tendaydu;

            }
        }

        private void data_phong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int curow = data_phong.CurrentRow.Index;
            txt_id_phong.Text = data_phong.Rows[curow].Cells[0].Value.ToString();
            string trangthai = data_phong.Rows[curow].Cells[5].Value.ToString();
            if (String.Compare(trangthai, "Trống", true) != 0)
            {
                button1.Enabled = false;
            }

            else
            {
                button1.Enabled = true;
            }
          
        }

        private void txt_id_phong_TextChanged(object sender, EventArgs e)
        {
            string a = txt_id_phong.Text.ToString();
            string full_name = "";
            string cot = "TenPhong";
            if ( txt_id_phong.Text != "")
            {

                string id = txt_id_phong.Text.ToString(); //Select MaKh from Khachhang
                string chuoi4 = "Select TenPhong from Phong where MaPhong ='" + a.Trim() + "'";
                string tendaydu = hamhotro.ouput_colum_data.load_one_colums(chuoi4, full_name, cot);
                lb_phong.Text = "Tên phòng: " + tendaydu;
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (id_hd.Text == "" || txt_id_phong.Text == "" || txt_id_nv.Text == "" || txt_id_khach.Text == "" || txt_song.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin ! ", "Thông báo ", MessageBoxButtons.OK);
                id_hd.Focus();

            }
            else
            {
                string full_name = "";
                string ma_p = txt_id_phong.Text.Trim();
                string cot = "songtoida";
                string chuoi4 = "Select songtoida from Phong where MaPhong ='" + ma_p.Trim() + "'";
                double songtoida =Convert.ToDouble(hamhotro.ouput_colum_data.load_one_colums(chuoi4, full_name, cot));
                double songuoi = Convert.ToDouble(txt_song.Text.Trim());
                string ma_hd = id_hd.Text.Trim();
                
                string ma_k = txt_id_khach.Text.Trim();
                string ma_nv = txt_id_nv.Text.Trim();
                string ngaydatphong = txt_ngaydat.Value.ToString("yyyy-MM-dd HH:mm:ss");
                string song = txt_song.Text.Trim();
                if (songuoi > songtoida)
                {
                    MessageBox.Show("Bạn quá đông người không thể đặt được phòng ! Bạn hãy thuê phòng khác ! ", "Thông báo", MessageBoxButtons.OK);
                        txt_song.Text="";
                    txt_song.Focus();
                }
                else
                {
                    //Hoadon (id_hoadon,MaPhong,Makh,Manv,Ngaydatphong,Ngaynhanphong,Ngaytraphong,soluongnguoi,phiphong,phiphuthu,thanhtien,trangthai)
                    string sql = "Select count(*) from Hoadon where id_hoadon ='" + id_hd.Text.Trim() + "'";
                    string sql1 = "Insert into Hoadon values(N'" + ma_hd + "','" + ma_p + "','" + ma_k + "','" + ma_nv + "','" + ngaydatphong + "','" + ngaydatphong + "','" + ngaydatphong + "','" + song + "','" + phiphong + "','" + phuthu + "','" + thanhtien + "',N'" + trangthai + "')";
                    string sq2 = "Update Phong set trangthai = N'Đã đặt' where MaPhong = '" + ma_p + "'";
                    hamhotro.ouput_colum_data.update(sq2);

                    chuoiketnoi.them(sql, sql1, data_datphong);
                    chuoiketnoi.Chuoiketnoi(chuoi, data_phong);
                    Namecolumn();
                    chuoiketnoi.Chuoiketnoi(sql_datphong, data_datphong);
                    Name_colums_datphong();
                    load_makh();
                    load_nv();
                    Clear();
                
                }
            
            
            }
        }
        public void Clear()
        {
            id_hd.Text = "";
            txt_id_nv.Text = "";
            txt_song.Text = "";
            id_hd.Focus();
            button1.Enabled = true;
            id_hd.Enabled = true;
            btn_sua.Enabled = false;
            btn_delete.Enabled = false;
        
        }

        private void data_datphong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //id_hoadon,MaPhong,Makh,Manv,Ngaydatphong,soluongnguoi,trangthai
            int curow = data_datphong.CurrentRow.Index;
            id_hd.Text = data_datphong.Rows[curow].Cells[0].Value.ToString();
            txt_id_phong.Text = data_datphong.Rows[curow].Cells[1].Value.ToString();
            txt_id_khach.Text = data_datphong.Rows[curow].Cells[2].Value.ToString();
            txt_id_nv.Text = data_datphong.Rows[curow].Cells[3].Value.ToString();
            txt_ngaydat.Text = data_datphong.Rows[curow].Cells[4].Value.ToString();
            txt_song.Text = data_datphong.Rows[curow].Cells[5].Value.ToString();
            id_phong_old = txt_id_phong.Text;
            button1.Enabled = false;
            id_hd.Enabled = false;
            btn_delete.Enabled = true;
            btn_sua.Enabled = true;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string full_name = "";
            string ma_p = txt_id_phong.Text.Trim();
            string cot = "songtoida";
            string chuoi4 = "Select songtoida from Phong where MaPhong ='" + ma_p.Trim() + "'";
            double songtoida = Convert.ToDouble(hamhotro.ouput_colum_data.load_one_colums(chuoi4, full_name, cot));
            double songuoi = Convert.ToDouble(txt_song.Text.Trim());
            string ma_hd = id_hd.Text.Trim();

            string ma_k = txt_id_khach.Text.Trim();
            string ma_nv = txt_id_nv.Text.Trim();
            string ngaydatphong = txt_ngaydat.Value.ToString("yyyy-MM-dd HH:mm:ss");
            string song = txt_song.Text.Trim();
            if (id_hd.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập ID .Vui lòng kiểm tra lại  ! ", "Thông báo", MessageBoxButtons.OK);
              
                id_hd.Focus();
            }
            else  if (songuoi > songtoida)
            {
                MessageBox.Show("Bạn quá đông người không thể đặt được phòng ! Bạn hãy thuê phòng khác ! ", "Thông báo", MessageBoxButtons.OK);
                txt_song.Text = "";
                txt_song.Focus();
            }
            else
            {
                //Hoadon (id_hoadon,MaPhong,Makh,Manv,Ngaydatphong,Ngaynhanphong,Ngaytraphong,soluongnguoi,phiphong,phiphuthu,thanhtien,trangthai)
                //id_hoadon,MaPhong,Makh,Manv,Ngaydatphong,soluongnguoi,trangthai
                string sql = "Update Hoadon set MaPhong = N'" + ma_p + "',Makh = '" + ma_k + "',Manv = '" + ma_nv + "',Ngaydatphong='" + ngaydatphong + "',Ngaynhanphong='" + ngaydatphong + "',Ngaytraphong='" + ngaydatphong + "',soluongnguoi='" + song + "' where id_hoadon = '" + ma_hd + "'";
                chuoiketnoi.Sua(sql);
                string sq2 = "Update Phong set trangthai = N'Đã đặt' where MaPhong = '" + ma_p + "'";
                string sq3 = "Update Phong set trangthai = N'Trống' where MaPhong = '" + id_phong_old + "'";
                if (String.Compare(id_phong_old, ma_p, true) != 0)
                {
                    hamhotro.ouput_colum_data.update(sq2);
                    hamhotro.ouput_colum_data.update(sq3);
                }
                else
                {
                    hamhotro.ouput_colum_data.update(sq2);
                }
                chuoiketnoi.Chuoiketnoi(chuoi, data_phong);
                Namecolumn();
                chuoiketnoi.Chuoiketnoi(sql_datphong, data_datphong);
                Name_colums_datphong();
                load_makh();
                load_nv();
                Clear();
            
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string ma_p = txt_id_phong.Text.Trim();
            if (id_hd.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập id hóa đơn , Vui lòng kiểm tra lại", "Thông báo ", MessageBoxButtons.OK);
                id_hd.Focus();
            }
            else
            {
                string sq2 = "Update Phong set trangthai = N'Trống' where MaPhong = '" + ma_p + "'";
                string sql = "Delete from Hoadon where id_hoadon = N'" + id_hd.Text.Trim() + "'";
                chuoiketnoi.Xoa(sql);
                hamhotro.ouput_colum_data.update(sq2);
                chuoiketnoi.Chuoiketnoi(chuoi, data_phong);
                Namecolumn();
                chuoiketnoi.Chuoiketnoi(sql_datphong, data_datphong);
                Name_colums_datphong();
                load_makh();
                load_nv();
                Clear();
            
            }
           
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chăn muốn thoát không ? ", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLy_KhachSan.quanly
{
    public partial class Room_manager : Form
    {
        int index = 0;
        int last = 0;
        public static string chuoi = "Select  * From Phong";
        public Room_manager()
        {
            InitializeComponent();
            chuoiketnoi.Chuoiketnoi(chuoi, data_gridview);
            Namecolumn();
            load_Lphong();
        }
     
        private void Namecolumn()
        {

            data_gridview.Columns[0].HeaderText = "Mã phòng"; data_gridview.Columns[0].Width = 130;
            data_gridview.Columns[1].HeaderText = "Tên phòng"; data_gridview.Columns[1].Width = 130;
            data_gridview.Columns[2].HeaderText = "Loại phòng"; data_gridview.Columns[2].Width = 120;
            data_gridview.Columns[3].HeaderText = "Mô tả"; data_gridview.Columns[3].Width = 120;
            data_gridview.Columns[4].HeaderText = "Số người tối đa"; data_gridview.Columns[4].Width = 140;
          
            data_gridview.Columns[5].HeaderText = "Trạng Thái"; data_gridview.Columns[5].Width = 120;
            int sc = data_gridview.Rows.Count;
            index = 0;
            last = sc - 1;
            lbl_solg.Text = "Số lượng bản ghi : " + (sc - 1);
            btn_xoa.Enabled = true;
            btn_sua.Enabled = true;
        }
        private void load_Lphong()
        {

            string load_loaiphong = "Select loaiphong from LPhong";
            chuoiketnoi.xulycbx(load_loaiphong, cbx_loaip);
            cbx_loaip.DisplayMember = "loaiphong";
            cbx_loaip.ValueMember = "loaiphong";

        }
        private void cbx_loaip_TextChanged(object sender, EventArgs e)
        {
           
        }
        
        private void PopulateData(int curow)
        {
           
            string trangthai = "";
            txt_ma.Enabled = false;
            txt_ma.Text = data_gridview.Rows[curow].Cells[0].Value.ToString();
            txt_ten.Text = data_gridview.Rows[curow].Cells[1].Value.ToString();
            cbx_loaip.Text = data_gridview.Rows[curow].Cells[2].Value.ToString();
            rtb_mota.Text = data_gridview.Rows[curow].Cells[3].Value.ToString();
            txt_song.Text = data_gridview.Rows[curow].Cells[4].Value.ToString();
            
            cbx_tt.Text = data_gridview.Rows[curow].Cells[5].Value.ToString();
            
           
            btn_them.Enabled = false;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;

        }

        private void Room_manager_Load(object sender, EventArgs e)
        {

        }

        private void data_gridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            index = data_gridview.CurrentRow.Index;
            PopulateData(index);
        }

        private void txt_giap_TextChanged(object sender, EventArgs e)
        {
           
        }
        
        private void btn_them_Click(object sender, EventArgs e)
        {

           

            if (txt_ma.Text == "" || txt_ten.Text == "" || txt_song.Text == ""|| rtb_mota.Text == "")
            {
                MessageBox.Show("Ban chưa nhập đầy đủ thông Tin !", "Error", MessageBoxButtons.OK);
            }
            else
            {
                string map = txt_ma.Text.Trim();
                if (map.Length > 15)
                {
                    MessageBox.Show("mã sách quá dài ! chỉ nhập nhiều nhất 15 ký tự", "Error", MessageBoxButtons.OK);
                    txt_ma.Text = "";
                    txt_ma.Focus();

                }
                else
                {
                string loaip = "";
                        if (cbx_loaip.Text == "Standard")
                            loaip = "Standard";
                        else if (cbx_loaip.Text == "Superior")
                            loaip = "Superior";
                        else if (cbx_loaip.Text == "Deluxe")
                            loaip = "Deluxe";
                        else
                            loaip = "VIP";
                       
                        string sql = "Select count(*) from Phong where MaPhong ='" + map.Trim() + "'";
                        string sql1 = "Insert into Phong values(N'" + map + "',N'" + txt_ten.Text + "','" + loaip + "',N'" + rtb_mota.Text.Trim() + "','" + txt_song.Text + "',N'" +cbx_tt.Text + "' )";
                        chuoiketnoi.them(sql, sql1, data_gridview);
                        chuoiketnoi.Chuoiketnoi(chuoi, data_gridview);
                        Namecolumn();
                        Clear();

                    
                     
                }
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {

         
            string loaip = "";
            if (cbx_loaip.Text == "Standard")
                loaip = "Standard";
             if (cbx_loaip.Text == "Superior")
                loaip = "Superior";
             if (cbx_loaip.Text == "Deluxe")
                loaip = "Deluxe";
             if (cbx_loaip.Text == "VIP")
                loaip = "VIP";
            
             string sql = "Update Phong set TenPhong = N'" + txt_ten.Text + "',";
             sql += "loaiphong = N'" + loaip.Trim() + "',";
             sql += "Mota = N'" + rtb_mota.Text + "',songtoida = '" + txt_song.Text + "',trangthai= N'" + cbx_tt.Text + "'";
             sql += "where MaPhong = '" + txt_ma.Text + "'";
                chuoiketnoi.Sua(sql);
                chuoiketnoi.Chuoiketnoi(chuoi, data_gridview);
                Namecolumn();
                Clear();
         
            
        }
        public void Clear()
        {
            txt_ma.Enabled = true;
            txt_ma.Text = "";
           
            txt_song.Text = "";
            txt_ten.Text = "";
            txt_search.Text = "";
            rtb_mota.Text = "";
            btn_xoa.Enabled = false;
            btn_sua.Enabled = false;
            btn_them.Enabled = true;
          
            txt_ma.Focus();

        }
        private void btn_nhaplai_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete from Phong where MaPhong = N'" + txt_ma.Text + "'";
            chuoiketnoi.Xoa(sql);
            chuoiketnoi.Chuoiketnoi(chuoi, data_gridview);
            Namecolumn();

            Clear();
        }

        private void dau_Click(object sender, EventArgs e)
        {
            index = 0;
            PopulateData(index);
            data_gridview.CurrentCell = data_gridview.Rows[index].Cells[0];
        }

        private void truoc_Click(object sender, EventArgs e)
        {
            index--;
            index = index < 0 ? 0 : index;
            PopulateData(index);
            data_gridview.CurrentCell = data_gridview.Rows[index].Cells[0];
        }

        private void sau_Click(object sender, EventArgs e)
        {
            index = index + 1;
            if (index >= last)
            {
                index = 0;

                PopulateData(index);
                data_gridview.CurrentCell = data_gridview.Rows[index].Cells[0];
            }
            else
            {
                PopulateData(index);
                data_gridview.CurrentCell = data_gridview.Rows[index].Cells[0];
            }
        }

        private void cuoi_Click(object sender, EventArgs e)
        {
            index = last - 1;
            PopulateData(index);
            data_gridview.CurrentCell = data_gridview.Rows[index].Cells[0];
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {

            string tukhoa = txt_search.Text;
            String chuoi1 = "";
            if (String.Compare(cb_luachon.Text,"Mã phòng",true)==0 || cb_luachon.SelectedItem == null)
            {
                chuoi1 = "Select * from Phong where MaPhong like N'%" + tukhoa + "%'";
            }
            else if (String.Compare(cb_luachon.Text,"Tên phòng",true)==0)
            {
                chuoi1 = "Select * from Phong where TenPhong like N'%" + tukhoa + "%'";
            }
            else if (String.Compare(cb_luachon.Text, "Loại phòng",true)==0)
            {
                chuoi1 = "Select * from Phong where loaiphong like N'%" + tukhoa + "%'";
            }
            else if (String.Compare(cb_luachon.Text,"Mô tả phòng",true)==0)
            {
                chuoi1 = "Select * from Phong where Mota like N'%" + tukhoa + "%'";
            }
            else if (String.Compare(cb_luachon.Text,"Số người tối đa",true) == 0)
            {
                chuoi1 = "Select * from Phong where songtoida like N'%" + tukhoa + "%'";
            }
            else if (String.Compare(cb_luachon.Text, "Giá phòng",true)==0)
            {
                chuoi1 = "Select * from Phong where giaphong like N'%" + tukhoa + "%'";
            }
            else
            {
                chuoi1 = "Select * from Phong where trangthai like N'%" + tukhoa + "%'";
            }

            chuoiketnoi.timkiem(chuoi1, data_gridview);
            Namecolumn();
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

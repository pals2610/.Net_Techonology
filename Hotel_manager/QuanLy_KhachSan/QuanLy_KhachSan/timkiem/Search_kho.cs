using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace QuanLy_KhachSan.timkiem
{
    public partial class Search_kho : Form
    {
        int index = 0;
        int last = 0;
        public static string chuoi = "Select  * From Khohang";
        public Search_kho()
        {
            InitializeComponent();
            chuoiketnoi.Chuoiketnoi(chuoi, data_gridview);
            Namecolumn();

        }
        private void Namecolumn()
        {

            data_gridview.Columns[0].HeaderText = "Mã Sản phẩm"; data_gridview.Columns[0].Width = 150;
            data_gridview.Columns[1].HeaderText = "Tên sản phẩm"; data_gridview.Columns[1].Width = 150;
            data_gridview.Columns[2].HeaderText = "Gía nhập"; data_gridview.Columns[3].Width = 120;
            data_gridview.Columns[3].HeaderText = "Số lượng"; data_gridview.Columns[2].Width = 120;
            data_gridview.Columns[4].HeaderText = "Gía bán"; data_gridview.Columns[3].Width = 120;
            int sc = data_gridview.Rows.Count;
            index = 0;
            last = sc - 1;
            lbl_solg.Text = "Số lượng bản ghi : " + (sc - 1);
            //btn_xoa.Enabled = true;
            //btn_sua.Enabled = true;
        }
        private void Search_kho_Load(object sender, EventArgs e)
        {

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chăn muốn thoát không ? ", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string tukhoa = txt_search.Text;
            String chuoi1 = "";
            if (String.Compare(cb_luachon.Text, "Mã sản phẩm", true) == 0 || cb_luachon.SelectedItem == null)
            {
                chuoi1 = "Select * from Khohang where Maitem like N'%" + tukhoa + "%'";
            }

            else
            {
                chuoi1 = "Select * from Khohang where TenItem like N'%" + tukhoa + "%'";
            }

            chuoiketnoi.timkiem(chuoi1, data_gridview);
            Namecolumn();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_tenfile.Text == "")
            {
                MessageBox.Show("Bạn hãy đặt tên cho file trước khi xuất Excel ! ", "Thông báo ", MessageBoxButtons.OK);
                txt_tenfile.Focus();
            }
            else
            {
                string ngaythang = txt_ngaythang.Value.ToString();
                string tenbang = "THÔNG TIN KHO HÀNG";
                string solg = lbl_solg.Text.Trim();
                string tenfile = txt_tenfile.Text.Trim();
                string duongdan = @"E:\Study\HUFI\Năm 3 (2022-2023)\CNdotnet\CNdotnet\Nhom12_DoAn\HotelDesktop\Hotel_manager\QuanLy_KhachSan\QuanLy_KhachSan\bin\excel\";
                hamhotro.Xuat_Excel.xuat1(data_gridview, duongdan, solg, tenfile, tenbang, ngaythang);
                string mofile = duongdan + tenfile + ".xlsx";
                Process.Start(@"" + mofile);

            }
        }
    }
}

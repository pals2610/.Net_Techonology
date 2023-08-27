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
    public partial class Kindofroom_Manager : Form
    {
        int index = 0;
        int last = 0;
        public static string chuoi = "Select  * From LPhong";
        public Kindofroom_Manager()
        {
            InitializeComponent();
            chuoiketnoi.Chuoiketnoi(chuoi, data_gridview);
            Namecolumn();
        }
        private void Namecolumn()
        {

            data_gridview.Columns[0].HeaderText = "Loại phòng"; data_gridview.Columns[0].Width = 130;
            data_gridview.Columns[1].HeaderText = "Mô tả"; data_gridview.Columns[1].Width = 200;
            data_gridview.Columns[2].HeaderText = "Giá phòng"; data_gridview.Columns[2].Width = 100;
           
            int sc = data_gridview.Rows.Count;
            index = 0;
            last = sc - 1;
            lbl_solg.Text = "Số lượng bản ghi : " + (sc - 1);
            btn_xoa.Enabled = false;
            btn_sua.Enabled = false;
        }
        private void Kindofroom_Manager_Load(object sender, EventArgs e)
        {

        }
        private void PopulateData(int curow)
        {
           
            txt_ma.Text = data_gridview.Rows[curow].Cells[0].Value.ToString();
            rtb_mota.Text = data_gridview.Rows[curow].Cells[1].Value.ToString();
            txt_gia.Text = data_gridview.Rows[curow].Cells[2].Value.ToString();
            txt_ma.Enabled = false;
            btn_them.Enabled = false;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;

        }
        private void data_gridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = data_gridview.CurrentRow.Index;
            PopulateData(index);
        }

        private void txt_gia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        public void Clear()
        {
            txt_ma.Enabled = true;
            rtb_mota.Text = "";
            txt_gia.Text = "";
            txt_ma.Text = "";
            btn_xoa.Enabled = false;
            btn_sua.Enabled = false;
            btn_them.Enabled = true;
            txt_ma.Focus();

        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            if (txt_ma.Text == "" || rtb_mota.Text == "" || txt_gia.Text == "" )
            {
                MessageBox.Show("Ban chưa nhập đầy đủ thông Tin !", "Error", MessageBoxButtons.OK);
            }
            else
            {
                string map = txt_ma.Text.Trim();
                string sql = "Select count(*) from LPhong where loaiphong ='" + map.Trim() + "'";
                string sql1 = "Insert into LPhong values(N'" + map + "',N'" + rtb_mota.Text + "','" + txt_gia.Text + "' )";
                chuoiketnoi.them(sql, sql1, data_gridview);
                chuoiketnoi.Chuoiketnoi(chuoi, data_gridview);
                Namecolumn();
                Clear();
            }
        }

        private void btn_nhaplai_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chăn muốn thoát không ? ", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            //loaiphong,mota,giaphong
            string sql = "Update LPhong set mota = N'" + rtb_mota.Text + "',giaphong='" + txt_gia.Text + "'where loaiphong = '"+txt_ma.Text+"'";
            chuoiketnoi.Sua(sql);
            chuoiketnoi.Chuoiketnoi(chuoi, data_gridview);
            Namecolumn();
            Clear();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete from LPhong where loaiphong = N'" + txt_ma.Text + "'";
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
            if (String.Compare(cb_luachon.Text, "Mã phòng", true) == 0 || cb_luachon.SelectedItem == null)
            {
                chuoi1 = "Select * from LPhong where loaiphong like N'%" + tukhoa + "%'";
            }
          
          
            else if (String.Compare(cb_luachon.Text, "Mô tả phòng", true) == 0)
            {
                chuoi1 = "Select * from LPhong where mota like N'%" + tukhoa + "%'";
            }
          
            else
            {
                chuoi1 = "Select * from LPhong where giaphong like N'%" + tukhoa + "%'";
            }
          
            chuoiketnoi.timkiem(chuoi1, data_gridview);
            Namecolumn();
        }
    }
}

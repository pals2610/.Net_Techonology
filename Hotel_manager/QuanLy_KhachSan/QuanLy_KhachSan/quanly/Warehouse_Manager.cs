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
    public partial class Warehouse_Manager : Form
    {
        int index = 0;
        int last = 0;
        public static string chuoi = "Select  * From Khohang";

        public Warehouse_Manager()
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
            btn_xoa.Enabled = true;
            btn_sua.Enabled = true;
        }
        private void PopulateData(int curow)
        {
            txt_ma.Enabled = false;
            txt_ma.Text = data_gridview.Rows[curow].Cells[0].Value.ToString();
            txt_ten.Text = data_gridview.Rows[curow].Cells[1].Value.ToString();
            txt_gianhap.Text = data_gridview.Rows[curow].Cells[2].Value.ToString();
            txt_solg.Text = data_gridview.Rows[curow].Cells[3].Value.ToString();
            txt_gia.Text = data_gridview.Rows[curow].Cells[4].Value.ToString();
            btn_them.Enabled = false;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;

        }

        private void Warehouse_Manager_Load(object sender, EventArgs e)
        {

        }
        public void Clear()
        {
            txt_ma.Enabled = true;
            txt_ma.Text = "";
            txt_ten.Text = "";
            txt_solg.Text = "";
            txt_gia.Text = "";
            txt_gianhap.Text = "";
            btn_xoa.Enabled = false;
            btn_sua.Enabled = false;
            btn_them.Enabled = true;
            txt_ma.Focus();

        }
        private void btn_nhaplai_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (txt_ma.Text == "" || txt_ten.Text == "" || txt_solg.Text == "" || txt_gia.Text == "")
            {
                MessageBox.Show("Ban chưa nhập đầy đủ thông Tin !", "Error", MessageBoxButtons.OK);
            }
            else
            {
                string ma = txt_ma.Text.Trim();
                string ten = txt_ten.Text.Trim();
                string gianhap = txt_gianhap.Text.Trim();
                string solg = txt_solg.Text.Trim();
                string gia = txt_gia.Text.Trim();
               
                if (ma.Length > 15)
                {
                    MessageBox.Show("mã sách quá dài ! chỉ nhập nhiều nhất 15 ký tự", "Error", MessageBoxButtons.OK);
                    txt_ma.Text = "";
                    txt_ma.Focus();

                }
                else
                {

                    string sql = "Select count(*) from Khohang where Maitem ='" + ma + "'";
                    string sql1 = "Insert into Khohang values(N'" +ma.Trim() + "',N'"+ten.Trim()+"','"+gianhap+"','"+solg+"','"+gia+"')";
                    chuoiketnoi.them(sql, sql1, data_gridview);
                    chuoiketnoi.Chuoiketnoi(chuoi, data_gridview);
                    Namecolumn();
                    Clear();
                }
            }
        }

        private void data_gridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = data_gridview.CurrentRow.Index;
            PopulateData(index);
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
        //Khohang (Maitem,TenItem,gia,soluong)
        private void btn_sua_Click(object sender, EventArgs e)
        {
           string ma = txt_ma.Text.Trim();
           string ten = txt_ten.Text.Trim();
           string solg = txt_solg.Text.Trim();
           string gia = txt_gia.Text.Trim();
           string gianhap = txt_gianhap.Text.Trim();
           string sql = "Update Khohang set TenItem = N'" + ten + "',gianhap = '"+gianhap+"',giaban = '" + gia + "',soluong='" + solg + "' where Maitem = '" + ma + "'";
           chuoiketnoi.Sua(sql);
           chuoiketnoi.Chuoiketnoi(chuoi, data_gridview);
           Namecolumn();
           Clear();
           
            
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string ma = txt_ma.Text.Trim();
            string sql = "Delete from Khohang where Maitem = N'" + ma + "'";
            chuoiketnoi.Xoa(sql);
            chuoiketnoi.Chuoiketnoi(chuoi, data_gridview);
            Namecolumn();

            Clear();
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
            if (String.Compare(cb_luachon.Text,"Mã sản phẩm",true)==0 || cb_luachon.SelectedItem == null)
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
    }
}

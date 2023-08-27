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
    public partial class Phuthu_Manager : Form
    {
        public static string full_name = "";
        public static string name_sp = "";
        public static string chuoi2 = "Select  * From Phuthu";
        public static string chuoi1 = "Select  * From Khohang";

        public Phuthu_Manager()
        {
            InitializeComponent();
            chuoiketnoi.Chuoiketnoi(chuoi1, data_sp);
            Namecolumn1();
            chuoiketnoi.Chuoiketnoi(chuoi2, data_phuthu);
            Namecolumn2();
            load_makh();
        }
        private void Namecolumn1()
        {
            
            data_sp.Columns[0].HeaderText = "Mã Sản phẩm"; data_sp.Columns[0].Width = 110;
            data_sp.Columns[1].HeaderText = "Tên sản phẩm"; data_sp.Columns[1].Width = 110;
            data_sp.Columns[2].HeaderText = "Gía nhập"; data_sp.Columns[3].Width = 110;
            data_sp.Columns[3].HeaderText = "Số lượng"; data_sp.Columns[2].Width = 110;
            data_sp.Columns[4].HeaderText = "Gía bán"; data_sp.Columns[3].Width = 110;
            int sc = data_sp.Rows.Count;

            // lbl_solg.Text = "Số lượng bản ghi : " + (sc - 1);
            btn_xoa.Enabled = true;
            btn_sua.Enabled = true;
        }


        private void Namecolumn2()
        {

            data_phuthu.Columns[0].HeaderText = "Mã hóa đơn"; data_phuthu.Columns[0].Width = 150;
            data_phuthu.Columns[1].HeaderText = "Mã khách"; data_phuthu.Columns[1].Width = 150;
            data_phuthu.Columns[2].HeaderText = "Mã sản phẩm"; data_phuthu.Columns[2].Width = 120;
            data_phuthu.Columns[3].HeaderText = "Tên sản phẩm"; data_phuthu.Columns[3].Width = 120;
            data_phuthu.Columns[4].HeaderText = "Số lượng"; data_phuthu.Columns[4].Width = 120;
            data_phuthu.Columns[5].HeaderText = "Gía bán"; data_phuthu.Columns[5].Width = 120;
            data_phuthu.Columns[6].HeaderText = "Trạng Thái"; data_phuthu.Columns[6].Width = 120;
            data_phuthu.Columns[7].HeaderText = "Thành Tiền"; data_phuthu.Columns[7].Width = 120;
            int sc = data_sp.Rows.Count;

            // lbl_solg.Text = "Số lượng bản ghi : " + (sc - 1);
            btn_xoa.Enabled = true;
            btn_sua.Enabled = true;
        }

        private void load_makh()
        {

            string load_makhach = "Select MaKh from Khachhang";
            chuoiketnoi.xulycbx(load_makhach, txt_makh);
            txt_makh.DisplayMember = "MaKh";
            txt_makh.ValueMember = "MaKh";

        }
        private void Phuthu_Manager_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string tukhoa = txt_tukhoa.Text.Trim();
            chuoi1 = "Select * from Khohang where TenItem like N'%" + tukhoa + "%'";
            chuoiketnoi.timkiem(chuoi1, data_sp);
            Namecolumn1();
        }

        private void txt_makh_TextChanged(object sender, EventArgs e)
        {
            string a = txt_makh.SelectedValue.ToString();

            if (txt_makh.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                string id = txt_makh.SelectedValue.ToString(); //Select MaKh from Khachhang
                string chuoi4 = "Select Tenkh from Khachhang where MaKh ='" + id.Trim() + "'";
                string tendaydu = chuoiketnoi.load_tenkhach(chuoi4, full_name);
                lb_tenk.Text = "Tên: " + tendaydu;
            }
            else
            {
                string id = "kh01"; //Select MaKh from Khachhang
                string chuoi4 = "Select Tenkh from Khachhang where MaKh ='" + id.Trim() + "'";
                string tendaydu = chuoiketnoi.load_tenkhach(chuoi4, full_name);
                lb_tenk.Text = "Tên: " + tendaydu;
            
            }
        }
        //Maitem,TenItem,gianhap,giaban,soluong
        private void data_sp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int curow = data_sp.CurrentRow.Index;
            txt_masp.Text = data_sp.Rows[curow].Cells[0].Value.ToString();
            lb_tensp.Text = data_sp.Rows[curow].Cells[1].Value.ToString();
       
            txt_giaban.Text = data_sp.Rows[curow].Cells[4].Value.ToString();
            btn_them.Enabled = true;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
        }

        private void txt_solg_ban_TextChanged(object sender, EventArgs e)
        {
            double thanhtien, solg_kho, solg_ban, gia_ban;

            if (txt_solg_ban.Text != "")
            {
                solg_ban = Convert.ToDouble(txt_solg_ban.Text.ToString());
                gia_ban = Convert.ToDouble(txt_giaban.Text.ToString());
                solg_kho = Convert.ToDouble(txt_solg_kho.Text.ToString());

                if (solg_ban > solg_kho)
                {
                    MessageBox.Show("Trong kho không đủ số lượng sản phẩm ,xin vui lòng nhập lại ", "Thông bảo", MessageBoxButtons.OK);

                    txt_solg_ban.Focus();
                }
                else
                {
                    thanhtien = solg_ban * gia_ban;
                    txt_thanhtien.Text = "" + thanhtien;
                }


            }
        }

        private void txt_solg_ban_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        //MaPhu,MaKh,Maitem,gia,soluong,thanhtien
        private void btn_them_Click(object sender, EventArgs e)
        {
        
            if (txt_idphuthu.Text == "" || txt_makh.Text == "" || txt_masp.Text == "" || txt_solg_ban.Text=="")
            {
                MessageBox.Show("Ban chưa nhập đầy đủ thông Tin !", "Error", MessageBoxButtons.OK);
            }
            else
            {

                string id_thuphi = txt_idphuthu.Text.Trim();
                string makh = txt_makh.Text.Trim();
                string masp = txt_masp.Text.Trim();
                string gia = txt_giaban.Text.Trim();
                string solg = txt_solg_ban.Text.Trim();
                string thanhtien = txt_thanhtien.Text.Trim();
                string tensp = lb_tensp.Text.Trim();

                if (id_thuphi.Length > 15)
                {
                    MessageBox.Show("mã sách quá dài ! chỉ nhập nhiều nhất 15 ký tự", "Error", MessageBoxButtons.OK);
                    txt_idphuthu.Text = "";
                    txt_idphuthu.Focus();

                }
                else
                {

                    //MaPhu,MaKh,Maitem,gia,soluong,thanhtien
                    
                    string sql = "Select count(*) from Phuthu where MaPhu ='" + id_thuphi + "'";
                    string sql1 = "Insert into Phuthu values(N'" + id_thuphi + "','" + makh + "','" + masp + "',N'"+tensp+"','" + solg + "','" + gia + "','0','" + thanhtien + "')";
                    chuoiketnoi.them(sql, sql1, data_phuthu);
                    chuoiketnoi.Chuoiketnoi(chuoi2, data_phuthu);
                    Namecolumn2();
                  
                    chuoiketnoi.Chuoiketnoi(chuoi1, data_sp);
                    Namecolumn1();
                }
            }
        }
        //insert into Phuthu (MaPhu,MaKh,Maitem,gia,soluong,trangthai,thanhtien)
        private void data_phuthu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int curow = data_phuthu.CurrentRow.Index;
            txt_idphuthu.Text = data_phuthu.Rows[curow].Cells[0].Value.ToString();
            txt_makh.Text = data_phuthu.Rows[curow].Cells[1].Value.ToString();
            txt_masp.Text = data_phuthu.Rows[curow].Cells[2].Value.ToString();
            lb_tensp.Text = data_phuthu.Rows[curow].Cells[3].Value.ToString();
            txt_giaban.Text = data_phuthu.Rows[curow].Cells[5].Value.ToString();
            txt_solg_ban.Text = data_phuthu.Rows[curow].Cells[4].Value.ToString();
            string trangthai = data_phuthu.Rows[curow].Cells[6].Value.ToString();
            txt_thanhtien.Text = data_phuthu.Rows[curow].Cells[7].Value.ToString();
            if (String.Compare(trangthai, "1", true) == 0)
            {
                btn_sua.Enabled = false;
                btn_xoa.Enabled = false;
            }
            else
            {
                btn_them.Enabled = true;
                btn_sua.Enabled = true;
                btn_xoa.Enabled = true;
            }
          
        }

        private void txt_masp_TextChanged(object sender, EventArgs e)
        {
           
            string a = txt_masp.Text.ToString();

            if (a != "")
            {
                string id = txt_makh.SelectedValue.ToString(); //Select MaKh from Khachhang
                string chuoi2 = "Select TenItem from Khohang where Maitem ='" + a.Trim() + "'";
                string chuoi4 = "Select soluong from Khohang where Maitem ='" + a.Trim() + "'";

                string tensp = hamhotro.ouput_colum_data.load_tensp(chuoi2, name_sp);
                string tendaydu = hamhotro.ouput_colum_data.load_soluongkho(chuoi4, full_name);
                txt_solg_kho.Text = "" + tendaydu;
                lb_tensp.Text = "" + tensp;
            }
        }
        //MaPhu,MaKh,Maitem,gia,soluong,thanhtien,trangthai
        private void btn_sua_Click(object sender, EventArgs e)
        {
            string id_thuphi = txt_idphuthu.Text.Trim();
            string makh = txt_makh.Text.Trim();
            string masp = txt_masp.Text.Trim();
            string gia = txt_giaban.Text.Trim();
            string solg = txt_solg_ban.Text.Trim();
            string thanhtien = txt_thanhtien.Text.Trim();
            string tensp = lb_tensp.Text.Trim();
            string sql = "Update Phuthu set MaKh = N'" + makh + "',Maitem= N'" + masp + "',tensp=N'"+tensp+"',gia = '" + gia + "',soluong='" + solg + "',thanhtien='" + thanhtien + "',trangthai='0' where MaPhu=N'" + id_thuphi + "' ";
            chuoiketnoi.Sua(sql);
            chuoiketnoi.Chuoiketnoi(chuoi2, data_phuthu);
            Namecolumn2();
           Clear();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {

            string sql = "Delete from Phuthu where MaPhu = N'" + txt_idphuthu.Text + "'";
            chuoiketnoi.Xoa(sql);

            chuoiketnoi.Chuoiketnoi(chuoi2, data_phuthu);
            Namecolumn2();
            Clear();
        }

        private void Clear()
        {
            txt_idphuthu.Text = "";
            txt_masp.Text = "";
            txt_solg_ban.Text = "";
            txt_solg_kho.Text = "";
            txt_thanhtien.Text = "";
            lb_tenk.Text = "tên khách : ";
            lb_tensp.Text = "tên sp: ";
            txt_giaban.Text = "";
            txt_tukhoa.Focus();
            btn_xoa.Enabled = false;
            btn_sua.Enabled = false;
            btn_them.Enabled = true;
        
        }

        private void btn_nhaplai_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ban, kho, conlai;
            ban = Convert.ToDouble(txt_solg_ban.Text.ToString().Trim());
            kho = Convert.ToDouble(txt_solg_kho.Text.ToString().Trim());
            conlai = kho - ban;
            string masp = txt_masp.Text.Trim();
            string sql = "Update Phuthu set trangthai='1' where MaPhu=N'" + txt_idphuthu.Text.Trim() + "' ";
            string sql2 = "Update Khohang set soluong = N'" + conlai.ToString() + "' where Maitem = '" + masp + "'";
            chuoiketnoi.update_solg(sql2);
            chuoiketnoi.Sua(sql);
            chuoiketnoi.Chuoiketnoi(chuoi2, data_phuthu);
            Namecolumn2();
            chuoiketnoi.Chuoiketnoi(chuoi1, data_sp);
            Namecolumn1();
            Clear();
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

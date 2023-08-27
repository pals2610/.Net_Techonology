using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;


namespace QuanLy_KhachSan.hamhotro
{
    class Xuat_Excel
    {
        public static void xuat1(DataGridView g, string duongdan, string s, string tenfile,string tenbang,string ngaythang)
        {
            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;
            obj.Range["A1:Z100"].Style.HorizontalAlignment = HorizontalAlignment.Center;
            for (int i = 1; i < g.Columns.Count + 1; i++)
            {
                obj.Cells[6, i] = g.Columns[i - 1].HeaderText;
            }
          
            for (int i = 0; i < g.Rows.Count; i++)
                for (int j = 0; j < g.Columns.Count; j++)
                {
                    if (g.Rows[i].Cells[j].Value != null)
                    {
                        obj.Cells[i + 7, j + 1] = g.Rows[i].Cells[j].Value;
                      
                    }


                }

            obj.Range["A1:Z100"].ColumnWidth = 25;
            obj.Range["A1:z2"].Font.Size = 16;
            obj.Range["A6:z6"].Font.Size = 15;
            obj.Range["A1:Z100"].Font.Name = "Times new roman";
            obj.Range["A1:B3"].Font.Bold = true;
            obj.Range["A1:B3"].Font.ColorIndex = 5; //Màu xanh da trời
            obj.Range["B1:B100"].ColumnWidth = 20;
            obj.Range["A1:B1"].MergeCells = true;
            obj.Range["C3:D3"].MergeCells = true;
            obj.Range["A2:B2"].MergeCells = true;
            obj.Range["D1:E1"].MergeCells = true;
            obj.Range["A1:B1"].Value = "Khách Sạn";
            obj.Range["D1:E1"].Value = "Thời gian : "+ngaythang;
            obj.Range["A2:B2"].Value = "Địa chỉ : Tân Bình";
            obj.Range["C3:D3"].Value = tenbang.Trim();
            obj.Range["C3:D3"].Font.Size = 16;
            
            obj.Range["A2:B2"].Font.ColorIndex = 5;
            obj.Range["B2:D2"].Font.ColorIndex = 3;
            obj.Range["C3:D3"].Font.ColorIndex = 3;
            obj.Cells[g.Rows.Count+9, g.Columns.Count] = " " + s;
            obj.ActiveWorkbook.SaveCopyAs(duongdan + tenfile + ".xlsx");
            obj.ActiveWorkbook.Saved = true;
           
        }

        public static void thongke(DataGridView g, string duongdan, string s, string tenfile, string tenbang, string thanhchu)
        {
            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;
            obj.Range["A1:Z100"].Style.HorizontalAlignment = HorizontalAlignment.Center;
            for (int i = 1; i < g.Columns.Count + 1; i++)
            {
                obj.Cells[6, i] = g.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < g.Rows.Count; i++)
                for (int j = 0; j < g.Columns.Count; j++)
                {
                    if (g.Rows[i].Cells[j].Value != null)
                    {
                        obj.Cells[i + 7, j + 1] = g.Rows[i].Cells[j].Value;

                    }


                }

            obj.Range["A1:Z100"].ColumnWidth = 25;
            obj.Range["A1:z2"].Font.Size = 16;
            obj.Range["A6:z6"].Font.Size = 15;
            obj.Range["A1:Z100"].Font.Name = "Times new roman";
            obj.Range["A1:B3"].Font.Bold = true;
            obj.Range["A1:B3"].Font.ColorIndex = 5; //Màu xanh da trời
            obj.Range["B1:B100"].ColumnWidth = 20;
            obj.Range["A1:B1"].MergeCells = true;
            obj.Range["C3:H3"].MergeCells = true;
            obj.Range["A2:B2"].MergeCells = true;
            obj.Range["D1:E1"].MergeCells = true;
            obj.Range["A1:B1"].Value = "Khách Sạn";
    
            obj.Range["A2:B2"].Value = "Địa chỉ : Tân Bình";
            obj.Range["C3:H3"].Value = tenbang.Trim();
            obj.Range["C3:D3"].Font.Size = 16;

            obj.Range["A2:B2"].Font.ColorIndex = 5;
            obj.Range["B2:D2"].Font.ColorIndex = 3;
            obj.Range["C3:D3"].Font.ColorIndex = 3;
            obj.Cells[g.Rows.Count + 9, g.Columns.Count] = " Tổng tiền :  " + s ;
            obj.Cells[g.Rows.Count + 10, g.Columns.Count] = " Thành chữ :  " + thanhchu;
            obj.ActiveWorkbook.SaveCopyAs(duongdan + tenfile + ".xlsx");
            obj.ActiveWorkbook.Saved = true;

        }

        public static void thongke_kho(DataGridView g, string duongdan, string s, string tenfile, string tenbang, string thanhchu)
        {
            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;
            obj.Range["A1:Z100"].Style.HorizontalAlignment = HorizontalAlignment.Center;
            for (int i = 1; i < g.Columns.Count + 1; i++)
            {
                obj.Cells[6, i] = g.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < g.Rows.Count; i++)
                for (int j = 0; j < g.Columns.Count; j++)
                {
                    if (g.Rows[i].Cells[j].Value != null)
                    {
                        obj.Cells[i + 7, j + 1] = g.Rows[i].Cells[j].Value;

                    }


                }

            obj.Range["A1:Z100"].ColumnWidth = 25;
            obj.Range["A1:z2"].Font.Size = 16;
            obj.Range["A6:z6"].Font.Size = 15;
            obj.Range["A1:Z100"].Font.Name = "Times new roman";
            obj.Range["A1:B3"].Font.Bold = true;
            obj.Range["A1:B3"].Font.ColorIndex = 5; //Màu xanh da trời
            obj.Range["B1:B100"].ColumnWidth = 70;
            obj.Range["A1:B1"].MergeCells = true;
            obj.Range["B3:H3"].MergeCells = true;
            obj.Range["A2:B2"].MergeCells = true;
            obj.Range["D1:E1"].MergeCells = true;
            obj.Range["A1:B1"].Value = "Khách Sạn";

            obj.Range["A2:B2"].Value = "Địa chỉ : Tân Bình";
            obj.Range["B3:H3"].Value = tenbang.Trim();
            obj.Range["C3:D3"].Font.Size = 16;

            obj.Range["A2:B2"].Font.ColorIndex = 5;
            obj.Range["B2:D2"].Font.ColorIndex = 3;
            obj.Range["B3:D3"].Font.ColorIndex = 3;
            obj.Cells[g.Rows.Count + 9, g.Columns.Count] = " Tổng tiền :  " + s;
            obj.Cells[g.Rows.Count + 10, g.Columns.Count] = " Thành chữ :  " + thanhchu;
            obj.ActiveWorkbook.SaveCopyAs(duongdan + tenfile + ".xlsx");
            obj.ActiveWorkbook.Saved = true;

        }
        public static void Export_Hoadon(DataGridView g, string tenkhach, string ngaythue, string ngaytra, string giaphong, string songaythue, string songuoi, string phiphong,string phuthu,string tongtien,string duongdan, string tenfile)
        {
            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;
            obj.Range["A1:Z100"].Style.HorizontalAlignment = HorizontalAlignment.Center;
            obj.Range["A1:Z100"].ColumnWidth = 25;
            obj.Range["A1:z2"].Font.Size = 16; 
            obj.Range["C3:D3"].Font.Size = 16;
            obj.Range["A6:z6"].Font.Size = 14;
            obj.Range["A1:Z100"].Font.Name = "Times new roman";
            obj.Range["A1:B3"].Font.Bold = true;
            obj.Range["A1:B3"].Font.ColorIndex = 5; //Màu xanh da trời
            obj.Range["B1:B100"].ColumnWidth = 20;
            obj.Range["A1:B1"].MergeCells = true;
            obj.Range["A5:B5"].MergeCells = true;
            obj.Range["A6:B6"].MergeCells = true;
            obj.Range["A7:B7"].MergeCells = true;
            obj.Range["A8:B8"].MergeCells = true;
            obj.Range["A9:B9"].MergeCells = true;
            obj.Range["A10:B10"].MergeCells = true;
            obj.Range["A11:B11"].MergeCells = true;
            obj.Range["B13:C13"].MergeCells = true;
            obj.Range["C3:D3"].MergeCells = true;
            obj.Range["A2:B2"].MergeCells = true;
            obj.Range["D1:E1"].MergeCells = true;
            obj.Range["A1:B1"].Value = "Khách Sạn";
            obj.Range["D1:E1"].Value = "Thời gian: " + ngaytra;
            obj.Range["A2:B2"].Value = "Địa chỉ: Tân Bình";
            obj.Range["C3:D3"].Value = "HÓA ĐƠN THANH TOÁN";
            obj.Range["B13:C13"].Value = "Bảng phụ thu";
            obj.Range["B13:C13"].Font.Size = 16;
            obj.Range["A5:B5"].Value = "Tên khách: "+tenkhach;
            obj.Range["A6:B6"].Value = "Ngày thuê phòng: " + ngaythue;
            obj.Range["A7:B7"].Value = "Ngày trả phòng: " + ngaytra;
            obj.Range["A8:B8"].Value = "Giá phòng: " + giaphong + " / 1 ngày";
            obj.Range["A9:B9"].Value = "Số ngày thuê: " + songaythue + "(ngày)";
            obj.Range["A10:B10"].Value = "Số người: " + songuoi + "  (người)";
            obj.Range["A11:B11"].Value = "Phí phòng: " + phiphong + "  (VNĐ)";
            obj.Range["B13:C13"].Value = "Bảng phụ thu ";

            for (int i = 1; i < g.Columns.Count + 1; i++)
            {
                obj.Cells[15, i] = g.Columns[i - 1].HeaderText;
            }
          
            for (int i = 0; i < g.Rows.Count; i++)
                for (int j = 0; j < g.Columns.Count; j++)
                {
                    if (g.Rows[i].Cells[j].Value != null)
                    {
                        obj.Cells[i + 16, j + 1] = g.Rows[i].Cells[j].Value;
                       
                    }


                }
            obj.Cells[g.Rows.Count + 17, g.Columns.Count] = " tổng phụ thu: " + phuthu + "VNĐ";
            obj.Cells[g.Rows.Count + 18, g.Columns.Count] = " tổng tiền: " + tongtien + "VNĐ";
            obj.ActiveWorkbook.SaveCopyAs(duongdan + tenfile + ".xlsx");
            obj.ActiveWorkbook.Saved = true;
        }
        public static void nhapkho(DataGridView g, string duongdan, string s, string tenfile, string tenbang, string ngaythang,string tienchu)
        {
            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;
            obj.Range["A1:Z100"].Style.HorizontalAlignment = HorizontalAlignment.Center;
            for (int i = 1; i < g.Columns.Count + 1; i++)
            {
                obj.Cells[6, i] = g.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < g.Rows.Count; i++)
                for (int j = 0; j < g.Columns.Count; j++)
                {
                    if (g.Rows[i].Cells[j].Value != null)
                    {
                        obj.Cells[i + 7, j + 1] = g.Rows[i].Cells[j].Value;

                    }


                }

            obj.Range["A1:Z100"].ColumnWidth = 25;
            obj.Range["A1:z2"].Font.Size = 16;
            obj.Range["A6:z6"].Font.Size = 15;
            obj.Range["A1:Z100"].Font.Name = "Times new roman";
            obj.Range["A1:B3"].Font.Bold = true;
            obj.Range["A1:B3"].Font.ColorIndex = 5; //Màu xanh da trời
            obj.Range["B1:B100"].ColumnWidth = 20;
            obj.Range["A1:B1"].MergeCells = true;
            obj.Range["C3:E3"].MergeCells = true;
            obj.Range["A2:B2"].MergeCells = true;
            obj.Range["D1:E1"].MergeCells = true;
            obj.Range["A1:B1"].Value = "Khách Sạn";
            obj.Range["D1:E1"].Value = "Thời gian : " + ngaythang;
            obj.Range["A2:B2"].Value = "Địa chỉ : Tân Bình";
            obj.Range["C3:E3"].Value = tenbang.Trim();
            obj.Range["C3:D3"].Font.Size = 16;

            obj.Range["A2:B2"].Font.ColorIndex = 5;
            obj.Range["B2:D2"].Font.ColorIndex = 3;
            obj.Range["C3:D3"].Font.ColorIndex = 3;
            obj.Cells[g.Rows.Count + 9, g.Columns.Count] = "Tổng tiền : " + s;
            obj.Cells[g.Rows.Count + 10, g.Columns.Count] = " Thành chữ: " + tienchu;
            obj.ActiveWorkbook.SaveCopyAs(duongdan + tenfile + ".xlsx");
            obj.ActiveWorkbook.Saved = true;

        }
    }
}

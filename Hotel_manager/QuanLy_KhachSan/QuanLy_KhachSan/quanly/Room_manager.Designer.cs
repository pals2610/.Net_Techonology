namespace QuanLy_KhachSan.quanly
{
    partial class Room_manager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Room_manager));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtb_mota = new System.Windows.Forms.RichTextBox();
            this.cbx_tt = new System.Windows.Forms.ComboBox();
            this.cbx_loaip = new System.Windows.Forms.ComboBox();
            this.txt_song = new System.Windows.Forms.TextBox();
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ma = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.truoc = new System.Windows.Forms.Button();
            this.dau = new System.Windows.Forms.Button();
            this.sau = new System.Windows.Forms.Button();
            this.cuoi = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.cb_luachon = new System.Windows.Forms.ComboBox();
            this.TK = new System.Windows.Forms.Label();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_nhaplai = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.lbl_solg = new System.Windows.Forms.Label();
            this.data_gridview = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Teal;
            this.groupBox1.Controls.Add(this.rtb_mota);
            this.groupBox1.Controls.Add(this.cbx_tt);
            this.groupBox1.Controls.Add(this.cbx_loaip);
            this.groupBox1.Controls.Add(this.txt_song);
            this.groupBox1.Controls.Add(this.txt_ten);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_ma);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(16, 119);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1361, 228);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phòng";
            // 
            // rtb_mota
            // 
            this.rtb_mota.Location = new System.Drawing.Point(620, 44);
            this.rtb_mota.Margin = new System.Windows.Forms.Padding(4);
            this.rtb_mota.Name = "rtb_mota";
            this.rtb_mota.Size = new System.Drawing.Size(309, 73);
            this.rtb_mota.TabIndex = 3;
            this.rtb_mota.Text = "";
            // 
            // cbx_tt
            // 
            this.cbx_tt.FormattingEnabled = true;
            this.cbx_tt.Items.AddRange(new object[] {
            "Trống",
            "Đặt phòng",
            "Đang Thuê"});
            this.cbx_tt.Location = new System.Drawing.Point(1091, 48);
            this.cbx_tt.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_tt.Name = "cbx_tt";
            this.cbx_tt.Size = new System.Drawing.Size(239, 32);
            this.cbx_tt.TabIndex = 2;
            // 
            // cbx_loaip
            // 
            this.cbx_loaip.FormattingEnabled = true;
            this.cbx_loaip.Location = new System.Drawing.Point(151, 146);
            this.cbx_loaip.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_loaip.Name = "cbx_loaip";
            this.cbx_loaip.Size = new System.Drawing.Size(239, 32);
            this.cbx_loaip.TabIndex = 2;
            this.cbx_loaip.TextChanged += new System.EventHandler(this.cbx_loaip_TextChanged);
            // 
            // txt_song
            // 
            this.txt_song.Location = new System.Drawing.Point(620, 146);
            this.txt_song.Margin = new System.Windows.Forms.Padding(4);
            this.txt_song.Name = "txt_song";
            this.txt_song.Size = new System.Drawing.Size(309, 29);
            this.txt_song.TabIndex = 1;
            // 
            // txt_ten
            // 
            this.txt_ten.Location = new System.Drawing.Point(151, 89);
            this.txt_ten.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ten.Multiline = true;
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(239, 31);
            this.txt_ten.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(457, 48);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mô tả phòng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(963, 58);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "Trạng thái";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(457, 154);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số người tối đa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 146);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Loại phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên phòng";
            // 
            // txt_ma
            // 
            this.txt_ma.Location = new System.Drawing.Point(151, 41);
            this.txt_ma.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ma.Name = "txt_ma";
            this.txt_ma.Size = new System.Drawing.Size(239, 29);
            this.txt_ma.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(501, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 36);
            this.label1.TabIndex = 15;
            this.label1.Text = "Quản lý thông tin phòng";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Teal;
            this.groupBox2.Controls.Add(this.truoc);
            this.groupBox2.Controls.Add(this.dau);
            this.groupBox2.Controls.Add(this.sau);
            this.groupBox2.Controls.Add(this.cuoi);
            this.groupBox2.Controls.Add(this.txt_search);
            this.groupBox2.Controls.Add(this.cb_luachon);
            this.groupBox2.Controls.Add(this.TK);
            this.groupBox2.Controls.Add(this.btn_thoat);
            this.groupBox2.Controls.Add(this.btn_nhaplai);
            this.groupBox2.Controls.Add(this.btn_xoa);
            this.groupBox2.Controls.Add(this.btn_them);
            this.groupBox2.Controls.Add(this.btn_sua);
            this.groupBox2.Controls.Add(this.lbl_solg);
            this.groupBox2.Controls.Add(this.data_gridview);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(16, 354);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1361, 484);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin dữ liệu  bảng";
            // 
            // truoc
            // 
            this.truoc.Location = new System.Drawing.Point(81, 46);
            this.truoc.Margin = new System.Windows.Forms.Padding(4);
            this.truoc.Name = "truoc";
            this.truoc.Size = new System.Drawing.Size(61, 32);
            this.truoc.TabIndex = 57;
            this.truoc.Text = "<";
            this.truoc.UseVisualStyleBackColor = true;
            this.truoc.Click += new System.EventHandler(this.truoc_Click);
            // 
            // dau
            // 
            this.dau.Location = new System.Drawing.Point(12, 46);
            this.dau.Margin = new System.Windows.Forms.Padding(4);
            this.dau.Name = "dau";
            this.dau.Size = new System.Drawing.Size(61, 32);
            this.dau.TabIndex = 56;
            this.dau.Text = "<<";
            this.dau.UseVisualStyleBackColor = true;
            this.dau.Click += new System.EventHandler(this.dau_Click);
            // 
            // sau
            // 
            this.sau.Location = new System.Drawing.Point(151, 46);
            this.sau.Margin = new System.Windows.Forms.Padding(4);
            this.sau.Name = "sau";
            this.sau.Size = new System.Drawing.Size(67, 32);
            this.sau.TabIndex = 58;
            this.sau.Text = ">";
            this.sau.UseVisualStyleBackColor = true;
            this.sau.Click += new System.EventHandler(this.sau_Click);
            // 
            // cuoi
            // 
            this.cuoi.Location = new System.Drawing.Point(225, 46);
            this.cuoi.Margin = new System.Windows.Forms.Padding(4);
            this.cuoi.Name = "cuoi";
            this.cuoi.Size = new System.Drawing.Size(68, 32);
            this.cuoi.TabIndex = 59;
            this.cuoi.Text = ">>";
            this.cuoi.UseVisualStyleBackColor = true;
            this.cuoi.Click += new System.EventHandler(this.cuoi_Click);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(805, 46);
            this.txt_search.Margin = new System.Windows.Forms.Padding(4);
            this.txt_search.Multiline = true;
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(251, 29);
            this.txt_search.TabIndex = 54;
            this.txt_search.Text = "Nhập từ khóa....";
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // cb_luachon
            // 
            this.cb_luachon.FormattingEnabled = true;
            this.cb_luachon.Items.AddRange(new object[] {
            "Mã phòng",
            "Tên phòng",
            "Loại phòng",
            "Mô tả phòng",
            "Số người tối đa",
            "Giá phòng",
            "Trạng thái"});
            this.cb_luachon.Location = new System.Drawing.Point(532, 46);
            this.cb_luachon.Margin = new System.Windows.Forms.Padding(4);
            this.cb_luachon.Name = "cb_luachon";
            this.cb_luachon.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cb_luachon.Size = new System.Drawing.Size(264, 32);
            this.cb_luachon.TabIndex = 53;
            this.cb_luachon.Text = "-- Lựa chọn trường tìm kiếm--";
            // 
            // TK
            // 
            this.TK.AutoSize = true;
            this.TK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TK.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TK.Location = new System.Drawing.Point(351, 50);
            this.TK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TK.Name = "TK";
            this.TK.Size = new System.Drawing.Size(160, 25);
            this.TK.TabIndex = 55;
            this.TK.Text = "Tìm kiếm theo :";
            // 
            // btn_thoat
            // 
            this.btn_thoat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_thoat.Image = ((System.Drawing.Image)(resources.GetObject("btn_thoat.Image")));
            this.btn_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thoat.Location = new System.Drawing.Point(1091, 330);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(231, 55);
            this.btn_thoat.TabIndex = 52;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_nhaplai
            // 
            this.btn_nhaplai.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nhaplai.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_nhaplai.Image = ((System.Drawing.Image)(resources.GetObject("btn_nhaplai.Image")));
            this.btn_nhaplai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nhaplai.Location = new System.Drawing.Point(1091, 262);
            this.btn_nhaplai.Margin = new System.Windows.Forms.Padding(4);
            this.btn_nhaplai.Name = "btn_nhaplai";
            this.btn_nhaplai.Size = new System.Drawing.Size(231, 60);
            this.btn_nhaplai.TabIndex = 51;
            this.btn_nhaplai.Text = "Nhập lại";
            this.btn_nhaplai.UseVisualStyleBackColor = true;
            this.btn_nhaplai.Click += new System.EventHandler(this.btn_nhaplai_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoa.Image")));
            this.btn_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoa.Location = new System.Drawing.Point(1091, 202);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(231, 53);
            this.btn_xoa.TabIndex = 49;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_them.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_them.Image = ((System.Drawing.Image)(resources.GetObject("btn_them.Image")));
            this.btn_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_them.Location = new System.Drawing.Point(1091, 85);
            this.btn_them.Margin = new System.Windows.Forms.Padding(4);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(231, 49);
            this.btn_them.TabIndex = 47;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_sua.Image = ((System.Drawing.Image)(resources.GetObject("btn_sua.Image")));
            this.btn_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sua.Location = new System.Drawing.Point(1091, 138);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(231, 57);
            this.btn_sua.TabIndex = 48;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // lbl_solg
            // 
            this.lbl_solg.AutoSize = true;
            this.lbl_solg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_solg.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_solg.Location = new System.Drawing.Point(8, 438);
            this.lbl_solg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_solg.Name = "lbl_solg";
            this.lbl_solg.Size = new System.Drawing.Size(241, 25);
            this.lbl_solg.TabIndex = 46;
            this.lbl_solg.Text = "Số lượng bản ghi...........";
            // 
            // data_gridview
            // 
            this.data_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_gridview.Location = new System.Drawing.Point(8, 85);
            this.data_gridview.Margin = new System.Windows.Forms.Padding(4);
            this.data_gridview.Name = "data_gridview";
            this.data_gridview.RowHeadersWidth = 51;
            this.data_gridview.Size = new System.Drawing.Size(1052, 338);
            this.data_gridview.TabIndex = 0;
            this.data_gridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_gridview_CellClick);
            // 
            // Room_manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1393, 859);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Room_manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý khách sạn";
            this.Load += new System.EventHandler(this.Room_manager_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_gridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtb_mota;
        private System.Windows.Forms.ComboBox cbx_tt;
        private System.Windows.Forms.ComboBox cbx_loaip;
        private System.Windows.Forms.TextBox txt_song;
        private System.Windows.Forms.TextBox txt_ten;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button truoc;
        private System.Windows.Forms.Button dau;
        private System.Windows.Forms.Button sau;
        private System.Windows.Forms.Button cuoi;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.ComboBox cb_luachon;
        private System.Windows.Forms.Label TK;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_nhaplai;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Label lbl_solg;
        private System.Windows.Forms.DataGridView data_gridview;
    }
}
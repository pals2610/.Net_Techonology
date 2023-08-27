namespace QuanLy_KhachSan.timkiem
{
    partial class Search_khachhang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search_khachhang));
            this.txt_ngaythang = new System.Windows.Forms.DateTimePicker();
            this.txt_tenfile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.cb_luachon = new System.Windows.Forms.ComboBox();
            this.TK = new System.Windows.Forms.Label();
            this.lbl_solg = new System.Windows.Forms.Label();
            this.data_gridview = new System.Windows.Forms.DataGridView();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_ngaythang
            // 
            this.txt_ngaythang.Location = new System.Drawing.Point(29, 582);
            this.txt_ngaythang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_ngaythang.Name = "txt_ngaythang";
            this.txt_ngaythang.Size = new System.Drawing.Size(265, 22);
            this.txt_ngaythang.TabIndex = 69;
            // 
            // txt_tenfile
            // 
            this.txt_tenfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenfile.Location = new System.Drawing.Point(341, 581);
            this.txt_tenfile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_tenfile.Multiline = true;
            this.txt_tenfile.Name = "txt_tenfile";
            this.txt_tenfile.Size = new System.Drawing.Size(288, 42);
            this.txt_tenfile.TabIndex = 68;
            this.txt_tenfile.Text = "Nhập tên file...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(359, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 36);
            this.label1.TabIndex = 66;
            this.label1.Text = "Tra cứu thông tin khách hàng";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Teal;
            this.groupBox2.Controls.Add(this.txt_search);
            this.groupBox2.Controls.Add(this.cb_luachon);
            this.groupBox2.Controls.Add(this.TK);
            this.groupBox2.Controls.Add(this.lbl_solg);
            this.groupBox2.Controls.Add(this.data_gridview);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(29, 75);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(1099, 484);
            this.groupBox2.TabIndex = 65;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin dữ liệu  bảng";
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(805, 46);
            this.txt_search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            "Mã khách",
            "Tên Khách",
            "giới tính",
            "số điện thoại",
            "Chứng minh nhân dân"});
            this.cb_luachon.Location = new System.Drawing.Point(512, 43);
            this.cb_luachon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.TK.Location = new System.Drawing.Point(331, 48);
            this.TK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TK.Name = "TK";
            this.TK.Size = new System.Drawing.Size(160, 25);
            this.TK.TabIndex = 55;
            this.TK.Text = "Tìm kiếm theo :";
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
            this.data_gridview.Location = new System.Drawing.Point(5, 96);
            this.data_gridview.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.data_gridview.Name = "data_gridview";
            this.data_gridview.RowHeadersWidth = 51;
            this.data_gridview.Size = new System.Drawing.Size(1052, 338);
            this.data_gridview.TabIndex = 0;
            // 
            // btn_thoat
            // 
            this.btn_thoat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_thoat.Image = ((System.Drawing.Image)(resources.GetObject("btn_thoat.Image")));
            this.btn_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thoat.Location = new System.Drawing.Point(897, 581);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(231, 43);
            this.btn_thoat.TabIndex = 70;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(663, 582);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 44);
            this.button1.TabIndex = 67;
            this.button1.Text = "Xuất Excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Search_khachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 654);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.txt_ngaythang);
            this.Controls.Add(this.txt_tenfile);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Search_khachhang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý khách sạn";
            this.Load += new System.EventHandler(this.Search_khachhang_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_gridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.DateTimePicker txt_ngaythang;
        private System.Windows.Forms.TextBox txt_tenfile;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.ComboBox cb_luachon;
        private System.Windows.Forms.Label TK;
        private System.Windows.Forms.Label lbl_solg;
        private System.Windows.Forms.DataGridView data_gridview;
    }
}
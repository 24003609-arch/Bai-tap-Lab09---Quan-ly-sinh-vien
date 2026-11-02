
namespace Lab09_DataReaderSearch12
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grpTimKiem = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cboGioitinh = new System.Windows.Forms.ComboBox();
            this.cbokhoa = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.cboSapxep = new System.Windows.Forms.ComboBox();
            this.cboThutu = new System.Windows.Forms.ComboBox();
            this.btTimkiem_click = new System.Windows.Forms.Button();
            this.btLammoi_click = new System.Windows.Forms.Button();
            this.grpDanhSach = new System.Windows.Forms.GroupBox();
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.btTrangtruoc_click = new System.Windows.Forms.Button();
            this.btTrangsau_click = new System.Windows.Forms.Button();
            this.grpChiTiet = new System.Windows.Forms.GroupBox();
            this.lbMasv = new System.Windows.Forms.Label();
            this.txtMasv = new System.Windows.Forms.TextBox();
            this.lbHoten = new System.Windows.Forms.Label();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.lbNgaysinh = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lbGioitinhCT = new System.Windows.Forms.Label();
            this.cboGioitinhCT = new System.Windows.Forms.ComboBox();
            this.lbDiem = new System.Windows.Forms.Label();
            this.txtDiemtrungbinh = new System.Windows.Forms.TextBox();
            this.lbKhoa = new System.Windows.Forms.Label();
            this.txtKhoaCT = new System.Windows.Forms.TextBox();
            this.lbTongsinhvien = new System.Windows.Forms.Label();
            this.lbTranghientai = new System.Windows.Forms.Label();
            this.lbTrangthai = new System.Windows.Forms.Label();
            this.bsSinhvien = new System.Windows.Forms.BindingSource(this.components);
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.grpTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.grpChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsSinhvien)).BeginInit();
            this.SuspendLayout();
            // 
            // grpTimKiem
            // 
            this.grpTimKiem.Controls.Add(this.label1);
            this.grpTimKiem.Controls.Add(this.label2);
            this.grpTimKiem.Controls.Add(this.label3);
            this.grpTimKiem.Controls.Add(this.label4);
            this.grpTimKiem.Controls.Add(this.label5);
            this.grpTimKiem.Controls.Add(this.label6);
            this.grpTimKiem.Controls.Add(this.textBox1);
            this.grpTimKiem.Controls.Add(this.cboGioitinh);
            this.grpTimKiem.Controls.Add(this.cbokhoa);
            this.grpTimKiem.Controls.Add(this.numericUpDown1);
            this.grpTimKiem.Controls.Add(this.numericUpDown2);
            this.grpTimKiem.Controls.Add(this.cboSapxep);
            this.grpTimKiem.Controls.Add(this.cboThutu);
            this.grpTimKiem.Controls.Add(this.btTimkiem_click);
            this.grpTimKiem.Controls.Add(this.btLammoi_click);
            this.grpTimKiem.Location = new System.Drawing.Point(15, 15);
            this.grpTimKiem.Name = "grpTimKiem";
            this.grpTimKiem.Size = new System.Drawing.Size(1020, 180);
            this.grpTimKiem.TabIndex = 0;
            this.grpTimKiem.TabStop = false;
            this.grpTimKiem.Text = "TÌM KIẾM VÀ LỌC SINH VIÊN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ khóa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(365, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giới tính:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(630, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Khoa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Điểm từ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(230, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Đến:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(415, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Sắp xếp:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 26);
            this.textBox1.TabIndex = 6;
            // 
            // cboGioitinh
            // 
            this.cboGioitinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ "});
            this.cboGioitinh.Location = new System.Drawing.Point(445, 27);
            this.cboGioitinh.Name = "cboGioitinh";
            this.cboGioitinh.Size = new System.Drawing.Size(150, 28);
            this.cboGioitinh.TabIndex = 7;
            // 
            // cbokhoa
            // 
            this.cbokhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbokhoa.Items.AddRange(new object[] {
            "Tất cả ",
            "",
            "Khoa Công nghệ thông tin",
            "",
            "",
            "",
            "",
            "Khoa Kinh tế",
            "",
            "",
            "",
            "",
            "Khoa Quản trị kinh doanh",
            "",
            "",
            "",
            "",
            "Khoa Kế toán – Kiểm toán",
            "",
            "",
            "",
            "",
            "Khoa Tài chính – Ngân hàng",
            "",
            "",
            "",
            "",
            "Khoa Ngôn ngữ Anh",
            "",
            "",
            "",
            "",
            "Khoa Ngôn ngữ Trung Quốc",
            "",
            "",
            "",
            "",
            "Khoa Điện – Điện tử",
            "",
            "",
            "",
            "",
            "Khoa Cơ khí",
            "",
            "",
            "",
            "",
            "Khoa Xây dựng",
            "",
            "",
            "",
            "",
            "Khoa Du lịch",
            "Khoa Truyền thông và Marketing",
            "",
            "",
            "",
            "",
            "Khoa Luật",
            "",
            "",
            "",
            "K",
            "hoa Thiết kế đồ họa",
            "",
            "",
            "",
            "",
            "Khoa Công nghệ ô tô",
            "",
            "",
            "",
            "",
            "Khoa Logistics và Quản lý chuỗi cung ứng",
            "Khoa Thương mại điện tử",
            "",
            "",
            "",
            "",
            "Khoa Quản lý giáo dục",
            "",
            "",
            "",
            "",
            "Khoa Điều dưỡng",
            "",
            "",
            "",
            "",
            "Khoa Dược"});
            this.cbokhoa.Location = new System.Drawing.Point(685, 27);
            this.cbokhoa.Name = "cbokhoa";
            this.cbokhoa.Size = new System.Drawing.Size(290, 28);
            this.cbokhoa.TabIndex = 8;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 1;
            this.numericUpDown1.Location = new System.Drawing.Point(110, 72);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(100, 26);
            this.numericUpDown1.TabIndex = 9;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DecimalPlaces = 1;
            this.numericUpDown2.Location = new System.Drawing.Point(280, 72);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(100, 26);
            this.numericUpDown2.TabIndex = 10;
            this.numericUpDown2.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // cboSapxep
            // 
            this.cboSapxep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSapxep.Items.AddRange(new object[] {
            "Mã sinh viên",
            "",
            "",
            "",
            "",
            "Họ tên",
            "",
            "",
            "",
            "",
            "Ngày sinh",
            "",
            "",
            "",
            "",
            "Giới tính",
            "",
            "",
            "",
            "",
            "Khoa",
            "Lớp",
            "",
            "",
            "",
            "",
            "Điểm trung bình"});
            this.cboSapxep.Location = new System.Drawing.Point(485, 72);
            this.cboSapxep.Name = "cboSapxep";
            this.cboSapxep.Size = new System.Drawing.Size(170, 28);
            this.cboSapxep.TabIndex = 11;
            // 
            // cboThutu
            // 
            this.cboThutu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboThutu.Items.AddRange(new object[] {
            "Tăng dần (ASC)",
            "",
            "",
            "",
            "",
            "Giảm dần (DESC)",
            "Điểm trung bình"});
            this.cboThutu.Location = new System.Drawing.Point(675, 72);
            this.cboThutu.Name = "cboThutu";
            this.cboThutu.Size = new System.Drawing.Size(130, 28);
            this.cboThutu.TabIndex = 12;
            // 
            // btTimkiem_click
            // 
            this.btTimkiem_click.Location = new System.Drawing.Point(685, 120);
            this.btTimkiem_click.Name = "btTimkiem_click";
            this.btTimkiem_click.Size = new System.Drawing.Size(130, 35);
            this.btTimkiem_click.TabIndex = 13;
            this.btTimkiem_click.Text = "TÌM KIẾM";
            this.btTimkiem_click.Click += new System.EventHandler(this.btTimkiem_click_Click);
            // 
            // btLammoi_click
            // 
            this.btLammoi_click.Location = new System.Drawing.Point(835, 120);
            this.btLammoi_click.Name = "btLammoi_click";
            this.btLammoi_click.Size = new System.Drawing.Size(140, 35);
            this.btLammoi_click.TabIndex = 14;
            this.btLammoi_click.Text = "LÀM MỚI";
            // 
            // grpDanhSach
            // 
            this.grpDanhSach.Controls.Add(this.dgvSinhVien);
            this.grpDanhSach.Controls.Add(this.btTrangtruoc_click);
            this.grpDanhSach.Controls.Add(this.btTrangsau_click);
            this.grpDanhSach.Location = new System.Drawing.Point(15, 205);
            this.grpDanhSach.Name = "grpDanhSach";
            this.grpDanhSach.Size = new System.Drawing.Size(1020, 275);
            this.grpDanhSach.TabIndex = 1;
            this.grpDanhSach.TabStop = false;
            this.grpDanhSach.Text = "DANH SÁCH SINH VIÊN";
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.AllowUserToAddRows = false;
            this.dgvSinhVien.AllowUserToDeleteRows = false;
            this.dgvSinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSinhVien.ColumnHeadersHeight = 34;
            this.dgvSinhVien.Location = new System.Drawing.Point(15, 25);
            this.dgvSinhVien.MultiSelect = false;
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.ReadOnly = true;
            this.dgvSinhVien.RowHeadersWidth = 62;
            this.dgvSinhVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSinhVien.Size = new System.Drawing.Size(990, 195);
            this.dgvSinhVien.TabIndex = 0;
            // 
            // btTrangtruoc_click
            // 
            this.btTrangtruoc_click.Location = new System.Drawing.Point(350, 230);
            this.btTrangtruoc_click.Name = "btTrangtruoc_click";
            this.btTrangtruoc_click.Size = new System.Drawing.Size(140, 30);
            this.btTrangtruoc_click.TabIndex = 1;
            this.btTrangtruoc_click.Text = "TRANG TRƯỚC";
            // 
            // btTrangsau_click
            // 
            this.btTrangsau_click.Location = new System.Drawing.Point(530, 230);
            this.btTrangsau_click.Name = "btTrangsau_click";
            this.btTrangsau_click.Size = new System.Drawing.Size(140, 30);
            this.btTrangsau_click.TabIndex = 2;
            this.btTrangsau_click.Text = "TRANG SAU";
            // 
            // grpChiTiet
            // 
            this.grpChiTiet.Controls.Add(this.lbMasv);
            this.grpChiTiet.Controls.Add(this.txtMasv);
            this.grpChiTiet.Controls.Add(this.lbHoten);
            this.grpChiTiet.Controls.Add(this.txtHoten);
            this.grpChiTiet.Controls.Add(this.lbNgaysinh);
            this.grpChiTiet.Controls.Add(this.dtpNgaySinh);
            this.grpChiTiet.Controls.Add(this.lbGioitinhCT);
            this.grpChiTiet.Controls.Add(this.cboGioitinhCT);
            this.grpChiTiet.Controls.Add(this.lbDiem);
            this.grpChiTiet.Controls.Add(this.txtDiemtrungbinh);
            this.grpChiTiet.Controls.Add(this.lbKhoa);
            this.grpChiTiet.Controls.Add(this.txtKhoaCT);
            this.grpChiTiet.Location = new System.Drawing.Point(15, 490);
            this.grpChiTiet.Name = "grpChiTiet";
            this.grpChiTiet.Size = new System.Drawing.Size(1020, 170);
            this.grpChiTiet.TabIndex = 2;
            this.grpChiTiet.TabStop = false;
            this.grpChiTiet.Text = "THÔNG TIN CHI TIẾT SINH VIÊN";
            // 
            // lbMasv
            // 
            this.lbMasv.AutoSize = true;
            this.lbMasv.Location = new System.Drawing.Point(20, 35);
            this.lbMasv.Name = "lbMasv";
            this.lbMasv.Size = new System.Drawing.Size(100, 20);
            this.lbMasv.TabIndex = 0;
            this.lbMasv.Text = "Mã sinh viên:";
            // 
            // txtMasv
            // 
            this.txtMasv.Location = new System.Drawing.Point(125, 32);
            this.txtMasv.Name = "txtMasv";
            this.txtMasv.ReadOnly = true;
            this.txtMasv.Size = new System.Drawing.Size(200, 26);
            this.txtMasv.TabIndex = 1;
            // 
            // lbHoten
            // 
            this.lbHoten.AutoSize = true;
            this.lbHoten.Location = new System.Drawing.Point(20, 80);
            this.lbHoten.Name = "lbHoten";
            this.lbHoten.Size = new System.Drawing.Size(61, 20);
            this.lbHoten.TabIndex = 2;
            this.lbHoten.Text = "Họ tên:";
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(125, 77);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.ReadOnly = true;
            this.txtHoten.Size = new System.Drawing.Size(200, 26);
            this.txtHoten.TabIndex = 3;
            // 
            // lbNgaysinh
            // 
            this.lbNgaysinh.AutoSize = true;
            this.lbNgaysinh.Location = new System.Drawing.Point(365, 35);
            this.lbNgaysinh.Name = "lbNgaysinh";
            this.lbNgaysinh.Size = new System.Drawing.Size(82, 20);
            this.lbNgaysinh.TabIndex = 4;
            this.lbNgaysinh.Text = "Ngày sinh:";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(465, 32);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(200, 26);
            this.dtpNgaySinh.TabIndex = 5;
            // 
            // lbGioitinhCT
            // 
            this.lbGioitinhCT.AutoSize = true;
            this.lbGioitinhCT.Location = new System.Drawing.Point(365, 80);
            this.lbGioitinhCT.Name = "lbGioitinhCT";
            this.lbGioitinhCT.Size = new System.Drawing.Size(71, 20);
            this.lbGioitinhCT.TabIndex = 6;
            this.lbGioitinhCT.Text = "Giới tính:";
            // 
            // cboGioitinhCT
            // 
            this.cboGioitinhCT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGioitinhCT.Items.AddRange(new object[] {
            "Nam",
            " Nữ"});
            this.cboGioitinhCT.Location = new System.Drawing.Point(465, 77);
            this.cboGioitinhCT.Name = "cboGioitinhCT";
            this.cboGioitinhCT.Size = new System.Drawing.Size(200, 28);
            this.cboGioitinhCT.TabIndex = 7;
            // 
            // lbDiem
            // 
            this.lbDiem.AutoSize = true;
            this.lbDiem.Location = new System.Drawing.Point(700, 35);
            this.lbDiem.Name = "lbDiem";
            this.lbDiem.Size = new System.Drawing.Size(125, 20);
            this.lbDiem.TabIndex = 8;
            this.lbDiem.Text = "Điểm trung bình:";
            // 
            // txtDiemtrungbinh
            // 
            this.txtDiemtrungbinh.Location = new System.Drawing.Point(820, 32);
            this.txtDiemtrungbinh.Name = "txtDiemtrungbinh";
            this.txtDiemtrungbinh.ReadOnly = true;
            this.txtDiemtrungbinh.Size = new System.Drawing.Size(170, 26);
            this.txtDiemtrungbinh.TabIndex = 9;
            // 
            // lbKhoa
            // 
            this.lbKhoa.AutoSize = true;
            this.lbKhoa.Location = new System.Drawing.Point(700, 80);
            this.lbKhoa.Name = "lbKhoa";
            this.lbKhoa.Size = new System.Drawing.Size(50, 20);
            this.lbKhoa.TabIndex = 10;
            this.lbKhoa.Text = "Khoa:";
            // 
            // txtKhoaCT
            // 
            this.txtKhoaCT.Location = new System.Drawing.Point(820, 77);
            this.txtKhoaCT.Name = "txtKhoaCT";
            this.txtKhoaCT.ReadOnly = true;
            this.txtKhoaCT.Size = new System.Drawing.Size(170, 26);
            this.txtKhoaCT.TabIndex = 11;
            // 
            // lbTongsinhvien
            // 
            this.lbTongsinhvien.AutoSize = true;
            this.lbTongsinhvien.Location = new System.Drawing.Point(20, 675);
            this.lbTongsinhvien.Name = "lbTongsinhvien";
            this.lbTongsinhvien.Size = new System.Drawing.Size(148, 20);
            this.lbTongsinhvien.TabIndex = 3;
            this.lbTongsinhvien.Text = "Tổng số sinh viên: 0";
            // 
            // lbTranghientai
            // 
            this.lbTranghientai.AutoSize = true;
            this.lbTranghientai.Location = new System.Drawing.Point(400, 675);
            this.lbTranghientai.Name = "lbTranghientai";
            this.lbTranghientai.Size = new System.Drawing.Size(143, 20);
            this.lbTranghientai.TabIndex = 4;
            this.lbTranghientai.Text = "Trang hiện tại: 1 / 1";
            // 
            // lbTrangthai
            // 
            this.lbTrangthai.AutoSize = true;
            this.lbTrangthai.Location = new System.Drawing.Point(20, 710);
            this.lbTrangthai.Name = "lbTrangthai";
            this.lbTrangthai.Size = new System.Drawing.Size(160, 20);
            this.lbTrangthai.TabIndex = 5;
            this.lbTrangthai.Text = "Trạng thái: Sẵn sàng.";
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1050, 760);
            this.Controls.Add(this.grpTimKiem);
            this.Controls.Add(this.grpDanhSach);
            this.Controls.Add(this.grpChiTiet);
            this.Controls.Add(this.lbTongsinhvien);
            this.Controls.Add(this.lbTranghientai);
            this.Controls.Add(this.lbTrangthai);
            this.MinimumSize = new System.Drawing.Size(950, 700);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ SINH VIÊN ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpTimKiem.ResumeLayout(false);
            this.grpTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.grpDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.grpChiTiet.ResumeLayout(false);
            this.grpChiTiet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsSinhvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.GroupBox grpTimKiem;
        private System.Windows.Forms.GroupBox grpDanhSach;
        private System.Windows.Forms.GroupBox grpChiTiet;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.Label lbMasv;
        private System.Windows.Forms.Label lbHoten;
        private System.Windows.Forms.Label lbNgaysinh;
        private System.Windows.Forms.Label lbGioitinhCT;
        private System.Windows.Forms.Label lbDiem;
        private System.Windows.Forms.Label lbKhoa;

        private System.Windows.Forms.Label lbTongsinhvien;
        private System.Windows.Forms.Label lbTranghientai;
        private System.Windows.Forms.Label lbTrangthai;

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtMasv;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.TextBox txtDiemtrungbinh;
        private System.Windows.Forms.TextBox txtKhoaCT;

        private System.Windows.Forms.ComboBox cboGioitinh;
        private System.Windows.Forms.ComboBox cbokhoa;
        private System.Windows.Forms.ComboBox cboSapxep;
        private System.Windows.Forms.ComboBox cboThutu;
        private System.Windows.Forms.ComboBox cboGioitinhCT;

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;

        private System.Windows.Forms.DateTimePicker dtpNgaySinh;

        private System.Windows.Forms.Button btTimkiem_click;
        private System.Windows.Forms.Button btLammoi_click;
        private System.Windows.Forms.Button btTrangtruoc_click;
        private System.Windows.Forms.Button btTrangsau_click;

        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.BindingSource bsSinhvien;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
    }
}

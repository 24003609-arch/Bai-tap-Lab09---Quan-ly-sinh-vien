using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;

namespace Lab09_DataReaderSearch12
{
    public partial class Form1 : Form
    {
        // 1. KẾT NỐI MYSQL
        private string connectionString =
            "Server=localhost;Port=3306;Database=QLSinhVien;Uid=root;Pwd=12345678;";

        // 2. CONTROL TÌM KIẾM ĐA TIÊU CHÍ
        private TextBox txtMaSVLoc;
        private TextBox txtHoTenLoc;
        private ComboBox cboKhoaLoc;
        private ComboBox cboGioiTinhLoc;
        private NumericUpDown nudDiemMin;
        private NumericUpDown nudDiemMax;
        private Button btnLoc;

        // CONTROL LỌC TUỔI - BÀI 8
        private NumericUpDown nudTuoiMin;
        private NumericUpDown nudTuoiMax;

        // 3. CONTROL PHÂN TRANG
        private Panel pnlPhanTrang;
        private Button btnTrangTruoc;
        private Button btnTrangSau;
        private Button btnXuatCSV;
        private Label lblTrang;

        // 4. BIẾN PHÂN TRANG
        private int pageIndex = 1;
        private int pageSize = 10;
        private int totalPages = 1;
        private int totalStudents = 0;

        private bool dangKhoiTao = false;

        // =====================================================
        // KHỞI TẠO FORM
        // =====================================================

        public Form1()
        {
            InitializeComponent();

            TaoGiaoDienLoc();
            TaoGiaoDienPhanTrang();

            Load -= Form1_Load;
            Load += Form1_Load;

            btTimkiem_click.Click -= btTimkiem_click_Click;
            btTimkiem_click.Click += btTimkiem_click_Click;

            dgvSinhVien.SelectionChanged -= dgvSinhVien_SelectionChanged;
            dgvSinhVien.SelectionChanged += dgvSinhVien_SelectionChanged;
        }

        // =====================================================
        // 1. TẠO GIAO DIỆN TÌM KIẾM VÀ LỌC
        // =====================================================

        private void TaoGiaoDienLoc()
        {
            Panel pnlLoc = new Panel();
            pnlLoc.Location = new Point(10, 55);
            pnlLoc.Size = new Size(1100, 120);
            pnlLoc.Anchor =
                AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            Label lblMaSV = new Label();
            lblMaSV.Text = "Mã SV:";
            lblMaSV.Location = new Point(5, 12);
            lblMaSV.AutoSize = true;

            txtMaSVLoc = new TextBox();
            txtMaSVLoc.Location = new Point(65, 8);
            txtMaSVLoc.Size = new Size(130, 25);

            Label lblHoTen = new Label();
            lblHoTen.Text = "Họ tên:";
            lblHoTen.Location = new Point(215, 12);
            lblHoTen.AutoSize = true;

            txtHoTenLoc = new TextBox();
            txtHoTenLoc.Location = new Point(275, 8);
            txtHoTenLoc.Size = new Size(170, 25);

            Label lblKhoa = new Label();
            lblKhoa.Text = "Khoa:";
            lblKhoa.Location = new Point(465, 12);
            lblKhoa.AutoSize = true;

            cboKhoaLoc = new ComboBox();
            cboKhoaLoc.Location = new Point(515, 8);
            cboKhoaLoc.Size = new Size(160, 25);
            cboKhoaLoc.DropDownStyle =
                ComboBoxStyle.DropDownList;

            Label lblGioiTinh = new Label();
            lblGioiTinh.Text = "Giới tính:";
            lblGioiTinh.Location = new Point(695, 12);
            lblGioiTinh.AutoSize = true;

            cboGioiTinhLoc = new ComboBox();
            cboGioiTinhLoc.Location = new Point(760, 8);
            cboGioiTinhLoc.Size = new Size(110, 25);
            cboGioiTinhLoc.DropDownStyle =
                ComboBoxStyle.DropDownList;

            Label lblMin = new Label();
            lblMin.Text = "Điểm từ:";
            lblMin.Location = new Point(5, 52);
            lblMin.AutoSize = true;

            nudDiemMin = new NumericUpDown();
            nudDiemMin.Location = new Point(65, 48);
            nudDiemMin.Size = new Size(90, 25);
            nudDiemMin.DecimalPlaces = 2;
            nudDiemMin.Minimum = 0;
            nudDiemMin.Maximum = 10;
            nudDiemMin.Value = 0;

            Label lblMax = new Label();
            lblMax.Text = "Đến:";
            lblMax.Location = new Point(175, 52);
            lblMax.AutoSize = true;

            nudDiemMax = new NumericUpDown();
            nudDiemMax.Location = new Point(215, 48);
            nudDiemMax.Size = new Size(90, 25);
            nudDiemMax.DecimalPlaces = 2;
            nudDiemMax.Minimum = 0;
            nudDiemMax.Maximum = 10;
            nudDiemMax.Value = 10;

            Label lblTuoiMin = new Label();
            lblTuoiMin.Text = "Tuổi từ:";
            lblTuoiMin.Location = new Point(330, 52);
            lblTuoiMin.AutoSize = true;

            nudTuoiMin = new NumericUpDown();
            nudTuoiMin.Location = new Point(390, 48);
            nudTuoiMin.Size = new Size(65, 25);
            nudTuoiMin.Minimum = 0;
            nudTuoiMin.Maximum = 120;
            nudTuoiMin.Value = 0;

            Label lblTuoiMax = new Label();
            lblTuoiMax.Text = "Tuổi đến:";
            lblTuoiMax.Location = new Point(470, 52);
            lblTuoiMax.AutoSize = true;

            nudTuoiMax = new NumericUpDown();
            nudTuoiMax.Location = new Point(540, 48);
            nudTuoiMax.Size = new Size(65, 25);
            nudTuoiMax.Minimum = 0;
            nudTuoiMax.Maximum = 120;
            nudTuoiMax.Value = 120;

            btnLoc = new Button();
            btnLoc.Text = "Tìm kiếm";
            btnLoc.Location = new Point(620, 46);
            btnLoc.Size = new Size(100, 30);
            btnLoc.Click += btnLoc_Click;

            Button btnLamMoiLoc = new Button();
            btnLamMoiLoc.Text = "Làm mới";
            btnLamMoiLoc.Location = new Point(735, 46);
            btnLamMoiLoc.Size = new Size(100, 30);
            btnLamMoiLoc.Click += btnLamMoiLoc_Click;

            pnlLoc.Controls.AddRange(new Control[]
            {
                lblMaSV, txtMaSVLoc,
                lblHoTen, txtHoTenLoc,
                lblKhoa, cboKhoaLoc,
                lblGioiTinh, cboGioiTinhLoc,
                lblMin, nudDiemMin,
                lblMax, nudDiemMax,
                lblTuoiMin, nudTuoiMin,
                lblTuoiMax, nudTuoiMax,
                btnLoc, btnLamMoiLoc
            });

            Controls.Add(pnlLoc);
            pnlLoc.BringToFront();
        }

        // =====================================================
        // 2. TẠO GIAO DIỆN PHÂN TRANG VÀ XUẤT CSV
        // =====================================================

        private void TaoGiaoDienPhanTrang()
        {
            pnlPhanTrang = new Panel();
            pnlPhanTrang.Size = new Size(530, 45);
            pnlPhanTrang.Location =
                new Point(10, ClientSize.Height - 55);

            pnlPhanTrang.Anchor =
                AnchorStyles.Bottom | AnchorStyles.Left;

            pnlPhanTrang.BackColor = Color.White;

            btnTrangTruoc = new Button();
            btnTrangTruoc.Text = "Trang trước";
            btnTrangTruoc.Location = new Point(5, 5);
            btnTrangTruoc.Size = new Size(100, 32);
            btnTrangTruoc.Click += btnTrangTruoc_Click;

            lblTrang = new Label();
            lblTrang.Text = "Trang 1/1";
            lblTrang.Location = new Point(120, 13);
            lblTrang.AutoSize = true;

            btnTrangSau = new Button();
            btnTrangSau.Text = "Trang sau";
            btnTrangSau.Location = new Point(220, 5);
            btnTrangSau.Size = new Size(100, 32);
            btnTrangSau.Click += btnTrangSau_Click;

            // NÚT XUẤT CSV - BÀI 10
            btnXuatCSV = new Button();
            btnXuatCSV.Text = "Xuất CSV";
            btnXuatCSV.Location = new Point(325, 5);
            btnXuatCSV.Size = new Size(100, 32);
            btnXuatCSV.BackColor = Color.LightGreen;
            btnXuatCSV.Click += btnXuatCSV_Click;

            pnlPhanTrang.Controls.AddRange(new Control[]
            {
                btnTrangTruoc,
                lblTrang,
                btnTrangSau,
                btnXuatCSV
            });

            Controls.Add(pnlPhanTrang);
            pnlPhanTrang.BringToFront();
        }

        // =====================================================
        // 3. KHỞI TẠO COMBOBOX SẮP XẾP
        // =====================================================

        private void KhoiTaoComboBox()
        {
            dangKhoiTao = true;

            try
            {
                cboSapxep.Items.Clear();

                cboSapxep.Items.AddRange(new object[]
                {
                    "Mã sinh viên",
                    "Họ tên",
                    "Ngày sinh",
                    "Khoa",
                    "Điểm trung bình"
                });

                cboSapxep.SelectedIndex = 0;

                cboThutu.Items.Clear();

                cboThutu.Items.AddRange(new object[]
                {
                    "Tăng dần",
                    "Giảm dần"
                });

                cboThutu.SelectedIndex = 0;
            }
            finally
            {
                dangKhoiTao = false;
            }

            cboSapxep.SelectedIndexChanged -=
                cboSapxep_SelectedIndexChanged;

            cboSapxep.SelectedIndexChanged +=
                cboSapxep_SelectedIndexChanged;

            cboThutu.SelectedIndexChanged -=
                cboThutu_SelectedIndexChanged;

            cboThutu.SelectedIndexChanged +=
                cboThutu_SelectedIndexChanged;
        }

        // =====================================================
        // 4. NẠP DANH SÁCH KHOA VÀ GIỚI TÍNH
        // =====================================================

        private void LoadDanhSachKhoa()
        {
            dangKhoiTao = true;

            try
            {
                cboKhoaLoc.Items.Clear();
                cboKhoaLoc.Items.Add("Tất cả");

                string sql = @"
                    SELECT DISTINCT Khoa
                    FROM SinhVien
                    WHERE Khoa IS NOT NULL
                    AND Khoa <> ''
                    ORDER BY Khoa";

                using (MySqlConnection conn =
                    new MySqlConnection(connectionString))
                using (MySqlCommand cmd =
                    new MySqlCommand(sql, conn))
                {
                    conn.Open();

                    using (MySqlDataReader reader =
                        cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cboKhoaLoc.Items.Add(
                                reader["Khoa"].ToString());
                        }
                    }
                }

                cboKhoaLoc.SelectedIndex = 0;

                cboGioiTinhLoc.Items.Clear();

                cboGioiTinhLoc.Items.AddRange(new object[]
                {
                    "Tất cả", "Nam", "Nữ"
                });

                cboGioiTinhLoc.SelectedIndex = 0;
            }
            finally
            {
                dangKhoiTao = false;
            }
        }

        // =====================================================
        // 5. XÁC ĐỊNH CỘT SẮP XẾP
        // =====================================================

        private string LayCotSapXep()
        {
            switch (cboSapxep.SelectedIndex)
            {
                case 1: return "HoTen";
                case 2: return "NgaySinh";
                case 3: return "Khoa";
                case 4: return "DiemTB";
                default: return "MaSV";
            }
        }

        private string LayThuTuSapXep()
        {
            return cboThutu.SelectedIndex == 1
                ? "DESC"
                : "ASC";
        }

        // =====================================================
        // 6. TÍNH NGÀY SINH THEO KHOẢNG TUỔI - BÀI 8
        // =====================================================

        private DateTime LayNgaySinhDen(int tuoiMin)
        {
            return DateTime.Today.AddYears(-tuoiMin);
        }

        private DateTime LayNgaySinhTu(int tuoiMax)
        {
            return DateTime.Today.AddYears(-(tuoiMax + 1));
        }

        // =====================================================
        // 7. TẠO ĐIỀU KIỆN TÌM KIẾM
        // =====================================================

        private string TaoDieuKienLoc(
            string maSV,
            string hoTen,
            string khoa,
            string gioiTinh,
            decimal min,
            decimal max,
            int tuoiMin,
            int tuoiMax)
        {
            string dieuKien = " WHERE 1 = 1 ";

            if (!string.IsNullOrWhiteSpace(maSV))
                dieuKien += " AND MaSV LIKE @MaSV ";

            if (!string.IsNullOrWhiteSpace(hoTen))
                dieuKien += " AND HoTen LIKE @HoTen ";

            if (!string.IsNullOrEmpty(khoa) && khoa != "Tất cả")
                dieuKien += " AND Khoa = @Khoa ";

            if (!string.IsNullOrEmpty(gioiTinh) &&
                gioiTinh != "Tất cả")
                dieuKien += " AND GioiTinh = @GioiTinh ";

            dieuKien += " AND DiemTB BETWEEN @Min AND @Max ";

            dieuKien += @"
                AND NgaySinh <= @NgaySinhDen
                AND NgaySinh > @NgaySinhTu ";

            return dieuKien;
        }

        // =====================================================
        // 8. THÊM THAM SỐ TRUY VẤN
        // =====================================================

        private void ThemParameterLoc(
            MySqlCommand cmd,
            string maSV,
            string hoTen,
            string khoa,
            string gioiTinh,
            decimal min,
            decimal max,
            int tuoiMin,
            int tuoiMax)
        {
            if (!string.IsNullOrWhiteSpace(maSV))
            {
                cmd.Parameters.Add(
                    "@MaSV", MySqlDbType.VarChar, 20).Value =
                    "%" + maSV.Trim() + "%";
            }

            if (!string.IsNullOrWhiteSpace(hoTen))
            {
                cmd.Parameters.Add(
                    "@HoTen", MySqlDbType.VarChar, 100).Value =
                    "%" + hoTen.Trim() + "%";
            }

            if (!string.IsNullOrEmpty(khoa) && khoa != "Tất cả")
            {
                cmd.Parameters.Add(
                    "@Khoa", MySqlDbType.VarChar, 100).Value = khoa;
            }

            if (!string.IsNullOrEmpty(gioiTinh) &&
                gioiTinh != "Tất cả")
            {
                cmd.Parameters.Add(
                    "@GioiTinh", MySqlDbType.VarChar, 10).Value =
                    gioiTinh;
            }

            cmd.Parameters.Add("@Min", MySqlDbType.Decimal).Value = min;
            cmd.Parameters.Add("@Max", MySqlDbType.Decimal).Value = max;

            cmd.Parameters.Add(
                "@NgaySinhDen", MySqlDbType.Date).Value =
                LayNgaySinhDen(tuoiMin);

            cmd.Parameters.Add(
                "@NgaySinhTu", MySqlDbType.Date).Value =
                LayNgaySinhTu(tuoiMax);
        }

        // =====================================================
        // 9. ĐẾM TỔNG SINH VIÊN
        // =====================================================

        private int DemTongSinhVien(
            string maSV,
            string hoTen,
            string khoa,
            string gioiTinh,
            decimal min,
            decimal max,
            int tuoiMin,
            int tuoiMax)
        {
            string sql = "SELECT COUNT(*) FROM SinhVien";

            sql += TaoDieuKienLoc(
                maSV, hoTen, khoa, gioiTinh,
                min, max, tuoiMin, tuoiMax);

            using (MySqlConnection conn =
                new MySqlConnection(connectionString))
            using (MySqlCommand cmd =
                new MySqlCommand(sql, conn))
            {
                ThemParameterLoc(
                    cmd, maSV, hoTen, khoa, gioiTinh,
                    min, max, tuoiMin, tuoiMax);

                conn.Open();

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        // =====================================================
        // 10. LẤY DỮ LIỆU THEO TRANG
        // =====================================================

        private DataTable SearchStudents(
            string maSV,
            string hoTen,
            string khoa,
            string gioiTinh,
            decimal min,
            decimal max,
            int tuoiMin,
            int tuoiMax)
        {
            DataTable dt = new DataTable();

            string sql = @"
                SELECT MaSV, HoTen, NgaySinh, GioiTinh,
                       Khoa, Lop, DiemTB, Email
                FROM SinhVien";

            sql += TaoDieuKienLoc(
                maSV, hoTen, khoa, gioiTinh,
                min, max, tuoiMin, tuoiMax);

            sql += " ORDER BY " +
                   LayCotSapXep() + " " +
                   LayThuTuSapXep();

            int offset = (pageIndex - 1) * pageSize;

            sql += " LIMIT " + pageSize +
                   " OFFSET " + offset;

            using (MySqlConnection conn =
                new MySqlConnection(connectionString))
            using (MySqlCommand cmd =
                new MySqlCommand(sql, conn))
            {
                ThemParameterLoc(
                    cmd, maSV, hoTen, khoa, gioiTinh,
                    min, max, tuoiMin, tuoiMax);

                conn.Open();

                using (MySqlDataReader reader =
                    cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }
            }

            return dt;
        }

        // =====================================================
        // 11. CẬP NHẬT PHÂN TRANG
        // =====================================================

        private void CapNhatTrang()
        {
            lblTrang.Text =
                "Trang " + pageIndex + "/" + totalPages;

            btnTrangTruoc.Enabled = pageIndex > 1;
            btnTrangSau.Enabled = pageIndex < totalPages;

            pnlPhanTrang.BringToFront();
        }

        // =====================================================
        // 12. ĐỊNH DẠNG DATAGRIDVIEW - BÀI 9
        // =====================================================

        private void DinhDangDataGridView()
        {
            dgvSinhVien.AllowUserToAddRows = false;
            dgvSinhVien.ReadOnly = true;

            dgvSinhVien.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvSinhVien.MultiSelect = false;

            dgvSinhVien.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvSinhVien.RowHeadersVisible = false;

            dgvSinhVien.EnableHeadersVisualStyles = false;

            dgvSinhVien.ColumnHeadersDefaultCellStyle.BackColor =
                Color.LightSteelBlue;

            dgvSinhVien.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.Black;

            dgvSinhVien.ColumnHeadersDefaultCellStyle.Font =
                new Font("Arial", 10, FontStyle.Bold);

            dgvSinhVien.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            dgvSinhVien.ColumnHeadersHeight = 35;

            dgvSinhVien.DefaultCellStyle.Font =
                new Font("Arial", 10, FontStyle.Regular);

            dgvSinhVien.DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            dgvSinhVien.DefaultCellStyle.SelectionBackColor =
                Color.SteelBlue;

            dgvSinhVien.DefaultCellStyle.SelectionForeColor =
                Color.White;

            if (dgvSinhVien.Columns.Contains("MaSV"))
                dgvSinhVien.Columns["MaSV"].HeaderText = "Mã sinh viên";

            if (dgvSinhVien.Columns.Contains("HoTen"))
                dgvSinhVien.Columns["HoTen"].HeaderText = "Họ tên";

            if (dgvSinhVien.Columns.Contains("NgaySinh"))
            {
                dgvSinhVien.Columns["NgaySinh"].HeaderText = "Ngày sinh";

                dgvSinhVien.Columns["NgaySinh"]
                    .DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            if (dgvSinhVien.Columns.Contains("GioiTinh"))
                dgvSinhVien.Columns["GioiTinh"].HeaderText = "Giới tính";

            if (dgvSinhVien.Columns.Contains("Khoa"))
                dgvSinhVien.Columns["Khoa"].HeaderText = "Khoa";

            if (dgvSinhVien.Columns.Contains("Lop"))
                dgvSinhVien.Columns["Lop"].HeaderText = "Lớp";

            if (dgvSinhVien.Columns.Contains("DiemTB"))
            {
                dgvSinhVien.Columns["DiemTB"].HeaderText =
                    "Điểm trung bình";

                dgvSinhVien.Columns["DiemTB"]
                    .DefaultCellStyle.Format = "N2";
            }

            if (dgvSinhVien.Columns.Contains("Email"))
                dgvSinhVien.Columns["Email"].HeaderText = "Email";

            foreach (DataGridViewRow row in dgvSinhVien.Rows)
            {
                if (row.IsNewRow ||
                    !dgvSinhVien.Columns.Contains("DiemTB"))
                    continue;

                object giaTriDiem = row.Cells["DiemTB"].Value;

                if (giaTriDiem == null ||
                    giaTriDiem == DBNull.Value)
                    continue;

                decimal diem = Convert.ToDecimal(giaTriDiem);

                if (diem < 5)
                {
                    row.DefaultCellStyle.BackColor =
                        Color.MistyRose;

                    row.DefaultCellStyle.ForeColor =
                        Color.DarkRed;
                }
                else if (diem >= 8)
                {
                    row.DefaultCellStyle.BackColor =
                        Color.LightGreen;

                    row.DefaultCellStyle.ForeColor =
                        Color.DarkGreen;
                }
                else
                {
                    row.DefaultCellStyle.BackColor =
                        Color.White;

                    row.DefaultCellStyle.ForeColor =
                        Color.Black;
                }
            }
        }

        // =====================================================
        // 13. HIỂN THỊ DANH SÁCH SINH VIÊN
        // =====================================================

        private void HienThiDanhSach(DataTable dt)
        {
            bsSinhvien.DataSource = dt;
            dgvSinhVien.DataSource = bsSinhvien;

            DinhDangDataGridView();

            if (dt.Rows.Count > 0)
            {
                HienThiThongTinChiTiet();
            }
            else
            {
                XoaThongTinChiTiet();
                lbTrangthai.Text =
                    "Không có sinh viên phù hợp";
            }

            CapNhatTrang();
        }

        // =====================================================
        // 14. TÌM KIẾM, LỌC VÀ PHÂN TRANG
        // =====================================================

        private void ThucHienTimKiemVaLoc(
            bool veTrangDau = true)
        {
            if (dangKhoiTao)
                return;

            decimal min = nudDiemMin.Value;
            decimal max = nudDiemMax.Value;

            int tuoiMin = (int)nudTuoiMin.Value;
            int tuoiMax = (int)nudTuoiMax.Value;

            if (min > max)
            {
                MessageBox.Show(
                    "Điểm tối thiểu không được lớn hơn điểm tối đa!");
                return;
            }

            if (tuoiMin > tuoiMax)
            {
                MessageBox.Show(
                    "Tuổi tối thiểu không được lớn hơn tuổi tối đa!");
                return;
            }

            if (veTrangDau)
                pageIndex = 1;

            string maSV = txtMaSVLoc.Text.Trim();
            string hoTen = txtHoTenLoc.Text.Trim();

            string khoa = cboKhoaLoc.SelectedItem == null
                ? "Tất cả"
                : cboKhoaLoc.SelectedItem.ToString();

            string gioiTinh = cboGioiTinhLoc.SelectedItem == null
                ? "Tất cả"
                : cboGioiTinhLoc.SelectedItem.ToString();

            try
            {
                totalStudents = DemTongSinhVien(
                    maSV, hoTen, khoa, gioiTinh,
                    min, max, tuoiMin, tuoiMax);

                totalPages = Math.Max(
                    1,
                    (int)Math.Ceiling(
                        (double)totalStudents / pageSize));

                if (pageIndex > totalPages)
                    pageIndex = totalPages;

                if (pageIndex < 1)
                    pageIndex = 1;

                DataTable dt = SearchStudents(
                    maSV, hoTen, khoa, gioiTinh,
                    min, max, tuoiMin, tuoiMax);

                HienThiDanhSach(dt);

                lbTongsinhvien.Text =
                    "Tổng sinh viên: " + totalStudents;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi xử lý dữ liệu: " + ex.Message,
                    "Thông báo lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =====================================================
        // 15. CÁC SỰ KIỆN TÌM KIẾM
        // =====================================================

        private void btTimkiem_click_Click(
            object sender, EventArgs e)
        {
            ThucHienTimKiemVaLoc();
        }

        private void btnLoc_Click(
            object sender, EventArgs e)
        {
            ThucHienTimKiemVaLoc();
        }

        private void btnLamMoiLoc_Click(
            object sender, EventArgs e)
        {
            txtMaSVLoc.Clear();
            txtHoTenLoc.Clear();

            cboKhoaLoc.SelectedIndex = 0;
            cboGioiTinhLoc.SelectedIndex = 0;

            nudDiemMin.Value = 0;
            nudDiemMax.Value = 10;

            nudTuoiMin.Value = 0;
            nudTuoiMax.Value = 120;

            ThucHienTimKiemVaLoc();
        }

        // =====================================================
        // 16. PHÂN TRANG
        // =====================================================

        private void btnTrangTruoc_Click(
            object sender, EventArgs e)
        {
            if (pageIndex > 1)
            {
                pageIndex--;
                ThucHienTimKiemVaLoc(false);
            }
        }

        private void btnTrangSau_Click(
            object sender, EventArgs e)
        {
            if (pageIndex < totalPages)
            {
                pageIndex++;
                ThucHienTimKiemVaLoc(false);
            }
        }

        // =====================================================
        // 17. SẮP XẾP
        // =====================================================

        private void cboSapxep_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            if (!dangKhoiTao)
                ThucHienTimKiemVaLoc();
        }

        private void cboThutu_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            if (!dangKhoiTao)
                ThucHienTimKiemVaLoc();
        }

        // =====================================================
        // 18. LẤY GIÁ TRỊ Ô AN TOÀN
        // =====================================================

        private string LayGiaTriO(
            DataGridViewRow row, string tenCot)
        {
            object giaTri = row.Cells[tenCot].Value;

            if (giaTri == null || giaTri == DBNull.Value)
                return "";

            return Convert.ToString(giaTri);
        }

        // =====================================================
        // 19. HIỂN THỊ CHI TIẾT SINH VIÊN
        // =====================================================

        private void HienThiThongTinChiTiet()
        {
            if (dgvSinhVien.CurrentRow == null)
                return;

            DataGridViewRow row = dgvSinhVien.CurrentRow;

            if (row.IsNewRow)
                return;

            txtMasv.Text = LayGiaTriO(row, "MaSV");
            txtHoten.Text = LayGiaTriO(row, "HoTen");

            txtDiemtrungbinh.Text =
                LayGiaTriO(row, "DiemTB");

            txtKhoaCT.Text =
                LayGiaTriO(row, "Khoa");

            cboGioitinhCT.Text =
                LayGiaTriO(row, "GioiTinh");

            object giaTriNgaySinh =
                row.Cells["NgaySinh"].Value;

            if (giaTriNgaySinh != null &&
                giaTriNgaySinh != DBNull.Value)
            {
                DateTime ngaySinh =
                    Convert.ToDateTime(giaTriNgaySinh);

                if (ngaySinh >= dtpNgaySinh.MinDate &&
                    ngaySinh <= dtpNgaySinh.MaxDate)
                {
                    dtpNgaySinh.Value = ngaySinh;
                }
            }

            lbTrangthai.Text =
                "Đang chọn: " + txtMasv.Text;
        }

        // =====================================================
        // 20. XÓA THÔNG TIN CHI TIẾT
        // =====================================================

        private void XoaThongTinChiTiet()
        {
            txtMasv.Clear();
            txtHoten.Clear();
            txtDiemtrungbinh.Clear();
            txtKhoaCT.Clear();

            cboGioitinhCT.Text = "";
        }

        private void dgvSinhVien_SelectionChanged(
            object sender, EventArgs e)
        {
            HienThiThongTinChiTiet();
        }

        // =====================================================
        // 21. XUẤT KẾT QUẢ TÌM KIẾM RA CSV - BÀI 10
        // =====================================================

        private void btnXuatCSV_Click(object sender, EventArgs e)
        {
            if (dgvSinhVien.Rows.Count == 0)
            {
                MessageBox.Show(
                    "Không có dữ liệu để xuất!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "CSV Files (*.csv)|*.csv";
                saveFileDialog.Title = "Xuất kết quả tìm kiếm";
                saveFileDialog.FileName = "DanhSachSinhVien.csv";
                saveFileDialog.DefaultExt = "csv";
                saveFileDialog.AddExtension = true;

                if (saveFileDialog.ShowDialog() != DialogResult.OK)
                    return;

                try
                {
                    using (StreamWriter writer = new StreamWriter(
                        saveFileDialog.FileName,
                        false,
                        new UTF8Encoding(true)))
                    {
                        // LẤY CÁC CỘT ĐANG HIỂN THỊ THEO THỨ TỰ
                        List<DataGridViewColumn> columns =
                            dgvSinhVien.Columns
                                .Cast<DataGridViewColumn>()
                                .Where(c => c.Visible)
                                .OrderBy(c => c.DisplayIndex)
                                .ToList();

                        // XUẤT TIÊU ĐỀ CỘT
                        List<string> headers = new List<string>();

                        foreach (DataGridViewColumn column in columns)
                        {
                            string header =
                                column.HeaderText.Replace("\"", "\"\"");

                            headers.Add("\"" + header + "\"");
                        }

                        writer.WriteLine(string.Join(",", headers));

                        // XUẤT CÁC DÒNG ĐANG HIỂN THỊ
                        foreach (DataGridViewRow row in dgvSinhVien.Rows)
                        {
                            if (row.IsNewRow || !row.Visible)
                                continue;

                            List<string> values = new List<string>();

                            foreach (DataGridViewColumn column in columns)
                            {
                                object cellValue =
                                    row.Cells[column.Index].Value;

                                string value = "";

                                if (cellValue != null &&
                                    cellValue != DBNull.Value)
                                {
                                    if (column.Name == "NgaySinh")
                                    {
                                        value = Convert.ToDateTime(cellValue)
                                            .ToString("dd/MM/yyyy");
                                    }
                                    else if (column.Name == "DiemTB")
                                    {
                                        value = Convert.ToDecimal(cellValue)
                                            .ToString("0.00");
                                    }
                                    else
                                    {
                                        value = Convert.ToString(cellValue);
                                    }
                                }

                                value = value.Replace("\"", "\"\"");

                                values.Add("\"" + value + "\"");
                            }

                            writer.WriteLine(string.Join(",", values));
                        }
                    }

                    MessageBox.Show(
                        "Xuất file CSV thành công!\n\nĐường dẫn: " +
                        saveFileDialog.FileName,
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Lỗi khi xuất file CSV: " + ex.Message,
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }

        // =====================================================
        // 22. FORM LOAD
        // =====================================================

        private void Form1_Load(
            object sender, EventArgs e)
        {
            try
            {
                KhoiTaoComboBox();
                LoadDanhSachKhoa();

                pageIndex = 1;

                ThucHienTimKiemVaLoc();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể tải dữ liệu: " + ex.Message,
                    "Lỗi kết nối",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =====================================================
        // 23. CÁC SỰ KIỆN CŨ CỦA DESIGNER
        // =====================================================

        private void bindingSource1_CurrentChanged(
            object sender, EventArgs e)
        {
        }

        private void label1_Click(
            object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(
            object sender, EventArgs e)
        {
        }

        private void lbGioitinhCT_Click(
            object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(
            object sender, EventArgs e)
        {
        }

        private void lbEmail_Click(
            object sender, EventArgs e)
        {
        }

        private void grpDanhSach_Enter(
            object sender, EventArgs e)
        {
        }
    }
}
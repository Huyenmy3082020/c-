using BaiTapLonQuanLiBanHang.DAO;
using BaiTapLonQuanLiBanHang.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLonQuanLiBanHang
{
    public partial class DanhSachHoaDon_Main_ : Form
    {
        private ErrorProvider errorProvider = new ErrorProvider();

        public DanhSachHoaDon_Main_()
        {
            InitializeComponent();
            this.Size = new Size(900, 800);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        // tên khách hàng không để trống
        private void txbKhachHang_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbKhachHang.Text))
            {
                errorProvider.SetError(txbKhachHang, "Tên khách hàng không được để trống");

            } else
            {
                errorProvider.SetError(txbKhachHang, null);
            }
        }

        // địa chỉ không để trống
        private void txbDiaChi_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbDiaChi.Text))
            {
                errorProvider.SetError(txbDiaChi, "Địa chỉ không được để trống");
            }
            else
            {
                errorProvider.SetError(txbDiaChi, null);
            }
        }

        // điện thoại không được để trống
        private void txbSoDienThoai_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbSoDienThoai.Text))
            {
                errorProvider.SetError(txbSoDienThoai, "Số điện thoại không được để trống");
                e.Cancel = true; 
            }
            else
            { 
                if (!IsNumeric(txbSoDienThoai.Text))
                {
                    errorProvider.SetError(txbSoDienThoai, "Số điện thoại phải là số");
                    e.Cancel = true;
                }
                else if (txbSoDienThoai.Text.Length >= 12)
                {
                    errorProvider.SetError(txbSoDienThoai, "Số điện thoại chỉ có thể có tối đa 11 chữ số");
                    e.Cancel = true;
                }
                else
                {
                    errorProvider.SetError(txbSoDienThoai, null);
                }
            }
        }

        // Hàm kiểm tra xem chuỗi có phải là số không
        private bool IsNumeric(string value)
        {
            return int.TryParse(value, out _);
        }


        // giới tính không được để trống
        private void rdonam_Validating(object sender, CancelEventArgs e)
        {
            if (!rdonam.Checked && !rdoNu.Checked)
            {
                errorProvider.SetError(rdonam, "vui lòng chọn giới tinh");
            }
            else
            {
                errorProvider.SetError(rdonam, null);


            }
        }

        // giới tính không được để trống
        private void rdoNu_Validating(object sender, CancelEventArgs e)
            {
                if (!rdonam.Checked && !rdoNu.Checked)
                {
                    errorProvider.SetError(rdoNu, "vui lòng chọn giới tinh");
                }
                else
                {
                    errorProvider.SetError(rdoNu, null);

                }
            }
        // hiện danh sách hóa đơn
        void LoadDanhSachHoaDon()
        {

            dataGridView1.DataSource = ChiTietHoaDonDAO.Instance.DanhSachHoaDon(txbKhachHang.Text);

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {

        }

        private void DanhSachHoaDon_Main__Load(object sender, EventArgs e)
        {
          
            LoadDanhSachLoaiHang(cbxTenLoaiHang);
            LoadDanhSachTenNhanVien();
            btnThem.Enabled = false;

            txbKhachHang.TextChanged += DanhSachHoaDon_Main__TextChanged;
            txbDiaChi.TextChanged += DanhSachHoaDon_Main__TextChanged;
            txbSoDienThoai.TextChanged += DanhSachHoaDon_Main__TextChanged;
            txbSoLuong.TextChanged += DanhSachHoaDon_Main__TextChanged;
            cbxTenLoaiHang.TextChanged += DanhSachHoaDon_Main__TextChanged;
        

        }
        // nút thêm mới 
        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenKh = txbKhachHang.Text.ToString();
            string diaChi = txbDiaChi.Text.ToString();
            string sdt = txbSoDienThoai.Text.ToString();
            string tennv = comboBoxTenNhanVien.Text.ToString();
            string tenlh = cbxTenLoaiHang.Text;
            string tenmh = cbxTenMathang.Text;
            int giamgia = Convert.ToInt32(nmSoLuong.Value);
            int soluong = Convert.ToInt32(txbSoLuong.Text);
            bool gt = Convert.ToBoolean(gioitinh());



                HoaDonDAO.Instance.ThemHoaDon(tenKh, diaChi, gt, tennv, sdt, tenmh, giamgia, soluong);
                 LoadDanhSachHoaDon();
                MessageBox.Show("Thêm mới thành công");

            
        }
        // kiểm tra giới tính
        bool gioitinh()
        {
            if (rdonam.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        void LoadDanhSachLoaiHang(ComboBox cbx)
        {
            cbx.DataSource = LoaihangDAO.Instance.dsLoaiHang();
            cbx.DisplayMember = "tenLh";
        }
        void LoadDanhSachMatHang(string id, ComboBox cbx)
        {
            List<MatHangDTO> list = MatHangDAO.Instance.layraId(id);
            cbxTenMathang.DisplayMember = "tenHang";
            cbxTenMathang.DataSource = list;
           
        }
        void LoadDanhSachTenNhanVien()
        {
            List<NhanVienDTO> list = NhanVienDAO.Instance.DanhSachNhanVien();
            comboBoxTenNhanVien.DisplayMember = "tennv";
            comboBoxTenNhanVien.DataSource = list;

        }


        private void cbxTenLoaiHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
            {
                return;
            }
            LoaiHangDTO seleted = cb.SelectedItem as LoaiHangDTO;
            string malh = seleted.Malh;
            LoadDanhSachMatHang(malh, cbxTenMathang);
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhanVien nhanVien = new NhanVien();
            nhanVien.Show();
        }

        private void mặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MatHang mh = new MatHang();
            mh.ShowDialog();

        }

    

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tổng số tiền phải thanh toán là :" + tinhtong());
            ChiTietHoaDonDAO.Instance.ThanhToanHoaDon(txbKhachHang.Text);
            dataGridView1.DataSource = null;
            txbKhachHang.Text = "";
            txbDiaChi.Text = "";
            txbSoDienThoai.Text = "";
            txbSoLuong.Text = "";
            cbxTenLoaiHang.Text = "";


        }
        public int tinhtong()
        {
            int sum = 0;
            // Kiểm tra xem DataGridView có ít nhất một dòng không
            if (dataGridView1.Rows.Count > 0)
            {
                // Khởi tạo biến tổng
           

                // Lặp qua từng dòng trong DataGridView
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    // Lấy giá trị của ô trong cột cuối cùng
                    int cellValue;
                    if (int.TryParse(row.Cells[dataGridView1.Columns.Count - 1].Value?.ToString(), out cellValue))
                    {
                        // Cộng giá trị vào tổng
                        sum += cellValue;
                    }
                }
            }
            return sum;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txbKhachHang.Text = Convert.ToString(row.Cells["tenKh"].Value);
                txbSoDienThoai.Text = Convert.ToString(row.Cells["soDienThoai"].Value);
                comboBoxTenNhanVien.Text = Convert.ToString(row.Cells["tenNhanVien"].Value);
            }
        }
        private void btnIn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ChiTietHoaDonDAO.Instance.DanhSachHoaDon(txbKhachHang.Text);

        }

        private void DanhSachHoaDon_Main__TextChanged(object sender, EventArgs e)
        {
            if (txbKhachHang.Text.Length>0 && txbDiaChi.Text.Length>0 && txbSoDienThoai.Text.Length>0 && comboBoxTenNhanVien.Text.Length>0
                && txbSoLuong.Text.Length > 0 && cbxTenLoaiHang.Text.Length>0)
            {
                btnThem.Enabled = true;
            }

        }

        private void txbSoLuong_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbSoLuong.Text))
            {
                errorProvider.SetError(txbSoLuong, "Số lượng không được để trống");
                e.Cancel = true; 
            }
            else
            {
               
                if (!IsNumeric(txbSoLuong.Text))
                {
                    errorProvider.SetError(txbSoLuong, "Số lượng phải là số");
                    e.Cancel = true;
                }
                else
                {
                    errorProvider.SetError(txbSoLuong, null);
                }
            }
        }

    }
}

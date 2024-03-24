using BaiTapLonQuanLiBanHang.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLonQuanLiBanHang
{
    public partial class NhaCungCap : Form
    {
        int mncc;
        ErrorProvider errorProvider = new ErrorProvider();
        public NhaCungCap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            NhaCungCapDAO.Instance.XoaNhaCungCap(mncc);
            LoadDanhSachNhaCungCap();

        }
        void LoadDanhSachNhaCungCap()
        {
            dtgDanhSachNhaCungCap.DataSource = NhaCungCapDAO.Instance.DanhSachNhaCungCap();

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            int mancc = Convert.ToInt32(txbNCC.Text);
                
            if (!NhaCungCapDAO.Instance.KiemTraKhoaChinh(mancc))
            {
                NhaCungCapDAO.Instance.ThemNhaCungCap(mancc, txbTen.Text, txbDienThoai.Text, cbxDiaChi.Text);
                LoadDanhSachNhaCungCap();
                MessageBox.Show("Them duoc roi nhe");

            }

            else
            {
                MessageBox.Show("Mã nhà cung cấp đã tồn tại , Vui long nhập mã khác nhé !!");
            }
         }

        private void dtgDanhSachNhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0 && e.RowIndex < dtgDanhSachNhaCungCap.Rows.Count)
            {
                DataGridViewRow row = dtgDanhSachNhaCungCap.Rows[e.RowIndex];

                txbTen.Text = Convert.ToString(row.Cells["ten"].Value);
                txbDienThoai.Text = Convert.ToString(row.Cells["dt"].Value);
                cbxDiaChi.Text = Convert.ToString(row.Cells["dc"].Value);

                mncc = Convert.ToInt32(dtgDanhSachNhaCungCap.Rows[e.RowIndex].Cells["mancc"].Value.ToString());

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            NhaCungCapDAO.Instance.SuaNhaCungCap(mncc, txbTen.Text, txbDienThoai.Text, cbxDiaChi.Text);
            LoadDanhSachNhaCungCap();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NhaCungCap_Load(object sender, EventArgs e)
        {
            LoadDanhSachNhaCungCap();
        }

        private void txbNCC_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txbDienThoai_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbDienThoai.Text))
            {
                errorProvider.SetError(txbDienThoai, "Số điện thoại không được để trống");
                e.Cancel = true;
            }
            else
            {
                if (!IsNumeric(txbDienThoai.Text))
                {
                    errorProvider.SetError(txbDienThoai, "Số điện thoại phải là số");
                    e.Cancel = true;
                }
                else if (txbDienThoai.Text.Length >= 12)
                {
                    errorProvider.SetError(txbDienThoai, "Số điện thoại chỉ có thể có tối đa 11 chữ số");
                    e.Cancel = true;
                }
                else
                {
                    errorProvider.SetError(txbDienThoai, null);
                }
            }
        }

        // Hàm kiểm tra xem chuỗi có phải là số không
        private bool IsNumeric(string value)
        {
            return int.TryParse(value, out _);
        }

        private void cbxDiaChi_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cbxDiaChi.Text))
            {
                errorProvider.SetError(cbxDiaChi, "Vui lòng chọn địa chỉ");

            }
            else
            {
                errorProvider.SetError(cbxDiaChi, null);
            }
        }

        private void txbTen_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbTen.Text))
            {
                errorProvider.SetError(txbTen, "Tên Nhà cung cấp không để trống ");

            }
            else
            {
                errorProvider.SetError(txbTen, null);
            }
        }
    }
}
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
    public partial class KhachHang : Form
    {

        ErrorProvider errorProvider = new ErrorProvider();
        public KhachHang()
        {
            InitializeComponent();
        }

        

        private void rdoNam_CheckedChanged(object sender, EventArgs e)
        {

        }

       
        private void txbTen_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbTen.Text))
            {
                errorProvider.SetError(txbTen, "khong trong");

            }
            else {
                errorProvider.SetError(txbTen, null);
            }
        }

        // Hàm kiểm tra xem chuỗi có phải là số không
        private bool IsNumeric(string value)
        {
            return int.TryParse(value, out _);
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

        private void cbxDiaChi_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbTen.Text))
            {
                errorProvider.SetError(txbTen, "khong trong");

            }
            else
            {
                errorProvider.SetError(txbTen, null);
            }
        }

        private void rdoNam_Validating(object sender, CancelEventArgs e)
        {
            if (!rdoNam.Checked && !rdoNu.Checked)
            {
                errorProvider.SetError(rdoNam, "vui lòng chọn giới tinh");
            }
            else
            {
                errorProvider.SetError(rdoNam, null);


            }
        }

        private void rdoNu_Validating(object sender, CancelEventArgs e)
        {
            if (!rdoNam.Checked && !rdoNu.Checked)
            {
                errorProvider.SetError(rdoNu, "vui lòng chọn giới tinh");
            }
            else
            {
                errorProvider.SetError(rdoNu, null);

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class DangKiTaiKhoan : Form
    {
        public DangKiTaiKhoan()
        {
            InitializeComponent();
        }

        private void DangKiTaiKhoan_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tentk = txbTenDangNhap.Text;
            string mk = txbtenMatKhau.Text;
            string mknl = txbNhapLaiMatKhau.Text;

            if (mk != mknl)
            {
                if (MessageBox.Show("Mật khẩu nhập lại không chính xác", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) != DialogResult.OK)
                {
                    return; 
                }
            }
            if (KiemTraTenDangNhap())
            {
                if (MessageBox.Show("Tên tài khoản đã tồn tại", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) != DialogResult.OK)
                {
                    return; 
                }
            }
            else
            {

                TaiKhoanDAO.Instance.ThemTaiKhoan(tentk, mknl) ;
                MessageBox.Show("Đăng kí thành công");
                Application.Exit(); 

            }
        }
        public bool KiemTraTenDangNhap()
        {
            string tenDangNhap = txbTenDangNhap.Text;
          if (TaiKhoanDAO.Instance.HienThiTaiKhoan(tenDangNhap))
            {
                return true;
            }
          return false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

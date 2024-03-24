using BaiTapLonQuanLiBanHang.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLonQuanLiBanHang
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tenTaiKhoan = txbTenDangNhap.Text;
            string matKhau = txbtenMatKhau.Text;
           if (Login(tenTaiKhoan,matKhau))
            {
                DanhSachHoaDon_Main_ ds = new DanhSachHoaDon_Main_();
                this.Hide();
                ds.ShowDialog();
                this.Show();
            }
           else
            {
                MessageBox.Show("Bạn nhập sai tài khoản hoặc mật khẩu ");

            }
        }
        bool Login(string tenTaiKhoan, string matKhau )
        {
          return TaiKhoanDAO.Instance.Login(tenTaiKhoan , matKhau);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DangKiTaiKhoan dk = new DangKiTaiKhoan();
            dk.ShowDialog();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

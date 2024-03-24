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
    public partial class LoaiHang : Form
    {
        string malh;

        ErrorProvider errorProvider= new ErrorProvider();
        public LoaiHang()
        {
            InitializeComponent();
        }

        private void TênMaLH_Validating(object sender, CancelEventArgs e)
        { 
            if (string.IsNullOrEmpty(TênMaLH.Text))
            {
                errorProvider.SetError(TênMaLH, "Vui long khong de trong");
            }
            else
            {
                errorProvider.SetError(TênMaLH, null);
            }
        }

        private void txbTenLH_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbTenLH.Text))
            {
                errorProvider.SetError(txbTenLH, "Vui long khong de trong");
            }
            else
            {
                errorProvider.SetError(txbTenLH, null);
            }

        }
        public void LoadDanhSachLoaiHang()
        {
            dtgDanhSachLoaiHang.DataSource = LoaihangDAO.Instance.dsLoaiHang();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            LoaihangDAO.Instance.ThemLoaiHang(malh,txbTenLH.Text);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            LoaihangDAO.Instance.XoaLoaiHang(malh);

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            LoaihangDAO.Instance.ThemLoaiHang(TênMaLH.Text, txbTenLH.Text);

        }

        private void LoaiHang_Load(object sender, EventArgs e)
        {
            LoadDanhSachLoaiHang();
        }

        private void dtgDanhSachLoaiHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dtgDanhSachLoaiHang.Rows.Count)
            {
                DataGridViewRow row = dtgDanhSachLoaiHang.Rows[e.RowIndex];

                TênMaLH.Text = Convert.ToString(row.Cells["malh"].Value);
                txbTenLH.Text = Convert.ToString(row.Cells["tenLh"].Value);


                btnXoa.Enabled = true;
                btnSua.Enabled = true;



            malh= dtgDanhSachLoaiHang.Rows[e.RowIndex].Cells["malh"].Value.ToString();


            }
        }
    }
}

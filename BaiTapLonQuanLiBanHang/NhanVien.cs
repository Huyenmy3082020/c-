using BaiTapLonQuanLiBanHang.DAO;
using BaiTapLonQuanLiBanHang.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace BaiTapLonQuanLiBanHang
{
    public partial class NhanVien : Form
    {
        int mnv;
        private ErrorProvider errorProvider = new ErrorProvider();

        public NhanVien()
        {
            InitializeComponent();
        }

       
        

        private void NhanVien_Load_1(object sender, EventArgs e)
        {

            LoadDanhSachNhanVien();
            dataGridViewdsnv.CellClick += dataGridViewdsnv_CellClick; // Thêm sự kiện CellClick vào DataGridView
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled=false;
            txbTen.TextChanged += NhanVien_TextChanged;
            txbPhuCap.TextChanged += NhanVien_TextChanged;
            txbLCB.TextChanged += NhanVien_TextChanged;
            txbSDT.TextChanged += NhanVien_TextChanged;
            cbxDiaChi.TextChanged += NhanVien_TextChanged;
            dtpkNgaySinh.TextChanged += NhanVien_TextChanged;
            dtpkNgayVaoLam.TextChanged += NhanVien_TextChanged;


        }
        

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tennv = txbTen.Text;
            int lcb = Convert.ToInt32(txbLCB.Text);
            string sdt = txbSDT.Text;
            string dc = cbxDiaChi.Text;
            DateTime ngayvaolam = dtpkNgayVaoLam.Value;
            DateTime ngaysinh = dtpkNgaySinh.Value;
            int pc = Convert.ToInt32(txbPhuCap.Text);

           if (NhanVienDAO.Instance.ThemNhanVien(tennv, dc, sdt, ngaysinh, ngayvaolam, lcb, pc))
            {
                MessageBox.Show("Them moi thanh cong");
                LoadDanhSachNhanVien();
            }
           
        }
        void LoadDanhSachNhanVien()
        {

            List<NhanVienDTO> danhSachNhanVien = NhanVienDAO.Instance.DanhSachNhanVien();
            dataGridViewdsnv.DataSource = danhSachNhanVien;
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }
        private bool IsNumeric(string value)
        {
            return int.TryParse(value, out _);
        }


        private void txbTen_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txbTen.Text)) {

                errorProvider.SetError(txbTen, "khong duoc de trong");
            }
            else {
                errorProvider.SetError(txbTen,null);

            }
        }

        private void txbLCB_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbLCB.Text))
            {

                errorProvider.SetError(txbLCB, "khong duoc de trong");

            }else if (!IsNumeric(txbLCB.Text))
            {
                errorProvider.SetError(txbLCB, "Chỉ chứa số không chứa kí tự");
            }
            else
            {
                errorProvider.SetError(txbLCB, null);

            }
        }

        private void txbPhuCap_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbPhuCap.Text))
            {

                errorProvider.SetError(txbPhuCap, "khong duoc de trong");

            }
            else if (!IsNumeric(txbPhuCap.Text))
            {
                errorProvider.SetError(txbPhuCap, "Chỉ chứa số không chứa kí tự");
            }
            else
            {
                errorProvider.SetError(txbPhuCap, null);

            }
        }

        private void txbSDT_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbSDT.Text))
            {

                errorProvider.SetError(txbSDT, "khong duoc de trong");
           

            }
            else if (!IsNumeric(txbSDT.Text))
            {
                errorProvider.SetError(txbSDT, "Chỉ chứa số không chứa kí tự");
            }
            else if (txbSDT.Text.Length > 12)
            {
                errorProvider.SetError(txbSDT, "Số điện thoại dưới 12 số");
            }
            else
            {
                errorProvider.SetError(txbSDT, null);

            }
        }

        private void cbxDiaChi_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cbxDiaChi.Text))
            {

                errorProvider.SetError(cbxDiaChi, "khong duoc de trong");

            }
            else
            {
                errorProvider.SetError(cbxDiaChi, null);

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

           

            MessageBox.Show("" + mnv);

        }


        private void NhanVien_TextChanged(object sender, EventArgs e)
        {
            if (txbTen.Text.Length>0 && txbSDT.Text.Length>0 && txbSDT.Text.Length>0 && txbPhuCap.Text.Length>0 && cbxDiaChi.Text.Length>0
                && dtpkNgaySinh.Value<dtpkNgayVaoLam.Value
                )
            {
                btnThem.Enabled = true;
            }

        }

        

        private void dataGridViewdsnv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewdsnv.Rows.Count)
            {
                DataGridViewRow row = dataGridViewdsnv.Rows[e.RowIndex];

                txbTen.Text = Convert.ToString(row.Cells["Tennv"].Value);
                txbSDT.Text = Convert.ToString(row.Cells["Sdt"].Value);
                txbPhuCap.Text = Convert.ToString(row.Cells["FphuCap"].Value);
                txbLCB.Text = Convert.ToString(row.Cells["Lcb1"].Value);
                cbxDiaChi.Text = Convert.ToString(row.Cells["SDiaChi"].Value);
                   btnXoa.Enabled = true;
                btnSua.Enabled = true;

             

                mnv = Convert.ToInt32(dataGridViewdsnv.Rows[e.RowIndex].Cells["Manv"].Value.ToString());

               
            }
            else
            {
                MessageBox.Show("Invalid row index selected.");
            }
        }

        private void dataGridViewdsnv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            string tennv = txbTen.Text;
            int lcb = Convert.ToInt32(txbLCB.Text);
            string sdt = txbSDT.Text;
            string dc = cbxDiaChi.Text;
            DateTime ngayvaolam = dtpkNgayVaoLam.Value;
            DateTime ngaysinh = dtpkNgaySinh.Value;
            int pc = Convert.ToInt32(txbPhuCap.Text);
            NhanVienDAO.Instance.SuaNhanVien(mnv, tennv, dc, sdt, ngaysinh, ngayvaolam, lcb, pc);
            LoadDanhSachNhanVien();
            MessageBox.Show("Sua nhan vien thanh cong");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
         
            if (NhanVienDAO.Instance.XoaNhanVien(mnv))
            {
                MessageBox.Show("Xoa nhan vien thanh cong");
                LoadDanhSachNhanVien();
            }
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TimKiemNV();
        }

        void TimKiemNV()
        {
            List<NhanVienDTO> danhSachNhanVien = NhanVienDAO.Instance.TimNhanVien(txbTen.Text);
            dataGridViewdsnv.DataSource = danhSachNhanVien;
            if (dataGridViewdsnv.DataSource == "")
            {
                MessageBox.Show("Khong tim thay nhan vien co ten"+txbTen.Text+"");
            }
            
        }
    

    }
}

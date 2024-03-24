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
    public partial class MatHang : Form
    {
        public MatHang()
        {
            InitializeComponent();
        }

        private void dataGridViewdsMatHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MatHang_Load(object sender, EventArgs e)
        {
            dataGridViewdsMatHang.DataSource = MatHangDAO.Instance.dsMathang();

        }
    }
}

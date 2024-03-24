using BaiTapLonQuanLiBanHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BaiTapLonQuanLiBanHang.DAO
{
    public class TaiKhoanDAO
    {
        private static TaiKhoanDAO instance;

        public static TaiKhoanDAO Instance 
        { get
           { 
            if (instance == null)
                {
                    instance = new TaiKhoanDAO();
                }
            return instance;
            
            } 
           private set => instance = value; 
        }
        public bool Login (string tenTaiKhoan, string matKhau)
        {
           
            DataTable data = Dataprovider.Instance.excuteQuery("HienThiTaiKhoan @tenDangNhap , @matKhau  ", new object[] { tenTaiKhoan, matKhau });

            return data.Rows.Count > 0;
        }
        public bool HienThiTaiKhoan(string tenTk)
        {
            DataTable data = Dataprovider.Instance.excuteQuery("HienThiTenTaiKhoan @tenDangNhap ",  new object[] {tenTk});

            return data.Rows.Count > 0;
        }
        public void ThemTaiKhoan(string tk,string mk)
        {
            Dataprovider.Instance.excuteQuery("ThemTaiKhoan @tenDangNhap , @matKhau ", new object[] { tk, mk });

        }
    }
}

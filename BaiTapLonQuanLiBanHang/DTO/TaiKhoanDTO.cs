using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLonQuanLiBanHang.DTO
{
    public class TaiKhoanDTO
    {
        string tenDangNhap;
        string matKhau;

        public string TenDangNhap { get => tenDangNhap; set => tenDangNhap = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }

        public TaiKhoanDTO()
        {

        }
        public TaiKhoanDTO(string tendn , string mk)
        {
            tenDangNhap = mk;
            matKhau = mk;
        }
        public TaiKhoanDTO(DataRow row)
        {
            this.tenDangNhap = row["tenDangNhap"].ToString();
            this.matKhau = row["matKhau"].ToString();

        }
    }
}

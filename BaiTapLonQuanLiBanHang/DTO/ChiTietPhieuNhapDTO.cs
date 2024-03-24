using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLonQuanLiBanHang.DTO
{
    public class ChiTietPhieuNhapDTO
    {
        string tenlh, tenhang, tenncc;
        int sl;
        float gianhap;
        float tt;

        public string Tenlh { get => tenlh; set => tenlh = value; }
        public string Tenhang { get => tenhang; set => tenhang = value; }
        public string Tenncc { get => tenncc; set => tenncc = value; }
        public int Sl { get => sl; set => sl = value; }
        public float Gianhap { get => gianhap; set => gianhap = value; }
        public float Tt { get => tt; set => tt = value; }

       public ChiTietPhieuNhapDTO()
        {

        }
        public ChiTietPhieuNhapDTO(string tenlh, string tenhang,string tenncc,int sl, float gianhap, float tt)
        {
            this.tenlh = tenlh;
            this.tenhang= tenhang;
            this.tenncc = tenncc;
            this.sl= sl;
            this.gianhap = gianhap;
            this.tt= tt;
        }
        public ChiTietPhieuNhapDTO(DataRow row)
        {
            this.tenlh = row["stenLH"].ToString();
            this.tenhang = row["stenHang"].ToString();
            this.tenncc = row["stenNhaCC"].ToString();
            this.sl = Convert.ToInt32(row["sl_Nhap"]);
            this.gianhap = Convert.ToSingle("fgiaNhap");
            this.tt = Convert.ToSingle("total_price");

        }



    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLonQuanLiBanHang.DTO
{
    public class NhaCungCapDTO
    {
        private int mancc;
        private string ten, dc, dt;

        public string Ten { get => ten; set => ten = value; }
        public string Dc { get => dc; set => dc = value; }
        public string Dt { get => dt; set => dt = value; }
        public int Mancc { get => mancc; set => mancc = value; }

        public NhaCungCapDTO() { }

        public NhaCungCapDTO(int mancc,string ten,string dc , string dt)
        {
            this.mancc = mancc;
            this.ten = ten;
            this.dc=dc;
            this.dt = dt;  
        }
        public NhaCungCapDTO(DataRow row)
        {
            mancc = Convert.ToInt32(row["imaNCC"]);
            ten = (row["stenNhaCC"]).ToString();
            dc = row["sdiaChi"].ToString();
            dt = row["sdienThoai"].ToString();


        }
    }
}

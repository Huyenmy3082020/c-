using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLonQuanLiBanHang.DTO
{
    public class LoaiHangDTO
    {
        private string malh;
        private string tenLh;

        public string Malh { get => malh; set => malh = value; }
        public string TenLh { get => tenLh; set => tenLh = value; }
        
        public LoaiHangDTO()
        {

        }
        public LoaiHangDTO(string malh, string tenlh)
        {
            this.malh= malh;
            this.tenLh= tenlh;
        }
        public LoaiHangDTO(DataRow row)
        {
            this.malh = row["smaLH"].ToString();
            this.tenLh = row["stenLH"].ToString();

        }
    }
}

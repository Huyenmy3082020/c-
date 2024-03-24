using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLonQuanLiBanHang.DAO
{
    public class ChiTietHoaDonDAO
    {
        private static ChiTietHoaDonDAO instance;

        public static ChiTietHoaDonDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChiTietHoaDonDAO();
                }
                return instance;
            }
            private set => instance = value;
        }

     
        public void ThemChiTietHoaDon(int maHD,string tenmh, float giamgia, int sl,string tenLH)
        {
            Dataprovider.Instance.excuteQuery("ThemChiTietHoaDon @maHD , @tenMH , @giamgia , @sl   ", new object[] { maHD,tenmh, giamgia, sl });
        }
        public List<ChiTietHoaDonDTO> DanhSachHoaDon(string tenkh)
        {
            List<ChiTietHoaDonDTO> list = new List<ChiTietHoaDonDTO>();

            DataTable table = Dataprovider.Instance.excuteQuery(" DanhSachHoaDon1 @tenKH ", new object[] {tenkh});


            foreach (DataRow dr in table.Rows)
            {
                ChiTietHoaDonDTO hd = new ChiTietHoaDonDTO(dr);
                list.Add(hd);
            }
            return list;
        }
       public void ThanhToanHoaDon(string tenkh)
        {
            Dataprovider.Instance.excuteQuery("ThanhToanHoaDon @tenKh ", new object[] { tenkh });
        }
    }
}

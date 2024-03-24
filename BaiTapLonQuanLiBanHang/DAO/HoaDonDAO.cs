using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLonQuanLiBanHang.DAO
{
    public class HoaDonDAO
    {
        private static HoaDonDAO instance;

        public static HoaDonDAO Instance {
            get
            {
                if (instance == null)
                {
                    instance = new HoaDonDAO();
                }
                return instance;
            }
            private set => instance = value;
        }

        public List<HoaDonDTO> DanhSachHoaDon()
        {
            List<HoaDonDTO> list = new List<HoaDonDTO>();

            DataTable table = Dataprovider.Instance.excuteQuery("DanhSachHoaDon1");


            foreach (DataRow dr in table.Rows)
            {
                HoaDonDTO hd = new HoaDonDTO(dr);
                list.Add(hd);
            }
            return list;
        }



        public bool ThemHoaDon(string tenkh, string dc, bool gt , string tennv , string sdt , string tenmh,float giamgia, int sl)
        {
          
            Dataprovider.Instance.excuteQuery("ThemHoaDon @tenKhachHang , @diaChi , @gt , @tennv , @sdt , @tenMH , @giamgia , @sl   ", new object[] {tenkh,dc,gt, tennv,sdt, tenmh,giamgia,sl});
            return true;
        }
        public DataTable TinhTongTien(string mah)
        {
                  
           DataTable data =  Dataprovider.Instance.excuteQuery("tongtienHoaDon @mah ", new object[] { mah });

            return data;
          }

        public bool DanhSachkajsod(string tenkh, string sdt)
        {

            DataTable data = Dataprovider.Instance.excuteQuery("DonDatHangKhachHang @tenKH , @sdt  ", new object[] {tenkh,sdt});
            return data.Rows.Count > 0;


        }
        public int LayRaIDMax()
        {
            return (int)Dataprovider.Instance.ExcuteScalar("select max(isoHd) from tblDonDatHang");
        }
        public void XoaHoaDon(string tenkh, string sdt, string tmh , string tnv )
        {
            Dataprovider.Instance.excuteQuery("XoaHoaDon @tenKH ,  @sdt , @tenmh , @tennv", new object[] { tenkh, sdt, tmh, tnv });
        }
    }
}

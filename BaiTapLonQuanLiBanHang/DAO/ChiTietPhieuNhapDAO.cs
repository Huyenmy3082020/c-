using BaiTapLonQuanLiBanHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLonQuanLiBanHang.DAO
{
    public class ChiTietPhieuNhapDAO
    {


        private static ChiTietPhieuNhapDAO instance;

        public static ChiTietPhieuNhapDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChiTietPhieuNhapDAO();
                }
                return instance;
            }
            private set => instance = value;
        }
        public List<ChiTietPhieuNhapDTO> DanhSachPhieuNhap(string tenncc)
        {
            List<ChiTietPhieuNhapDTO> list = new List<ChiTietPhieuNhapDTO>();

            DataTable table = Dataprovider.Instance.excuteQuery("DanhSachChiTietPhieuNhap @tenncc ", new object[] { tenncc });


            foreach (DataRow dr in table.Rows)
            {
                ChiTietPhieuNhapDTO hd = new ChiTietPhieuNhapDTO(dr);
                list.Add(hd);
            }
            return list;
        }
    }

}
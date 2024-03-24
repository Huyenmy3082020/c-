using BaiTapLonQuanLiBanHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLonQuanLiBanHang.DAO
{
    internal class NhanVienDAO
    {
        private static NhanVienDAO instance;

        public static NhanVienDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NhanVienDAO();
                }

                return instance;
            }
            private set => instance = value;
        }
       
        public List<NhanVienDTO> DanhSachNhanVien()
        {
            List<NhanVienDTO> list = new List<NhanVienDTO>();
            string query = "select *from tblNhanVien";

            DataTable data = Dataprovider.Instance.excuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                NhanVienDTO d = new NhanVienDTO(item);
                list.Add(d);
            }
            return list;
        }
        public bool ThemNhanVien(string tennv, string dc , string sdt, DateTime ngaysinh, DateTime ngayvaolam, int lcb, int pc)
        {
            Dataprovider.Instance.excuteQuery("ThemNhanVien @tennv , @diachi , @sdt , @ngaysinh , @ngayvaolam , @lcb , @fphucap", new object[] { tennv, dc, sdt, ngaysinh, ngayvaolam, lcb, pc });
            return true;
        }
        public void SuaNhanVien(int mnv,string tennv, string dc, string sdt, DateTime ngaysinh, DateTime ngayvaolam, int lcb, int pc)
        {
            Dataprovider.Instance.excuteQuery("SuaNhanVien @manv , @tennv , @diachi , @sdt , @ngaysinh , @ngayvaolam , @lcb , @fphucap", new object[] {mnv,tennv, dc, sdt, ngaysinh, ngayvaolam, lcb, pc });

        }
        public bool XoaNhanVien(int mnv)
        {
           DataTable result = Dataprovider.Instance.excuteQuery("XoaNhanVien @manv ", new object[] { mnv });
            return result.Rows.Count > 0;

        }
        public List<NhanVienDTO> TimNhanVien(string tnv)
        {
            List<NhanVienDTO> list = new List<NhanVienDTO>();
            string query = string.Format("select * from tblNhanVien where stenNV like '%{0}%'", tnv);

            DataTable data = Dataprovider.Instance.excuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                NhanVienDTO sv = new NhanVienDTO(row);
                list.Add(sv);

            }
            return list;

        }
    }
}

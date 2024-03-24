using BaiTapLonQuanLiBanHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLonQuanLiBanHang.DAO
{
    public class NhaCungCapDAO
    {
        private static NhaCungCapDAO instance;

        public static NhaCungCapDAO Instance { 
            get 
            {
                if (instance == null)
                    instance = new NhaCungCapDAO();
                return instance;              
             }
            
                set => instance = value; }
        public List<NhaCungCapDTO> DanhSachNhaCungCap()
        {
            List<NhaCungCapDTO> list = new List<NhaCungCapDTO>();
            string query = "\r\nselect *from tblNhaCungCap ";

            DataTable data = Dataprovider.Instance.excuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                NhaCungCapDTO d = new NhaCungCapDTO(item);
                list.Add(d);
            }
            return list;
        }
        public void ThemNhaCungCap(int ncc,string tncc, string dc , string sdt)
        {
            Dataprovider.Instance.excuteQuery("ThemNhaCungCap   @mancc , @tenncc , @dc , @sdt ", new object[] {ncc,tncc, dc, sdt });
        }
        public void XoaNhaCungCap(int mncc)
        {
            Dataprovider.Instance.excuteQuery("XoaNhaCungCap @mancc", new object[] {mncc});

        }
        public void SuaNhaCungCap(int ncc,string tncc, string dc, string sdt)
        {
            Dataprovider.Instance.excuteQuery("SuaNhaCungCap    @mancc , @tenncc , @dc , @sdt ", new object[] { ncc,tncc, dc, sdt });

        }
        public bool KiemTraKhoaChinh(int mancc)
        {
            DataTable dt = Dataprovider.Instance.excuteQuery("KiemTraKhoaChinh @mancc", new object[] { mancc });
            return dt.Rows.Count > 0 ;

        }
    }
}


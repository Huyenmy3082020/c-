using BaiTapLonQuanLiBanHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLonQuanLiBanHang.DAO
{
    public class LoaihangDAO
    {
        private static LoaihangDAO instance;

        public static LoaihangDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LoaihangDAO();
                }

                return instance;
            }
            private set => instance = value;
        }

        public List<LoaiHangDTO> dsLoaiHang()
        {
            List<LoaiHangDTO> list = new List<LoaiHangDTO>();
        
            DataTable data = Dataprovider.Instance.excuteQuery("select * from tblLoaiHang");
            foreach (DataRow item in data.Rows)
            {
                LoaiHangDTO d = new LoaiHangDTO(item);
                list.Add(d);
            }
            return list;
        }
        public void ThemLoaiHang(string malh, string tenlh)
        {
            Dataprovider.Instance.excuteQuery("ThemLoaiHang @malh , @tenlh ",new object[] {malh,tenlh});
        }
        public void SuaLoaiHang (string malh, string tenlh)
        {
            Dataprovider.Instance.excuteQuery("SuaLoaiHang @malh , @tenlh ", new object[] {malh,tenlh});

        }
        public void XoaLoaiHang (string malh)
        {
            Dataprovider.Instance.excuteQuery("XoaLoaiHang @malh ", new object[] {malh});
        }
    }
}
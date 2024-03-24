using BaiTapLonQuanLiBanHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLonQuanLiBanHang.DAO
{
    internal class MatHangDAO
    {
        private static MatHangDAO instance;

        public static MatHangDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MatHangDAO();
                }

                return instance;
            }
            private set => instance = value;
        }

        public List<MatHangDTO> layraId(string id)
        {
            List<MatHangDTO> list = new List<MatHangDTO>();
            string query = "\r\nselect *from tblMatHang where sMaLH ='"+ id +"'";

            DataTable data = Dataprovider.Instance.excuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                MatHangDTO d = new MatHangDTO(item);
                list.Add(d);
            }
            return list;
        }
        public DataTable layraIDtheoten(string tenHang)
        {
            string query = "\r\nselect *from tblMatHang where stenHang ='" + tenHang + "'";

            DataTable data = Dataprovider.Instance.excuteQuery(query);

            return data;
        }
        public List<MatHangDTO> dsMathang()
        {
            List<MatHangDTO> list = new List<MatHangDTO>();
            string query = "\r\nselect *from tblMatHang ";

            DataTable data = Dataprovider.Instance.excuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                MatHangDTO d = new MatHangDTO(item);
                list.Add(d);
            }
            return list;
        }
    }
}

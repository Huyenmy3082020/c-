using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLonQuanLiBanHang.DAO
{
    public class DonDatHangDAO
    {
        private static DonDatHangDAO instance;

        public static DonDatHangDAO Instance {
            get
            {
                if (instance == null)
                {
                    instance = new DonDatHangDAO();
                }
                return instance;
            }
            
            private set => instance = value;
        }
        public int LayRaIDMax()
        {
            return (int)Dataprovider.Instance.ExcuteScalar("select max(isoHd) from tblDonDatHang");
        }
    }
}

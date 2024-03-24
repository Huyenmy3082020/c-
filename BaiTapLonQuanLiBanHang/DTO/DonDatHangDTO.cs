using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLonQuanLiBanHang.DTO
{
    public class DonDatHangDTO
    {
        private int soHd;
        private int  maNV;
        private int maKH;

        private DateTime ngayDatHang;
        private DateTime ngayGiaoHang;
        private string diaChiGiaohang;

        public int SoHd { get => soHd; set => soHd = value; }
        public int MaNV { get => maNV; set => maNV = value; }
        public int MaKH { get => maKH; set => maKH = value; }
        public DateTime NgayDatHang { get => ngayDatHang; set => ngayDatHang = value; }
        public DateTime NgayGiaoHang { get => ngayGiaoHang; set => ngayGiaoHang = value; }
        public string DiaChiGiaohang { get => diaChiGiaohang; set => diaChiGiaohang = value; }

        public DonDatHangDTO() { }
        public DonDatHangDTO(int sohd, int manv, int makh, DateTime ngayDathang, DateTime ngaygiaohang,string diaChiGiaoHang)
        {
            soHd = sohd;
            maNV = manv;
            maKH = makh;
            ngayDatHang = ngayDathang;
            ngayGiaoHang = ngaygiaohang;
            diaChiGiaoHang = diaChiGiaoHang;

        }
        public DonDatHangDTO(DataRow row)
        {
            if (row == null)
                throw new ArgumentNullException(nameof(row), "DataRow cannot be null.");

            // Sử dụng các biến tên cột được đặt tên có ý nghĩa hoặc hằng số
            const string SoHdColumn = "isoHd";
            const string MaNVColumn = "imaNV";
            const string MaKHColumn = "imaKH";
            const string NgayDatHangColumn = "dngayDatHang";
            const string NgayGiaoHangColumn = "dngayGiaoHang";
            const string DiaChiGiaoHangColumn = "sdiaChiGiaoHang";

            // Kiểm tra xem các cột có tồn tại trong dòng không trước khi truy cập
            if (row.Table.Columns.Contains(SoHdColumn))
                SoHd = Convert.ToInt32(row[SoHdColumn]);

            if (row.Table.Columns.Contains(MaNVColumn))
                MaNV = Convert.ToInt32(row[MaNVColumn]);

            if (row.Table.Columns.Contains(MaKHColumn))
                MaKH = Convert.ToInt32(row[MaKHColumn]);

            if (row.Table.Columns.Contains(NgayDatHangColumn))
                NgayDatHang = Convert.ToDateTime(row[NgayDatHangColumn]);

            if (row.Table.Columns.Contains(NgayGiaoHangColumn))
                NgayGiaoHang = Convert.ToDateTime(row[NgayGiaoHangColumn]);

            if (row.Table.Columns.Contains(DiaChiGiaoHangColumn))
                DiaChiGiaohang = row[DiaChiGiaoHangColumn].ToString();
        }


    }
}

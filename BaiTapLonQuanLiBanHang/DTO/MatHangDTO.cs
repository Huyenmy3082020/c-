using System.Data;
using System.Text.RegularExpressions;
using System;

namespace BaiTapLonQuanLiBanHang.DTO
{
    public class MatHangDTO
    {
        private string maHang;
        private string tenHang;
        private int maNhaCungCap;
        private string maLoaiHang;
        private int soLuong;
        private float giaHang;
        private string donViTinh;

        // Getter và Setter cho thuộc tính mã hàng
        public string MaHang
        {
            get { return maHang; }
            set { maHang = value; }
        }

        // Getter và Setter cho thuộc tính tên hàng
        public string TenHang
        {
            get { return tenHang; }
            set { tenHang = value; }
        }

        // Getter và Setter cho thuộc tính mã nhà cung cấp
        public int MaNhaCungCap
        {
            get { return maNhaCungCap; }
            set { maNhaCungCap = value; }
        }

        // Getter và Setter cho thuộc tính mã loại hàng
        public string MaLoaiHang
        {
            get { return maLoaiHang; }
            set { maLoaiHang = value; }
        }

        // Getter và Setter cho thuộc tính số lượng
        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }

        // Getter và Setter cho thuộc tính giá hàng
        public float GiaHang
        {
            get { return giaHang; }
            set { giaHang = value; }
        }

        // Getter và Setter cho thuộc tính đơn vị tính
        public string DonViTinh
        {
            get { return donViTinh; }
            set { donViTinh = value; }
        }

        // Constructor không tham số
        public MatHangDTO()
        {
            // Khởi tạo đối tượng MatHangDTO
        }

        // Constructor với tham số
        public MatHangDTO(string maHang, string tenHang, int maNhaCungCap, string maLoaiHang, int soLuong, float giaHang, string donViTinh)
        {
            this.maHang = maHang;
            this.tenHang = tenHang;
            this.maNhaCungCap = maNhaCungCap;
            this.maLoaiHang = maLoaiHang;
            this.soLuong = soLuong;
            this.giaHang = giaHang;
            this.donViTinh = donViTinh;
        }
        public MatHangDTO(DataRow row)
        {


            maHang = row["smaHang"].ToString();
            tenHang = row["stenHang"].ToString();
            maNhaCungCap = Convert.ToInt32(row["imaNCC"]);
            maLoaiHang = row["sMaLH"].ToString();
            soLuong = Convert.ToInt32(row["soLuong"]);
            giaHang = Convert.ToSingle(row["fgiaHang"]);
            donViTinh = row["sDVT"].ToString();

        }
    }
}

using System;
using System.Data;

namespace BaiTapLonQuanLiBanHang.DTO
{
    public class NhanVienDTO
    {
        private int manv;
        private string tennv;
        private string sDiaChi;
        private string sdt;
        private DateTime dngaySinh;
        private DateTime dngayVaoLam;
        private float Lcb;
        private float fphuCap;

        // Constructor không tham số
        public NhanVienDTO() { }

        // Constructor có tham số
        public NhanVienDTO(int manv, string tennv, string dc, string sdt, DateTime ngaySinh, DateTime ngayVaoLam, float lcb, float phucap)
        {
            this.manv = manv;
            this.tennv = tennv;
            this.sDiaChi = dc;
            this.sdt = sdt;
            this.dngaySinh = ngaySinh;
            this.dngayVaoLam = ngayVaoLam;
            this.Lcb = lcb;
            this.fphuCap = phucap;
        }

        // Constructor từ DataRow
        public NhanVienDTO(DataRow row)
        {
            this.manv = Convert.ToInt32(row["iMaNV"]);
            this.tennv = row["stenNV"].ToString();
            this.SDiaChi = row["sdiaChi"].ToString();
            this.sdt = row["sdienThoai"].ToString();
            this.dngaySinh = Convert.ToDateTime(row["dngaySinh"]);
            this.dngayVaoLam = Convert.ToDateTime(row["dngayVaoLam"]);
            this.Lcb = Convert.ToSingle(row["fluongCoBan"]);
            this.fphuCap = Convert.ToSingle(row["fphuCap"]);
        }

        // Getter và setter
        public int Manv { get => manv; set => manv = value; }
        public string Tennv { get => tennv; set => tennv = value; }
        public string SDiaChi { get => sDiaChi; set => sDiaChi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public DateTime DngaySinh { get => dngaySinh; set => dngaySinh = value; }
        public DateTime DngayVaoLam { get => dngayVaoLam; set => dngayVaoLam = value; }
        public float Lcb1 { get => Lcb; set => Lcb = value; }
        public float FphuCap { get => fphuCap; set => fphuCap = value; }
    }
}

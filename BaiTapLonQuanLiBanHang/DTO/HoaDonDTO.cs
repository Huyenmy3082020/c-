using System.Data;
using System;

public class HoaDonDTO
{
    private string tenKh;
    private bool gioiTinh;
    private string diaChi;
    private string soDienThoai;
    private string tenNhanVien;
    private string tenLoaihang;
    private string tenMathang;
    private float giamGia;
    private int soLuong;
    double tongTien;

    public string TenKh { get => tenKh; set => tenKh = value; }
    public bool GioiTinh { get => gioiTinh; set => gioiTinh = value; }
    public string DiaChi { get => diaChi; set => diaChi = value; }
    public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
    public string TenNhanVien { get => tenNhanVien; set => tenNhanVien = value; }
    public string TenLoaihang { get => tenLoaihang; set => tenLoaihang = value; }
    public string TenMathang { get => tenMathang; set => tenMathang = value; }
    public float GiamGia { get => giamGia; set => giamGia = value; }
    public int SoLuong { get => soLuong; set => soLuong = value; }
    public double TongTien { get => tongTien; set => tongTien = value; }

    // Constructor
    public HoaDonDTO(string tenkh, bool gioitinh, string sdt, string tnv,double tt,string tlh, string tmh,float gg, int sl )
    {
        this.TenKh = tenkh;
        this.GioiTinh = gioitinh;
        this.SoDienThoai = sdt;
        this.TenNhanVien = tnv;
        this.TenLoaihang = tlh;
        this.TenMathang = tmh;
     
        this.GiamGia = gg;
        this.SoLuong = sl;
        this.tongTien = tt;
    }
    public HoaDonDTO(DataRow row)
    {
        if (row != null)
        {
            this.TenKh = row["stenKH"].ToString();

            this.GioiTinh = Convert.ToBoolean(row["bgioiTinh"]);

            this.DiaChi = row["sdiaChi"].ToString();
            this.SoDienThoai = row["sdienThoai"].ToString();
            this.TenNhanVien = row["stenNV"].ToString();
            this.TenLoaihang = row["stenLH"].ToString();
            this.TenMathang = row["stenHang"].ToString();
            this.GiamGia = Convert.ToSingle(row["fmucGiamGia"]);
            this.SoLuong = Convert.ToInt32(row["sl"]);
            this.tongTien = Convert.ToSingle(row["total_price"]);
        }
  
    }

}

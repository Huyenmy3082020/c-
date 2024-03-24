using System.Data;
using System;
using System.Data.SqlTypes;

public class ChiTietHoaDonDTO
{

      private string tenLoaiHang;
      private string tenMathang;
      private float gianhap;
      private int soLuong;
    DateTime ngaynhaphang;
       double tt;

    public string TenMathang { get => tenMathang; set => tenMathang = value; }
    public float Gianhap { get => gianhap; set => gianhap = value; }
    public int SoLuong { get => soLuong; set => soLuong = value; }
    public string TenLoaiHang { get => tenLoaiHang; set => tenLoaiHang = value; }
    public double Tt { get => tt; set => tt = value; }
    public DateTime NgayNhapHang { get => ngaynhaphang; set => ngaynhaphang = value; }

    public ChiTietHoaDonDTO(string tenLH,string tenMH,float giamGia, int sl, DateTime ngaynhaphang,double tt )
    {
        this.TenLoaiHang= tenLH;
        this.tenMathang = tenMH;
        this.gianhap = giamGia;
        this.soLuong = sl;
        this.ngaynhaphang  = ngaynhaphang;
        this.tt = tt;

    }
    public ChiTietHoaDonDTO(DataRow row)
    {
        if (row != null)
        {
            
            this.TenMathang = row["stenHang"].ToString();
            this.tenLoaiHang = row["stenLH"].ToString();
            this.SoLuong = Convert.ToInt32(row["sl"]);
            this.gianhap = Convert.ToSingle(row["fgiaNhap"]);
          

            this.tt = Convert.ToSingle(row["total_price"]);
        }

    }

}

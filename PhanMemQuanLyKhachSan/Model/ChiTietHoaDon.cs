namespace PhanMemQuanLyKhachSan.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("ChiTietHoaDon")]
    public partial class ChiTietHoaDon
    {
        public int ChiTietHoaDonID { get; set; }

        public int? HoaDonID { get; set; }

        public int? DichVuID { get; set; }

        public int? GiaDV { get; set; }

        public int? SoLuong { get; set; }

        public int? ThanhTien { get; set; }

        public virtual DichVu DichVu { get; set; }

        public virtual DichVu DichVu1 { get; set; }

        public virtual DichVu DichVu2 { get; set; }

        public virtual HoaDon HoaDon { get; set; }

        public virtual HoaDon HoaDon1 { get; set; }

        public virtual HoaDon HoaDon2 { get; set; }
    }
    public partial class ChiTietHoaDon
    {
        public static List<ChiTietHoaDon> GetAll()
        {
            Model1 context = new Model1();
            return context.ChiTietHoaDons.ToList();
        }
        public static ChiTietHoaDon GetChiTietHoaDon(int cthdId)
        {
            Model1 context = new Model1();
            return context.ChiTietHoaDons.Where(p => p.ChiTietHoaDonID == cthdId).FirstOrDefault();

        }
        public void InsertUpdate()
        {
            Model1 context = new Model1();
            context.ChiTietHoaDons.AddOrUpdate(this);
            context.SaveChanges();
        }


    }
}

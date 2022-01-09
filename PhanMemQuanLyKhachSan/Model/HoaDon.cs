namespace PhanMemQuanLyKhachSan.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("HoaDon")]
    public partial class HoaDon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HoaDon()
        {
            ChiTietHoaDons = new HashSet<ChiTietHoaDon>();
            ChiTietHoaDons1 = new HashSet<ChiTietHoaDon>();
            ChiTietHoaDons2 = new HashSet<ChiTietHoaDon>();
        }

        public int HoaDonID { get; set; }

        public int? NhanVienID { get; set; }

        public int? KhachHangID { get; set; }

        public int? PhongID { get; set; }

        [StringLength(15)]
        public string TenLoai { get; set; }

        public int? SoDem { get; set; }

        public int? SoKhach { get; set; }

        [StringLength(15)]
        public string NgayHD { get; set; }

        public int? TongTien { get; set; }

        public int? BookingID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons2 { get; set; }

        public virtual KhachHang KhachHang { get; set; }

        public virtual KhachHang KhachHang1 { get; set; }

        public virtual KhachHang KhachHang2 { get; set; }

        public virtual NhanVien NhanVien { get; set; }

        public virtual NhanVien NhanVien1 { get; set; }

        public virtual NhanVien NhanVien2 { get; set; }

        public virtual Phong Phong { get; set; }

        public virtual Phong Phong1 { get; set; }

        public virtual Phong Phong2 { get; set; }
    }
    public partial class HoaDon
    {
        public static List<HoaDon> GetAll()
        {
            Model1 context = new Model1();
            return context.HoaDons.ToList();
        }
        public static HoaDon GetHoaDon(int hoaDonId)
        {
            Model1 context = new Model1();
            return context.HoaDons.Where(p => p.HoaDonID == hoaDonId).FirstOrDefault();
        }
        public static HoaDon GetHoaDonByPhong(int? phongId)
        {
            Model1 context = new Model1();
            return context.HoaDons.LastOrDefault(p => p.PhongID == phongId);

        }

        public int InsertUpdate()
        {
            Model1 context = new Model1();
            context.HoaDons.AddOrUpdate(this);
            return context.SaveChanges();
        }
    }
}

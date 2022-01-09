namespace PhanMemQuanLyKhachSan.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("Phong")]
    public partial class Phong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Phong()
        {
            HoaDons = new HashSet<HoaDon>();
            HoaDons1 = new HashSet<HoaDon>();
            HoaDons2 = new HashSet<HoaDon>();
        }

        public int PhongID { get; set; }

        public int? LoaiPhongID { get; set; }

        public int? GiaPhong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDon> HoaDons { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDon> HoaDons1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDon> HoaDons2 { get; set; }

        public virtual LoaiPhong LoaiPhong { get; set; }

        public virtual LoaiPhong LoaiPhong1 { get; set; }

        public virtual LoaiPhong LoaiPhong2 { get; set; }
    }
    public partial class Phong
    {
        public static List<Phong> GetAll()
        {
            Model1 context = new Model1();
            return context.Phongs.ToList();
        }
        public static List<Phong> GetAll(int loaiPhong)
        {
            Model1 context = new Model1();
            return context.Phongs.Where(p => p.LoaiPhongID == loaiPhong).ToList();
        }
        public static Phong GetPhong(int vatTuId)
        {
            Model1 context = new Model1();
            return context.Phongs.Where(p => p.PhongID == vatTuId).FirstOrDefault();

        }

    }
}

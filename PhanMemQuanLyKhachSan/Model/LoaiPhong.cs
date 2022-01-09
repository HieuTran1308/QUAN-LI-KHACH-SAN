namespace PhanMemQuanLyKhachSan.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("LoaiPhong")]
    public partial class LoaiPhong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LoaiPhong()
        {
            Phongs = new HashSet<Phong>();
            Phongs1 = new HashSet<Phong>();
            Phongs2 = new HashSet<Phong>();
        }

        public int LoaiPhongID { get; set; }

        [StringLength(15)]
        public string TenLoai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Phong> Phongs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Phong> Phongs1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Phong> Phongs2 { get; set; }
    }
    public partial class LoaiPhong
    {
        public static List<LoaiPhong> GetAll()
        {
            Model1 context = new Model1();
            return context.LoaiPhongs.ToList();
        }
        public static LoaiPhong GetLoaiPhong(int idLoaiPhong)
        {
            Model1 context = new Model1();
            return context.LoaiPhongs.Where(p => p.LoaiPhongID == idLoaiPhong).FirstOrDefault();
        }
    }
}


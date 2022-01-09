namespace PhanMemQuanLyKhachSan.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("NhanVien")]
    public partial class NhanVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhanVien()
        {
            HoaDons = new HashSet<HoaDon>();
            HoaDons1 = new HashSet<HoaDon>();
            HoaDons2 = new HashSet<HoaDon>();
            LichLamViecs = new HashSet<LichLamViec>();
            LichLamViecs1 = new HashSet<LichLamViec>();
            LichLamViecs2 = new HashSet<LichLamViec>();
        }

        public int NhanVienID { get; set; }

        [StringLength(50)]
        public string TenNV { get; set; }

        [StringLength(200)]
        public string PathImage { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDon> HoaDons { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDon> HoaDons1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDon> HoaDons2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LichLamViec> LichLamViecs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LichLamViec> LichLamViecs1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LichLamViec> LichLamViecs2 { get; set; }
    }
    public partial class NhanVien
    {
        public static List<NhanVien> GetAll()
        {
            Model1 context = new Model1();
            return context.NhanViens.ToList();
        }
        public static NhanVien GetNhanVien(int idNhanVien)
        {
            Model1 context = new Model1();
            return context.NhanViens.Where(p => p.NhanVienID == idNhanVien).FirstOrDefault();

        }
        public void InsertUpdate()
        {
            Model1 context = new Model1();
            context.NhanViens.AddOrUpdate(this);
            context.SaveChanges();
        }

        public static void Delete(int id)
        {
            Model1 context = new Model1();
            NhanVien db = context.NhanViens.Where(p => p.NhanVienID == id).FirstOrDefault();
            if (db != null)
            {
                //  context.Students.Attach(db);
                context.NhanViens.Remove(db);
                context.SaveChanges();
            }
            else
                throw new Exception("Khong ton tai trong csdl");
        }
    }
}

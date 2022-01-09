using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace PhanMemQuanLyKhachSan.Model
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Booking> Bookings { get; set; }
        public virtual DbSet<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        public virtual DbSet<DichVu> DichVus { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<LichLamViec> LichLamViecs { get; set; }
        public virtual DbSet<LoaiPhong> LoaiPhongs { get; set; }
        public virtual DbSet<MatKhau> MatKhaus { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<Phong> Phongs { get; set; }
        public virtual DbSet<VatTu> VatTus { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DichVu>()
                .HasMany(e => e.ChiTietHoaDons)
                .WithOptional(e => e.DichVu)
                .HasForeignKey(e => e.DichVuID);

            modelBuilder.Entity<DichVu>()
                .HasMany(e => e.ChiTietHoaDons1)
                .WithOptional(e => e.DichVu1)
                .HasForeignKey(e => e.DichVuID);

            modelBuilder.Entity<DichVu>()
                .HasMany(e => e.ChiTietHoaDons2)
                .WithOptional(e => e.DichVu2)
                .HasForeignKey(e => e.DichVuID);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.TenLoai)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.NgayHD)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .HasMany(e => e.ChiTietHoaDons)
                .WithOptional(e => e.HoaDon)
                .HasForeignKey(e => e.HoaDonID);

            modelBuilder.Entity<HoaDon>()
                .HasMany(e => e.ChiTietHoaDons1)
                .WithOptional(e => e.HoaDon1)
                .HasForeignKey(e => e.HoaDonID);

            modelBuilder.Entity<HoaDon>()
                .HasMany(e => e.ChiTietHoaDons2)
                .WithOptional(e => e.HoaDon2)
                .HasForeignKey(e => e.HoaDonID);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.QuocTich)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .HasMany(e => e.HoaDons)
                .WithOptional(e => e.KhachHang)
                .HasForeignKey(e => e.KhachHangID);

            modelBuilder.Entity<KhachHang>()
                .HasMany(e => e.HoaDons1)
                .WithOptional(e => e.KhachHang1)
                .HasForeignKey(e => e.KhachHangID);

            modelBuilder.Entity<KhachHang>()
                .HasMany(e => e.HoaDons2)
                .WithOptional(e => e.KhachHang2)
                .HasForeignKey(e => e.KhachHangID);

            modelBuilder.Entity<LichLamViec>()
                .Property(e => e.Ngay)
                .IsUnicode(false);

            modelBuilder.Entity<LoaiPhong>()
                .Property(e => e.TenLoai)
                .IsUnicode(false);

            modelBuilder.Entity<LoaiPhong>()
                .HasMany(e => e.Phongs)
                .WithOptional(e => e.LoaiPhong)
                .HasForeignKey(e => e.LoaiPhongID);

            modelBuilder.Entity<LoaiPhong>()
                .HasMany(e => e.Phongs1)
                .WithOptional(e => e.LoaiPhong1)
                .HasForeignKey(e => e.LoaiPhongID);

            modelBuilder.Entity<LoaiPhong>()
                .HasMany(e => e.Phongs2)
                .WithOptional(e => e.LoaiPhong2)
                .HasForeignKey(e => e.LoaiPhongID);

            modelBuilder.Entity<MatKhau>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<MatKhau>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.HoaDons)
                .WithOptional(e => e.NhanVien)
                .HasForeignKey(e => e.NhanVienID);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.HoaDons1)
                .WithOptional(e => e.NhanVien1)
                .HasForeignKey(e => e.NhanVienID);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.HoaDons2)
                .WithOptional(e => e.NhanVien2)
                .HasForeignKey(e => e.NhanVienID);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.LichLamViecs)
                .WithOptional(e => e.NhanVien)
                .HasForeignKey(e => e.NhanVienID);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.LichLamViecs1)
                .WithOptional(e => e.NhanVien1)
                .HasForeignKey(e => e.NhanVienID);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.LichLamViecs2)
                .WithOptional(e => e.NhanVien2)
                .HasForeignKey(e => e.NhanVienID);

            modelBuilder.Entity<Phong>()
                .HasMany(e => e.HoaDons)
                .WithOptional(e => e.Phong)
                .HasForeignKey(e => e.PhongID);

            modelBuilder.Entity<Phong>()
                .HasMany(e => e.HoaDons1)
                .WithOptional(e => e.Phong1)
                .HasForeignKey(e => e.PhongID);

            modelBuilder.Entity<Phong>()
                .HasMany(e => e.HoaDons2)
                .WithOptional(e => e.Phong2)
                .HasForeignKey(e => e.PhongID);
        }
    }
}

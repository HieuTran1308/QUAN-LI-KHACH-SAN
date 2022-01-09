namespace PhanMemQuanLyKhachSan.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("VatTu")]
    public partial class VatTu
    {
        public int VatTuID { get; set; }

        [StringLength(50)]
        public string TenVT { get; set; }
    }
    public partial class VatTu
    {
        public static List<VatTu> GetAll()
        {
            Model1 context = new Model1();
            return context.VatTus.ToList();
        }
        public static VatTu GetVatTu(int vatTuId)
        {
            Model1 context = new Model1();
            return context.VatTus.Where(p => p.VatTuID == vatTuId).FirstOrDefault();

        }
        public void InsertUpdate()
        {
            Model1 context = new Model1();
            context.VatTus.AddOrUpdate(this);
            context.SaveChanges();
        }

        public static void Delete(int id)
        {
            Model1 context = new Model1();
            VatTu db = context.VatTus.Where(p => p.VatTuID == id).FirstOrDefault();
            if (db != null)
            {
                //  context.Students.Attach(db);
                context.VatTus.Remove(db);
                context.SaveChanges();
            }
            else
                throw new Exception("Khong ton tai trong csdl");
        }
    }
}

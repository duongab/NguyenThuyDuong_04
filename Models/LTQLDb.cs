using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace NguyenThuyDuong_1721050422_LTQL.Models
{
    public partial class LTQLDb : DbContext
    {
        public LTQLDb()
            : base("name=LTQLDb")
        {
        }

        public virtual DbSet<TinhThanh>  TinhThanhs { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            

            modelBuilder.Entity<TinhThanh>()
                 .Property(e => e.TenTinhThanh)
                   .HasMaxLength(100);

            modelBuilder.Entity<NhanVien>()
                 .Property(e => e.TenNhanVien)
                   .HasMaxLength(100);
        }
    }
}

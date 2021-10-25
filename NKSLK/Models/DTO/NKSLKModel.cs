using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace NKSLK.Models.DTO
{
    public partial class NKSLKModel : DbContext
    {
        public NKSLKModel()
            : base("name=NKSLKModel")
        {
        }

        public virtual DbSet<CongNhan> CongNhans { get; set; }
        public virtual DbSet<CongViec> CongViecs { get; set; }
        public virtual DbSet<DanhMucCongNhan> DanhMucCongNhans { get; set; }
        public virtual DbSet<DanhMucCongViec> DanhMucCongViecs { get; set; }
        public virtual DbSet<NhatKySLK> NhatKySLKs { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<ToNhanCong> ToNhanCongs { get; set; }
        public virtual DbSet<v_Luong> v_Luong { get; set; }
        public virtual DbSet<v_LuongCongNhan> v_LuongCongNhan { get; set; }
        public virtual DbSet<v_MaxCV> v_MaxCV { get; set; }
        public virtual DbSet<v_ThoiGianCaNhan> v_ThoiGianCaNhan { get; set; }
        public virtual DbSet<v_ThoiGianNhom> v_ThoiGianNhom { get; set; }
        public virtual DbSet<v_TongToanBo> v_TongToanBo { get; set; }
        public virtual DbSet<v_TyLe> v_TyLe { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CongNhan>()
                .Property(e => e.LuongHD)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CongNhan>()
                .Property(e => e.LuongBaoHiem)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CongNhan>()
                .HasMany(e => e.DanhMucCongNhans)
                .WithRequired(e => e.CongNhan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CongViec>()
                .Property(e => e.DinhMucKhoan)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CongViec>()
                .Property(e => e.DinhMucLD)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CongViec>()
                .HasMany(e => e.DanhMucCongViecs)
                .WithRequired(e => e.CongViec)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ToNhanCong>()
                .HasMany(e => e.DanhMucCongNhans)
                .WithRequired(e => e.ToNhanCong)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ToNhanCong>()
                .HasMany(e => e.DanhMucCongViecs)
                .WithRequired(e => e.ToNhanCong)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<v_MaxCV>()
                .Property(e => e.DinhMucKhoan)
                .HasPrecision(18, 0);

            modelBuilder.Entity<v_MaxCV>()
                .Property(e => e.DinhMucLD)
                .HasPrecision(18, 0);

            modelBuilder.Entity<v_TongToanBo>()
                .Property(e => e.TongToanBo)
                .HasPrecision(38, 6);
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using _1.DAL.DomainClass;

#nullable disable

namespace _1.DAL.Context
{
    public partial class FpolyDBContext : DbContext
    {
        public FpolyDBContext()
        {
        }

        public FpolyDBContext(DbContextOptions<FpolyDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ChatLieu> ChatLieus { get; set; }
        public virtual DbSet<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        public virtual DbSet<ChiTietKhuyenMai> ChiTietKhuyenMais { get; set; }
        public virtual DbSet<ChiTietPttt> ChiTietPttts { get; set; }
        public virtual DbSet<ChiTietSp> ChiTietSps { get; set; }
        public virtual DbSet<ChucVu> ChucVus { get; set; }
        public virtual DbSet<GiaoCa> GiaoCas { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<KhuyenMai> KhuyenMais { get; set; }
        public virtual DbSet<KichThuoc> KichThuocs { get; set; }
        public virtual DbSet<LichSuTichDiem> LichSuTichDiems { get; set; }
        public virtual DbSet<LoaiSp> LoaiSps { get; set; }
        public virtual DbSet<MauSac> MauSacs { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<Nsx> Nsxes { get; set; }
        public virtual DbSet<PhuongThucThanhToan> PhuongThucThanhToans { get; set; }
        public virtual DbSet<QuyDoiDiem> QuyDoiDiems { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=oh\\sqlexpress;Initial Catalog=FINALASS_BanQuanAo_Nhom666_FA22_PRO131;Persist Security Info=True;User ID=sa;Password=111111");
            }
        }//FINALASS_BanQuanAo_Nhom666_FA22_PRO131

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<ChatLieu>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Ma).IsUnicode(false);

                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ChiTietHoaDon>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DonGia).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoLuong).HasDefaultValueSql("((0))");

                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdCtspNavigation)
                    .WithMany(p => p.ChiTietHoaDons)
                    .HasForeignKey(d => d.IdCtsp)
                    .HasConstraintName("FK__ChiTietHo__IdCTS__151B244E");

                entity.HasOne(d => d.IdHdNavigation)
                    .WithMany(p => p.ChiTietHoaDons)
                    .HasForeignKey(d => d.IdHd)
                    .HasConstraintName("FK__ChiTietHoa__IdHD__14270015");
            });

            modelBuilder.Entity<ChiTietKhuyenMai>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdCtspNavigation)
                    .WithMany(p => p.ChiTietKhuyenMais)
                    .HasForeignKey(d => d.IdCtsp)
                    .HasConstraintName("FK__ChiTietKh__IdCTS__1BC821DD");

                entity.HasOne(d => d.IdKmNavigation)
                    .WithMany(p => p.ChiTietKhuyenMais)
                    .HasForeignKey(d => d.IdKm)
                    .HasConstraintName("FK__ChiTietKhu__IdKM__1CBC4616");
            });

            modelBuilder.Entity<ChiTietPttt>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Ma).IsUnicode(false);

                entity.Property(e => e.TienKhachDua).HasDefaultValueSql("((0))");

                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdHdNavigation)
                    .WithMany(p => p.ChiTietPttts)
                    .HasForeignKey(d => d.IdHd)
                    .HasConstraintName("FK__ChiTietPTT__IdHD__123EB7A3");

                entity.HasOne(d => d.IdPtttNavigation)
                    .WithMany(p => p.ChiTietPttts)
                    .HasForeignKey(d => d.IdPttt)
                    .HasConstraintName("FK__ChiTietPT__IdPTT__1332DBDC");
            });

            modelBuilder.Entity<ChiTietSp>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.GiaBan).HasDefaultValueSql("((0))");

                entity.Property(e => e.GiaNhap).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ma).IsUnicode(false);

                entity.Property(e => e.MoTa).HasDefaultValueSql("('')");

                entity.Property(e => e.SoLuongTon).HasDefaultValueSql("((0))");

                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdClieuNavigation)
                    .WithMany(p => p.ChiTietSps)
                    .HasForeignKey(d => d.IdClieu)
                    .HasConstraintName("FK__ChiTietSP__IdCLi__1AD3FDA4");

                entity.HasOne(d => d.IdKtNavigation)
                    .WithMany(p => p.ChiTietSps)
                    .HasForeignKey(d => d.IdKt)
                    .HasConstraintName("FK__ChiTietSP__IdKT__19DFD96B");

                entity.HasOne(d => d.IdLoaiSpNavigation)
                    .WithMany(p => p.ChiTietSps)
                    .HasForeignKey(d => d.IdLoaiSp)
                    .HasConstraintName("FK__ChiTietSP__IdLoa__18EBB532");

                entity.HasOne(d => d.IdMauSacNavigation)
                    .WithMany(p => p.ChiTietSps)
                    .HasForeignKey(d => d.IdMauSac)
                    .HasConstraintName("FK__ChiTietSP__IdMau__17F790F9");

                entity.HasOne(d => d.IdNsxNavigation)
                    .WithMany(p => p.ChiTietSps)
                    .HasForeignKey(d => d.IdNsx)
                    .HasConstraintName("FK__ChiTietSP__IdNsx__17036CC0");

                entity.HasOne(d => d.IdSpNavigation)
                    .WithMany(p => p.ChiTietSps)
                    .HasForeignKey(d => d.IdSp)
                    .HasConstraintName("FK__ChiTietSP__IdSP__160F4887");
            });

            modelBuilder.Entity<ChucVu>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Ma).IsUnicode(false);

                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<GiaoCa>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.GhiChu).IsUnicode(false);

                entity.HasOne(d => d.IdNguoiGiaoCaNavigation)
                    .WithMany(p => p.GiaoCaIdNguoiGiaoCaNavigations)
                    .HasForeignKey(d => d.IdNguoiGiaoCa)
                    .HasConstraintName("FK_NguoiGC");

                entity.HasOne(d => d.IdNguoiNhanCaNavigation)
                    .WithMany(p => p.GiaoCaIdNguoiNhanCaNavigations)
                    .HasForeignKey(d => d.IdNguoiNhanCa)
                    .HasConstraintName("FK_NguoiNC");
            });

            modelBuilder.Entity<HoaDon>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Ma).IsUnicode(false);

                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdKhNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.IdKh)
                    .HasConstraintName("FK_KhachHang");

                entity.HasOne(d => d.IdNvNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.IdNv)
                    .HasConstraintName("FK__HoaDon__IdNV__0E6E26BF");
            });

            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Ma).IsUnicode(false);

                entity.Property(e => e.Sdt).IsUnicode(false);

                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<KhuyenMai>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<KichThuoc>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Ma).IsUnicode(false);

                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<LichSuTichDiem>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdHdNavigation)
                    .WithMany(p => p.LichSuTichDiems)
                    .HasForeignKey(d => d.IdHd)
                    .HasConstraintName("FK__LichSuTich__IdHD__0F624AF8");

                entity.HasOne(d => d.IdKhNavigation)
                    .WithMany(p => p.LichSuTichDiems)
                    .HasForeignKey(d => d.IdKh)
                    .HasConstraintName("FK__LichSuTich__IdKH__10566F31");

                entity.HasOne(d => d.IdQuyDoiDiemNavigation)
                    .WithMany(p => p.LichSuTichDiems)
                    .HasForeignKey(d => d.IdQuyDoiDiem)
                    .HasConstraintName("FK__LichSuTic__IdQuy__114A936A");
            });

            modelBuilder.Entity<LoaiSp>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Ma).IsUnicode(false);

                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<MauSac>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Ma).IsUnicode(false);

                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<NhanVien>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Ma).IsUnicode(false);

                entity.Property(e => e.MatKhau).IsUnicode(false);

                entity.Property(e => e.Sdt).IsUnicode(false);

                entity.Property(e => e.TrangThai).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.IdCvNavigation)
                    .WithMany(p => p.NhanViens)
                    .HasForeignKey(d => d.IdCv)
                    .HasConstraintName("FK__NhanVien__IdCV__0D7A0286");
            });

            modelBuilder.Entity<Nsx>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Ma).IsUnicode(false);

                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<PhuongThucThanhToan>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<QuyDoiDiem>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<SanPham>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Ma).IsUnicode(false);

                entity.Property(e => e.MoTa).HasDefaultValueSql("('')");

                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    [Table("ChiTietSP")]
    public partial class ChiTietSp
    {
        public ChiTietSp()
        {
            ChiTietHoaDons = new HashSet<ChiTietHoaDon>();
            ChiTietKhuyenMais = new HashSet<ChiTietKhuyenMai>();
        }

        [Key]
        public Guid Id { get; set; }
        [Column("IdSP")]
        public Guid? IdSp { get; set; }
        public Guid? IdNsx { get; set; }
        public Guid? IdMauSac { get; set; }
        [Column("IdLoaiSP")]
        public Guid? IdLoaiSp { get; set; }
        [Column("IdKT")]
        public Guid? IdKt { get; set; }
        [Column("IdCLieu")]
        public Guid? IdClieu { get; set; }
        [Required]
        [StringLength(50)]
        public string Anh { get; set; }
        [StringLength(50)]
        public string MoTa { get; set; }
        public int? SoLuongTon { get; set; }
        [Column(TypeName = "decimal(20, 0)")]
        public decimal? GiaNhap { get; set; }
        [Column(TypeName = "decimal(20, 0)")]
        public decimal? GiaBan { get; set; }
        public int? TrangThai { get; set; }

        [ForeignKey(nameof(IdClieu))]
        [InverseProperty(nameof(ChatLieu.ChiTietSps))]
        public virtual ChatLieu IdClieuNavigation { get; set; }
        [ForeignKey(nameof(IdKt))]
        [InverseProperty(nameof(KichThuoc.ChiTietSps))]
        public virtual KichThuoc IdKtNavigation { get; set; }
        [ForeignKey(nameof(IdLoaiSp))]
        [InverseProperty(nameof(LoaiSp.ChiTietSps))]
        public virtual LoaiSp IdLoaiSpNavigation { get; set; }
        [ForeignKey(nameof(IdMauSac))]
        [InverseProperty(nameof(MauSac.ChiTietSps))]
        public virtual MauSac IdMauSacNavigation { get; set; }
        [ForeignKey(nameof(IdNsx))]
        [InverseProperty(nameof(Nsx.ChiTietSps))]
        public virtual Nsx IdNsxNavigation { get; set; }
        [ForeignKey(nameof(IdSp))]
        [InverseProperty(nameof(SanPham.ChiTietSps))]
        public virtual SanPham IdSpNavigation { get; set; }
        [InverseProperty(nameof(ChiTietHoaDon.IdCtspNavigation))]
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        [InverseProperty(nameof(ChiTietKhuyenMai.IdCtspNavigation))]
        public virtual ICollection<ChiTietKhuyenMai> ChiTietKhuyenMais { get; set; }
    }
}

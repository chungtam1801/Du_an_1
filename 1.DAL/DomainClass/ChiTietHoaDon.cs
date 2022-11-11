using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    [Table("ChiTietHoaDon")]
    public partial class ChiTietHoaDon
    {
        [Key]
        public Guid Id { get; set; }
        [Column("IdCTSP")]
        public Guid? IdCtsp { get; set; }
        [Column("IdHD")]
        public Guid? IdHd { get; set; }
        [Column(TypeName = "decimal(20, 0)")]
        public decimal? DonGia { get; set; }
        public int? SoLuong { get; set; }
        public int? TrangThai { get; set; }

        [ForeignKey(nameof(IdCtsp))]
        [InverseProperty(nameof(ChiTietSp.ChiTietHoaDons))]
        public virtual ChiTietSp IdCtspNavigation { get; set; }
        [ForeignKey(nameof(IdHd))]
        [InverseProperty(nameof(HoaDon.ChiTietHoaDons))]
        public virtual HoaDon IdHdNavigation { get; set; }
    }
}

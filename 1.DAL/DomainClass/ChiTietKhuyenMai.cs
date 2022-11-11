using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    [Table("ChiTietKhuyenMai")]
    public partial class ChiTietKhuyenMai
    {
        [Key]
        public Guid Id { get; set; }
        [Column("IdCTSP")]
        public Guid? IdCtsp { get; set; }
        [Column("IdKM")]
        public Guid? IdKm { get; set; }
        public int? TrangThai { get; set; }

        [ForeignKey(nameof(IdCtsp))]
        [InverseProperty(nameof(ChiTietSp.ChiTietKhuyenMais))]
        public virtual ChiTietSp IdCtspNavigation { get; set; }
        [ForeignKey(nameof(IdKm))]
        [InverseProperty(nameof(KhuyenMai.ChiTietKhuyenMais))]
        public virtual KhuyenMai IdKmNavigation { get; set; }
    }
}

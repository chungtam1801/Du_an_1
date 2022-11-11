using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    [Table("ChiTietPTTT")]
    [Index(nameof(Ma), Name = "UQ__ChiTietP__3214CC9EA8405382", IsUnique = true)]
    public partial class ChiTietPttt
    {
        [Key]
        public Guid Id { get; set; }
        [Column("IdHD")]
        public Guid? IdHd { get; set; }
        [Column("IdPTTT")]
        public Guid? IdPttt { get; set; }
        [StringLength(20)]
        public string Ma { get; set; }
        [Column(TypeName = "decimal(20, 0)")]
        public decimal? TienKhachDua { get; set; }
        public int? TrangThai { get; set; }

        [ForeignKey(nameof(IdHd))]
        [InverseProperty(nameof(HoaDon.ChiTietPttts))]
        public virtual HoaDon IdHdNavigation { get; set; }
        [ForeignKey(nameof(IdPttt))]
        [InverseProperty(nameof(PhuongThucThanhToan.ChiTietPttts))]
        public virtual PhuongThucThanhToan IdPtttNavigation { get; set; }
    }
}

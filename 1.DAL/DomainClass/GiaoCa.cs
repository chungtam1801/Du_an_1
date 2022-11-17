using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    [Table("GiaoCa")]
    public partial class GiaoCa
    {
        [Key]
        [Column("ID")]
        public Guid Id { get; set; }
        public Guid? IdNguoiGiaoCa { get; set; }
        public Guid? IdNguoiNhanCa { get; set; }
        [Column(TypeName = "money")]
        public decimal? TienDuKien { get; set; }
        [Column(TypeName = "money")]
        public decimal? TienLay { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ThoiGianGiao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ThoiGianNhan { get; set; }
        public string GhiChu { get; set; }
        public int? TrangThai { get; set; }

        [ForeignKey(nameof(IdNguoiGiaoCa))]
        [InverseProperty(nameof(NhanVien.GiaoCaIdNguoiGiaoCaNavigations))]
        public virtual NhanVien IdNguoiGiaoCaNavigation { get; set; }
        [ForeignKey(nameof(IdNguoiNhanCa))]
        [InverseProperty(nameof(NhanVien.GiaoCaIdNguoiNhanCaNavigations))]
        public virtual NhanVien IdNguoiNhanCaNavigation { get; set; }
    }
}

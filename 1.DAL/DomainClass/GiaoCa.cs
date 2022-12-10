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
        public string GhiChu { get; set; }
        public int? TrangThai { get; set; }
        [Column(TypeName = "money")]
        public decimal? TienDauca { get; set; }
        [Column(TypeName = "money")]
        public decimal? TienCuoiCa { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ThoiGianVaoCa { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ThoiGianKetCa { get; set; }
        public int? SoHoaDon { get; set; }
        [Column(TypeName = "money")]
        public decimal? Tongtienhang { get; set; }
        [Column(TypeName = "money")]
        public decimal? Tienmat { get; set; }
        [Column(TypeName = "money")]
        public decimal? Nganhang { get; set; }
        [Column(TypeName = "money")]
        public decimal? TongTienMat { get; set; }
        [Column(TypeName = "money")]
        public decimal? TienSDDiem { get; set; }

        [ForeignKey(nameof(IdNguoiGiaoCa))]
        [InverseProperty(nameof(NhanVien.GiaoCaIdNguoiGiaoCaNavigations))]
        public virtual NhanVien IdNguoiGiaoCaNavigation { get; set; }
        [ForeignKey(nameof(IdNguoiNhanCa))]
        [InverseProperty(nameof(NhanVien.GiaoCaIdNguoiNhanCaNavigations))]
        public virtual NhanVien IdNguoiNhanCaNavigation { get; set; }
    }
}

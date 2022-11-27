using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    [Table("HoaDon")]
    [Index(nameof(Ma), Name = "UQ__HoaDon__3214CC9E6AF877D5", IsUnique = true)]
    public partial class HoaDon
    {
        public HoaDon()
        {
            ChiTietHoaDons = new HashSet<ChiTietHoaDon>();
            ChiTietPttts = new HashSet<ChiTietPttt>();
            LichSuTichDiems = new HashSet<LichSuTichDiem>();
        }

        [Key]
        public Guid Id { get; set; }
        [Column("IdNV")]
        public Guid? IdNv { get; set; }
        [StringLength(20)]
        public string Ma { get; set; }
        [Column(TypeName = "date")]
        public DateTime NgayTao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? NgayThanhToan { get; set; }
        public double? GiamGia { get; set; }
        public int? TrangThai { get; set; }
        [Column(TypeName = "money")]
        public decimal? TienShip { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? NgayShip { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? NgayNhan { get; set; }
        public string GhiChu { get; set; }
        [Column("IdKH")]
        [StringLength(20)]
        public string IdKh { get; set; }

        [ForeignKey(nameof(IdNv))]
        [InverseProperty(nameof(NhanVien.HoaDons))]
        public virtual NhanVien IdNvNavigation { get; set; }
        [InverseProperty(nameof(ChiTietHoaDon.IdHdNavigation))]
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        [InverseProperty(nameof(ChiTietPttt.IdHdNavigation))]
        public virtual ICollection<ChiTietPttt> ChiTietPttts { get; set; }
        [InverseProperty(nameof(LichSuTichDiem.IdHdNavigation))]
        public virtual ICollection<LichSuTichDiem> LichSuTichDiems { get; set; }
    }
}

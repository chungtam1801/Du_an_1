using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    [Table("KhachHang")]
    [Index(nameof(Ma), Name = "UQ__KhachHan__3214CC9EE8E94A2E", IsUnique = true)]
    public partial class KhachHang
    {
        public KhachHang()
        {
            LichSuTichDiems = new HashSet<LichSuTichDiem>();
        }

        [Key]
        public Guid Id { get; set; }
        [StringLength(20)]
        public string Ma { get; set; }
        [StringLength(30)]
        public string Ten { get; set; }
        [Required]
        [StringLength(30)]
        public string TenDem { get; set; }
        [Required]
        [StringLength(30)]
        public string Ho { get; set; }
        [Column(TypeName = "date")]
        public DateTime NgaySinh { get; set; }
        [Required]
        [StringLength(30)]
        public string Sdt { get; set; }
        [Required]
        [StringLength(100)]
        public string DiaChi { get; set; }
        [Required]
        [StringLength(30)]
        public string DiemTich { get; set; }
        public int? TrangThai { get; set; }

        [InverseProperty(nameof(LichSuTichDiem.IdKhNavigation))]
        public virtual ICollection<LichSuTichDiem> LichSuTichDiems { get; set; }
    }
}

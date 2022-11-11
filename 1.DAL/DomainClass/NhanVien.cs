using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    [Table("NhanVien")]
    [Index(nameof(Ma), Name = "UQ__NhanVien__3214CC9ECA2AF9EF", IsUnique = true)]
    public partial class NhanVien
    {
        public NhanVien()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        [Key]
        public Guid Id { get; set; }
        [Column("IdCV")]
        public Guid? IdCv { get; set; }
        [StringLength(20)]
        public string Ma { get; set; }
        [Required]
        [StringLength(30)]
        public string Ten { get; set; }
        [Required]
        [StringLength(30)]
        public string TenDem { get; set; }
        [Required]
        [StringLength(30)]
        public string Ho { get; set; }
        [Required]
        [StringLength(10)]
        public string GioiTinh { get; set; }
        [Column(TypeName = "date")]
        public DateTime NgaySinh { get; set; }
        [Required]
        [StringLength(100)]
        public string DiaChi { get; set; }
        [Required]
        [StringLength(30)]
        public string Sdt { get; set; }
        [Required]
        public string MatKhau { get; set; }
        public int? TrangThai { get; set; }

        [ForeignKey(nameof(IdCv))]
        [InverseProperty(nameof(ChucVu.NhanViens))]
        public virtual ChucVu IdCvNavigation { get; set; }
        [InverseProperty(nameof(HoaDon.IdNvNavigation))]
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}

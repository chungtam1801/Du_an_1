using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    [Table("KhuyenMai")]
    public partial class KhuyenMai
    {
        public KhuyenMai()
        {
            ChiTietKhuyenMais = new HashSet<ChiTietKhuyenMai>();
        }

        [Key]
        public Guid Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Ten { get; set; }
        [StringLength(40)]
        public string GiaTri { get; set; }
        [Column("NgayBD", TypeName = "date")]
        public DateTime NgayBd { get; set; }
        [Column("NgayKT", TypeName = "date")]
        public DateTime NgayKt { get; set; }
        public int? TrangThai { get; set; }
        [Column("IdSP")]
        public Guid? IdSp { get; set; }

        [InverseProperty(nameof(ChiTietKhuyenMai.IdKmNavigation))]
        public virtual ICollection<ChiTietKhuyenMai> ChiTietKhuyenMais { get; set; }
    }
}

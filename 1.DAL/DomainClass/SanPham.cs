using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    [Table("SanPham")]
    [Index(nameof(Ma), Name = "UQ__SanPham__3214CC9EBCBE4FE4", IsUnique = true)]
    public partial class SanPham
    {
        public SanPham()
        {
            ChiTietSps = new HashSet<ChiTietSp>();
        }

        [Key]
        public Guid Id { get; set; }
        [StringLength(20)]
        public string Ma { get; set; }
        [Required]
        [StringLength(30)]
        public string Ten { get; set; }
        [StringLength(50)]
        public string MoTa { get; set; }
        public int? TrangThai { get; set; }

        [InverseProperty(nameof(ChiTietSp.IdSpNavigation))]
        public virtual ICollection<ChiTietSp> ChiTietSps { get; set; }
    }
}

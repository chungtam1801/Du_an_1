using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    [Table("PhuongThucThanhToan")]
    public partial class PhuongThucThanhToan
    {
        public PhuongThucThanhToan()
        {
            ChiTietPttts = new HashSet<ChiTietPttt>();
        }

        [Key]
        public Guid Id { get; set; }
        [Required]
        [StringLength(30)]
        public string Ten { get; set; }
        public int? TrangThai { get; set; }

        [InverseProperty(nameof(ChiTietPttt.IdPtttNavigation))]
        public virtual ICollection<ChiTietPttt> ChiTietPttts { get; set; }
    }
}

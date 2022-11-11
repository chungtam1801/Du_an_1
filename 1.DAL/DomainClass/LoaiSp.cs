using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    [Table("LoaiSP")]
    [Index(nameof(Ma), Name = "UQ__LoaiSP__3214CC9EBC78A518", IsUnique = true)]
    public partial class LoaiSp
    {
        public LoaiSp()
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
        [Column("MaLoaiSPCha")]
        public Guid? MaLoaiSpcha { get; set; }
        public int? TrangThai { get; set; }

        [InverseProperty(nameof(ChiTietSp.IdLoaiSpNavigation))]
        public virtual ICollection<ChiTietSp> ChiTietSps { get; set; }
    }
}

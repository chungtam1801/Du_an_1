using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    [Table("NSX")]
    [Index(nameof(Ma), Name = "UQ__NSX__3214CC9EF1373A75", IsUnique = true)]
    public partial class Nsx
    {
        public Nsx()
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
        [Required]
        [StringLength(100)]
        public string DiaChi { get; set; }
        public int? TrangThai { get; set; }

        [InverseProperty(nameof(ChiTietSp.IdNsxNavigation))]
        public virtual ICollection<ChiTietSp> ChiTietSps { get; set; }
    }
}

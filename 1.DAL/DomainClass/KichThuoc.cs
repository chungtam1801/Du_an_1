using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    [Table("KichThuoc")]
    [Index(nameof(Ma), Name = "UQ__KichThuo__3214CC9EE311A74C", IsUnique = true)]
    public partial class KichThuoc
    {
        public KichThuoc()
        {
            ChiTietSps = new HashSet<ChiTietSp>();
        }

        [Key]
        public Guid Id { get; set; }
        [StringLength(20)]
        public string Ma { get; set; }
        [Required]
        [StringLength(30)]
        public string Size { get; set; }
        public int? TrangThai { get; set; }

        [InverseProperty(nameof(ChiTietSp.IdKtNavigation))]
        public virtual ICollection<ChiTietSp> ChiTietSps { get; set; }
    }
}

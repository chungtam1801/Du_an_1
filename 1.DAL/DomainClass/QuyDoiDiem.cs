using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    [Table("QuyDoiDiem")]
    public partial class QuyDoiDiem
    {
        public QuyDoiDiem()
        {
            LichSuTichDiems = new HashSet<LichSuTichDiem>();
        }

        [Key]
        public Guid Id { get; set; }
        public int SoDiem { get; set; }
        [Column(TypeName = "decimal(20, 0)")]
        public decimal TiLeTichDiem { get; set; }
        [Column(TypeName = "decimal(20, 0)")]
        public decimal TiLeTieuDiem { get; set; }
        public int? TrangThai { get; set; }

        [InverseProperty(nameof(LichSuTichDiem.IdQuyDoiDiemNavigation))]
        public virtual ICollection<LichSuTichDiem> LichSuTichDiems { get; set; }
    }
}

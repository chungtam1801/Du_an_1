using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    [Table("LichSuTichDiem")]
    public partial class LichSuTichDiem
    {
        [Key]
        public Guid Id { get; set; }
        [Column("IdKH")]
        public Guid? IdKh { get; set; }
        public Guid? IdQuyDoiDiem { get; set; }
        [Column("IdHD")]
        public Guid? IdHd { get; set; }
        public int Diem { get; set; }
        public int? TrangThai { get; set; }

        [ForeignKey(nameof(IdHd))]
        [InverseProperty(nameof(HoaDon.LichSuTichDiems))]
        public virtual HoaDon IdHdNavigation { get; set; }
        [ForeignKey(nameof(IdKh))]
        [InverseProperty(nameof(KhachHang.LichSuTichDiems))]
        public virtual KhachHang IdKhNavigation { get; set; }
        [ForeignKey(nameof(IdQuyDoiDiem))]
        [InverseProperty(nameof(QuyDoiDiem.LichSuTichDiems))]
        public virtual QuyDoiDiem IdQuyDoiDiemNavigation { get; set; }
    }
}

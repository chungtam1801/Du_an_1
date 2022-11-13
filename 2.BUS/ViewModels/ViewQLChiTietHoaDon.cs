using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class ViewQLChiTietHoaDon
    {
        public Guid Id { get; set; }
        public Guid? IdCtsp { get; set; }
        public Guid? IdHd { get; set; }
        public decimal? DonGia { get; set; }
        public int? SoLuong { get; set; }
        public int? TrangThai { get; set; }
    }
}

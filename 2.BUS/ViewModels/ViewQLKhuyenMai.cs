using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class ViewQLKhuyenMai
    {
        public Guid Id { get; set; }
        public string Ten { get; set; }
        public string GiaTri { get; set; }
        public DateTime NgayBd { get; set; }
        public DateTime NgayKt { get; set; }
        public string SanPham { get; set; }
        public int? TrangThai { get; set; }
    }
}

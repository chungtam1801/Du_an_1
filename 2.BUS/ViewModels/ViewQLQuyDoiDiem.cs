using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class ViewQLQuyDoiDiem
    {
        public Guid Id { get; set; }
        public int SoDiem { get; set; }
        public decimal TiLeTichDiem { get; set; }
        public decimal TiLeTieuDiem { get; set; }
        public int? TrangThai { get; set; }
    }
}

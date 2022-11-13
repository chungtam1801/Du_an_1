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
    public class ViewQLChiTietPttt
    {
        public Guid Id { get; set; }
        public Guid? IdHd { get; set; }
        public Guid? IdPttt { get; set; }
        public string Ma { get; set; }
        public decimal? TienKhachDua { get; set; }
        public int? TrangThai { get; set; }
    }
}

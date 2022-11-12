using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class ViewQLChiTietKhuyenMai
    {
        public Guid Id { get; set; }
        public Guid? IdCtsp { get; set; }
        public Guid? IdKm { get; set; }
        public int? TrangThai { get; set; }
    }
}

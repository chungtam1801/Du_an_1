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
    public class ViewQLKhachHang
    {
        public Guid Id { get; set; }
        public string Ma { get; set; }
        public string Ten { get; set; }
        public string TenDem { get; set; }
        public string Ho { get; set; }
        public DateTime NgaySinh { get; set; }
        public string Sdt { get; set; }
        public string DiaChi { get; set; }
        public string DiemTich { get; set; }
        public int? TrangThai { get; set; }
    }
}

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
    public class ViewQLChiTietSp
    {
        public Guid Id { get; set; }
        public Guid? IdSp { get; set; }
        public Guid? IdNsx { get; set; }
        public Guid? IdMauSac { get; set; }
        public Guid? IdLoaiSp { get; set; }
        public Guid? IdKt { get; set; }
        public Guid? IdClieu { get; set; }
        public string Anh { get; set; }
        public string MoTa { get; set; }
        public int? SoLuongTon { get; set; }
        public decimal? GiaNhap { get; set; }
        public decimal? GiaBan { get; set; }
        public int? TrangThai { get; set; }
    }
}

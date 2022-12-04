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
        public string Ma { get; set; }
        public string Ten { get; set; }
        public string Nsx { get; set; }
        public string MauSac { get; set; }
        public string LoaiSp { get; set; }
        public string KichThuoc { get; set; }
        public string ChatLieu { get; set; }
        public int? SoLuong { get; set; }
        public Guid Id { get; set; }
        public decimal? DonGia { get; set; }
        public decimal? TongTien { get; set; }
    }
}

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
    public class ViewQLHoaDon
    {
        public Guid Id { get; set; }
        public string MaNV { get; set; }
        public string Ma { get; set; }
        public DateTime? NgayTao { get; set; }
        public DateTime? NgayThanhToan { get; set; }
        public DateTime? NgayGiaoHang { get; set; }
        public DateTime? NgayNhanHang { get; set; }
        public double? GiamGia { get; set; }
        public decimal? TongTien { get; set; }
        public string TrangThai { get; set; }
        //0-Cho-BanHang
        //1-Da thanh toan
        //2-Huy thanh toan
        //3-Cho-DatHang
        //4-DangGiao
        //5-DaGiao
        //6-Huy
    }
}

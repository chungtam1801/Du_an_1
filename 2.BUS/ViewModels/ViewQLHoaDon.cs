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
        public Guid? IdNv { get; set; }
        public string Ma { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime NgayThanhToan { get; set; }
        public DateTime NgayGiaoHang { get; set; }
        public DateTime NgayNhanHang { get; set; }
        public string GiamGia { get; set; }
        public decimal TongTien { get; set; }
        public string TrangThai { get; set; }
        //0-Cho-BanHang
        //1-Da thanh toan
        //2-Cho-DatHang
        //3-DangGiao
        //4-DaGiao
        //5-Huy
    }
}

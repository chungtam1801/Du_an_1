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
        public string GiamGia { get; set; }
        public int? TrangThai { get; set; }
        //0-Cho-BanHang
        //1-DaThanhToan
        //2-Huy
        //3-Cho-DatHang
        //4-DangGiao
        //5-DaGiao
        //6-HoanTra
    }
}

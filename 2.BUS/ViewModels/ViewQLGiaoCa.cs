using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class ViewQLGiaoCa
    {
        public Guid Id { get; set; }
        public Guid? IdNguoiGiaoCa { get; set; }
        public Guid? IdNguoiNhanCa { get; set; }
        public string GhiChu { get; set; }
        public int? TrangThai { get; set; }
        public decimal? TienDauca { get; set; }
        public decimal? TienMat { get; set; }
        public decimal? NganHang { get; set; }
        public decimal? TienSdDiem { get; set; }
        public decimal? TienCuoiCa { get; set; }
        public decimal? TongTienMat { get; set; }
        public DateTime? ThoiGianVaoCa { get; set; }
        public DateTime? ThoiGianKetCa { get; set; }
        public int? SoHoaDon { get; set; }
        public decimal? Tongtienhang { get; set; }

    }
}

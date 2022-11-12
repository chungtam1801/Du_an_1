using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class ViewQLLichSuTichDiem
    {
        public Guid Id { get; set; }
        public Guid? IdKh { get; set; }
        public Guid? IdQuyDoiDiem { get; set; }
        public Guid? IdHd { get; set; }
        public int Diem { get; set; }
        public int? TrangThai { get; set; }
    }
}

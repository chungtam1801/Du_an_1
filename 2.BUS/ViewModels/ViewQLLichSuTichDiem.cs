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
        //Lam them
        public Guid Id { get; set; }
        public string Ten { get; set; }
        public string Sdt { get; set; }
        public string  MaHD { get; set; }
        public DateTime? NgayThayDoi { get; set; }
        public int Diem { get; set; }
        public Guid? MaQuyDoiDiem { get; set; }
        
    }
}

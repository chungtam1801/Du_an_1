using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;

namespace _2.BUS.Services
{
    public class QLHoaDonServices : IQLHoaDonServices
    {
        private IHoaDonRepository _iHoaDonRepository;
        public QLHoaDonServices()
        {
            _iHoaDonRepository = new HoaDonRepository();
        }
        public string Add(HoaDon obj)
        {
            if (obj == null) return "Thêm thất bại";
            var tempobj = obj;
            if (_iHoaDonRepository.Add(tempobj)) return "Thêm thành công";
            return "Thêm thất bại";
        }

        public string Delete(HoaDon obj)
        {
            if (obj == null) return "Xóa thất bại";
            var tempobj = obj;
            if (_iHoaDonRepository.Delete(tempobj)) return "Xóa thành công";
            return "Xóa thất bại";
        }

        public List<HoaDon> GetAll()
        {
            return _iHoaDonRepository.GetAll();
        }

        public HoaDon GetByID(Guid id)
        {
            throw new NotImplementedException();
        }

        public string Update(HoaDon obj)
        {
            if (obj == null) return "Sửa thất bại";
            var tempobj = obj;
            if (_iHoaDonRepository.Update(tempobj)) return "Sửa thành công";
            return "Sửa thất bại";
        }
    }
}

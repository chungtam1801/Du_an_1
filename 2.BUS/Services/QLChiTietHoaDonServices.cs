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
    public class QLChiTietHoaDonServices : IQLChiTietHoaDonServices
    {
        private IChiTietHoaDonRepository _iChiTietHoaDonRepository;
        public QLChiTietHoaDonServices()
        {
            _iChiTietHoaDonRepository = new ChiTietHoaDonRepository();
        }
        public string Add(ChiTietHoaDon obj)
        {
            if (obj == null) return "Thêm thất bại";
            var tempobj = obj;
            if (_iChiTietHoaDonRepository.Add(tempobj)) return "Thêm thành công";
            return "Thêm thất bại";
        }

        public string Delete(ChiTietHoaDon obj)
        {
            if (obj == null) return "Xóa thất bại";
            var tempobj = obj;
            if (_iChiTietHoaDonRepository.Delete(tempobj)) return "Xóa thành công";
            return "Xóa thất bại";
        }

        public List<ChiTietHoaDon> GetAll()
        {
            return _iChiTietHoaDonRepository.GetAll();
        }

        public ChiTietHoaDon GetByID(Guid id)
        {
            throw new NotImplementedException();
        }

        public string Update(ChiTietHoaDon obj)
        {
            if (obj == null) return "Sửa thất bại";
            var tempobj = obj;
            if (_iChiTietHoaDonRepository.Update(tempobj)) return "Sửa thành công";
            return "Sửa thất bại";
        }
    }
}

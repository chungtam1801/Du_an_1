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
    public class QLChiTietKhuyenMaiServices : IQLChiTietKhuyenMaiServices
    {
        private IClassCRUDRepo<ChiTietKhuyenMai> _iChiTietKhuyenMaiRepository;
        public QLChiTietKhuyenMaiServices()
        {
            _iChiTietKhuyenMaiRepository = new ChiTietKhuyenMaiRepository();
        }
        public string Add(ChiTietKhuyenMai obj)
        {
            if (obj == null) return "Thêm thất bại";
            var tempobj = obj;
            if (_iChiTietKhuyenMaiRepository.Add(tempobj)) return "Thêm thành công";
            return "Thêm thất bại";
        }

        public string Delete(ChiTietKhuyenMai obj)
        {
            if (obj == null) return "Xóa thất bại";
            var tempobj = obj;
            if (_iChiTietKhuyenMaiRepository.Delete(tempobj)) return "Xóa thành công";
            return "Xóa thất bại";
        }

        public List<ChiTietKhuyenMai> GetAll()
        {
            return _iChiTietKhuyenMaiRepository.GetAll();
        }

        public ChiTietKhuyenMai GetByID(Guid id)
        {
            throw new NotImplementedException();
        }

        public string Update(ChiTietKhuyenMai obj)
        {
            if (obj == null) return "Sửa thất bại";
            var tempobj = obj;
            if (_iChiTietKhuyenMaiRepository.Update(tempobj)) return "Sửa thành công";
            return "Sửa thất bại";
        }
    }
}

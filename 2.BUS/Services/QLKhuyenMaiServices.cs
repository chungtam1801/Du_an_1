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
    public class QLKhuyenMaiServices : IQLKhuyenMaiServices
    {
        private IClassCRUDRepo<KhuyenMai> _iKhuyenMaiRepository;
        public QLKhuyenMaiServices()
        {
            _iKhuyenMaiRepository = new KhuyenMaiRepository();
        }
        public string Add(KhuyenMai obj)
        {
            if (obj == null) return "Thêm thất bại";
            var tempobj = obj;
            if (_iKhuyenMaiRepository.Add(tempobj)) return "Thêm thành công";
            return "Thêm thất bại";
        }

        public string Delete(KhuyenMai obj)
        {
            if (obj == null) return "Xóa thất bại";
            var tempobj = obj;
            if (_iKhuyenMaiRepository.Delete(tempobj)) return "Xóa thành công";
            return "Xóa thất bại";
        }

        public List<KhuyenMai> GetAll()
        {
            return _iKhuyenMaiRepository.GetAll();
        }

        public KhuyenMai GetByID(Guid id)
        {
            throw new NotImplementedException();
        }

        public string Update(KhuyenMai obj)
        {
            if (obj == null) return "Sửa thất bại";
            var tempobj = obj;
            if (_iKhuyenMaiRepository.Update(tempobj)) return "Sửa thành công";
            return "Sửa thất bại";
        }
    }
}

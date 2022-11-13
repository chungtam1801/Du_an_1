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
    public class QLChiTietSpServices : IQLChiTietSpServices
    {
        private IChiTietSpRepository _iChiTietSpRepository;
        public QLChiTietSpServices()
        {
            _iChiTietSpRepository = new ChiTietSpRepository();
        }
        public string Add(ChiTietSp obj)
        {
            if (obj == null) return "Thêm thất bại";
            var tempobj = obj;
            if (_iChiTietSpRepository.Add(tempobj)) return "Thêm thành công";
            return "Thêm thất bại";
        }

        public string Delete(ChiTietSp obj)
        {
            if (obj == null) return "Xóa thất bại";
            var tempobj = obj;
            if (_iChiTietSpRepository.Delete(tempobj)) return "Xóa thành công";
            return "Xóa thất bại";
        }

        public List<ChiTietSp> GetAll()
        {
            return _iChiTietSpRepository.GetAll();
        }

        public ChiTietSp GetByID(Guid id)
        {
            throw new NotImplementedException();
        }

        public string Update(ChiTietSp obj)
        {
            if (obj == null) return "Sửa thất bại";
            var tempobj = obj;
            if (_iChiTietSpRepository.Update(tempobj)) return "Sửa thành công";
            return "Sửa thất bại";
        }
    }
}

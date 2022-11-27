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
    public class QLChucVuServices : IQLChucVuServices
    {
        private IClassCRUDRepo<ChucVu> _iChucVuRepository;
        public QLChucVuServices()
        {
            _iChucVuRepository = new ChucVuRepository();
        }
        public string Add(ChucVu obj)
        {
            if (obj == null) return "Thêm thất bại";
            var tempobj = obj;
            if (_iChucVuRepository.Add(tempobj)) return "Thêm thành công";
            return "Thêm thất bại";
        }

        public string Delete(ChucVu obj)
        {
            if (obj == null) return "Xóa thất bại";
            var tempobj = obj;
            if (_iChucVuRepository.Delete(tempobj)) return "Xóa thành công";
            return "Xóa thất bại";
        }

        public List<ChucVu> GetAll()
        {
            return _iChucVuRepository.GetAll();
        }

        public ChucVu GetByID(Guid id)
        {
            throw new NotImplementedException();
        }

        public string Update(ChucVu obj)
        {
            if (obj == null) return "Sửa thất bại";
            var tempobj = obj;
            if (_iChucVuRepository.Update(tempobj)) return "Sửa thành công";
            return "Sửa thất bại";
        }
    }
}

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
    public class QLKhachHangServices : IQLKhachHangServices
    {
        private IKhachHangRepository _iKhachHangRepository;
        public QLKhachHangServices()
        {
            _iKhachHangRepository = new KhachHangRepository();
        }
        public string Add(KhachHang obj)
        {
            if (obj == null) return "Thêm thất bại";
            var tempobj = obj;
            if (_iKhachHangRepository.Add(tempobj)) return "Thêm thành công";
            return "Thêm thất bại";
        }

        public string Delete(KhachHang obj)
        {
            if (obj == null) return "Xóa thất bại";
            var tempobj = obj;
            if (_iKhachHangRepository.Delete(tempobj)) return "Xóa thành công";
            return "Xóa thất bại";
        }

        public List<KhachHang> GetAll()
        {
            return _iKhachHangRepository.GetAll();
        }

        public KhachHang GetByID(Guid id)
        {
            throw new NotImplementedException();
        }

        public string Update(KhachHang obj)
        {
            if (obj == null) return "Sửa thất bại";
            var tempobj = obj;
            if (_iKhachHangRepository.Update(tempobj)) return "Sửa thành công";
            return "Sửa thất bại";
        }
    }
}

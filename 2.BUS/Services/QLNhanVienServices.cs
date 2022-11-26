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
    public class QLNhanVienServices : IQLNhanVienServices
    {
        private IClassCRUDRepo<NhanVien> _iNhanVienRepository;
        public QLNhanVienServices()
        {
            _iNhanVienRepository = new NhanVienRepository();
        }
        public string Add(NhanVien obj)
        {
            if (obj == null) return "Thêm thất bại";
            var tempobj = obj;
            if (_iNhanVienRepository.Add(tempobj)) return "Thêm thành công";
            return "Thêm thất bại";
        }

        public string Delete(NhanVien obj)
        {
            if (obj == null) return "Xóa thất bại";
            var tempobj = obj;
            if (_iNhanVienRepository.Delete(tempobj)) return "Xóa thành công";
            return "Xóa thất bại";
        }

        public List<NhanVien> GetAll()
        {
            return _iNhanVienRepository.GetAll();
        }

        public NhanVien GetByID(Guid id)
        {
            throw new NotImplementedException();
        }

        public string Update(NhanVien obj)
        {
            if (obj == null) return "Sửa thất bại";
            var tempobj = obj;
            if (_iNhanVienRepository.Update(tempobj)) return "Sửa thành công";
            return "Sửa thất bại";
        }
    }
}

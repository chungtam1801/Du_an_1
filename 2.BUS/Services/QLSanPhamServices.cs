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
    public class QLSanPhamServices : IQLSanPhamServices
    {
        private ISanPhamRepository _iSanPhamRepository;
        public QLSanPhamServices()
        {
            _iSanPhamRepository = new SanPhamRepository();
        }
        public string Add(SanPham obj)
        {
            if (obj == null) return "Thêm thất bại";
            var tempobj = obj;
            if (_iSanPhamRepository.Add(tempobj)) return "Thêm thành công";
            return "Thêm thất bại";
        }

        public string Delete(SanPham obj)
        {
            if (obj == null) return "Xóa thất bại";
            var tempobj = obj;
            if (_iSanPhamRepository.Delete(tempobj)) return "Xóa thành công";
            return "Xóa thất bại";
        }

        public List<SanPham> GetAll()
        {
            return _iSanPhamRepository.GetAll();
        }

        public List<SanPham> GetAll(string s)
        {
            if(s == null) return GetAll();
            return GetAll().Where(c=> c.Ten.ToLower().Contains(s.ToLower())).ToList();
        }

        public SanPham GetByID(Guid id)
        {
            throw new NotImplementedException();
        }

        public string Update(SanPham obj)
        {
            if (obj == null) return "Sửa thất bại";
            var tempobj = obj;
            if (_iSanPhamRepository.Update(tempobj)) return "Sửa thành công";
            return "Sửa thất bại";
        }
    }
}

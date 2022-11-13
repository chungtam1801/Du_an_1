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
    public class QLNsxServices : IQLNsxServices
    {
        private INsxRepository _iNsxRepository;
        public QLNsxServices()
        {
            _iNsxRepository = new NsxRepository();
        }
        public string Add(Nsx obj)
        {
            if (obj == null) return "Thêm thất bại";
            var tempobj = obj;
            if (_iNsxRepository.Add(tempobj)) return "Thêm thành công";
            return "Thêm thất bại";
        }

        public string Delete(Nsx obj)
        {
            if (obj == null) return "Xóa thất bại";
            var tempobj = obj;
            if (_iNsxRepository.Delete(tempobj)) return "Xóa thành công";
            return "Xóa thất bại";
        }

        public List<Nsx> GetAll()
        {
            return _iNsxRepository.GetAll();
        }

        public Nsx GetByID(Guid id)
        {
            throw new NotImplementedException();
        }

        public string Update(Nsx obj)
        {
            if (obj == null) return "Sửa thất bại";
            var tempobj = obj;
            if (_iNsxRepository.Update(tempobj)) return "Sửa thành công";
            return "Sửa thất bại";
        }
    }
}

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
    public class QLKichThuocServices : IQLKichThuocServices
    {
        private IClassCRUDRepo<KichThuoc> _iKichThuocRepository;
        public QLKichThuocServices()
        {
            _iKichThuocRepository= new KichThuocRepository();
        }
        public string Add(KichThuoc obj)
        {
            if (obj == null) return "Thêm thất bại";
            var tempobj = obj;
            if (_iKichThuocRepository.Add(tempobj)) return "Thêm thành công";
            return "Thêm thất bại";
        }

        public string Delete(KichThuoc obj)
        {
            if (obj == null) return "Xóa thất bại";
            var tempobj = obj;
            if (_iKichThuocRepository.Delete(tempobj)) return "Xóa thành công";
            return "Xóa thất bại";
        }

        public List<KichThuoc> GetAll()
        {
            return _iKichThuocRepository.GetAll();  
        }

        public KichThuoc GetByID(Guid id)
        {
            throw new NotImplementedException();
        }

        public string Update(KichThuoc obj)
        {
            if (obj == null) return "Sửa thất bại";
            var tempobj = obj;
            if (_iKichThuocRepository.Update(tempobj)) return "Sửa thành công";
            return "Sửa thất bại";
        }
    }
}

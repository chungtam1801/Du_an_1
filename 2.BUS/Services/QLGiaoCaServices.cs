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
    public class QLGiaoCaServices : IQLGiaoCaServices
    {
        private IClassCRUDRepo<GiaoCa> _iGiaoCaRepository;
        public QLGiaoCaServices()
        {
            _iGiaoCaRepository = new GiaoCaRepository();
        }
        public string Add(GiaoCa obj)
        {
            if (obj == null) return "Thêm thất bại";
            var tempobj = obj;
            if (_iGiaoCaRepository.Add(tempobj)) return "Bắt đầu ca làm việc";
            return "Vào ca thất bại";
        }

        public string Delete(GiaoCa obj)
        {
            if (obj == null) return "Xóa thất bại";
            var tempobj = obj;
            if (_iGiaoCaRepository.Delete(tempobj)) return "Xóa thành công";
            return "Xóa thất bại";
        }

        public List<GiaoCa> GetAll()
        {
            return _iGiaoCaRepository.GetAll();
        }

        public GiaoCa GetByID(Guid id)
        {
            throw new NotImplementedException();
        }

        public string Update(GiaoCa obj)
        {
            if (obj == null) return "Sửa thất bại";
            var tempobj = obj;
            if (_iGiaoCaRepository.Update(tempobj)) return "Sửa thành công";
            return "Sửa thất bại";
        }
    }
}

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
    public class QLChiTietPtttServices : IQLChiTietPtttServices
    {
        private IChiTietPtttRepository _iChiTietPtttRepository;
        public QLChiTietPtttServices()
        {
            _iChiTietPtttRepository = new ChiTietPtttRepository();
        }
        public string Add(ChiTietPttt obj)
        {
            if (obj == null) return "Thêm thất bại";
            var tempobj = obj;
            if (_iChiTietPtttRepository.Add(tempobj)) return "Thêm thành công";
            return "Thêm thất bại";
        }

        public string Delete(ChiTietPttt obj)
        {
            if (obj == null) return "Xóa thất bại";
            var tempobj = obj;
            if (_iChiTietPtttRepository.Delete(tempobj)) return "Xóa thành công";
            return "Xóa thất bại";
        }

        public List<ChiTietPttt> GetAll()
        {
            return _iChiTietPtttRepository.GetAll();
        }

        public ChiTietPttt GetByID(Guid id)
        {
            throw new NotImplementedException();
        }

        public string Update(ChiTietPttt obj)
        {
            if (obj == null) return "Sửa thất bại";
            var tempobj = obj;
            if (_iChiTietPtttRepository.Update(tempobj)) return "Sửa thành công";
            return "Sửa thất bại";
        }
    }
}

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
    public class QLLichSuTichDiemServices : IQLLichSuTichDiemServices
    {
        private IClassCRUDRepo<LichSuTichDiem> _iLichSuTichDiemRepository;
        public QLLichSuTichDiemServices()
        {
            _iLichSuTichDiemRepository = new LichSuTichDiemRepository();
        }
        public string Add(LichSuTichDiem obj)
        {
            if (obj == null) return "Thêm thất bại";
            var tempobj = obj;
            if (_iLichSuTichDiemRepository.Add(tempobj)) return "Thêm thành công";
            return "Thêm thất bại";
        }

        public string Delete(LichSuTichDiem obj)
        {
            if (obj == null) return "Xóa thất bại";
            var tempobj = obj;
            if (_iLichSuTichDiemRepository.Delete(tempobj)) return "Xóa thành công";
            return "Xóa thất bại";
        }

        public List<LichSuTichDiem> GetAll()
        {
            return _iLichSuTichDiemRepository.GetAll(); 
        }

        public LichSuTichDiem GetByID(Guid id)
        {
            throw new NotImplementedException();
        }

        public string Update(LichSuTichDiem obj)
        {
            if (obj == null) return "Sửa thất bại";
            var tempobj = obj;
            if (_iLichSuTichDiemRepository.Update(tempobj)) return "Sửa thành công";
            return "Sửa thất bại";
        }
    }
}

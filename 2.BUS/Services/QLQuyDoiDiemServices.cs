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
    public class QLQuyDoiDiemServices : IQLQuyDoiDiemServices
    {
        private IClassCRUDRepo<QuyDoiDiem> _iQuyDoiDiemRepository;
        public QLQuyDoiDiemServices()
        {
            _iQuyDoiDiemRepository = new QuyDoiDiemRepository();
        }
        public string Add(QuyDoiDiem obj)
        {
            if (obj == null) return "Thêm thất bại";
            var tempobj = obj;
            if (_iQuyDoiDiemRepository.Add(tempobj)) return "Thêm thành công";
            return "Thêm thất bại";
        }

        public string Delete(QuyDoiDiem obj)
        {
            if (obj == null) return "Xóa thất bại";
            var tempobj = obj;
            if (_iQuyDoiDiemRepository.Delete(tempobj)) return "Xóa thành công";
            return "Xóa thất bại";
        }

        public List<QuyDoiDiem> GetAll()
        {
            return _iQuyDoiDiemRepository.GetAll();
        }

        public QuyDoiDiem GetByID(Guid id)
        {
            throw new NotImplementedException();
        }

        public string Update(QuyDoiDiem obj)
        {
            if (obj == null) return "Sửa thất bại";
            var tempobj = obj;
            if (_iQuyDoiDiemRepository.Update(tempobj)) return "Sửa thành công";
            return "Sửa thất bại";
        }
    }
}

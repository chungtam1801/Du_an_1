using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.ViewModels;

namespace _2.BUS.Services
{
    public class QLKhuyenMaiServices : IQLKhuyenMaiServices
    {
        private IClassCRUDRepo<KhuyenMai> _iKhuyenMaiRepository;
        private IClassCRUDRepo<SanPham> _iSPRespository;
        public QLKhuyenMaiServices()
        {
            _iKhuyenMaiRepository = new KhuyenMaiRepository();
        }
        public string Add(KhuyenMai obj)
        {
            if (obj == null) return "Thêm thất bại";
            var tempobj = obj;
            if (_iKhuyenMaiRepository.Add(tempobj)) return "Thêm thành công";
            return "Thêm thất bại";
        }

        public string Delete(KhuyenMai obj)
        {
            if (obj == null) return "Xóa thất bại";
            var tempobj = obj;
            if (_iKhuyenMaiRepository.Delete(tempobj)) return "Xóa thành công";
            return "Xóa thất bại";
        }

        public List<KhuyenMai> GetAll()
        {
            return _iKhuyenMaiRepository.GetAll();
        }

        public List<ViewQLKhuyenMai> GetAllView()
        {
            var listView = new List<ViewQLKhuyenMai>();
            listView = (from a in _iKhuyenMaiRepository.GetAll()
                        join b in _iSPRespository.GetAll() on a.IdSp equals b.Id
                        
                        //join i in _iChiTietKhuyenMaiRepository.GetAll() on a.ChiTietKhuyenMais equals i.Id
                        select new ViewQLKhuyenMai()
                        {
                            Id = a.Id,
                            Ten = a.Ten,
                            GiaTri = a.GiaTri,
                            NgayBd = a.NgayBd,
                            NgayKt = a.NgayKt,
                            SanPham = b.Ten,
                            TrangThai = a.TrangThai
                        }
                         ).ToList();
            return listView;
        }

        public KhuyenMai GetByID(Guid id)
        {
            throw new NotImplementedException();
        }

        public string Update(KhuyenMai obj)
        {
            if (obj == null) return "Sửa thất bại";
            var tempobj = obj;
            if (_iKhuyenMaiRepository.Update(tempobj)) return "Sửa thành công";
            return "Sửa thất bại";
        }
    }
}

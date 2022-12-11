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
    public class QLChiTietKhuyenMaiServices : IQLChiTietKhuyenMaiServices
    {
        private IClassCRUDRepo<ChiTietKhuyenMai> _iChiTietKhuyenMaiRepository;
        private IClassCRUDRepo<ChiTietSp> _ictqLSanPhamRespository;
        private IClassCRUDRepo<SanPham> _iqLSanPhamRespository;
        private IClassCRUDRepo<KhuyenMai> _iKhuyenMaiRespository;

        public QLChiTietKhuyenMaiServices()
        {
            _iChiTietKhuyenMaiRepository = new ChiTietKhuyenMaiRepository();
        }
        public string Add(ChiTietKhuyenMai obj)
        {
            if (obj == null) return "Thêm thất bại";
            var tempobj = obj;
            if (_iChiTietKhuyenMaiRepository.Add(tempobj)) return "Thêm thành công";
            return "Thêm thất bại";
        }

        public string Delete(ChiTietKhuyenMai obj)
        {
            if (obj == null) return "Xóa thất bại";
            var tempobj = obj;
            if (_iChiTietKhuyenMaiRepository.Delete(tempobj)) return "Xóa thành công";
            return "Xóa thất bại";
        }

        public List<ChiTietKhuyenMai> GetAll()
        {
            return _iChiTietKhuyenMaiRepository.GetAll();
        }

        public List<ViewQLChiTietKhuyenMai> GetAllView()
        {
            var listView = new List<ViewQLChiTietKhuyenMai>();
            listView = (from a in _iChiTietKhuyenMaiRepository.GetAll()
                        join b in _ictqLSanPhamRespository.GetAll() on a.IdCtsp equals b.Id
                        join c in _iKhuyenMaiRespository.GetAll() on a.IdKm equals c.Id

                        //join i in _iChiTietKhuyenMaiRepository.GetAll() on a.ChiTietKhuyenMais equals i.Id
                        select new ViewQLChiTietKhuyenMai()
                        {
                            Id = a.Id,
                            KhuyenMai = c.Ten,
                            //SanPham = _iqLSanPhamRespository.GetAll().First(c => c.Id),
                            TrangThai = a.TrangThai
                        }
                         ).ToList();
            return listView;
        }

        public ChiTietKhuyenMai GetByID(Guid id)
        {
            throw new NotImplementedException();
        }

        public string Update(ChiTietKhuyenMai obj)
        {
            if (obj == null) return "Sửa thất bại";
            var tempobj = obj;
            if (_iChiTietKhuyenMaiRepository.Update(tempobj)) return "Sửa thành công";
            return "Sửa thất bại";
        }

        List<ViewQLKhuyenMai> IQLChiTietKhuyenMaiServices.GetAllView()
        {
            throw new NotImplementedException();
        }
    }
}

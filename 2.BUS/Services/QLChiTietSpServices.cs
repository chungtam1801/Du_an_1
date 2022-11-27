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
    public class QLChiTietSpServices : IQLChiTietSpServices
    {
        private IClassCRUDRepo<ChiTietSp> _iChiTietSpRepository;
        private IClassCRUDRepo<SanPham> _iSanPhamRepository;
        private IClassCRUDRepo<MauSac> _iMauSacRepository;
        private IClassCRUDRepo<ChatLieu> _iChatLieuRepository;
        private IClassCRUDRepo<KichThuoc> _iKichThuocRepository;
        private IClassCRUDRepo<Nsx> _iNsxRepository;
        private IClassCRUDRepo<LoaiSp> _iLoaiSpRepository;
        public QLChiTietSpServices()
        {
            _iChiTietSpRepository = new ChiTietSpRepository();
            _iChatLieuRepository = new ChatLieuRepository();
            _iKichThuocRepository = new KichThuocRepository();
            _iMauSacRepository = new MauSacRepository();
            _iNsxRepository = new NsxRepository();
            _iSanPhamRepository = new SanPhamRepository();
            _iLoaiSpRepository = new LoaiSpRepository();
        }
        public string Add(ChiTietSp obj)
        {
            if (obj == null) return "Thêm thất bại";
            var tempobj = obj;
            if (_iChiTietSpRepository.Add(tempobj)) return "Thêm thành công";
            return "Thêm thất bại";
        }

        public string Delete(ChiTietSp obj)
        {
            if (obj == null) return "Xóa thất bại";
            var tempobj = obj;
            if (_iChiTietSpRepository.Delete(tempobj)) return "Xóa thành công";
            return "Xóa thất bại";
        }

        public List<ChiTietSp> GetAll()
        {
            return _iChiTietSpRepository.GetAll();
        }

        public List<ViewQLChiTietSp> GetAllView()
        {
            var listView = new List<ViewQLChiTietSp>();
            listView =  (from a in  _iChiTietSpRepository.GetAll()
                         join b in _iSanPhamRepository.GetAll() on a.IdSp equals b.Id
                         join c in _iChatLieuRepository.GetAll() on a.IdClieu equals c.Id
                         join d in _iKichThuocRepository.GetAll() on a.IdKt equals d.Id
                         join e in _iMauSacRepository.GetAll() on a.IdMauSac equals e.Id
                         join g in _iNsxRepository.GetAll() on a.IdNsx equals g.Id
                         join h in _iLoaiSpRepository.GetAll() on a.IdLoaiSp equals h.Id
                         select new ViewQLChiTietSp()
                         { 
                             Id = a.Id,
                             Ma = a.Ma,
                             Ten = b.Ten,
                             Nsx = g.Ten,
                             MauSac = e.Ten,
                             LoaiSp = h.Ten,
                             KichThuoc = d.Size,
                             ChatLieu = c.Ten,
                             Anh = a.Anh,
                             MoTa = a.MoTa,
                             SoLuongTon = a.SoLuongTon,
                             GiaNhap = a.GiaNhap,
                             GiaBan = a.GiaBan,
                             TrangThai = a.TrangThai,
                         } 
                         ).ToList();
            return listView;
        }

        public List<ViewQLChiTietSp> GetAllView(string s)
        {
            if (s == null) return GetAllView();
            return GetAllView().Where(c => c.Ten.ToLower().Contains(s.ToLower()) || c.Nsx.ToLower().Contains(s.ToLower()) || c.MauSac.ToLower().Contains(s.ToLower()) || c.LoaiSp.ToLower().Contains(s.ToLower()) || c.KichThuoc.ToLower().Contains(s.ToLower()) || c.ChatLieu.ToLower().Contains(s.ToLower())).ToList();
        }

        public ChiTietSp GetByID(Guid id)
        {
            throw new NotImplementedException();
        }

        public string Update(ChiTietSp obj)
        {
            if (obj == null) return "Sửa thất bại";
            var tempobj = obj;
            if (_iChiTietSpRepository.Update(tempobj)) return "Sửa thành công";
            return "Sửa thất bại";
        }
    }
}

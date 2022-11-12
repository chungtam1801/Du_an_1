﻿using System;
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
    public class QLPhuongThucThanhToanServices : IQLPhuongThucThanhToanServices
    {
        private IPhuongThucThanhToanRepository _iPhuongThucThanhToanRepository;
        public QLPhuongThucThanhToanServices()
        {
            _iPhuongThucThanhToanRepository = new PhuongThucThanhToanRepository();
        }
        public string Add(PhuongThucThanhToan obj)
        {
            if (obj == null) return "Thêm thất bại";
            var tempobj = obj;
            if (_iPhuongThucThanhToanRepository.Add(tempobj)) return "Thêm thành công";
            return "Thêm thất bại";
        }

        public string Delete(PhuongThucThanhToan obj)
        {
            if (obj == null) return "Xóa thất bại";
            var tempobj = obj;
            if (_iPhuongThucThanhToanRepository.Delete(tempobj)) return "Xóa thành công";
            return "Xóa thất bại";
        }

        public List<PhuongThucThanhToan> GetAll()
        {
            return _iPhuongThucThanhToanRepository.GetAll();
        }

        public PhuongThucThanhToan GetByID(Guid id)
        {
            throw new NotImplementedException();
        }

        public string Update(PhuongThucThanhToan obj)
        {
            if (obj == null) return "Sửa thất bại";
            var tempobj = obj;
            if (_iPhuongThucThanhToanRepository.Update(tempobj)) return "Sửa thành công";
            return "Sửa thất bại";
        }
    }
}

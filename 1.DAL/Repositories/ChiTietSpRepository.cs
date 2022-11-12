﻿using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class ChiTietSpRepository : IChiTietSpRepository
    {
        private FpolyDBContext _dbContext;
        public ChiTietSpRepository()
        {
            _dbContext = new FpolyDBContext();
        }
        public bool Add(ChiTietSp obj)
        {
            if (obj == null) return false;
            obj.Id = Guid.NewGuid();//Tự động zen khóa chính
            _dbContext.ChiTietSps.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(ChiTietSp obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.ChiTietSps.FirstOrDefault(c => c.Id == obj.Id);

            _dbContext.Remove(tempobj);
            _dbContext.SaveChanges();
            return true;
        }

        public List<ChiTietSp> GetAll()
        {
            return _dbContext.ChiTietSps.ToList();
        }

        public ChiTietSp GetbyId(ChiTietSp id)
        {
            throw new NotImplementedException();
        }

        public bool Update(ChiTietSp obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.ChiTietSps.FirstOrDefault(c => c.Id == obj.Id);
            tempobj.Anh = obj.Anh;
            tempobj.MoTa = obj.MoTa;    
            tempobj.SoLuongTon= obj.SoLuongTon;
            tempobj.GiaNhap= obj.GiaNhap;
            tempobj.GiaBan= obj.GiaBan;
            tempobj.TrangThai= obj.TrangThai;
            
            //Còn bao nhiêu thuộc tính làm tương tự
            _dbContext.Update(tempobj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
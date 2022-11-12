using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;

namespace _1.DAL.Repositories
{
    public class ChatLieuRepository : IChatLieuRepository
    {
        private FpolyDBContext _dbContext;
        public ChatLieuRepository()
        {
            _dbContext = new FpolyDBContext();
        }
        public bool Add(ChatLieu obj)
        {
            if (obj == null) return false;
            obj.Id = Guid.NewGuid();//Tự động zen khóa chính
            _dbContext.ChatLieus.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(ChatLieu obj)
        {
            if(obj == null) return false;
            var tempobj = _dbContext.ChatLieus.FirstOrDefault(c => c.Id == obj.Id);

            _dbContext.Remove(tempobj);
            _dbContext.SaveChanges();
            return true;
        }

        public List<ChatLieu> GetAll()
        {
            return _dbContext.ChatLieus.ToList();
        }

        public ChatLieu GetbyId(ChatLieu id)
        {
            throw new NotImplementedException();
        }

        public bool Update(ChatLieu obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.ChatLieus.FirstOrDefault(c => c.Id == obj.Id);
            tempobj.Ma=obj.Ma;
            tempobj.Ten=obj.Ten;
            tempobj.TrangThai=obj.TrangThai;
            //Còn bao nhiêu thuộc tính làm tương tự
            _dbContext.Update(tempobj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}

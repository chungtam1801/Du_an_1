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
    public class QLChatLieuServices : IQLChatLieuServices
    {
        private IChatLieuRepository _iChatLieuRepository;
        public QLChatLieuServices()
        {
            _iChatLieuRepository = new ChatLieuRepository();
        }
        public string Add(ChatLieu obj)
        {
            if (obj == null) return "Thêm thất bại";
            var tempobj = obj;
            if (_iChatLieuRepository.Add(tempobj)) return "Thêm thành công";
            return "Thêm thất bại";
        }

        public string Delete(ChatLieu obj)
        {
            if (obj == null) return "Xóa thất bại";
            var tempobj = obj;
            if (_iChatLieuRepository.Delete(tempobj)) return "Xóa thành công";
            return "Xóa thất bại";
        }

        public List<ChatLieu> GetAll()
        {
            return _iChatLieuRepository.GetAll();
        }

        public ChatLieu GetByID(Guid id)
        {
            throw new NotImplementedException();
        }

        public string Update(ChatLieu obj)
        {
            if(obj == null) return "Sửa thất bại";
            var tempobj = obj;
            if (_iChatLieuRepository.Update(tempobj)) return "Sửa thành công";
            return "Sửa thất bại";
        }
    }
}

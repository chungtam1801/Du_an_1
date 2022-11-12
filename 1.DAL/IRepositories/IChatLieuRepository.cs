using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainClass;

namespace _1.DAL.IRepositories
{
    public interface IChatLieuRepository
    {
        bool Add(ChatLieu obj);
        bool Update(ChatLieu obj);
        bool Delete(ChatLieu obj);
        ChatLieu GetbyId(ChatLieu id);
        List<ChatLieu> GetAll();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainClass;

namespace _2.BUS.IServices
{
    public interface IQLChatLieuServices
    {
        string Add(ChatLieu obj);
        string Update(ChatLieu obj);
        string Delete(ChatLieu obj);
        List<ChatLieu> GetAll();
        ChatLieu GetByID(Guid id);
    }
}

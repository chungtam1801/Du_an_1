using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;

namespace _2.BUS.Services
{
    public class QuyDoiDiemServices
    {
        private IClassCRUDRepo<QuyDoiDiem> _CRUDQuyDoiDiem;
        public QuyDoiDiemServices()
        {
            _CRUDQuyDoiDiem = new QuyDoiDiemRepository();
        }
        public string QuyDoiDiem(decimal tien1,int diem,decimal tien2)
        {
            QuyDoiDiem temp = _CRUDQuyDoiDiem.GetAll().FirstOrDefault(c => c.TrangThai == 1);
            if(temp != null)
            {
                temp.TrangThai = 0;
                _CRUDQuyDoiDiem.Update(temp);
            }
            QuyDoiDiem quyDoiDiem = _CRUDQuyDoiDiem.GetAll().FirstOrDefault(c => c.TiLeTichDiem == tien1 && c.SoDiem == diem && c.TiLeTieuDiem == tien2);
            if(quyDoiDiem == null)
            {
                quyDoiDiem = new QuyDoiDiem();
                quyDoiDiem.TiLeTichDiem = tien1;
                quyDoiDiem.SoDiem = diem;
                quyDoiDiem.TiLeTieuDiem = tien2;
                quyDoiDiem.TrangThai = 1;
                if (_CRUDQuyDoiDiem.Add(quyDoiDiem)) return "Lưu thành công";
                else return "Lưu thất bại";
            }
            else
            {
                quyDoiDiem.TrangThai = 1;
                if (_CRUDQuyDoiDiem.Update(quyDoiDiem)) return "Lưu thành công";
                else return "Lưu thất bại";
            }
        }
        //public void SetQDD(QuyDoiDiem quyDoiDiem)
        //{
        //    QuyDoiDiem temp = _CRUDQuyDoiDiem.GetAll().FirstOrDefault(c => c.TrangThai == 1);
        //    if (temp != null)
        //    {
        //        temp.TrangThai = 0;
        //        _CRUDQuyDoiDiem.Update(temp);
        //    }
        //    quyDoiDiem.TrangThai = 1;
        //    _CRUDQuyDoiDiem.Update(quyDoiDiem);
        //}
        public List<QuyDoiDiem> GetAll()
        {
            return _CRUDQuyDoiDiem.GetAll();
        }
    }
}

using Business.Abstract;
using Core.Entities.Concrete;
using DataAccess.Abstract;

namespace Business.Concrete
{
    public class AdminManager : IAdminService
    {
        IAdminDal _adminDal;

        public AdminManager(IAdminDal adminDal)
        {
            _adminDal = adminDal;
        }

        public Admin Get(Admin admin)
        {
            return _adminDal.Get(a => a.UserName == admin.UserName && a.Password == admin.Password);
        }
    }
}

using Core.Entities.Concrete;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IAdminService
    {
        Admin Get(Admin admin);
    }
}

using eDrago.DAL.Models;

namespace eDrago.BLL.Interfaces
{
    public interface ILoginBusiness
    {
        ClienteLogin Login(Login login);
    }
}

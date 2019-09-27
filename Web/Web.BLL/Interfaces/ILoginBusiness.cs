using Web.DAL.Models;

namespace Web.BLL.Interfaces
{
    public interface ILoginBusiness
    {
        ClienteLogin Login(Login login);
    }
}

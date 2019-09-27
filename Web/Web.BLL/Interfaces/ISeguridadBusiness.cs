
namespace Web.BLL.Interfaces
{
    public interface ISeguridadBusiness
    {
        string EncriptarPassword(string cadena);
        string DesencriptarPassword(string cadena);
        string GetLocalIPAddress();
    }
}

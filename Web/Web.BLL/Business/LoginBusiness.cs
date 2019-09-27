using Web.BLL.Interfaces;
using Web.DAL.Models;
using System.Configuration;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;
using System;
using System.Web;

namespace Web.BLL.Business
{
    public class LoginBusiness : ILoginBusiness
    {
        public readonly ISeguridadBusiness _seguridadBusiness;

        public LoginBusiness()
        {
            _seguridadBusiness = new SeguridadBusiness();
        }

        readonly static string uri = ConfigurationManager.AppSettings["WEBApi"].ToString();

        public ClienteLogin Login(Login login)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(uri);

                    var request = string.Format("Autenticacion/Login?UserName={0}&Password={1}&Encrypt={2}", login.UserName, login.Password, false);
                    var stringContent = new StringContent("", Encoding.UTF8, "application/json");
                    var response = client.PostAsync(request, stringContent);

                    response.Wait();

                    var result = JsonConvert.DeserializeObject<JSONLogin>(response.Result.Content.ReadAsStringAsync().Result);

                    if (result != null)
                    {
                        HttpContext.Current.Response.Cookies.Add(new HttpCookie("JWT")
                        {
                            Value = result.authentication.token,
                            Expires = DateTime.UtcNow.AddMinutes(Convert.ToInt32(result.authentication.expires_in)),
                            HttpOnly = true
                        });

                        HttpContext.Current.Response.Cookies.Add(new HttpCookie("Token")
                        {
                            Value = result.authentication.token,
                            HttpOnly = true
                        });

                        HttpContext.Current.Response.Cookies.Add(new HttpCookie("Refresh_Token")
                        {
                            Value = result.authentication.refresh_token,
                            HttpOnly = true
                        });

                        return result.login;
                    }

                    return null;
                }
            }
            catch (Exception ex)
            {
                //DefaultLogger.Log("ERROR Login: ", ex);
                return null;
            }
        }
    }
}

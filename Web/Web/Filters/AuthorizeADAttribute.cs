using Web.DAL.Context;
using System.Collections.Generic;
using System.Configuration;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Security.Principal;

namespace Web.Filters
{
    interface ICustomPrincipal : IPrincipal
    {
        int Id { get; set; }
        string ClieAlias { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Email { get; set; }
    }

    public class CustomPrincipal : ICustomPrincipal
    {
        public IIdentity Identity { get; private set; }
        public bool IsInRole(string role) { return false; }

        public CustomPrincipal(string email)
        {
            this.Identity = new GenericIdentity(email);
        }

        public int Id { get; set; }
        public string ClieAlias { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }

    public class CustomPrincipalSerializeModel
    {
        public int Id { get; set; }
        public string ClieAlias { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }

}
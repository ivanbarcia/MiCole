using System.Data.Entity;
using Web.DAL.Models;

namespace Web.DAL.Context
{
    public class DataContext : DbContext
    {
        public DataContext()
            : base()
        {
            Database.SetInitializer<DataContext>(null);
        }
    }
}

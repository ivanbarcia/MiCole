using System.Data.Entity;

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

using System.Data.Entity;

namespace eDrago.DAL.Context
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

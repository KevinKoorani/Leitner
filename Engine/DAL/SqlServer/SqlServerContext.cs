using System.Data.Entity;
using Engine.DAL.Model;

namespace Engine.DAL.SqlServer
{
    public class SqlServerContext : DbContext
    {
        private static SqlServerContext _instance;
        public static SqlServerContext GetContext => _instance ?? (_instance = new SqlServerContext());

        private SqlServerContext() : base("Data Source=.;Initial Catalog=Leitner;Integrated Security=true")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<SqlServerContext>());
        }

        public DbSet<Data> Data { get; set; }
    }
}

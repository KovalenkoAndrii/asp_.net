using asp_th.Domain.Entites;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace asp_th.Domain
{
    public class MyDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionStringBuilder = new SqliteConnectionStringBuilder { DataSource = "asp_th_Db.db" };
            var connectionString = connectionStringBuilder.ToString();
            var connection = new SqliteConnection(connectionString);

            optionsBuilder.UseSqlite(connection);
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Operation> Operations { get; set; }
        public DbSet<Visit> Visits { get; set; }
    }
}

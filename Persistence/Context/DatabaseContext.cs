using App.DataBase;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Context
{
    public class DatabaseContext:DbContext, IDataBaseContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog = CleanDBContact;Integrated Security= True");
        }
        public DbSet<Contact> Contacts { get; set; }

    }
}

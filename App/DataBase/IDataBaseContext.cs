using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace App.DataBase
{
    public interface IDataBaseContext
    {
        public DbSet<Contact> Contacts { get; set; }
        public int SaveChanges();
    }
}

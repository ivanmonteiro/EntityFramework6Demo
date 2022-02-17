using Microsoft.EntityFrameworkCore;
using EntityFramework6Demo.Models;

namespace WebApplicationDemo.Data
{
    public class ContactsDbContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }

        public ContactsDbContext(DbContextOptions<ContactsDbContext> options)
            : base(options)
        { }
    }
}

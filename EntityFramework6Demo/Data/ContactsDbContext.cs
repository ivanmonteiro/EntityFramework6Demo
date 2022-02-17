using EntityFramework6Demo.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework6Demo.Data
{
    public class ContactsDbContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }

        public ContactsDbContext(DbContextOptions<ContactsDbContext> options)
            : base(options)
        { }
    }
}

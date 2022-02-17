using Microsoft.EntityFrameworkCore;
using WebApplicationDemo.Models;

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

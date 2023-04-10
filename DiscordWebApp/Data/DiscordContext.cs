using DiscordWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DiscordWebApp.Data
{
    public class DiscordContext : DbContext
    {

        public DiscordContext(DbContextOptions<DiscordContext> options) :base(options)
        
        {

        }
        public DbSet<Person> Persons { get; set; }
    }
}

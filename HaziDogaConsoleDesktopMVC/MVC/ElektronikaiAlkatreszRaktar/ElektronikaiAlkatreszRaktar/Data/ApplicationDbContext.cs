using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ElektronikaiAlkatreszRaktar.Models;

namespace ElektronikaiAlkatreszRaktar.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ElektronikaiAlkatreszRaktar.Models.Adatmodel> Adatmodel { get; set; }
    }
}
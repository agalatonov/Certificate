using Microsoft.EntityFrameworkCore;
using WebApi.Data.Models;

namespace WebApi.Data
{
    public class CertificateDbContext(DbContextOptions<CertificateDbContext> options) : DbContext(options)
    {
        public int GetMaxId { get { return Certificates.Any() ? Certificates.Max(x => x.Id) : 0; } }

        public DbSet<Certificate> Certificates { get; set; }
    }
}

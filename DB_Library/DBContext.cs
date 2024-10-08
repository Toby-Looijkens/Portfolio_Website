using Logic.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Library
{
    // Sql server connection string
    public class DBContext : DbContext
    {
        public DbSet<GalleryItem> Gallery { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Role> Roles { get; set; } = null!;
        public DbSet<ImageLink> ImageLinks { get; set; } = null!;
        public DbSet<DownloadLink> DownloadLinks { get; set; } = null!;

        public DBContext(DbContextOptions<DBContext> options)
        : base(options) { }

        public DBContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost; Database=S3-Site-DB;User Id = DESKTOP-6T3T1M6\\looij; Password=; TrustServerCertificate=true; Integrated Security = true;");
        }
    }
}

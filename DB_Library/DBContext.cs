using Logic.Entities;
using Microsoft.EntityFrameworkCore;
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
        string connectionString = "Server=localhost; Database=S3-Site-DB;User Id = DESKTOP-GHB40U5\\looij; Password=; TrustServerCertificate=true; Integrated Security = true;";
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
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}

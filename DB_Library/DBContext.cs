using Logic.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DB_Library
{
    // Sql server connection string
    public class DBContext : DbContext
    {
        public DbSet<GalleryItem> Gallery { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Role> Roles { get; set; } = null!;
        public DbSet<ImageLink> ImageFileLinks { get; set; } = null!;
        public DbSet<DownloadLink> DownloadableFileLinks { get; set; } = null!;
        public DbSet<Tag> Tags { get; set; } = null!;

        public DBContext(DbContextOptions<DBContext> options)
        : base(options) {  }

        public DBContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost; Database=S3-Site-DB;User Id = DESKTOP-6T3T1M6\\looij; Password=; TrustServerCertificate=true; Integrated Security = true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<GalleryItem>()
                .HasMany(x => x.Tags)
                .WithMany(x => x.GalleryItems)
                .UsingEntity(j => j.ToTable("GalleryItemTags"));


            modelBuilder.Entity<GalleryItem>().Property(x => x.ID).HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<Tag>().Property(x => x.ID).HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<User>().Property(x => x.ID).HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<Role>().Property(x => x.ID).HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<DownloadLink>().Property(x => x.ID).HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<ImageLink>().Property(x => x.ID).HasDefaultValueSql("NEWID()");
        }

        /*private void SetEntityBaseIdDefaultValue(ModelBuilder modelBuilder)
        {
            foreach (Type? entityType in modelBuilder.Model.GetEntityTypes()
                            .Where(etype => etype.ClrType != null)
                            .Where(etype => typeof(IBaseModel).IsAssignableFrom(etype.ClrType))
                            .Select(etype => etype.ClrType)
                    )
            {
                modelBuilder.Entity(entityType).Property("Id").HasDefaultValueSql("NEWSEQUENTIALID()");
            }
        }*/
    }
}

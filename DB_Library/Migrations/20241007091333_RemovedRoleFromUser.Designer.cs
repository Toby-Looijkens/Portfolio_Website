﻿// <auto-generated />
using System;
using DB_Library;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DB_Library.Migrations
{
    [DbContext(typeof(DBContext))]
    [Migration("20241007091333_RemovedRoleFromUser")]
    partial class RemovedRoleFromUser
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Logic.Entities.DownloadLink", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("GalleryItemID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("URL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("GalleryItemID");

                    b.ToTable("DownloadLinks");
                });

            modelBuilder.Entity("Logic.Entities.GalleryItem", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Hidden")
                        .HasColumnType("bit");

                    b.Property<Guid>("ThumbnailLinkID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("ThumbnailLinkID");

                    b.ToTable("Gallery");
                });

            modelBuilder.Entity("Logic.Entities.ImageLink", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("GalleryItemID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("URL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("GalleryItemID");

                    b.ToTable("ImageLinks");
                });

            modelBuilder.Entity("Logic.Entities.Role", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Logic.Entities.User", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Logic.Entities.DownloadLink", b =>
                {
                    b.HasOne("Logic.Entities.GalleryItem", null)
                        .WithMany("GalleryDownloadLinks")
                        .HasForeignKey("GalleryItemID");
                });

            modelBuilder.Entity("Logic.Entities.GalleryItem", b =>
                {
                    b.HasOne("Logic.Entities.ImageLink", "ThumbnailLink")
                        .WithMany()
                        .HasForeignKey("ThumbnailLinkID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ThumbnailLink");
                });

            modelBuilder.Entity("Logic.Entities.ImageLink", b =>
                {
                    b.HasOne("Logic.Entities.GalleryItem", null)
                        .WithMany("GalleryImageLinks")
                        .HasForeignKey("GalleryItemID");
                });

            modelBuilder.Entity("Logic.Entities.GalleryItem", b =>
                {
                    b.Navigation("GalleryDownloadLinks");

                    b.Navigation("GalleryImageLinks");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using Galaxy.Books.DataLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Galaxy.Books.DataLayer.Migrations
{
    [DbContext(typeof(BooksDbContext))]
    [Migration("20221009014158_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BookTag", b =>
                {
                    b.Property<Guid>("BooksBookId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TagsTagId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("BooksBookId", "TagsTagId");

                    b.HasIndex("TagsTagId");

                    b.ToTable("BookTag");
                });

            modelBuilder.Entity("Galaxy.Books.Domains.Author", b =>
                {
                    b.Property<Guid>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AuthorId");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("Galaxy.Books.Domains.Book", b =>
                {
                    b.Property<Guid>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("PublishedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Publisher")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("Galaxy.Books.Domains.BookAuthor", b =>
                {
                    b.Property<Guid>("BookId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AuthorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.HasKey("BookId", "AuthorId");

                    b.HasIndex("AuthorId");

                    b.ToTable("BookAuthor");
                });

            modelBuilder.Entity("Galaxy.Books.Domains.PriceOffer", b =>
                {
                    b.Property<Guid>("PriceOfferId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BookId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("NewPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PromotionalText")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PriceOfferId");

                    b.HasIndex("BookId")
                        .IsUnique();

                    b.ToTable("PriceOffers");
                });

            modelBuilder.Entity("Galaxy.Books.Domains.Review", b =>
                {
                    b.Property<Guid>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BookId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumStars")
                        .HasColumnType("int");

                    b.Property<string>("VoterName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReviewId");

                    b.HasIndex("BookId");

                    b.ToTable("Review");
                });

            modelBuilder.Entity("Galaxy.Books.Domains.Tag", b =>
                {
                    b.Property<Guid>("TagId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("TagId");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("BookTag", b =>
                {
                    b.HasOne("Galaxy.Books.Domains.Book", null)
                        .WithMany()
                        .HasForeignKey("BooksBookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Galaxy.Books.Domains.Tag", null)
                        .WithMany()
                        .HasForeignKey("TagsTagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Galaxy.Books.Domains.BookAuthor", b =>
                {
                    b.HasOne("Galaxy.Books.Domains.Author", "Author")
                        .WithMany("BooksLink")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Galaxy.Books.Domains.Book", "Book")
                        .WithMany("AuthorsLink")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Book");
                });

            modelBuilder.Entity("Galaxy.Books.Domains.PriceOffer", b =>
                {
                    b.HasOne("Galaxy.Books.Domains.Book", null)
                        .WithOne("Promotion")
                        .HasForeignKey("Galaxy.Books.Domains.PriceOffer", "BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Galaxy.Books.Domains.Review", b =>
                {
                    b.HasOne("Galaxy.Books.Domains.Book", null)
                        .WithMany("Reviews")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Galaxy.Books.Domains.Author", b =>
                {
                    b.Navigation("BooksLink");
                });

            modelBuilder.Entity("Galaxy.Books.Domains.Book", b =>
                {
                    b.Navigation("AuthorsLink");

                    b.Navigation("Promotion");

                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}

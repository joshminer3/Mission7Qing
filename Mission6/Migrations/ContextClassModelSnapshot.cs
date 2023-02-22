﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission6.Models;

#nullable disable

namespace Mission6.Migrations
{
    [DbContext(typeof(ContextClass))]
    partial class ContextClassModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.0");

            modelBuilder.Entity("Mission6.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryID = 1,
                            CategoryName = "Musical"
                        },
                        new
                        {
                            CategoryID = 2,
                            CategoryName = "Fantasy"
                        },
                        new
                        {
                            CategoryID = 3,
                            CategoryName = "Drama"
                        },
                        new
                        {
                            CategoryID = 4,
                            CategoryName = "Action"
                        },
                        new
                        {
                            CategoryID = 5,
                            CategoryName = "Comedy"
                        },
                        new
                        {
                            CategoryID = 6,
                            CategoryName = "Horror"
                        },
                        new
                        {
                            CategoryID = 7,
                            CategoryName = "Sports"
                        },
                        new
                        {
                            CategoryID = 8,
                            CategoryName = "Romance"
                        });
                });

            modelBuilder.Entity("Mission6.Models.MovieForm", b =>
                {
                    b.Property<int>("AppId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("TEXT");

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("AppId");

                    b.HasIndex("CategoryID");

                    b.ToTable("Responses");

                    b.HasData(
                        new
                        {
                            AppId = 1,
                            CategoryID = 1,
                            Director = "Richard Linklatler",
                            Edited = true,
                            LentTo = "Josh",
                            Notes = "Great Movie",
                            Rating = "PG-13",
                            Title = "School of Rock",
                            Year = 2003
                        },
                        new
                        {
                            AppId = 2,
                            CategoryID = 2,
                            Director = "Peter Jackson",
                            Edited = true,
                            LentTo = "Josh",
                            Notes = "Fantastic Movie",
                            Rating = "PG-13",
                            Title = "Lord of the Rings",
                            Year = 2001
                        },
                        new
                        {
                            AppId = 3,
                            CategoryID = 3,
                            Director = "Damien Chazelle",
                            Edited = true,
                            LentTo = "Josh",
                            Notes = "Amazing Film",
                            Rating = "R",
                            Title = "Whiplash",
                            Year = 2014
                        });
                });

            modelBuilder.Entity("Mission6.Models.MovieForm", b =>
                {
                    b.HasOne("Mission6.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}

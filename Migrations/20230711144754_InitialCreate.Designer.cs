﻿// <auto-generated />
using System;
using CommonReviewApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CommonReviewApp.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230711144754_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CommonReviewApp.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("CommonReviewApp.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("CommonReviewApp.Models.Owner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Owners");
                });

            modelBuilder.Entity("CommonReviewApp.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<int>("ReviewerId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ThingId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ReviewerId");

                    b.HasIndex("ThingId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("CommonReviewApp.Models.Reviewer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Reviewers");
                });

            modelBuilder.Entity("CommonReviewApp.Models.Thing", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Things");
                });

            modelBuilder.Entity("CommonReviewApp.Models.ThingCategory", b =>
                {
                    b.Property<int>("ThingId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int?>("ThingCategoryCategoryId")
                        .HasColumnType("int");

                    b.Property<int?>("ThingCategoryThingId")
                        .HasColumnType("int");

                    b.HasKey("ThingId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ThingCategoryThingId", "ThingCategoryCategoryId");

                    b.ToTable("ThingCategories");
                });

            modelBuilder.Entity("CommonReviewApp.Models.ThingOwner", b =>
                {
                    b.Property<int>("ThingId")
                        .HasColumnType("int");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.HasKey("ThingId", "OwnerId");

                    b.HasIndex("OwnerId");

                    b.ToTable("ThingOwners");
                });

            modelBuilder.Entity("CommonReviewApp.Models.Owner", b =>
                {
                    b.HasOne("CommonReviewApp.Models.Country", "Country")
                        .WithMany("Owners")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("CommonReviewApp.Models.Review", b =>
                {
                    b.HasOne("CommonReviewApp.Models.Reviewer", "Reviewer")
                        .WithMany("Reviews")
                        .HasForeignKey("ReviewerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CommonReviewApp.Models.Thing", "Thing")
                        .WithMany("Reviews")
                        .HasForeignKey("ThingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Reviewer");

                    b.Navigation("Thing");
                });

            modelBuilder.Entity("CommonReviewApp.Models.ThingCategory", b =>
                {
                    b.HasOne("CommonReviewApp.Models.Category", "Category")
                        .WithMany("ThingCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CommonReviewApp.Models.Thing", "Thing")
                        .WithMany("ThingCategories")
                        .HasForeignKey("ThingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CommonReviewApp.Models.ThingCategory", null)
                        .WithMany("ThingCategories")
                        .HasForeignKey("ThingCategoryThingId", "ThingCategoryCategoryId");

                    b.Navigation("Category");

                    b.Navigation("Thing");
                });

            modelBuilder.Entity("CommonReviewApp.Models.ThingOwner", b =>
                {
                    b.HasOne("CommonReviewApp.Models.Owner", "Owner")
                        .WithMany("ThingOwners")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CommonReviewApp.Models.Thing", "Thing")
                        .WithMany("ThingOwners")
                        .HasForeignKey("ThingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");

                    b.Navigation("Thing");
                });

            modelBuilder.Entity("CommonReviewApp.Models.Category", b =>
                {
                    b.Navigation("ThingCategories");
                });

            modelBuilder.Entity("CommonReviewApp.Models.Country", b =>
                {
                    b.Navigation("Owners");
                });

            modelBuilder.Entity("CommonReviewApp.Models.Owner", b =>
                {
                    b.Navigation("ThingOwners");
                });

            modelBuilder.Entity("CommonReviewApp.Models.Reviewer", b =>
                {
                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("CommonReviewApp.Models.Thing", b =>
                {
                    b.Navigation("Reviews");

                    b.Navigation("ThingCategories");

                    b.Navigation("ThingOwners");
                });

            modelBuilder.Entity("CommonReviewApp.Models.ThingCategory", b =>
                {
                    b.Navigation("ThingCategories");
                });
#pragma warning restore 612, 618
        }
    }
}

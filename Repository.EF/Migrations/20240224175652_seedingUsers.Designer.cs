﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository.EF;

#nullable disable

namespace Repository.EF.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20240224175652_seedingUsers")]
    partial class seedingUsers
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TrialRepository.Core.Models.Company", b =>
                {
                    b.Property<int>("CompanyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CompanyId"));

                    b.Property<string>("CompanyBranch")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("CompanyId");

                    b.ToTable("Companys");

                    b.HasData(
                        new
                        {
                            CompanyId = 1,
                            CompanyBranch = "Automotive",
                            CompanyName = "BMW"
                        },
                        new
                        {
                            CompanyId = 2,
                            CompanyBranch = "Software Services",
                            CompanyName = "Demeba"
                        },
                        new
                        {
                            CompanyId = 3,
                            CompanyBranch = "Automobile",
                            CompanyName = "DB"
                        });
                });

            modelBuilder.Entity("TrialRepository.Core.Models.Users", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("Confirm_Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Is_AgreeToPrivacy")
                        .HasColumnType("bit");

                    b.Property<bool?>("Is_AgreeToTerms")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            CompanyId = 1,
                            Confirm_Password = "123654",
                            Email = "a@fake.com",
                            FirstName = "Demo",
                            Is_AgreeToPrivacy = false,
                            Is_AgreeToTerms = true,
                            LastName = "Demo1",
                            Password = "123654",
                            UserName = "DemoFake1"
                        },
                        new
                        {
                            UserId = 2,
                            CompanyId = 2,
                            Confirm_Password = "123654",
                            Email = "b@fake.com",
                            FirstName = "Demo2",
                            Is_AgreeToPrivacy = false,
                            Is_AgreeToTerms = true,
                            LastName = "Demo2",
                            Password = "123654",
                            UserName = "DemoFake2"
                        },
                        new
                        {
                            UserId = 3,
                            CompanyId = 3,
                            Confirm_Password = "123654",
                            Email = "b@fake.com",
                            FirstName = "Demo3",
                            Is_AgreeToPrivacy = false,
                            Is_AgreeToTerms = true,
                            LastName = "Demo2 ",
                            Password = "123654",
                            UserName = "DemoFake3"
                        });
                });

            modelBuilder.Entity("TrialRepository.Core.Models.Users", b =>
                {
                    b.HasOne("TrialRepository.Core.Models.Company", null)
                        .WithMany("user")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TrialRepository.Core.Models.Company", b =>
                {
                    b.Navigation("user");
                });
#pragma warning restore 612, 618
        }
    }
}

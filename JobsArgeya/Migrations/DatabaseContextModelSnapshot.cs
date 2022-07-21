﻿// <auto-generated />
using System;
using JobsArgeya.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace JobsArgeya.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("JobsArgeya.Data.Entities.Apply", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("cvPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("faculty")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("internEndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("internStartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("isIntern")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("jobId")
                        .HasColumnType("int");

                    b.Property<int>("officeId")
                        .HasColumnType("int");

                    b.Property<string>("phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("resume")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("university")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Applies");
                });

            modelBuilder.Entity("JobsArgeya.Data.Entities.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OfficeId")
                        .HasColumnType("int");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subject")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Contact");
                });

            modelBuilder.Entity("JobsArgeya.Data.Entities.Jobs", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("isActive")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("jobContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("jobDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("jobKeywords")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("jobSlug")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("jobTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("officeId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Jobs");
                });

            modelBuilder.Entity("JobsArgeya.Data.Entities.MailSubscribers", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("slug")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("MailSubscribers");
                });

            modelBuilder.Entity("JobsArgeya.Data.Entities.Offices", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("officeDomain")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("officeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Offices");
                });

            modelBuilder.Entity("JobsArgeya.Data.Entities.Roles", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("roleName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("JobsArgeya.Data.Entities.Settings", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("adress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("facebook")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("instagram")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("keywords")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("linkedin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("logo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("officeId")
                        .HasColumnType("int");

                    b.Property<string>("phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("siteColor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("smtpPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("smtpPort")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("smtpServer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("smtpUsername")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("twitter")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("useSSL")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Settings");
                });

            modelBuilder.Entity("JobsArgeya.Data.Entities.Users", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("officeId")
                        .HasColumnType("int");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("roleId")
                        .HasColumnType("int");

                    b.Property<string>("surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}

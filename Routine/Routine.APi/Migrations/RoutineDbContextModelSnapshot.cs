﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Routine.APi.Data;

namespace Routine.APi.Migrations
{
    [DbContext(typeof(RoutineDbContext))]
    partial class RoutineDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Routine.APi.Entities.Company", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("BankruptTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Industry")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Introduction")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Product")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            Id = new Guid("bbdee09c-089b-4d30-bece-44df5923716c"),
                            Country = "USA",
                            Industry = "Internet",
                            Introduction = "Great Company",
                            Name = "Microsoft",
                            Product = "Software"
                        },
                        new
                        {
                            Id = new Guid("6fb600c1-9011-4fd7-9234-881379716440"),
                            Country = "USA",
                            Industry = "Internet",
                            Introduction = "Don't be evil",
                            Name = "Google",
                            Product = "Software"
                        },
                        new
                        {
                            Id = new Guid("5efc910b-2f45-43df-afee-620d40542853"),
                            Country = "CN",
                            Industry = "Internet",
                            Introduction = "Fubao Company",
                            Name = "Alipapa",
                            Product = "Software"
                        },
                        new
                        {
                            Id = new Guid("8cc04f96-2c42-4f76-832e-1903835b0190"),
                            Country = "CN",
                            Industry = "Communication",
                            Introduction = "Building a Smart World of Everything",
                            Name = "Huawei",
                            Product = "Hardware"
                        },
                        new
                        {
                            Id = new Guid("d1f1f410-f563-4355-aa91-4774d693363f"),
                            Country = "CN",
                            Industry = "Communication",
                            Introduction = "Born for a fever",
                            Name = "Xiaomi",
                            Product = "Hardware"
                        },
                        new
                        {
                            Id = new Guid("19b8d0f9-4fdf-41ab-b172-f2d5d725b6d9"),
                            Country = "CN",
                            Industry = "Wine",
                            Introduction = "Great Wine",
                            Name = "Wuliangye",
                            Product = "Wine"
                        },
                        new
                        {
                            Id = new Guid("6c28b511-34f6-43b2-89f6-fa3dab77bcf9"),
                            Country = "JP",
                            Industry = "Textile",
                            Introduction = "Good clothes",
                            Name = "UNIQLO",
                            Product = "Costume"
                        },
                        new
                        {
                            Id = new Guid("4ab2b4af-45ce-41b3-8aed-5447c3140330"),
                            Country = "ESP",
                            Industry = "Textile",
                            Introduction = "Stylish clothes",
                            Name = "ZARA",
                            Product = "Costume"
                        },
                        new
                        {
                            Id = new Guid("cd11c117-551c-409f-80e9-c15d89fd7ca8"),
                            Country = "GER",
                            Industry = "Auto",
                            Introduction = "The best car",
                            Name = "Mercedes-Benz",
                            Product = "Car"
                        },
                        new
                        {
                            Id = new Guid("a39f7877-3849-48a1-b6af-e35b90c73e6a"),
                            Country = "GER",
                            Industry = "Auto",
                            Introduction = "Good car",
                            Name = "BMW",
                            Product = "Car"
                        },
                        new
                        {
                            Id = new Guid("eb8fc677-2600-4fdb-a8ef-51c006e7fc20"),
                            Country = "USA",
                            Industry = "Internet",
                            Introduction = "An American web services provider headquartered in Sunnyvale",
                            Name = "Yahoo!",
                            Product = "Software"
                        });
                });

            modelBuilder.Entity("Routine.APi.Entities.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmployeeNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ca268a19-0f39-4d8b-b8d6-5bace54f8027"),
                            CompanyId = new Guid("bbdee09c-089b-4d30-bece-44df5923716c"),
                            DateOfBirth = new DateTime(1955, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeNo = "M001",
                            FirstName = "William",
                            Gender = 1,
                            LastName = "Gates"
                        },
                        new
                        {
                            Id = new Guid("265348d2-1276-4ada-ae33-4c1b8348edce"),
                            CompanyId = new Guid("bbdee09c-089b-4d30-bece-44df5923716c"),
                            DateOfBirth = new DateTime(1998, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeNo = "M002",
                            FirstName = "Kent",
                            Gender = 1,
                            LastName = "Back"
                        },
                        new
                        {
                            Id = new Guid("47b70abc-98b8-4fdc-b9fa-5dd6716f6e6b"),
                            CompanyId = new Guid("6fb600c1-9011-4fd7-9234-881379716440"),
                            DateOfBirth = new DateTime(1986, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeNo = "G001",
                            FirstName = "Mary",
                            Gender = 0,
                            LastName = "King"
                        },
                        new
                        {
                            Id = new Guid("059e2fcb-e5a4-4188-9b46-06184bcb111b"),
                            CompanyId = new Guid("6fb600c1-9011-4fd7-9234-881379716440"),
                            DateOfBirth = new DateTime(1977, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeNo = "G002",
                            FirstName = "Kevin",
                            Gender = 1,
                            LastName = "Richardson"
                        },
                        new
                        {
                            Id = new Guid("910e7452-c05f-4bf1-b084-6367873664a1"),
                            CompanyId = new Guid("6fb600c1-9011-4fd7-9234-881379716440"),
                            DateOfBirth = new DateTime(1982, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeNo = "G003",
                            FirstName = "Frederic",
                            Gender = 1,
                            LastName = "Pullan"
                        },
                        new
                        {
                            Id = new Guid("a868ff18-3398-4598-b420-4878974a517a"),
                            CompanyId = new Guid("5efc910b-2f45-43df-afee-620d40542853"),
                            DateOfBirth = new DateTime(1964, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeNo = "A001",
                            FirstName = "Jack",
                            Gender = 1,
                            LastName = "Ma"
                        },
                        new
                        {
                            Id = new Guid("2c3bb40c-5907-4eb7-bb2c-7d62edb430c9"),
                            CompanyId = new Guid("5efc910b-2f45-43df-afee-620d40542853"),
                            DateOfBirth = new DateTime(1997, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeNo = "A002",
                            FirstName = "Lorraine",
                            Gender = 0,
                            LastName = "Shaw"
                        },
                        new
                        {
                            Id = new Guid("e32c33a7-df20-4b9a-a540-414192362d52"),
                            CompanyId = new Guid("5efc910b-2f45-43df-afee-620d40542853"),
                            DateOfBirth = new DateTime(2000, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeNo = "A003",
                            FirstName = "Abel",
                            Gender = 0,
                            LastName = "Obadiah"
                        },
                        new
                        {
                            Id = new Guid("3fae0ed7-5391-460a-8320-6b0255b62b72"),
                            CompanyId = new Guid("8cc04f96-2c42-4f76-832e-1903835b0190"),
                            DateOfBirth = new DateTime(1972, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeNo = "H001",
                            FirstName = "Alexia",
                            Gender = 0,
                            LastName = "More"
                        },
                        new
                        {
                            Id = new Guid("1b863e75-8bd8-4876-8292-e99998bfa4b1"),
                            CompanyId = new Guid("8cc04f96-2c42-4f76-832e-1903835b0190"),
                            DateOfBirth = new DateTime(1999, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeNo = "H002",
                            FirstName = "Barton",
                            Gender = 0,
                            LastName = "Robin"
                        },
                        new
                        {
                            Id = new Guid("c8353598-5b34-4529-a02b-dc7e9f93e59b"),
                            CompanyId = new Guid("8cc04f96-2c42-4f76-832e-1903835b0190"),
                            DateOfBirth = new DateTime(1990, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeNo = "H003",
                            FirstName = "Ted",
                            Gender = 1,
                            LastName = "Howard"
                        },
                        new
                        {
                            Id = new Guid("ca86eded-a704-4fbc-8d5e-979761a2e0b8"),
                            CompanyId = new Guid("8cc04f96-2c42-4f76-832e-1903835b0190"),
                            DateOfBirth = new DateTime(2000, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeNo = "M003",
                            FirstName = "Victor",
                            Gender = 1,
                            LastName = "Burns"
                        });
                });

            modelBuilder.Entity("Routine.APi.Entities.Employee", b =>
                {
                    b.HasOne("Routine.APi.Entities.Company", "Company")
                        .WithMany("Employees")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

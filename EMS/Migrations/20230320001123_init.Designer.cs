﻿// <auto-generated />
using System;
using EMS.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EMS.Migrations
{
    [DbContext(typeof(EMSDbContext))]
    [Migration("20230320001123_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EMS.Models.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartmentId"), 1L, 1);

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DepartmentId");

                    b.ToTable("Department");

                    b.HasData(
                        new
                        {
                            DepartmentId = 1,
                            DepartmentName = "Human Resources"
                        },
                        new
                        {
                            DepartmentId = 2,
                            DepartmentName = "Information Technology"
                        },
                        new
                        {
                            DepartmentId = 3,
                            DepartmentName = "Finance"
                        },
                        new
                        {
                            DepartmentId = 4,
                            DepartmentName = "Marketing"
                        },
                        new
                        {
                            DepartmentId = 5,
                            DepartmentName = "Operations Management"
                        });
                });

            modelBuilder.Entity("EMS.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"), 1L, 1);

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("EmployeeId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeId = 1,
                            DOB = new DateTime(2003, 3, 20, 8, 11, 23, 672, DateTimeKind.Local).AddTicks(4811),
                            DepartmentId = 1,
                            Email = "juan@gmail.com",
                            EmployeeName = "Juan Dela Cruz",
                            Phone = "09123456789"
                        },
                        new
                        {
                            EmployeeId = 2,
                            DOB = new DateTime(2003, 3, 20, 8, 11, 23, 672, DateTimeKind.Local).AddTicks(4828),
                            DepartmentId = 2,
                            Email = "maria@gmail.com",
                            EmployeeName = "Maria Clara",
                            Phone = "12345678912"
                        });
                });

            modelBuilder.Entity("EMS.Models.Employee", b =>
                {
                    b.HasOne("EMS.Models.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("EMS.Models.Department", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}

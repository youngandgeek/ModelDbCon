﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ModelDbCon.Models;

namespace ModelDbCon.Migrations
{
    [DbContext(typeof(DbConClass))]
    [Migration("20231204133141_new dept_name")]
    partial class newdept_name
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ModelDbCon.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Degree")
                        .HasColumnType("int");

                    b.Property<int>("MinDegree")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("deptId")
                        .HasColumnType("int");

                    b.Property<string>("dept_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("dept_id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("deptId");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("ModelDbCon.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ManagerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("ModelDbCon.Models.Instructor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Salary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("course_id")
                        .HasColumnType("int");

                    b.Property<int?>("crsId")
                        .HasColumnType("int");

                    b.Property<int?>("deptId")
                        .HasColumnType("int");

                    b.Property<int>("dept_id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("crsId");

                    b.HasIndex("deptId");

                    b.ToTable("Instructor");
                });

            modelBuilder.Entity("ModelDbCon.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("Dept")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Dept");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("ModelDbCon.Models.Course", b =>
                {
                    b.HasOne("ModelDbCon.Models.Department", "dept")
                        .WithMany()
                        .HasForeignKey("deptId");

                    b.Navigation("dept");
                });

            modelBuilder.Entity("ModelDbCon.Models.Instructor", b =>
                {
                    b.HasOne("ModelDbCon.Models.Course", "crs")
                        .WithMany()
                        .HasForeignKey("crsId");

                    b.HasOne("ModelDbCon.Models.Department", "dept")
                        .WithMany()
                        .HasForeignKey("deptId");

                    b.Navigation("crs");

                    b.Navigation("dept");
                });

            modelBuilder.Entity("ModelDbCon.Models.Student", b =>
                {
                    b.HasOne("ModelDbCon.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("Dept")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });
#pragma warning restore 612, 618
        }
    }
}
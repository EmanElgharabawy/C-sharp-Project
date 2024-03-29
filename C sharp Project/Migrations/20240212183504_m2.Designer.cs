﻿// <auto-generated />
using System;
using C_sharp_Project.YoussifMohamed.Model.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace C_sharp_Project.Migrations
{
    [DbContext(typeof(ClinicDB))]
    [Migration("20240212183504_m2")]
    partial class m2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("C_sharp_Project.YoussifMohamed.Model.Entity.Doctor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("department")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Id");

                    b.ToTable("Doctor");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Cairo",
                            Name = "Eman",
                            Phone = "012345698715",
                            department = "Surgery Department",
                            password = "Doctor123"
                        });
                });

            modelBuilder.Entity("C_sharp_Project.YoussifMohamed.Model.Entity.Doctorspatient", b =>
                {
                    b.Property<int>("PatientID")
                        .HasColumnType("int");

                    b.Property<int>("DoctorID")
                        .HasColumnType("int");

                    b.Property<string>("Diagnosis")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Medicine")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("PatientID", "DoctorID");

                    b.HasIndex("DoctorID");

                    b.ToTable("Doctorspatient");
                });

            modelBuilder.Entity("C_sharp_Project.YoussifMohamed.Model.Entity.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RecipID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RecipID");

                    b.ToTable("Patient");
                });

            modelBuilder.Entity("C_sharp_Project.YoussifMohamed.Model.Entity.PatientTests", b =>
                {
                    b.Property<int>("PatientID")
                        .HasColumnType("int");

                    b.Property<int>("TestsID")
                        .HasColumnType("int");

                    b.Property<string>("Results")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("PatientID", "TestsID");

                    b.HasIndex("TestsID");

                    b.ToTable("PatientTests");
                });

            modelBuilder.Entity("C_sharp_Project.YoussifMohamed.Model.Entity.Reciptionist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Reciptionist");
                });

            modelBuilder.Entity("C_sharp_Project.YoussifMohamed.Model.Entity.Tests", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Price")
                        .HasMaxLength(5)
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Tests");
                });

            modelBuilder.Entity("C_sharp_Project.YoussifMohamed.Model.Entity.Doctorspatient", b =>
                {
                    b.HasOne("C_sharp_Project.YoussifMohamed.Model.Entity.Doctor", "Doctor")
                        .WithMany()
                        .HasForeignKey("DoctorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("C_sharp_Project.YoussifMohamed.Model.Entity.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("C_sharp_Project.YoussifMohamed.Model.Entity.Patient", b =>
                {
                    b.HasOne("C_sharp_Project.YoussifMohamed.Model.Entity.Reciptionist", "Reciptionist")
                        .WithMany("Patient")
                        .HasForeignKey("RecipID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Reciptionist");
                });

            modelBuilder.Entity("C_sharp_Project.YoussifMohamed.Model.Entity.PatientTests", b =>
                {
                    b.HasOne("C_sharp_Project.YoussifMohamed.Model.Entity.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("C_sharp_Project.YoussifMohamed.Model.Entity.Tests", "Tests")
                        .WithMany()
                        .HasForeignKey("TestsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Patient");

                    b.Navigation("Tests");
                });

            modelBuilder.Entity("C_sharp_Project.YoussifMohamed.Model.Entity.Reciptionist", b =>
                {
                    b.Navigation("Patient");
                });
#pragma warning restore 612, 618
        }
    }
}

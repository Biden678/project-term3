﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Signup.Models;

#nullable disable

namespace Signup.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20231129155316_epro3p1")]
    partial class epro3p1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Signup.Models.Product", b =>
                {
                    b.Property<int>("Id_Product")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Product"), 1L, 1);

                    b.Property<string>("Contract_Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Damages")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Date_From")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Date_To")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id_Type_Insurance")
                        .HasColumnType("int");

                    b.Property<int>("Level_Responsibility_For_People")
                        .HasColumnType("int");

                    b.Property<int>("Level_Responsibility_For_The_Property")
                        .HasColumnType("int");

                    b.Property<int>("Limited_Years")
                        .HasColumnType("int");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int?>("Type_InsuranceId_Type_Insurance")
                        .HasColumnType("int");

                    b.Property<int>("VAT")
                        .HasColumnType("int");

                    b.HasKey("Id_Product");

                    b.HasIndex("Type_InsuranceId_Type_Insurance");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Signup.Models.Type_Insurance", b =>
                {
                    b.Property<int>("Id_Type_Insurance")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Type_Insurance"), 1L, 1);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id_Type_Insurance");

                    b.ToTable("Type_Insurances");
                });

            modelBuilder.Entity("Signup.Models.Type_Service", b =>
                {
                    b.Property<int>("Id_Type_Service")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Type_Service"), 1L, 1);

                    b.Property<int>("Id_Type_Insurance")
                        .HasColumnType("int");

                    b.Property<string>("Name_Service")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int?>("Type_InsuranceId_Type_Insurance")
                        .HasColumnType("int");

                    b.HasKey("Id_Type_Service");

                    b.HasIndex("Type_InsuranceId_Type_Insurance");

                    b.ToTable("Type_Services");
                });

            modelBuilder.Entity("Signup.Models.Users", b =>
                {
                    b.Property<int>("Cus_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Cus_Id"), 1L, 1);

                    b.Property<string>("Cus_ADD")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<string>("Cus_Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cus_Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Cus_Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cus_Phone")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Cus_Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Signup.Models.Product", b =>
                {
                    b.HasOne("Signup.Models.Type_Insurance", "Type_Insurance")
                        .WithMany()
                        .HasForeignKey("Type_InsuranceId_Type_Insurance");

                    b.Navigation("Type_Insurance");
                });

            modelBuilder.Entity("Signup.Models.Type_Service", b =>
                {
                    b.HasOne("Signup.Models.Type_Insurance", "Type_Insurance")
                        .WithMany("Type_Services")
                        .HasForeignKey("Type_InsuranceId_Type_Insurance");

                    b.Navigation("Type_Insurance");
                });

            modelBuilder.Entity("Signup.Models.Type_Insurance", b =>
                {
                    b.Navigation("Type_Services");
                });
#pragma warning restore 612, 618
        }
    }
}
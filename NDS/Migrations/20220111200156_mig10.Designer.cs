﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NDS.Models.Context;

namespace NDS.Migrations
{
    [DbContext(typeof(NDSDbContext))]
    [Migration("20220111200156_mig10")]
    partial class mig10
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("NDS.Models.Domain.AdminUser", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tbl_AdminUser");
                });

            modelBuilder.Entity("NDS.Models.Domain.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("FkProvinceId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FkProvinceId");

                    b.ToTable("Tbl_City");
                });

            modelBuilder.Entity("NDS.Models.Domain.Customer", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FkCityId")
                        .HasColumnType("int");

                    b.Property<int>("FkProvinceId")
                        .HasColumnType("int");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("latitude")
                        .HasColumnType("float");

                    b.Property<double>("longitude")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("FkCityId");

                    b.HasIndex("FkProvinceId");

                    b.ToTable("Tbl_Customer");
                });

            modelBuilder.Entity("NDS.Models.Domain.Order", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CompleteDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("FkCustomerId")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsComplete")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<long>("TotalPrice")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("FkCustomerId");

                    b.ToTable("Tbl_Order");
                });

            modelBuilder.Entity("NDS.Models.Domain.OrderDetails", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("FkOrderId")
                        .HasColumnType("bigint");

                    b.Property<long>("FkProductId")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FkOrderId");

                    b.HasIndex("FkProductId");

                    b.ToTable("Tbl_OrderDetails");
                });

            modelBuilder.Entity("NDS.Models.Domain.Payment", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("FkCustomerId")
                        .HasColumnType("bigint");

                    b.Property<long>("FkOrderId")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<long>("Price")
                        .HasColumnType("bigint");

                    b.Property<string>("RefCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FkCustomerId");

                    b.HasIndex("FkOrderId");

                    b.ToTable("Tbl_Payment");
                });

            modelBuilder.Entity("NDS.Models.Domain.Product", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeliverDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("FkSupplierId")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsExist")
                        .HasColumnType("bit");

                    b.Property<long>("Price")
                        .HasColumnType("bigint");

                    b.Property<int>("ProductType")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FkSupplierId");

                    b.ToTable("Tbl_Product");
                });

            modelBuilder.Entity("NDS.Models.Domain.Province", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tbl_Province");
                });

            modelBuilder.Entity("NDS.Models.Domain.PublishPlan", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeliveryDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("FkCustomerId")
                        .HasColumnType("bigint");

                    b.Property<long>("FkProductId")
                        .HasColumnType("bigint");

                    b.Property<long>("FkStaffId")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FkCustomerId");

                    b.HasIndex("FkProductId");

                    b.HasIndex("FkStaffId");

                    b.ToTable("Tbl_PublishPlan");
                });

            modelBuilder.Entity("NDS.Models.Domain.Staff", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NationalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tbl_Staff");
                });

            modelBuilder.Entity("NDS.Models.Domain.StaffSessionReady", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("FkStaffId")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("SessionDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("SessionReadyStatus")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FkStaffId");

                    b.ToTable("Tbl_StaffSessionReady");
                });

            modelBuilder.Entity("NDS.Models.Domain.Supplier", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("FkCityId")
                        .HasColumnType("int");

                    b.Property<int>("FkProvinceId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Tel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FkCityId");

                    b.HasIndex("FkProvinceId");

                    b.ToTable("Tbl_Supplier");
                });

            modelBuilder.Entity("NDS.Models.Domain.Transaction", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Price")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Tbl_Transaction");
                });

            modelBuilder.Entity("NDS.Models.Domain.City", b =>
                {
                    b.HasOne("NDS.Models.Domain.Province", "Tbl_Province")
                        .WithMany()
                        .HasForeignKey("FkProvinceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tbl_Province");
                });

            modelBuilder.Entity("NDS.Models.Domain.Customer", b =>
                {
                    b.HasOne("NDS.Models.Domain.City", "Tbl_City")
                        .WithMany()
                        .HasForeignKey("FkCityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NDS.Models.Domain.Province", "Tbl_Province")
                        .WithMany()
                        .HasForeignKey("FkProvinceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tbl_City");

                    b.Navigation("Tbl_Province");
                });

            modelBuilder.Entity("NDS.Models.Domain.Order", b =>
                {
                    b.HasOne("NDS.Models.Domain.Customer", "Tbl_Customer")
                        .WithMany()
                        .HasForeignKey("FkCustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tbl_Customer");
                });

            modelBuilder.Entity("NDS.Models.Domain.OrderDetails", b =>
                {
                    b.HasOne("NDS.Models.Domain.Order", "Tbl_Order")
                        .WithMany()
                        .HasForeignKey("FkOrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NDS.Models.Domain.Product", "Tbl_Product")
                        .WithMany()
                        .HasForeignKey("FkProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tbl_Order");

                    b.Navigation("Tbl_Product");
                });

            modelBuilder.Entity("NDS.Models.Domain.Payment", b =>
                {
                    b.HasOne("NDS.Models.Domain.Customer", "Tbl_Customer")
                        .WithMany()
                        .HasForeignKey("FkCustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NDS.Models.Domain.Order", "Tbl_Order")
                        .WithMany()
                        .HasForeignKey("FkOrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tbl_Customer");

                    b.Navigation("Tbl_Order");
                });

            modelBuilder.Entity("NDS.Models.Domain.Product", b =>
                {
                    b.HasOne("NDS.Models.Domain.Supplier", "Tbl_Supplier")
                        .WithMany()
                        .HasForeignKey("FkSupplierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tbl_Supplier");
                });

            modelBuilder.Entity("NDS.Models.Domain.PublishPlan", b =>
                {
                    b.HasOne("NDS.Models.Domain.Customer", "Tbl_Customer")
                        .WithMany()
                        .HasForeignKey("FkCustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NDS.Models.Domain.Product", "Tbl_Product")
                        .WithMany()
                        .HasForeignKey("FkProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NDS.Models.Domain.Staff", "Tbl_Staff")
                        .WithMany()
                        .HasForeignKey("FkStaffId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tbl_Customer");

                    b.Navigation("Tbl_Product");

                    b.Navigation("Tbl_Staff");
                });

            modelBuilder.Entity("NDS.Models.Domain.StaffSessionReady", b =>
                {
                    b.HasOne("NDS.Models.Domain.Staff", "Tbl_Staff")
                        .WithMany()
                        .HasForeignKey("FkStaffId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tbl_Staff");
                });

            modelBuilder.Entity("NDS.Models.Domain.Supplier", b =>
                {
                    b.HasOne("NDS.Models.Domain.City", "Tbl_City")
                        .WithMany()
                        .HasForeignKey("FkCityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NDS.Models.Domain.Province", "Tbl_Province")
                        .WithMany()
                        .HasForeignKey("FkProvinceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tbl_City");

                    b.Navigation("Tbl_Province");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebInventoryManagementSystem_IT703_2016012187.Data;

#nullable disable

namespace WebInventoryManagementSystem_IT703_2016012187.Migrations
{
    [DbContext(typeof(WebInventoryManagementSystem_IT703_2016012187Context))]
    [Migration("20220917023310_nullables")]
    partial class nullables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WebInventoryManagementSystem_IT703_2016012187.Models.Brand", b =>
                {
                    b.Property<int>("BrandId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BrandId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BrandId");

                    b.ToTable("Brand");
                });

            modelBuilder.Entity("WebInventoryManagementSystem_IT703_2016012187.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("WebInventoryManagementSystem_IT703_2016012187.Models.Client", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClientId"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClientId");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("WebInventoryManagementSystem_IT703_2016012187.Models.IncomingOrder", b =>
                {
                    b.Property<int>("IncomingOrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IncomingOrderId"), 1L, 1);

                    b.Property<int?>("InventoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderedOn")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ReceivedOn")
                        .HasColumnType("datetime2");

                    b.Property<int?>("SupplierId")
                        .HasColumnType("int");

                    b.HasKey("IncomingOrderId");

                    b.HasIndex("InventoryId");

                    b.HasIndex("ProductId");

                    b.HasIndex("SupplierId");

                    b.ToTable("IncomingOrder");
                });

            modelBuilder.Entity("WebInventoryManagementSystem_IT703_2016012187.Models.Inventory", b =>
                {
                    b.Property<int>("InventoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InventoryId"), 1L, 1);

                    b.Property<int?>("LocationId")
                        .HasColumnType("int");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("InventoryId");

                    b.HasIndex("LocationId");

                    b.HasIndex("ProductId");

                    b.ToTable("Inventory");
                });

            modelBuilder.Entity("WebInventoryManagementSystem_IT703_2016012187.Models.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LocationId"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LocationId");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("WebInventoryManagementSystem_IT703_2016012187.Models.OutgoingOrder", b =>
                {
                    b.Property<int>("OutgoingOrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OutgoingOrderId"), 1L, 1);

                    b.Property<int?>("ClientId")
                        .HasColumnType("int");

                    b.Property<int?>("InventoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderedOn")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ReceivedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("OutgoingOrderId");

                    b.HasIndex("ClientId");

                    b.HasIndex("InventoryId");

                    b.HasIndex("ProductId");

                    b.ToTable("OutgoingOrder");
                });

            modelBuilder.Entity("WebInventoryManagementSystem_IT703_2016012187.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"), 1L, 1);

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SKU")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductId");

                    b.HasIndex("BrandId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("WebInventoryManagementSystem_IT703_2016012187.Models.Supplier", b =>
                {
                    b.Property<int>("SupplierId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SupplierId"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SupplierId");

                    b.ToTable("Supplier");
                });

            modelBuilder.Entity("WebInventoryManagementSystem_IT703_2016012187.Models.IncomingOrder", b =>
                {
                    b.HasOne("WebInventoryManagementSystem_IT703_2016012187.Models.Inventory", "Inventory")
                        .WithMany()
                        .HasForeignKey("InventoryId");

                    b.HasOne("WebInventoryManagementSystem_IT703_2016012187.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.HasOne("WebInventoryManagementSystem_IT703_2016012187.Models.Supplier", "Supplier")
                        .WithMany()
                        .HasForeignKey("SupplierId");

                    b.Navigation("Inventory");

                    b.Navigation("Product");

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("WebInventoryManagementSystem_IT703_2016012187.Models.Inventory", b =>
                {
                    b.HasOne("WebInventoryManagementSystem_IT703_2016012187.Models.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId");

                    b.HasOne("WebInventoryManagementSystem_IT703_2016012187.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.Navigation("Location");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("WebInventoryManagementSystem_IT703_2016012187.Models.OutgoingOrder", b =>
                {
                    b.HasOne("WebInventoryManagementSystem_IT703_2016012187.Models.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId");

                    b.HasOne("WebInventoryManagementSystem_IT703_2016012187.Models.Inventory", "Inventory")
                        .WithMany()
                        .HasForeignKey("InventoryId");

                    b.HasOne("WebInventoryManagementSystem_IT703_2016012187.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.Navigation("Client");

                    b.Navigation("Inventory");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("WebInventoryManagementSystem_IT703_2016012187.Models.Product", b =>
                {
                    b.HasOne("WebInventoryManagementSystem_IT703_2016012187.Models.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebInventoryManagementSystem_IT703_2016012187.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}

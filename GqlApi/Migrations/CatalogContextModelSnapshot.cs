﻿// <auto-generated />
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GqlApi.Migrations
{
    [DbContext(typeof(CatalogContext))]
    partial class CatalogContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Models.EnityFramework.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Brands", (string)null);
                });

            modelBuilder.Entity("Models.EnityFramework.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AvailableStock")
                        .HasColumnType("int");

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasMaxLength(2048)
                        .HasColumnType("nvarchar(2048)");

                    b.Property<string>("ImageFileName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<int>("MaxStockThreshold")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("OnReorder")
                        .HasColumnType("bit");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("RestockThreshold")
                        .HasColumnType("int");

                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("Name");

                    b.HasIndex("TypeId");

                    b.ToTable("Products", (string)null);
                });

            modelBuilder.Entity("Models.EnityFramework.ProductType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("ProductTypes", (string)null);
                });

            modelBuilder.Entity("Models.EnityFramework.Product", b =>
                {
                    b.HasOne("Models.EnityFramework.Brand", "Brand")
                        .WithMany("Products")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.EnityFramework.ProductType", "Type")
                        .WithMany("Products")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("Models.EnityFramework.Brand", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Models.EnityFramework.ProductType", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}

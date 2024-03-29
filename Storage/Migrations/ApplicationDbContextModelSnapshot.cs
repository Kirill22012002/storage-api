﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Storage.Context;

namespace Storage.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Storage.DbModels.Category", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    b.Property<string>("Title")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("title");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Storage.DbModels.Cell", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("title");

                    b.HasKey("Id");

                    b.ToTable("Cells");
                });

            modelBuilder.Entity("Storage.DbModels.Customer", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    b.Property<short?>("Age")
                        .HasColumnType("smallint")
                        .HasColumnName("age");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Storage.DbModels.CustomersProduct", b =>
                {
                    b.Property<long?>("IdCustomer")
                        .HasColumnType("bigint")
                        .HasColumnName("idCustomer");

                    b.Property<long?>("IdProduct")
                        .HasColumnType("bigint")
                        .HasColumnName("idProduct");

                    b.HasIndex("IdCustomer");

                    b.HasIndex("IdProduct");

                    b.ToTable("CustomersProducts");
                });

            modelBuilder.Entity("Storage.DbModels.Part", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    b.Property<int?>("Amount")
                        .HasColumnType("int")
                        .HasColumnName("amount");

                    b.Property<string>("Barcode")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("barcode");

                    b.Property<DateTime?>("Datefiling")
                        .HasColumnType("datetime")
                        .HasColumnName("datefiling");

                    b.Property<long?>("IdProduct")
                        .HasColumnType("bigint")
                        .HasColumnName("idProduct");

                    b.HasKey("Id");

                    b.HasIndex("IdProduct");

                    b.HasIndex(new[] { "Barcode" }, "UQ_Part_Barcode")
                        .IsUnique()
                        .HasFilter("[barcode] IS NOT NULL");

                    b.ToTable("Parts");
                });

            modelBuilder.Entity("Storage.DbModels.Product", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("title");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Storage.DbModels.ProductCategory", b =>
                {
                    b.Property<long?>("IdCategory")
                        .HasColumnType("bigint")
                        .HasColumnName("idCategory");

                    b.Property<long?>("IdProduct")
                        .HasColumnType("bigint")
                        .HasColumnName("idProduct");

                    b.HasIndex("IdCategory");

                    b.HasIndex("IdProduct");

                    b.ToTable("ProductCategory");
                });

            modelBuilder.Entity("Storage.DbModels.Record", b =>
                {
                    b.Property<long?>("IdCell")
                        .HasColumnType("bigint")
                        .HasColumnName("idCell");

                    b.Property<long?>("IdPart")
                        .HasColumnType("bigint")
                        .HasColumnName("idPart");

                    b.HasIndex("IdCell");

                    b.HasIndex("IdPart");

                    b.ToTable("Records");
                });

            modelBuilder.Entity("Storage.DbModels.CustomersProduct", b =>
                {
                    b.HasOne("Storage.DbModels.Customer", "IdCustomerNavigation")
                        .WithMany()
                        .HasForeignKey("IdCustomer")
                        .HasConstraintName("FK__Customers__idCus__412EB0B6");

                    b.HasOne("Storage.DbModels.Product", "IdProductNavigation")
                        .WithMany()
                        .HasForeignKey("IdProduct")
                        .HasConstraintName("FK__Customers__idPro__4222D4EF");

                    b.Navigation("IdCustomerNavigation");

                    b.Navigation("IdProductNavigation");
                });

            modelBuilder.Entity("Storage.DbModels.Part", b =>
                {
                    b.HasOne("Storage.DbModels.Product", "IdProductNavigation")
                        .WithMany("Parts")
                        .HasForeignKey("IdProduct")
                        .HasConstraintName("FK__Parts__idProduct__3A81B327");

                    b.Navigation("IdProductNavigation");
                });

            modelBuilder.Entity("Storage.DbModels.ProductCategory", b =>
                {
                    b.HasOne("Storage.DbModels.Category", "IdCategoryNavigation")
                        .WithMany()
                        .HasForeignKey("IdCategory")
                        .HasConstraintName("FK__ProductCa__idCat__5DCAEF64");

                    b.HasOne("Storage.DbModels.Product", "IdProductNavigation")
                        .WithMany()
                        .HasForeignKey("IdProduct")
                        .HasConstraintName("FK__ProductCa__idPro__5EBF139D");

                    b.Navigation("IdCategoryNavigation");

                    b.Navigation("IdProductNavigation");
                });

            modelBuilder.Entity("Storage.DbModels.Record", b =>
                {
                    b.HasOne("Storage.DbModels.Cell", "IdCellNavigation")
                        .WithMany()
                        .HasForeignKey("IdCell")
                        .HasConstraintName("FK__Records__idCell__3C69FB99");

                    b.HasOne("Storage.DbModels.Part", "IdPartNavigation")
                        .WithMany()
                        .HasForeignKey("IdPart")
                        .HasConstraintName("FK__Records__idPart__3D5E1FD2");

                    b.Navigation("IdCellNavigation");

                    b.Navigation("IdPartNavigation");
                });

            modelBuilder.Entity("Storage.DbModels.Product", b =>
                {
                    b.Navigation("Parts");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using Hamburgerci.Entities.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Hamburgerci.Entities.Migrations
{
    [DbContext(typeof(SqlDbContext))]
    partial class SqlDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Hamburgerci.Entities.Concrete.Extra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ExtraAdi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double>("Fiyat")
                        .HasColumnType("float");

                    b.Property<int?>("SiparisDetayId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ExtraAdi")
                        .IsUnique();

                    b.HasIndex("SiparisDetayId");

                    b.ToTable("Extralar");
                });

            modelBuilder.Entity("Hamburgerci.Entities.Concrete.Kullanici", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("KullaniciAdi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Sifre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("SoyAdi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("KullaniciAdi")
                        .IsUnique();

                    b.ToTable("Kullanicilar");
                });

            modelBuilder.Entity("Hamburgerci.Entities.Concrete.Menu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<byte>("Boyut")
                        .HasColumnType("tinyint");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("Fiyat")
                        .HasColumnType("float");

                    b.Property<string>("MenuAdi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("MenuAdi")
                        .IsUnique();

                    b.ToTable("Menuler");
                });

            modelBuilder.Entity("Hamburgerci.Entities.Concrete.SiparisDetay", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("Adet")
                        .HasColumnType("float");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("MenuId")
                        .HasColumnType("int");

                    b.Property<int>("SiparisMasterID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MenuId");

                    b.HasIndex("SiparisMasterID");

                    b.ToTable("SiparisDetaylari");
                });

            modelBuilder.Entity("Hamburgerci.Entities.Concrete.SiparisMaster", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("KullaniciId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KullaniciId");

                    b.ToTable("SiparisMaster");
                });

            modelBuilder.Entity("Hamburgerci.Entities.Concrete.Extra", b =>
                {
                    b.HasOne("Hamburgerci.Entities.Concrete.SiparisDetay", null)
                        .WithMany("Extralar")
                        .HasForeignKey("SiparisDetayId");
                });

            modelBuilder.Entity("Hamburgerci.Entities.Concrete.SiparisDetay", b =>
                {
                    b.HasOne("Hamburgerci.Entities.Concrete.Menu", "Menu")
                        .WithMany()
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hamburgerci.Entities.Concrete.SiparisMaster", "SiparisMaster")
                        .WithMany("SiparisDetaylari")
                        .HasForeignKey("SiparisMasterID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Menu");

                    b.Navigation("SiparisMaster");
                });

            modelBuilder.Entity("Hamburgerci.Entities.Concrete.SiparisMaster", b =>
                {
                    b.HasOne("Hamburgerci.Entities.Concrete.Kullanici", "Kullanici")
                        .WithMany()
                        .HasForeignKey("KullaniciId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kullanici");
                });

            modelBuilder.Entity("Hamburgerci.Entities.Concrete.SiparisDetay", b =>
                {
                    b.Navigation("Extralar");
                });

            modelBuilder.Entity("Hamburgerci.Entities.Concrete.SiparisMaster", b =>
                {
                    b.Navigation("SiparisDetaylari");
                });
#pragma warning restore 612, 618
        }
    }
}

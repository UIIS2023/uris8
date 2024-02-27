﻿// <auto-generated />
using System;
using IT64_2019_URIS_CustomerRegistration.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace IT64_2019_URIS_CustomerRegistration.Migrations
{
    [DbContext(typeof(CustomerRegistrationApiDbContext))]
    partial class CustomerRegistrationAPIDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("IT64_2019_URIS_CustomerRegistration.Entities.Customer", b =>
                {
                    b.Property<Guid>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AuthorizedPerson")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Guarantor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Payments")
                        .HasColumnType("float");

                    b.Property<string>("Person")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Priority")
                        .HasColumnType("int");

                    b.Property<int>("RealizedArea")
                        .HasColumnType("int");

                    b.Property<Guid>("RegistrationFormId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("IT64_2019_URIS_CustomerRegistration.Entities.LegalPerson", b =>
                {
                    b.Property<Guid>("LegalPersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccountNumLP")
                        .HasColumnType("int");

                    b.Property<string>("CityLP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactPerson")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("EmailLP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fax")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdentificationNumLP")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("NameLP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Positions")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StateLP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetLP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LegalPersonId");

                    b.HasIndex("CustomerId");

                    b.ToTable("LegalPersons");
                });

            modelBuilder.Entity("IT64_2019_URIS_CustomerRegistration.Entities.NaturalPerson", b =>
                {
                    b.Property<Guid>("NaturalPersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccountNumNP")
                        .HasColumnType("int");

                    b.Property<string>("CityNP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("EmailNP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JMBG")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StateNP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetNP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tel1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tel2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipNP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NaturalPersonId");

                    b.HasIndex("CustomerId");

                    b.ToTable("NaturalPersons");
                });

            modelBuilder.Entity("IT64_2019_URIS_CustomerRegistration.Entities.LegalPerson", b =>
                {
                    b.HasOne("IT64_2019_URIS_CustomerRegistration.Entities.Customer", "Customers")
                        .WithMany("LegalPersons")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customers");
                });

            modelBuilder.Entity("IT64_2019_URIS_CustomerRegistration.Entities.NaturalPerson", b =>
                {
                    b.HasOne("IT64_2019_URIS_CustomerRegistration.Entities.Customer", "Customers")
                        .WithMany("NaturalPersons")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customers");
                });

            modelBuilder.Entity("IT64_2019_URIS_CustomerRegistration.Entities.Customer", b =>
                {
                    b.Navigation("LegalPersons");

                    b.Navigation("NaturalPersons");
                });
#pragma warning restore 612, 618
        }
    }
}

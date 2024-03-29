﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using URIS_BiddingProcess_it24.Data;

#nullable disable

namespace URIS_BiddingProcess_it24.Migrations
{
    [DbContext(typeof(BiddingProcessApiDbContext))]
    [Migration("20230212120429_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("URIS_BiddingProcess_it24.Models.entity.Bidding", b =>
                {
                    b.Property<Guid>("BiddingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BiddingCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfMaintenance")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Excepted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("StartingPrice")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BiddingId");

                    b.ToTable("Biddings");
                });

            modelBuilder.Entity("URIS_BiddingProcess_it24.Models.entity.BiddingConditions", b =>
                {
                    b.Property<Guid>("BiddingConditionsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BiddingId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("RentalDuration")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BiddingConditionsId");

                    b.HasIndex("BiddingId");

                    b.ToTable("BiddingsConditions");
                });

            modelBuilder.Entity("URIS_BiddingProcess_it24.Models.entity.OpeningOfBids", b =>
                {
                    b.Property<Guid>("OpeningOfBidsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ArrivingDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ArrivingHour")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("BiddingId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("OpeningOfBidsId");

                    b.HasIndex("BiddingId");

                    b.ToTable("OpeningsOfBids");
                });

            modelBuilder.Entity("URIS_BiddingProcess_it24.Models.entity.PublicBidding", b =>
                {
                    b.Property<Guid>("PublicBiddingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BiddingId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("PriceStep")
                        .HasColumnType("int");

                    b.HasKey("PublicBiddingId");

                    b.HasIndex("BiddingId");

                    b.ToTable("PublicBiddings");
                });

            modelBuilder.Entity("URIS_BiddingProcess_it24.Models.entity.BiddingConditions", b =>
                {
                    b.HasOne("URIS_BiddingProcess_it24.Models.entity.Bidding", "Bidding")
                        .WithMany("BiddingConditions")
                        .HasForeignKey("BiddingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bidding");
                });

            modelBuilder.Entity("URIS_BiddingProcess_it24.Models.entity.OpeningOfBids", b =>
                {
                    b.HasOne("URIS_BiddingProcess_it24.Models.entity.Bidding", "Bidding")
                        .WithMany("OpeningOfBids")
                        .HasForeignKey("BiddingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bidding");
                });

            modelBuilder.Entity("URIS_BiddingProcess_it24.Models.entity.PublicBidding", b =>
                {
                    b.HasOne("URIS_BiddingProcess_it24.Models.entity.Bidding", "Bidding")
                        .WithMany("PublicBidding")
                        .HasForeignKey("BiddingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bidding");
                });

            modelBuilder.Entity("URIS_BiddingProcess_it24.Models.entity.Bidding", b =>
                {
                    b.Navigation("BiddingConditions");

                    b.Navigation("OpeningOfBids");

                    b.Navigation("PublicBidding");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using CarBookingApp.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CarBookingApp.Persistance.Migrations
{
    [DbContext(typeof(CarBookingAppDbContext))]
    [Migration("20211119115122_initial2")]
    partial class initial2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.10");

            modelBuilder.Entity("CarBookingApp.Domain.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Car 1"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Car 2"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Car 3"
                        });
                });

            modelBuilder.Entity("CarBookingApp.Domain.CarBooking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CarId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("TEXT");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.ToTable("CarBookings");
                });

            modelBuilder.Entity("CarBookingApp.Domain.CarBooking", b =>
                {
                    b.HasOne("CarBookingApp.Domain.Car", "Car")
                        .WithMany("CarBookings")
                        .HasForeignKey("CarId");

                    b.Navigation("Car");
                });

            modelBuilder.Entity("CarBookingApp.Domain.Car", b =>
                {
                    b.Navigation("CarBookings");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using DatabaseTask.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DatabaseTask.Data.Migrations
{
    [DbContext(typeof(DatabaseTaskDbContext))]
    [Migration("20240611110526_CreateDatabase")]
    partial class CreateDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DatabaseTask.Core.Domain.Class", b =>
                {
                    b.Property<Guid>("ClassCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ClassName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("GroupLeaderID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ClassCode");

                    b.HasIndex("GroupLeaderID");

                    b.ToTable("Class");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.FoodCoupon", b =>
                {
                    b.Property<Guid>("VoucherCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("StudentID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("VoucherCode");

                    b.HasIndex("StudentID");

                    b.ToTable("FoodCoupons");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.GroupLeader", b =>
                {
                    b.Property<Guid>("GroupLeaderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GroupLeaderID");

                    b.ToTable("GroupLeaders");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Student", b =>
                {
                    b.Property<Guid>("StudentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ClassCode")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentID");

                    b.HasIndex("ClassCode");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Class", b =>
                {
                    b.HasOne("DatabaseTask.Core.Domain.GroupLeader", "GroupLeader")
                        .WithMany("Classes")
                        .HasForeignKey("GroupLeaderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GroupLeader");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.FoodCoupon", b =>
                {
                    b.HasOne("DatabaseTask.Core.Domain.Student", "Student")
                        .WithMany("FoodCoupons")
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Student", b =>
                {
                    b.HasOne("DatabaseTask.Core.Domain.Class", "Class")
                        .WithMany()
                        .HasForeignKey("ClassCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Class");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.GroupLeader", b =>
                {
                    b.Navigation("Classes");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Student", b =>
                {
                    b.Navigation("FoodCoupons");
                });
#pragma warning restore 612, 618
        }
    }
}
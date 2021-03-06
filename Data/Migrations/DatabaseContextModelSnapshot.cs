﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SpiritPenguin.Data;

namespace SpiritPenguin.Data.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0");

            modelBuilder.Entity("SpiritPenguin.Data.Entities.Expense", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<double>("Amount")
                        .HasColumnType("REAL");

                    b.Property<string>("Comment")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("ExpenseCategoryId")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("PayeeId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ExpenseCategoryId");

                    b.HasIndex("PayeeId");

                    b.ToTable("Expenses");
                });

            modelBuilder.Entity("SpiritPenguin.Data.Entities.ExpenseEstimate", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<double>("Amount")
                        .HasColumnType("REAL");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("ExpenseTypeId")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("ExpenseEstimates");
                });

            modelBuilder.Entity("SpiritPenguin.Data.Entities.Period", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Periods");
                });

            modelBuilder.Entity("SpiritPenguin.Data.Entities.Picklist", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("PicklistTypeId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("PicklistTypeId");

                    b.ToTable("Picklist");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5cf235b2-a803-43d1-824d-38de32c83ccd"),
                            CreatedDate = new DateTime(2019, 10, 17, 19, 37, 9, 987, DateTimeKind.Local).AddTicks(8695),
                            IsActive = true,
                            IsDeleted = false,
                            PicklistTypeId = new Guid("b40ee6c6-3dc9-41e7-a2d0-350237306099"),
                            Value = "Bills"
                        },
                        new
                        {
                            Id = new Guid("bfe3c2bb-0717-489d-8d6f-12979c61ab25"),
                            CreatedDate = new DateTime(2019, 10, 17, 19, 37, 9, 987, DateTimeKind.Local).AddTicks(9722),
                            IsActive = true,
                            IsDeleted = false,
                            PicklistTypeId = new Guid("b40ee6c6-3dc9-41e7-a2d0-350237306099"),
                            Value = "Rent"
                        },
                        new
                        {
                            Id = new Guid("8c98085a-a16a-4115-a7d1-12f8a980de67"),
                            CreatedDate = new DateTime(2019, 10, 17, 19, 37, 9, 987, DateTimeKind.Local).AddTicks(9778),
                            IsActive = true,
                            IsDeleted = false,
                            PicklistTypeId = new Guid("b40ee6c6-3dc9-41e7-a2d0-350237306099"),
                            Value = "Other"
                        },
                        new
                        {
                            Id = new Guid("67918693-1acb-4421-81bb-8be1ece04268"),
                            CreatedDate = new DateTime(2019, 10, 17, 19, 37, 9, 987, DateTimeKind.Local).AddTicks(9804),
                            IsActive = true,
                            IsDeleted = false,
                            PicklistTypeId = new Guid("b40ee6c6-3dc9-41e7-a2d0-350237306099"),
                            Value = "Entertainment"
                        },
                        new
                        {
                            Id = new Guid("d0c9c322-5b5f-4766-b148-e7501492a954"),
                            CreatedDate = new DateTime(2019, 10, 17, 19, 37, 9, 987, DateTimeKind.Local).AddTicks(9828),
                            IsActive = true,
                            IsDeleted = false,
                            PicklistTypeId = new Guid("b40ee6c6-3dc9-41e7-a2d0-350237306099"),
                            Value = "Junk Food"
                        },
                        new
                        {
                            Id = new Guid("763c0414-97ba-46cc-8846-2e03babbe0ba"),
                            CreatedDate = new DateTime(2019, 10, 17, 19, 37, 9, 987, DateTimeKind.Local).AddTicks(9857),
                            IsActive = true,
                            IsDeleted = false,
                            PicklistTypeId = new Guid("b40ee6c6-3dc9-41e7-a2d0-350237306099"),
                            Value = "Necessities"
                        },
                        new
                        {
                            Id = new Guid("43f1b49f-a6a9-4072-b602-794263811372"),
                            CreatedDate = new DateTime(2019, 10, 17, 19, 37, 9, 987, DateTimeKind.Local).AddTicks(9880),
                            IsActive = true,
                            IsDeleted = false,
                            PicklistTypeId = new Guid("b40ee6c6-3dc9-41e7-a2d0-350237306099"),
                            Value = "Lifestyle"
                        },
                        new
                        {
                            Id = new Guid("883c19f8-e2f2-4141-a96e-43dd5a80b45e"),
                            CreatedDate = new DateTime(2019, 10, 17, 19, 37, 9, 987, DateTimeKind.Local).AddTicks(9902),
                            IsActive = true,
                            IsDeleted = false,
                            PicklistTypeId = new Guid("b40ee6c6-3dc9-41e7-a2d0-350237306099"),
                            Value = "Developer"
                        },
                        new
                        {
                            Id = new Guid("8574d514-d5a7-496b-a00a-3ac9d00a99f4"),
                            CreatedDate = new DateTime(2019, 10, 17, 19, 37, 9, 987, DateTimeKind.Local).AddTicks(9924),
                            IsActive = true,
                            IsDeleted = false,
                            PicklistTypeId = new Guid("b40ee6c6-3dc9-41e7-a2d0-350237306099"),
                            Value = "Loan repayment"
                        },
                        new
                        {
                            Id = new Guid("7b3ce76b-4c69-4e94-8c61-a9dc415251cd"),
                            CreatedDate = new DateTime(2019, 10, 17, 19, 37, 9, 987, DateTimeKind.Local).AddTicks(9949),
                            IsActive = true,
                            IsDeleted = false,
                            PicklistTypeId = new Guid("b40ee6c6-3dc9-41e7-a2d0-350237306099"),
                            Value = "Automotive"
                        });
                });

            modelBuilder.Entity("SpiritPenguin.Data.Entities.PicklistType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("PicklistTypes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("b40ee6c6-3dc9-41e7-a2d0-350237306099"),
                            CreatedDate = new DateTime(2019, 10, 17, 19, 37, 9, 984, DateTimeKind.Local).AddTicks(5903),
                            IsDeleted = false,
                            Value = "ExpenseCategory"
                        });
                });

            modelBuilder.Entity("SpiritPenguin.Data.Entities.Expense", b =>
                {
                    b.HasOne("SpiritPenguin.Data.Entities.Picklist", "ExpenseCategory")
                        .WithMany()
                        .HasForeignKey("ExpenseCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SpiritPenguin.Data.Entities.Picklist", "Payee")
                        .WithMany()
                        .HasForeignKey("PayeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SpiritPenguin.Data.Entities.Picklist", b =>
                {
                    b.HasOne("SpiritPenguin.Data.Entities.PicklistType", "PicklistType")
                        .WithMany()
                        .HasForeignKey("PicklistTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

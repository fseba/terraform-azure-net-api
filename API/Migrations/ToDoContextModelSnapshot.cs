﻿// <auto-generated />
using System;
using DemoAPIAzure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DemoAPIAzure.Migrations
{
    [DbContext(typeof(ToDoContext))]
    partial class ToDoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DemoAPIAzure.Entities.Category", b =>
                {
                    b.Property<Guid>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = new Guid("7c2196e4-9d06-4574-a212-d4bdef0a4bfb"),
                            Name = "Things to buy",
                            Weight = 20
                        },
                        new
                        {
                            CategoryId = new Guid("7c2196e4-9d06-4574-a212-d4bdef0a4bfc"),
                            Name = "Platzi courses to do",
                            Weight = 50
                        });
                });

            modelBuilder.Entity("DemoAPIAzure.Entities.ToDo", b =>
                {
                    b.Property<Guid>("ToDoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Priority")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("ToDoId");

                    b.HasIndex("CategoryId");

                    b.ToTable("ToDos");

                    b.HasData(
                        new
                        {
                            ToDoId = new Guid("8c2196e4-9d06-4574-a212-d4bdef0a4bfa"),
                            CategoryId = new Guid("7c2196e4-9d06-4574-a212-d4bdef0a4bfb"),
                            CreationDate = new DateTime(2022, 10, 9, 11, 27, 18, 324, DateTimeKind.Local).AddTicks(3927),
                            Priority = 2,
                            Title = "Milk"
                        },
                        new
                        {
                            ToDoId = new Guid("8c2196e4-9d06-4574-a212-d4bdef0a4bfb"),
                            CategoryId = new Guid("7c2196e4-9d06-4574-a212-d4bdef0a4bfb"),
                            CreationDate = new DateTime(2022, 10, 9, 11, 27, 18, 324, DateTimeKind.Local).AddTicks(3938),
                            Priority = 3,
                            Title = "Dog food"
                        },
                        new
                        {
                            ToDoId = new Guid("8c2196e4-9d06-4574-a212-d4bdef0a4bfc"),
                            CategoryId = new Guid("7c2196e4-9d06-4574-a212-d4bdef0a4bfc"),
                            CreationDate = new DateTime(2022, 10, 9, 11, 27, 18, 324, DateTimeKind.Local).AddTicks(3939),
                            Priority = 3,
                            Title = "Kubernetes"
                        },
                        new
                        {
                            ToDoId = new Guid("8c2196e4-9d06-4574-a212-d4bdef0a4bfd"),
                            CategoryId = new Guid("7c2196e4-9d06-4574-a212-d4bdef0a4bfc"),
                            CreationDate = new DateTime(2022, 10, 9, 11, 27, 18, 324, DateTimeKind.Local).AddTicks(3940),
                            Priority = 3,
                            Title = "New Relic"
                        },
                        new
                        {
                            ToDoId = new Guid("8c2196e4-9d06-4574-a212-d4bdef0a4bfe"),
                            CategoryId = new Guid("7c2196e4-9d06-4574-a212-d4bdef0a4bfc"),
                            CreationDate = new DateTime(2022, 10, 9, 11, 27, 18, 324, DateTimeKind.Local).AddTicks(3941),
                            Priority = 3,
                            Title = "Azure Databases"
                        });
                });

            modelBuilder.Entity("DemoAPIAzure.Entities.ToDo", b =>
                {
                    b.HasOne("DemoAPIAzure.Entities.Category", "Category")
                        .WithMany("ToDos")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("DemoAPIAzure.Entities.Category", b =>
                {
                    b.Navigation("ToDos");
                });
#pragma warning restore 612, 618
        }
    }
}

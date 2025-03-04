﻿// <auto-generated />
using System;
using BookStore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BookStore.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20191027142429_AddNewBooksToBookTableSeed")]
    partial class AddNewBooksToBookTableSeed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BookStore.Models.Books.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoUniqueName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Andrzej Sapkowski",
                            PhotoUniqueName = "3d4cdb83-8fb8-42aa-a05c-fb2f7d5d1e6d_wiedzmin-miecz-przeznaczenia.jpg",
                            Price = 28.99m,
                            Title = "Wiedźmin Miecz przeznaczenia"
                        },
                        new
                        {
                            Id = 2,
                            Author = "Stanisław Lem",
                            PhotoUniqueName = "lem-kongres-futurologiczny.jpg",
                            Price = 18.89m,
                            Title = "Kongres futurologiczny"
                        },
                        new
                        {
                            Id = 3,
                            Author = "Carl Gustav Jung",
                            PhotoUniqueName = "czerwona-ksiega.jpg",
                            Price = 87.99m,
                            Title = "Czerwona księga"
                        },
                        new
                        {
                            Id = 4,
                            Author = "Richard King",
                            PhotoUniqueName = "dywizjon-303.jpg",
                            Price = 25.69m,
                            Title = "Dywizjon 303. Walka i codzienność"
                        },
                        new
                        {
                            Id = 5,
                            Author = "Wojciech Drewniak",
                            PhotoUniqueName = "historia-bez-cenzury.jpg",
                            Price = 28.99m,
                            Title = "Historia bez cenzury 4"
                        },
                        new
                        {
                            Id = 6,
                            Author = "Jan Parandowski",
                            PhotoUniqueName = "mitologia.jpg",
                            Price = 32.99m,
                            Title = "Mitologia. Wierzenia i podania Greków i Rzymian"
                        },
                        new
                        {
                            Id = 7,
                            Author = "J.R.R. Tolkien",
                            PhotoUniqueName = "the-two-towers.jpg",
                            Price = 55.59m,
                            Title = "Władca pierścieni, Dwie wieże"
                        },
                        new
                        {
                            Id = 8,
                            Author = "Walter Isaacson",
                            PhotoUniqueName = "lonardo-da-vinci.jpg",
                            Price = 34.85m,
                            Title = "Leonardo da Vinci"
                        },
                        new
                        {
                            Id = 9,
                            Author = "J.K. Rowling",
                            PhotoUniqueName = "harry-potter-kamien-filozoficzny.jpg",
                            Price = 23.99m,
                            Title = "Harry Potter i Kamień Filozoficzny"
                        },
                        new
                        {
                            Id = 10,
                            Author = "Childress David Hatcher",
                            PhotoUniqueName = "olmekowie-najstarsza-tajemnica-meksyku.jpg",
                            Price = 20.99m,
                            Title = "Olmekowie Najstarsza tajemnica Meksyku"
                        });
                });

            modelBuilder.Entity("BookStore.Models.OrderItems.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BookId")
                        .HasColumnType("int");

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("BookStore.Models.Orders.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("OrderFulfilled")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("OrderPlaced")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("BookStore.Models.OrderItems.OrderItem", b =>
                {
                    b.HasOne("BookStore.Models.Books.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId");

                    b.HasOne("BookStore.Models.Orders.Order", null)
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId");
                });
#pragma warning restore 612, 618
        }
    }
}

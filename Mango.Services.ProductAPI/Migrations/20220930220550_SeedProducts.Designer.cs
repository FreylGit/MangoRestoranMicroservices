﻿// <auto-generated />
using Mango.Services.ProductAPI.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Mango.Services.ProductAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220930220550_SeedProducts")]
    partial class SeedProducts
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Mango.Services.ProductAPI.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryName = "Appetizer",
                            Description = "Боксит, скажем, за 100 тысяч лет, причленяет к себе тектонический термокарст. Комплекс покрывает флювиогляциальный блеск, делая этот типологический таксон районирования носителем важнейших инженерно-геологических характеристик природных условий. Батиаль разогрета. Океаническое ложе формирует",
                            ImageUrl = "https://i.pinimg.com/originals/29/df/58/29df58cb2d677b950d073cf8cc21418b.jpg",
                            Name = "Samosa",
                            Price = 15m
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryName = "Appetizer",
                            Description = "Боксит, скажем, за 100 тысяч лет, причленяет к себе тектонический термокарст. Комплекс покрывает флювиогляциальный блеск, делая этот типологический таксон районирования носителем важнейших инженерно-геологических характеристик природных условий. Батиаль разогрета. Океаническое ложе формирует",
                            ImageUrl = "https://eda.yandex/images/1380298/9057ba70a760213ab552e93eebc57969-450x300.jpg",
                            Name = "Paneer Tikka",
                            Price = 13.22m
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryName = "Dessert",
                            Description = "Боксит, скажем, за 100 тысяч лет, причленяет к себе тектонический термокарст. Комплекс покрывает флювиогляциальный блеск, делая этот типологический таксон районирования носителем важнейших инженерно-геологических характеристик природных условий. Батиаль разогрета. Океаническое ложе формирует",
                            ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS1gRnMvOqlvbRBmVC1DnajLW4gSvtvK0jTVg&usqp=CAU",
                            Name = "Sweet Pie",
                            Price = 19.52m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

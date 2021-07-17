﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SampleProject.Core.SqlServer.Commons;

namespace SampleProject.Core.SqlServer.Migrations
{
    [DbContext(typeof(SampleProjectDbContext))]
    [Migration("20210717131547_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SampleProject.Core.Domain.ArticelCategoryAggregate.ArticleCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ArticleCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(2021, 7, 17, 17, 45, 46, 429, DateTimeKind.Local).AddTicks(4721),
                            Title = "Domain Driven Design"
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(2021, 7, 17, 17, 45, 46, 434, DateTimeKind.Local).AddTicks(7992),
                            Title = "Asp Core"
                        });
                });

            modelBuilder.Entity("SampleProject.Core.Domain.ArticleAggregate.Article", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ArticleCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ArticleCategoryId");

                    b.ToTable("Articles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ArticleCategoryId = 1,
                            Content = "Value Object in Domain Driven Design",
                            Created = new DateTime(2021, 7, 17, 17, 45, 46, 465, DateTimeKind.Local).AddTicks(8048),
                            ShortDescription = "Value Object in Domain Driven Design",
                            Title = "Value Object"
                        },
                        new
                        {
                            Id = 2,
                            ArticleCategoryId = 1,
                            Content = "Domian Event in Domain Driven Design",
                            Created = new DateTime(2021, 7, 17, 17, 45, 46, 465, DateTimeKind.Local).AddTicks(9402),
                            ShortDescription = "Domian Event in Domain Driven Design",
                            Title = "Domian Event"
                        });
                });

            modelBuilder.Entity("SampleProject.Core.Domain.ArticleAggregate.Article", b =>
                {
                    b.HasOne("SampleProject.Core.Domain.ArticelCategoryAggregate.ArticleCategory", "ArticleCategory")
                        .WithMany("Articles")
                        .HasForeignKey("ArticleCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ArticleCategory");
                });

            modelBuilder.Entity("SampleProject.Core.Domain.ArticelCategoryAggregate.ArticleCategory", b =>
                {
                    b.Navigation("Articles");
                });
#pragma warning restore 612, 618
        }
    }
}

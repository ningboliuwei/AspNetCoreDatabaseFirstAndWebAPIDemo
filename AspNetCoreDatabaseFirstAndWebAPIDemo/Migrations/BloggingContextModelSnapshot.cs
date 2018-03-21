﻿// <auto-generated />
using AspNetCoreDatabseFirstAndWebAPIDemo.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace AspNetCoreDatabaseFirstAndWebAPIDemo.Migrations
{
    [DbContext(typeof(BloggingContext))]
    partial class BloggingContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011");

            modelBuilder.Entity("AspNetCoreDatabseFirstAndWebAPIDemo.models.Blog", b =>
                {
                    b.Property<int>("BlogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)");

                    b.Property<string>("Title");

                    b.HasKey("BlogId");

                    b.ToTable("blogs");
                });

            modelBuilder.Entity("AspNetCoreDatabseFirstAndWebAPIDemo.models.Post", b =>
                {
                    b.Property<int>("PostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)");

                    b.Property<string>("Author")
                        .HasMaxLength(200);

                    b.Property<int?>("BlogId");

                    b.Property<string>("Content")
                        .HasColumnType("varchar(20000)");

                    b.Property<DateTime>("PublishTime");

                    b.HasKey("PostId");

                    b.HasIndex("BlogId");

                    b.ToTable("posts");
                });

            modelBuilder.Entity("AspNetCoreDatabseFirstAndWebAPIDemo.models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)");

                    b.Property<string>("Password");

                    b.Property<string>("Username")
                        .HasMaxLength(200);

                    b.HasKey("UserId");

                    b.ToTable("users");
                });

            modelBuilder.Entity("AspNetCoreDatabseFirstAndWebAPIDemo.models.Post", b =>
                {
                    b.HasOne("AspNetCoreDatabseFirstAndWebAPIDemo.models.Blog")
                        .WithMany("Posts")
                        .HasForeignKey("BlogId");
                });
#pragma warning restore 612, 618
        }
    }
}

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
    [Migration("20180321050605_Init3")]
    partial class Init3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011");

            modelBuilder.Entity("AspNetCoreDatabseFirstAndWebAPIDemo.models.Attachement", b =>
                {
                    b.Property<int>("AttachmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)");

                    b.Property<string>("Filename")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("AttachmentId");

                    b.ToTable("attachements");
                });

            modelBuilder.Entity("AspNetCoreDatabseFirstAndWebAPIDemo.models.Blog", b =>
                {
                    b.Property<int>("BlogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(500);

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

                    b.Property<int>("BlogId")
                        .HasColumnType("int(11)");

                    b.Property<string>("Conent")
                        .HasColumnType("varchar(20000)");

                    b.Property<string>("Title")
                        .HasMaxLength(1000);

                    b.HasKey("PostId");

                    b.ToTable("posts");
                });

            modelBuilder.Entity("AspNetCoreDatabseFirstAndWebAPIDemo.models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)");

                    b.Property<DateTime>("Birthday");

                    b.Property<string>("Password");

                    b.Property<string>("Realname");

                    b.Property<string>("Username")
                        .HasMaxLength(200);

                    b.HasKey("UserId");

                    b.ToTable("users");
                });

            modelBuilder.Entity("AspNetCoreDatabseFirstAndWebAPIDemo.models.Post", b =>
                {
                    b.HasOne("AspNetCoreDatabseFirstAndWebAPIDemo.models.Blog", "PostNavigation")
                        .WithOne("Post")
                        .HasForeignKey("AspNetCoreDatabseFirstAndWebAPIDemo.models.Post", "PostId")
                        .HasConstraintName("FK_Post_Blog_BlogId");
                });
#pragma warning restore 612, 618
        }
    }
}

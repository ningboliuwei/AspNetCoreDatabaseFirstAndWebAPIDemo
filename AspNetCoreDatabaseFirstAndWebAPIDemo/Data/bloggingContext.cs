using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AspNetCoreDatabseFirstAndWebAPIDemo.models
{
    public partial class BloggingContext : DbContext
    {
        public virtual DbSet<Attachement> Attachements { get; set; }
        public virtual DbSet<Blog> Blogs { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<User> Users { get; set; }

        public BloggingContext(DbContextOptions<BloggingContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Attachement>(entity =>
            {
                entity.HasKey(e => e.AttachmentId);

                entity.ToTable("attachements");

                entity.Property(e => e.AttachmentId).HasColumnType("int(11)");

                entity.Property(e => e.Filename)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Blog>(entity =>
            {
                entity.ToTable("blogs");

                entity.Property(e => e.BlogId).HasColumnType("int(11)");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<Post>(entity =>
            {
                entity.ToTable("posts");

                entity.Property(e => e.PostId)
                    .HasColumnType("int(11)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Author).HasMaxLength(200);

                entity.Property(e => e.BlogId).HasColumnType("int(11)");

                entity.Property(e => e.Conent).HasColumnType("varchar(20000)");

                entity.Property(e => e.Title).HasMaxLength(1000);

                entity.HasOne(d => d.PostNavigation)
                    .WithOne(p => p.Post)
                    .HasForeignKey<Post>(d => d.PostId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Post_Blog_BlogId");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("users");

                entity.Property(e => e.UserId).HasColumnType("int(11)");

                entity.Property(e => e.Username).HasMaxLength(200);
            });
        }
    }
}

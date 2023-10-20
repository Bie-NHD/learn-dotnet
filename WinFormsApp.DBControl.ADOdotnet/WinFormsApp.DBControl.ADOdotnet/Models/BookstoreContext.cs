using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WinFormsApp.DBControl.ADOdotnet.Models;

public partial class BookstoreContext : DbContext
{
    public BookstoreContext()
    {
    }

    public BookstoreContext(DbContextOptions<BookstoreContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Book> Books { get; set; }

    public virtual DbSet<Genre> Genres { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost;Integrated Security=True;Trusted_Connection=True;Database=bookstore;TrustServerCertificate=True;Encrypt=False;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasKey(e => e.BookCode).HasName("PK__Book__0A5FFCC6162E5038");

            entity.ToTable("Book");

            entity.Property(e => e.BookName)
                .HasMaxLength(200)
                .HasDefaultValueSql("('N/A')");
            entity.Property(e => e.GenreCode).HasDefaultValueSql("((0))");

            entity.HasOne(d => d.GenreCodeNavigation).WithMany(p => p.Books)
                .HasForeignKey(d => d.GenreCode)
                .HasConstraintName("FK__Book__GenreCode__3B75D760");
        });

        modelBuilder.Entity<Genre>(entity =>
        {
            entity.HasKey(e => e.GenreCode).HasName("PK__Genre__A783F94AB745524F");

            entity.ToTable("Genre");

            entity.Property(e => e.GenreName).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

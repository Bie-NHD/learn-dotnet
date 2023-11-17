using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DBControl;

public partial class UQuanlybanhangContext : DbContext
{
    public UQuanlybanhangContext()
    {
    }

    public UQuanlybanhangContext(DbContextOptions<UQuanlybanhangContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=u_quanlybanhang;Integrated Security=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.ProductCode);

            entity.ToTable("product");

            entity.Property(e => e.ProductCode).ValueGeneratedNever();
            entity.Property(e => e.ProductName).HasMaxLength(200);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

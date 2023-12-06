using Bibliotekarz.Shared.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotekarz.Server.Data.Context;

public class ApplicationDbContext(DbContextOptions options) : DbContext(options)
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // optionsBuilder.UseSqlServer("Server=localhost;Database=BibliotekarzDb;User Id=sa;Password=P@ssw0rd;MultipleActiveResultSets=true;TrustServerCertificate=true");
        //optionsBuilder.UseSqlServer("Server=localhost;Database=BibliotekarzDb;Integrated Security=true;MultipleActiveResultSets=true;TrustServerCertificate=true");

        //optionsBuilder.UseInMemoryDatabase("BibliotekarzInMemoryDb")
        //    .EnableDetailedErrors().EnableSensitiveDataLogging();
    }

    public virtual DbSet<Book> Books { get; set; }
    public virtual DbSet<Customer> Borrowers { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Book>(book =>
        {
            book.ToTable("Books");
            book.Property(b => b.Title).IsRequired().HasMaxLength(300);
            book.Property(b => b.Author).IsRequired().HasMaxLength(150);
        });

        builder.Entity<Customer>(book =>
        {
            book.Property(b => b.FirstName).IsRequired().HasMaxLength(120);
            book.Property(b => b.LastName).IsRequired().HasMaxLength(150);
        });

        builder.Entity<Book>()
            .HasOne(b => b.Borrower)
            .WithMany(c => c.Books)
            .HasForeignKey(b => b.BorrowerId)
            .OnDelete(DeleteBehavior.NoAction);
    }
}

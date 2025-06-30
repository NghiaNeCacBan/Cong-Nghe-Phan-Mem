// backend/JCertPreBackend/Data/JCertPreContext.cs
  using Microsoft.EntityFrameworkCore;
  using JCertPreBackend.Models;

  namespace JCertPreBackend.Data
  {
      public class JCertPreContext : DbContext
      {
          public JCertPreContext(DbContextOptions<JCertPreContext> options) : base(options) { }
          public DbSet<User> Users { get; set; } = null!;
          public DbSet<Course> Courses { get; set; } = null!;
      }
  }
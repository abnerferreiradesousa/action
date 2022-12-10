using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using crm_ps.Models;

namespace crm_ps.Context;

public class PlataformContext : DbContext
{
    public PlataformContext(DbContextOptions<PlataformContext> options): base(options)
    {
    }

    public DbSet<Candidate> Candidates { get; set; }
    public DbSet<Course> Courses { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Candidate>()
                    .HasMany<Course>(s => s.Courses)
                    .WithMany(c => c.Candidates);
    }

}
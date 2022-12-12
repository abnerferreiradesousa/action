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
    public DbSet<CandidateCourse> CandidateCourses { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CandidateCourse>()
            .HasKey(candidateCourse => 
                new { candidateCourse.CandidateId, candidateCourse.CourseId });
    }

}
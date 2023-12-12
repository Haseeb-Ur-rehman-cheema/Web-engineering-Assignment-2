using Microsoft.EntityFrameworkCore;
using System;

namespace Assignment_2.Data
{
    public class SchoolDbContext:DbContext
    {
            public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options)
            {
            }
            public DbSet<Student> Students { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Enrolled> Enrolleds { get; set; }
    }
    }


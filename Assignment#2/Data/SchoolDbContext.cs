using Microsoft.EntityFrameworkCore;
using System;
using Assignment_2.Data;
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

        public IQueryable<object> Query1a()
        {
            return from c in Classes
                   where Enrolleds.Count(e => e.cid == c.cid) > 100
                   select new { c.name, c.room_number };
        }
        public IQueryable<object> Query1b()
        {
            return from s in Students
                   where Enrolleds.All(e => Classes.Any(c => c.cid == e.cid && c.faculty.deptid != 22))
                   select new { s.sid, s.major };
        }

        public IQueryable<object> Query2c()
        {
            return from s in Students
                   where Enrolleds.Count(e => e.sid == s.sid) > 2
                   select new { s.sname, ClassCount = Enrolleds.Count(e => e.sid == s.sid) };
        }

        public IQueryable<object> Query2d()
        {
            return from f in Faculties
                   join c in Classes on f.fid equals c.fid into facultyClasses
                   select new { FacultyName = f.fname, TotalClasses = facultyClasses.Count() };
        }

        public IQueryable<string> Query2f()
        {
            return from s in Students
                   join e in Enrolleds on s.sid equals e.sid
                   join c in Classes on e.cid equals c.cid
                   join f in Faculties on c.fid equals f.fid
                   where f.deptname == "Computer Science"
                   select s.sname;
        }

    }
}


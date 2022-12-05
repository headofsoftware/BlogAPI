using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=SABRI;database=BlogNew; integrated security=true;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*
             modelBuilder.Entity<LessonStudent>()
                .HasKey(ls => new { ls.StudentID, ls.LessonID });

            modelBuilder.Entity<LessonStudent>()
                .HasOne(ky => ky.Lesson)
                .WithMany(s => s.Students);
            
            modelBuilder.Entity<LessonStudent>()
                .HasOne(ky => ky.Student)
                .WithMany(s => s.Lessons);
             */
        }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<User> Users { get; set; }
    }
}

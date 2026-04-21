using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearningManagementSystem.Core.Dtos;
using Microsoft.EntityFrameworkCore;

namespace LearningManagementSystem.Core
{
    public class DataContext: DbContext
    {
        public DbSet<UserDto> Users { get; set; }
        public DbSet<CourseDto> Courses { get; set; }
        public DbSet<TestDto> Tests { get; set; }
        public DbSet<TestResultDto> Results { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=72780309; Database=LearningManagementSystem;";
            optionsBuilder.UseNpgsql(connectionString);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using StudentExercises_EF.Models;

namespace StudentExercises_EF.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Student { get; set; }
        public DbSet<Instructor> Instructor { get; set; }
        public DbSet<Cohort> Cohort { get; set; }
        public DbSet<Exercise> Exercise { get; set; }
        public DbSet<AssignedExercise> AssignedExercise { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Create two cohorts
            modelBuilder.Entity<Cohort>().HasData(
                new Cohort()
                {
                    Id = 1,
                    Name = "Day Cohort 1"
                },
                new Cohort()
                {
                    Id = 2,
                    Name = "Day Cohort 2"
                },
                new Cohort()
                {
                    Id = 3,
                    Name = "Day Cohort 3"
                }
            );

            // Create two students
            modelBuilder.Entity<Student>().HasData(
                new Student()
                {
                    Id = 1,
                    FirstName = "Jakob",
                    LastName = "Wildman",
                    SlackHandle = "Jakob",
                    CohortId = 2
                },
                new Student()
                {
                    Id = 2,
                    FirstName = "Susan",
                    LastName = "MacAfee",
                    SlackHandle = "@susan",
                    CohortId = 1
                },
                new Student()
                {
                    Id = 3,
                    FirstName = "Barry",
                    LastName = "Griffith",
                    SlackHandle = "@barry",
                    CohortId = 3
                },
                new Student()
                {
                    Id = 4,
                    FirstName = "Pat",
                    LastName = "Shaver",
                    SlackHandle = "@pat",
                    CohortId = 3
                },
                new Student()
                {
                    Id = 5,
                    FirstName = "Mandy",
                    LastName = "Campbell",
                    SlackHandle = "@mandy",
                    CohortId = 3
                },
                new Student()
                {
                    Id = 6,
                    FirstName = "Sarah",
                    LastName = "Brooks",
                    SlackHandle = "@sarah",
                    CohortId = 3
                },
                new Student()
                {
                    Id = 7,
                    FirstName = "Swathi",
                    LastName = "Mukkamala",
                    SlackHandle = "@swathi",
                    CohortId = 3
                },
                new Student()
                {
                    Id = 8,
                    FirstName = "Ashon",
                    LastName = "Woodbury",
                    SlackHandle = "@ashon",
                    CohortId = 3
                },
                new Student()
                {
                    Id = 9,
                    FirstName = "Dylan",
                    LastName = "Bishop",
                    SlackHandle = "@dylan",
                    CohortId = 3
                },
                new Student()
                {
                    Id = 10,
                    FirstName = "Austin",
                    LastName = "Preece",
                    SlackHandle = "@austin",
                    CohortId = 3
                }
            );

            modelBuilder.Entity<Instructor>().HasData(
                new Instructor()
                {
                    Id = 1,
                    FirstName = "Jordan",
                    LastName = "Castelloe",
                    Specialty = "Rat exterminator",
                    SlackHandle = "@jordan",
                    CohortId = 3
                },
                new Instructor()
                {
                    Id = 2,
                    FirstName = "Tommy",
                    LastName = "Spurlock",
                    Specialty = "Inspiring Speeches",
                    SlackHandle = "@tommy",
                    CohortId = 3
                },
                new Instructor()
                {
                    Id = 3,
                    FirstName = "Jordan",
                    LastName = "Castelloe",
                    Specialty = "Muppets",
                    SlackHandle = "@jordan",
                    CohortId = 2
                },
                new Instructor()
                {
                    Id = 4,
                    FirstName = "Tommy",
                    LastName = "Spurlock",
                    Specialty = "Dance Lessons",
                    SlackHandle = "@tommy",
                    CohortId = 2
                },
                new Instructor()
                {
                    Id = 5,
                    FirstName = "Jordan",
                    LastName = "Castelloe",
                    Specialty = "Hoagie",
                    SlackHandle = "@jordan",
                    CohortId = 1
                }
            );

            modelBuilder.Entity<Exercise>().HasData(
                new Exercise()
                {
                    Id = 1,
                    Name = "Restauraunt Tracker",
                    Language = "C#"
                },
                new Exercise()
                {
                    Id = 2,
                    Name = "Student Exercises",
                    Language = "C#"
                },
                new Exercise()
                {
                    Id = 3,
                    Name = "Server Side Capstone",
                    Language = "C#"
                }
            );
        }
    }
}

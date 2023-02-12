using BJJ_Trainer_Assist.Models;
using Microsoft.EntityFrameworkCore;

namespace BJJ_Trainer_Assist.Data
{
    public class DbInitializer
    {
        private readonly ApplicationDbContext _context;

        public DbInitializer(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Database.GetPendingMigrations().Any())
            {
                //Seeding fighter data
                if (!_context.Fighters.Any())
                {
                    _context.Fighters.AddRange(
                        new Fighter
                        {
                            FighterName = "John Doe",
                            Height = 180,
                            Weight = 80,
                            BeltRankId = 3,
                            BMI = 25,
                            Gender = Gender.Male,
                            MaxWorkoutDuration = 5,
                            Role = FighterRole.Student
                        },
                        new Fighter
                        {
                            FighterName = "Jane Doe",
                            Height = 170,
                            Weight = 70,
                            BeltRankId = 12,
                            BMI = 24,
                            Gender = Gender.Female,
                            MaxWorkoutDuration = 5,
                            Role = FighterRole.Student
                        },
                        new Fighter
                        {
                            FighterName = "Bob Smith",
                            Height = 190,
                            Weight = 90,
                            BeltRankId = 9,
                            BMI = 27,
                            Gender = Gender.Male,
                            MaxWorkoutDuration = 5,
                            Role = FighterRole.Student
                        },
                        new Fighter
                        {
                            FighterName = "Sara Lee",
                            Height = 165,
                            Weight = 65,
                            BeltRankId = 1,
                            BMI = 24,
                            Gender = Gender.Female,
                            MaxWorkoutDuration = 5,
                            Role = FighterRole.Student
                        },
                        new Fighter
                        {
                            FighterName = "Peter Parker",
                            Height = 185,
                            Weight = 75,
                            BeltRankId = 24,
                            BMI = 24,
                            Gender = Gender.Male,
                            MaxWorkoutDuration = 5,
                            Role = FighterRole.Instructor
                        },
                        new Fighter
                        {
                            FighterName = "Mary Jane",
                            Height = 167,
                            Weight = 68,
                            BeltRankId = 12,
                            BMI = 22,
                            Gender = Gender.Female,
                            MaxWorkoutDuration = 5,
                            Role = FighterRole.Student
                        },
                        new Fighter
                        {
                            FighterName = "Harry Potter",
                            Height = 178,
                            Weight = 77,
                            BeltRankId = 8,
                            BMI = 24,
                            Gender = Gender.Male,
                            MaxWorkoutDuration = 5,
                            Role = FighterRole.Student
                        },
                        new Fighter
                        {
                            FighterName = "Hermione Granger",
                            Height = 170,
                            Weight = 71,
                            BeltRankId = 4,
                            BMI = 25,
                            Gender = Gender.Female,
                            MaxWorkoutDuration = 5,
                            Role = FighterRole.Student
                        },
                        new Fighter
                        {
                            FighterName = "Ron Weasley",
                            Height = 183,
                            Weight = 78,
                            BeltRankId = 2,
                            BMI = 26,
                            Gender = Gender.Male,
                            MaxWorkoutDuration = 5,
                            Role = FighterRole.Student
                        },
                        new Fighter
                        {
                            FighterName = "Vo Hoan Vu",
                            Height = 161,
                            Weight = 55,
                            BeltRankId = 2,
                            BMI = 26,
                            Gender = Gender.Male,
                            MaxWorkoutDuration = 5,
                            Role = FighterRole.Student
                        }
                    );

                    _context.SaveChanges();
                }
            }
        }
    }
}

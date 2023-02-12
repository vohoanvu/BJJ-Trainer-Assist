using BJJ_Trainer_Assist.Models;

namespace BJJ_Trainer_Assist.Utilities
{
    public static class Helpers
    {
        public static void SetAdminFighterData(this Fighter user)
        {
            user.FighterName = "The Code-Jitsu Master";
            user.Height = 1.62;
            user.Weight = 60;
            user.BMI = user.Weight / (user.Height * user.Height);
            user.Gender = Gender.Male;
            user.Role = FighterRole.Instructor;
            user.MaxWorkoutDuration = 5;
            user.BeltRankId = 4; //White belt and 3 stripes
        }
    }
}

using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace BJJ_Trainer_Assist.Models
{
    public class Fighter: IdentityUser
    {
        [PersonalData]
        public string FighterName { get; set; }

        [PersonalData]
        public double Height { get; set; }

        [PersonalData]
        public double Weight { get; set; }

        [PersonalData]
        public double BMI { get; set; }

        [PersonalData]
        public Gender Gender { get; set; }

        [PersonalData]
        public FighterRole Role { get; set; }

        [PersonalData]
        public int MaxWorkoutDuration { get; set; }

        [PersonalData]
        public int BeltRankId { get; set; }
        [ForeignKey("BeltRankId")]
        public virtual BeltRank BeltRank { get; set; }
    }
}
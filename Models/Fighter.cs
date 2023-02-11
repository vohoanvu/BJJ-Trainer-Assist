using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace BJJ_Trainer_Assist.Models
{
    public class Fighter: IdentityUser
    {
        public string? Name { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public double BMI { get; set; }
        public Gender Gender { get; set; }
        public FighterRole Role { get; set; }
        public int MaxWorkoutDuration { get; set; }

        public int BeltRankId { get; set; }
        [ForeignKey("BeltRankId")]
        public virtual BeltRank BeltRank { get; set; }
    }
}
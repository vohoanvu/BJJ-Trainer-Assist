using BJJ_Trainer_Assist.Models;
using System.ComponentModel.DataAnnotations;

namespace BJJ_Trainer_Assist.Controllers.FighterAccount
{
    public class RegisterDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Fighter nickname")]
        public string? FighterName { get; set; }

        [Required]
        public double Height { get; set; }

        [Required]
        public double Weight { get; set; }

        [Required]
        public Gender Gender { get; set; }

        [Required]
        public FighterRole Role { get; set; }

        [Required]
        public int MaxWorkoutDuration { get; set; }

        public BeltColor BeltColor { get; set; }

        [Range(0, 4)]
        public int Stripe { get; set; }
    }
}

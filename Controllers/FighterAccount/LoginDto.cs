using System.ComponentModel.DataAnnotations;

namespace BJJ_Trainer_Assist.Controllers.FighterAccount
{
    public class LoginDto
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}

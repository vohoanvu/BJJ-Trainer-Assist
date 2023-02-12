using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using BJJ_Trainer_Assist.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using BJJ_Trainer_Assist.Models;

namespace BJJ_Trainer_Assist.Controllers.FighterAccount
{
    [Route("api/[controller]")]
    [ApiController]
    public class FighterController : ControllerBase
    {
        private readonly UserManager<Fighter> _userManager;
        private readonly SignInManager<Fighter> _signInManager;
        private readonly ApplicationDbContext _context;

        public FighterController(UserManager<Fighter> userManager, SignInManager<Fighter> signInManager, ApplicationDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
        }

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register([FromBody] RegisterDto input)
        {
            var user = new Fighter
            {
                UserName = input.Email,
                FighterName = input.FighterName ?? string.Empty,
                Height = input.Height,
                Weight = input.Weight,
                BMI = input.Weight / (input.Height * input.Height),
                Gender = input.Gender,
                Role = input.Role,
                MaxWorkoutDuration = input.MaxWorkoutDuration,
                BeltRankId = _context.BeltRanks
                    .Single(b => b.Color == input.BeltColor && b.Stripe == input.Stripe).Id
            };

            var result = await _userManager.CreateAsync(user, input.Password);

            if (!result.Succeeded)
            {
                return BadRequest(result.Errors);
            }

            return Ok(result);
        }


        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> LoginWithPassword(LoginDto input)
        {
            var result = await _signInManager.PasswordSignInAsync(input.Email, input.Password, false, false);

            if (!result.Succeeded)
            {
                return BadRequest();
            }

            return Ok();
        }
    }
}

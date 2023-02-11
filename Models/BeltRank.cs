using System.ComponentModel.DataAnnotations;

namespace BJJ_Trainer_Assist.Models
{
    public class BeltRank
    {
        [Key]
        public int Id { get; set; }
        public BeltColor Color { get; set; }

        [Range(0, 4)]
        public int Stripe;

        public ICollection<Fighter> Fighters { get; set; }
    }
}

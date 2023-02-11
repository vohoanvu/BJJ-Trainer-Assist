using BJJ_Trainer_Assist.Models;
using Duende.IdentityServer.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Reflection.Emit;

namespace BJJ_Trainer_Assist.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<Fighter>
    {
        public ApplicationDbContext(DbContextOptions options, IOptions<OperationalStoreOptions> operationalStoreOptions)
            : base(options, operationalStoreOptions)
        {

        }

        public DbSet<Fighter> Fighters { get; set; }
        public DbSet<BeltRank> BeltRanks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seeding all 25 belt ranks data
            modelBuilder.Entity<BeltRank>().HasData(
                new BeltRank { Id = 1, Color = BeltColor.White, Stripe = 0 },
                new BeltRank { Id = 2, Color = BeltColor.White, Stripe = 1 },
                new BeltRank { Id = 3, Color = BeltColor.White, Stripe = 2 },
                new BeltRank { Id = 4, Color = BeltColor.White, Stripe = 3 },
                new BeltRank { Id = 5, Color = BeltColor.White, Stripe = 4 },
                new BeltRank { Id = 6, Color = BeltColor.Blue, Stripe = 0 },
                new BeltRank { Id = 7, Color = BeltColor.Blue, Stripe = 1 },
                new BeltRank { Id = 8, Color = BeltColor.Blue, Stripe = 2 },
                new BeltRank { Id = 9, Color = BeltColor.Blue, Stripe = 3 },
                new BeltRank { Id = 10, Color = BeltColor.Blue, Stripe = 4 },
                new BeltRank { Id = 11, Color = BeltColor.Purple, Stripe = 0 },
                new BeltRank { Id = 12, Color = BeltColor.Purple, Stripe = 1 },
                new BeltRank { Id = 13, Color = BeltColor.Purple, Stripe = 2 },
                new BeltRank { Id = 14, Color = BeltColor.Purple, Stripe = 3 },
                new BeltRank { Id = 15, Color = BeltColor.Purple, Stripe = 4 },
                new BeltRank { Id = 16, Color = BeltColor.Brown, Stripe = 0 },
                new BeltRank { Id = 17, Color = BeltColor.Brown, Stripe = 1 },
                new BeltRank { Id = 18, Color = BeltColor.Brown, Stripe = 2 },
                new BeltRank { Id = 19, Color = BeltColor.Brown, Stripe = 3 },
                new BeltRank { Id = 20, Color = BeltColor.Brown, Stripe = 4 },
                new BeltRank { Id = 21, Color = BeltColor.Black, Stripe = 0 },
                new BeltRank { Id = 22, Color = BeltColor.Black, Stripe = 1 },
                new BeltRank { Id = 23, Color = BeltColor.Black, Stripe = 2 },
                new BeltRank { Id = 24, Color = BeltColor.Black, Stripe = 3 },
                new BeltRank { Id = 25, Color = BeltColor.Black, Stripe = 4 }
            );
        }
    }
}
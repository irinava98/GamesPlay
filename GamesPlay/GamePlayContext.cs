using GamesPlay.Models;
using Microsoft.EntityFrameworkCore;

namespace GamesPlay
{
    public class GamePlayContext: DbContext
    {
        public GamePlayContext():base()
        {
        }

        public GamePlayContext(DbContextOptions<GamePlayContext> options):base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Game> Games { get; set; }  

        public DbSet<GameUser> UserGames { get; set; }  

        public DbSet<Comment> Comments { get; set; }    

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().Property(u => u.Username).IsRequired();
            modelBuilder.Entity<User>().Property(u => u.Email).IsRequired();
            modelBuilder.Entity<User>().Property(u => u.Password).IsRequired();
            modelBuilder.Entity<User>().Property(u => u.Role).IsRequired();
            modelBuilder.Entity<Game>().Property(g => g.Title).IsRequired().HasMaxLength(40);
            modelBuilder.Entity<Game>().Property(g => g.Category).IsRequired().HasMaxLength(25);
            modelBuilder.Entity<Game>().Property(g => g.GameLink).IsRequired();
            modelBuilder.Entity<Game>().Property(g => g.Likes).HasDefaultValue(0);
            modelBuilder.Entity<GameUser>().HasKey(e => new { e.UserId, e.GameId });
            modelBuilder.Entity<Comment>().Property(c => c.Content).IsRequired();
            modelBuilder.Entity<Comment>().HasOne(c => c.User).WithMany(u => u.Comments).HasForeignKey(c => c.UserId);
            modelBuilder.Entity<Comment>().HasOne(c => c.Game).WithMany(u => u.Comments).HasForeignKey(c => c.GameId);

        }


    }
}

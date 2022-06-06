using System.Collections.Generic;

namespace GamesPlay.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }

        public Roles Role { get; set; }
        public string Password { get; set; }



        public virtual ICollection<GameUser> GamesUsers { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    }
}

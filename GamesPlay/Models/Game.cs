using System.Collections.Generic;

namespace GamesPlay.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Categories Category { get; set; }
        public string GameLink { get; set; }
        public string ImageUrl { get; set; }
        public string Summary {get; set;}
        public int Likes { get; set; }

 
        public virtual ICollection<GameUser> GamesUsers { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }

    }
}

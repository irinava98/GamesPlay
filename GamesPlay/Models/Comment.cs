﻿namespace GamesPlay.Models
{
    public class Comment
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public int GameId { get; set; }

        public Game Game { get; set; }

        public string Content { get; set; }
    }
}

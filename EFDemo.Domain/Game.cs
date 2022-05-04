﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EFDemo.Domain
{
    public class Game
    {
        public Game()
        {
            GamePlayers = new List<GamePlayer>();
        }

        public int Id { get; set; }

        public int Round { get; set; }

        public DateTimeOffset? StartTime { get; set; }

        public List<GamePlayer> GamePlayers { get; set; }
    }
}

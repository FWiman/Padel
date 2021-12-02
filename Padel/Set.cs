using System;
using System.Collections.Generic;

namespace Padel
{
    public class Set
    {
        public List<Game> _games { get; } = new List<Game>();

        public void Point(Player player)
        {
            var game = new Game(player, player);
            game.Point(player);
            _games.Add(game);

        }

    }
}

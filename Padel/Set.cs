using System.Collections.Generic;

namespace Padel
{
    public class Set
    {
        public List<Game> _games { get; } = new List<Game>();

        public Set(Player player1, Player player2)
        {
            _games.Add(new Game(player1, player2));
        }

        public void Point(Player player)
        {

            if (player.Score._Score > 4)
            {
                var game = new Game(player, player);
                game.Point(player);
                _games.Add(game);
            }
            else
            {
                _games[^1].Point(player);
            }

        }

    }
}

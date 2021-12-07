using System;
using System.Collections.Generic;

namespace Padel
{
    public class Match
    {
        public List<Set> _sets { get; } = new List<Set>();
        public Player _player1;
        public Player _player2;
        public Match(int numberOfSets, Player player1, Player player2)
        {
            _sets = new List<Set>(numberOfSets);
            for (int i = 0; i < numberOfSets; i++)
            {
                _sets.Add(new Set(player1,player2));

            }
            _player1 = player1;
            _player2 = player2;
        }

        public void Point(Player player)                    // Changed so that a point is given and "placed" in the list of set.
        {
            if (player.Score._Score > 3)
            {
                var set = new Set(player, player);
                set.Point(player);
                _sets.Add(set);
            }
            else
            {
                _sets[^1].Point(player);
            }
        }

        public Score MatchScore()
        {
            return new Score();
        }

        public string ScoreString()
        {
            if (_player1.Score._Score == 3)
            {
                return "Player 1 wins the match";
            }
            else if (_player2.Score._Score == 3)
            {
                return "Player 2 wins the match";
            }
            return $"Player 1 score is {_player1.Score._Score} \n Player 2 score is {_player2.Score._Score}";
        }

    }
}

namespace Padel
{

    public class Game
    {
        private Player _player1;
        private Player _player2;

        public Game(Player player1, Player player2)
        {
            _player1 = player1;
            _player2 = player2;                             // Changed variable to _player2
        }

        public void Point(Player player)
        {
            player.Point();                                 // Changed _player1 to player to be able to give point to both players.
        }

        public Score Score(Player player)                   // Added an in parameter and changed _player1 to player to be able to hold both players score.
        {
            return player.Score;
        }

        public string ScoreString()
        {
            if (_player1.Score._Score > 40)
            {
                return "Player 1 wins";
            }
            return "Player 2 wins";

        }
    }
}

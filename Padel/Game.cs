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
            player.Point();
            ScoreString();
        }

        public Score Score(Player player)                   // Added an in parameter and changed _player1 to player to be able to hold both players score.
        {
            return player.Score;
        }

        public string ScoreString()
        {
            if (_player1.Score._Score == 4 && _player2.Score._Score == 4)
            {
                return "Deuce";
            }
            else if (_player1.Score._Score > 4 && _player1.Score._Score >= _player2.Score._Score + 2)
            {
                return "Player 1 wins";
            }
            else if (_player2.Score._Score > 4 && _player2.Score._Score >= _player1.Score._Score + 2)
            {
                return "Player 2 wins";
            }
            else if (_player1.Score._Score > 4 && _player1.Score._Score >= _player2.Score._Score + 1)
            {
                return "Match Point";
            }
            else if (_player2.Score._Score > 4 && _player2.Score._Score >= _player1.Score._Score + 1)
            {
                return "Match Point";
            }
            return $"{_player1.Score._Score}\n{_player2.Score._Score}";
        }
    }
}

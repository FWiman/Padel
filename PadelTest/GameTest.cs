using Padel;
using Xunit;

namespace PadelTest
{
    public class GameTest
    {
        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void ScoreString_ShouldBeDeuceAlways()
        {
            Player player1 = new Player("Fredrik");
            Player player2 = new Player("Alexandra");
            Game game = new Game(player1, player2);

            player1.Score._Score = 4;
            player2.Score._Score = 5;

            for (int i = 0; i < 200; i++)
            {
                game.Point(player1);
                game.Point(player2);
            }

            var result = game.ScoreString();

            Assert.Equal("Match Point", result);

        }

        /// <summary>
        /// Testar två stycken utfall där player1 får sista pöängen och vinner ena fallet och player2 andra fallet.
        /// </summary>
        /// <param name="Case"></param>
        /// <param name="points"></param>
        /// <param name="expected"></param>
        [Theory]
        [InlineData(0, 5, "Player 1 wins")]
        [InlineData(1, 5, "Player 2 wins")]
        public static void GameTesting(int Case, int points, string expected)
        {
            var player1 = new Player("Fredrik");
            var player2 = new Player("Alexandra");

            var game1 = new Game(player1, player2);


            for (int i = 0; i < 5; i++)
            {
                if (Case == 0)
                {
                    game1.Point(player1);
                }
                if (Case == 1)
                {
                    game1.Point(player2);
                }

            }
            if (Case == 0)
            {
                Assert.Equal(points, game1.Score(player1)._Score);
                Assert.Equal(expected, game1.ScoreString());
            }
            if (Case == 1)
            {
                Assert.Equal(points, game1.Score(player2)._Score);
                Assert.Equal(expected, game1.ScoreString());
            }


        }
        /// <summary>
        /// testar Deuce för att se att det återgår till deuce.
        /// </summary>
        [Fact]
        public static void DeuceTesting()
        {
            var player1 = new Player("Fredrik");
            var player2 = new Player("Alexandra");

            var game = new Game(player1, player2);

            for (int i = 0; i < 4; i++)
            {
                game.Point(player1);
                game.Point(player2);
            }

            var result = game.ScoreString();

            Assert.Equal("Deuce", result);
        }

        /// <summary>
        /// Här försöker vi se om man vinner Deuce efter att man leder med två poäng.
        /// </summary>
        [Fact]
        public static void WinningAfterTwoPointsDeuceTesting()
        {
            var player1 = new Player("Fredrik");
            var player2 = new Player("Alexandra");

            var game = new Game(player1, player2);


            player1.Score._Score = 5;    
            player2.Score._Score = 7;    
            
            var result = game.ScoreString();

            Assert.Equal("Player 2 wins", result);
        }
        /// <summary>
        /// Testar att se om en spelare vinner efter att man tagit 1 poäng. Borde vara fel!
        /// </summary>
        [Fact]
        public static void WinningAfterOnePointDeuceTesting_ShouldNotWork()
        {
            var player1 = new Player("Fredrik");
            var player2 = new Player("Alexandra");

            var game = new Game(player1, player2);

            for (int i = 0; i < 4; i++)
            {
                game.Point(player1);
                game.Point(player2);

                if (player1.Score._Score == 4)
                {
                    for (int j = 0; j < 1; j++)
                    {
                        game.Point(player1);
                    }
                }

            }

            var result = game.ScoreString();

            Assert.False("Player 1 wins" == result);
        }

    }
}

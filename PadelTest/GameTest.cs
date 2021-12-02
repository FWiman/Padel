using Padel;
using Xunit;

namespace PadelTest
{
    public class GameTest
    {
        [Theory]
        [InlineData(0,50,"Player 1 wins")]
        [InlineData(1,50,"Player 2 wins")]
        public static void GameTesting(int Case, int points, string expected)
        {
            var player1 = new Player("Fredrik");
            var player2 = new Player("Alexandra");

            var game1 = new Game(player1, player2);


            for (int i = 0; i < 4; i++)
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
        
        /*
        [Fact]
        public static void DeuceTesting()
        {
            
        }
        */
    }
}

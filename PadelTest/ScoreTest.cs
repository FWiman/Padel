using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Padel;

namespace PadelTest
{
    public class ScoreTest                                      
    {
        /// <summary>
        /// Vi testar här om vi increasar score med olika indata.
        /// </summary>
        /// <param name="nrOfTimes"></param>
        /// <param name="expected"></param>
        [Theory]
        [InlineData(1,1)]
        [InlineData(2,2)]
        [InlineData(3,3)]
        public static void TestingAddScore(int nrOfTimes, int expected)
        {
            var score = new Score();

            for (int i = 0; i < nrOfTimes; i++)
            {
                score.Increase();
            }

            Assert.Equal(expected, score._Score);

        }
        /// <summary>
        /// Testar om Score kan bli ett negativt tal, borde inte gå. En bugg!!
        /// </summary>
        [Fact]
        public void Score_Should_Not_Allow_Negative_Value()
        {
            var player1 = new Player("Fredrik");
            var player2 = new Player("Alexandra");
            var game = new Game(player1, player2);

            game.Point(player1);

            int negativeValue = 1;
            player1.Score._Score = player1.Score._Score - negativeValue;
            Assert.Equal(0, player1.Score._Score);
        }
    }
}

using Padel;
using Xunit;

namespace PadelTest
{
    public class MatchTest
    {
        /// <summary>
        /// Testar att ge player1 3 set poäng.
        /// </summary>
        [Fact]
        public static void MatchListTest3Sets()
        {
            var player1 = new Player("Fredrik");
            var player2 = new Player("Alexandra");
            var match = new Match(3, player1, player2);

            for (int i = 0; i < 3; i++)
            {
                match.Point(player1);
            }
            Assert.Equal(3, match._sets.Count);
        }

        /// <summary>
        /// Testar att se om matchen slutar efter 3 sets trots att vi ger player1 4 set poäng.
        /// </summary>
        [Fact]
        public void Matchtest_MoreThan3()
        {
            var player1 = new Player("Fredrik");
            var player2 = new Player("Alexandra");
            var match = new Match(3, player1, player2);

            for (int i = 0; i < 4; i++)
            {
                match.Point(player1);
            }

            Assert.Equal(3, match._sets.Count);
        }

        /// <summary>
        /// Testar tre olika indata för att se om MatchScore fungerar med tre olika utfall.
        /// </summary>
        /// <param name="nrOfSets"></param>
        /// <param name="GameCase"></param>
        /// <param name="expected"></param>
        [Theory]
        [InlineData(3, 0, "Player 1 wins the match")]
        [InlineData(3, 1, "Player 2 wins the match")]
        [InlineData(3, 2, "Player 1 score is 1 \n Player 2 score is 2")]
        public void Matchtest_DifferentWinningScenarios(int nrOfSets, int GameCase, string expected)
        {
            var player1 = new Player("Fredrik");
            var player2 = new Player("Alexandra");
            var match = new Match(3, player1, player2);

            for (int i = 0; i < nrOfSets; i++)
            {
                if (GameCase == 0)
                {
                    match.Point(player1);
                }
                else if (GameCase == 1)
                {
                    match.Point(player2);
                }
                else if (GameCase == 2)
                {
                    player1.Score._Score = 1;
                    player2.Score._Score = 2;
                }
            }

            var result = match.ScoreString();

            Assert.Equal(3, match._sets.Count);
            Assert.Equal(expected, result);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="score1"></param>
        /// <param name="score2"></param>
        /// <param name="expected"></param>
        [Theory]
        [InlineData(3, 2, 0)]
        [InlineData(1, 3, 0)]
        [InlineData(0, 0, 0)]
        public void ScoreShouldReturnSetScore(int score1, int score2, int expected)
        {
            var player1 = new Player("Fredrik");
            var player2 = new Player("Alexandra");
            var match = new Match(3, player1, player2);

            player1.Score._Score = score1;
            player2.Score._Score = score2;

            var result = match.MatchScore();

            Assert.Equal(result._Score, expected);

        }

        /// <summary>
        /// Testar Pointmetoden, borde inte kunna ge poäng efter att en spelare har 3 poäng redan.
        /// </summary>
        [Fact]
        public void TestPoint()
        {
            var player1 = new Player("Fredrik");
            var player2 = new Player("Alexandra");
            var match = new Match(3, player1, player2);

            player1.Score._Score = 3;
            match.Point(player1);

            Assert.Equal(3, player1.Score._Score);

        }
    }
}

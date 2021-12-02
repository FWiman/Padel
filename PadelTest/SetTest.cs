using Padel;
using Xunit;

namespace PadelTest
{
    public class SetTest
    {

        [Fact]
        public static void ListTest()                           // Testing to see if the list works.
        {
            var set = new Set();
            var player1 = new Player("Fredrik");

            for (int i = 0; i < 3; i++)
            {
                set.Point(player1);
            }
            Assert.Equal(3, set._games.Count);
        }

        
        [Theory]
        [InlineData(3, 0, 40, 0)]
        [InlineData(0, 3, 0, 40)]
        [InlineData(1, 2, 15, 30)]

        public static void AddPointToSet(int player1Score, int player2Score, int expectedPlayer1, int expectedPlayer2)      
        {
                                                    // Seeing if the player who wins the game gets transfered to the list of sets.
            int player1SetScore = 0;
            int player2SetScore = 0;
            var set = new Set();
            var player2 = new Player("Alexandra");
            var player1 = new Player("Fredrik");


            for (int i = 0; i < player1Score; i++)
            {
                set.Point(player1);
                player1SetScore = set._games[i].Score(player1)._Score;
            }

            for (int i = 0; i < player2Score; i++)
            {
                set.Point(player2);
                player2SetScore = set._games[i].Score(player2)._Score;
            }

            Assert.Equal(expectedPlayer1, player1SetScore);
            Assert.Equal(expectedPlayer2, player2SetScore);

        }
        
    }
}

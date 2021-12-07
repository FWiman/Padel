using Padel;
using Xunit;

namespace PadelTest
{
    public class SetTest
    {
        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public static void ListTest_ShouldBeOneInstanceOfList()
        {

            var player2 = new Player("Alexandra");
            var player1 = new Player("Fredrik");
            var set = new Set(player1, player2);

            for (int i = 0; i < 5; i++)
            {
                set.Point(player1);
            }
            Assert.Single(set._games);
        }

        [Fact]
        public static void ListTest_ShouldBeMoreThanOneInstanceOfList()
        {

            var player2 = new Player("Alexandra");
            var player1 = new Player("Fredrik");
            var set = new Set(player1, player2);

            for (int i = 0; i < 6; i++)
            {
                set.Point(player1);
            }
            Assert.True(set._games.Count == 2);
        }

        [Fact]
        public void ListTest_AllInstancesShouldContainPlayer1Score()
        {
            var player1 = new Player("Fredrik");
            var player2 = new Player("Alexandra");
            var set = new Set(player1, player2);
            var game = new Game(player1, player2);


            player1.Score._Score = 4;
            set.Point(player1);
            set.Point(player1);

            Assert.Equal(set._games[0].Score(player1), player1.Score);
            Assert.Equal(set._games[1].Score(player1), player1.Score);

        }

        [Fact]
        public void ListTest_SecondInstanceOfListShouldContainPlayer2Score()
        {
            var player1 = new Player("Fredrik");
            var player2 = new Player("Alexandra");
            var set = new Set(player1, player2);
            var game = new Game(player1, player2);

            for (int i = 0; i < 5; i++)
            {
                game.Point(player2);
            }
            set.Point(player2);

            Assert.True(set._games[1].Score(player2) == player2.Score);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Padel;

namespace PadelTest
{
    public class MatchTest
    {
        [Fact]
        public static void MatchListTest()
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
    }
}

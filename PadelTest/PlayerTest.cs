using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Padel;

namespace PadelTest
{
    public class PlayerTest
    {
        /// <summary>
        /// Kollar om player1 sparar namnet.
        /// </summary>
        [Fact]
        public static void TestingCorrectName()
        {
            var player1 = new Player("Fredrik.W");

            Assert.Equal("Fredrik.W", player1.Name);

        }
        /// <summary>
        /// Testar om namnet är null.
        /// </summary>
        [Fact]
        public static void TestingNullName()
        {
            var player1 = new Player("Fredrik.W");

            Assert.NotNull(player1);
        }
        /// <summary>
        /// Testar om man lämnar namnet tomt.
        /// </summary>
        [Fact]
        public static void TestingEmptyName()
        {
            var player1 = new Player("Fredrik.W");

            Assert.NotEmpty(player1.Name);
        }
        /// <summary>
        /// Testar att addera poäng till player1 med olika indata.
        /// </summary>
        /// <param name="nrOfTimes"></param>
        /// <param name="expected"></param>
        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        [InlineData(3, 3)]
        public static void TestingAddPoint(int nrOfTimes, int expected)
        {
            var player1 = new Player("Fredrik");

            for (int i = 0; i < nrOfTimes; i++)
            {
                player1.Point();
            }

            Assert.Equal(expected, player1.Score._Score);

        }

    }
}

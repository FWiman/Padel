using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Padel;

namespace PadelTest
{
    public class PlayerTest
    {
        [Fact]
        public static void TestingCorrectName()
        {
            var player1 = new Player("Fredrik.W");

            Assert.Equal("Fredrik.W", player1.Name);

        }

        [Fact]
        public static void TestingNullName()
        {
            var player1 = new Player("Fredrik.W");

            Assert.NotNull(player1);
        }

        [Fact]
        public static void TestingEmptyName()
        {
            var player1 = new Player("Fredrik.W");

            Assert.NotEmpty(player1.Name);
        }

        [Theory]
        [InlineData(1, 15)]
        [InlineData(2, 30)]
        [InlineData(3, 40)]
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

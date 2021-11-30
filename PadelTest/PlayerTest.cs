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

    }
}

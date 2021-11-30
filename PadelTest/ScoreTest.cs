using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Padel;

namespace PadelTest
{
    public class ScoreTest                                      // Testing to add score by a loop wich checks to see if score is 15,30 and 40.
    {
        [Theory]
        [InlineData(1,15)]
        [InlineData(2,30)]
        [InlineData(3,40)]
        public static void TestingAddScore(int nrOfTimes, int expected)
        {
            var score = new Score();

            for (int i = 0; i < nrOfTimes; i++)
            {
                score.Increase();
            }

            Assert.Equal(expected, score._Score);

        }
    }
}

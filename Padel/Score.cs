using System;

namespace Padel
{
    public class Score
    {
        public int _Score;

        public void Increase()                          // Fixed so that score counts 15 and 10 up too 40 instead of 1-4.
        {
            if (_Score < 30)
            {
                _Score += 15;
            }
            else
            {
                _Score += 10;
            }
        }

    }
}

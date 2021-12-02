using System;

namespace Padel
{
    public class Player
    {
        public string Name { get; set; }
        public Score Score { get; set; } = new Score();                     // Added that a new score is created with every player.
        
        public Player(string name)
        {
            Name = name;
        }
        
        public void Point()                                                 // Point now increases everytime it is used.
        {
            Score.Increase();
        }
    }
}

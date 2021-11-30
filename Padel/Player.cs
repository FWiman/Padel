using System;

namespace Padel
{
    public class Player
    {
        public string Name { get; set; }
        public Score Score { get; set; }
        
        public Player(string name)
        {
            Name = name;
        }
        
        public void Point()
        {
            Score.Increase();
        }
    }
}

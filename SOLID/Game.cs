using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    abstract class Game
    {
        public void Play()
        {
            Initialize();
            Start();

            while (!HasWinner())
            {
                TakeTurn();
            }


        }
        public abstract void Initialize();
        public abstract void Start();
        public abstract bool HasWinner();
        public abstract void TakeTurn();
    
    }
}

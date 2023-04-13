using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace SOLID
{
    class PAMPARAM : Game
    {
        private int _move = 0;
        private string player;
        private string enemy;

        public override bool HasWinner()
        {
            return _move < 0;
        }

        public override void Initialize()
        {
            Console.WriteLine("Adinzi yazin:");
            player = Console.ReadLine();
            Console.WriteLine($"Welcome {player}");
            Console.WriteLine("Adinzi yazin:");
            enemy = Console.ReadLine();
            Console.WriteLine($"Welcom {enemy}");
        }

        public override void Start()
        {
            Console.WriteLine("Let's go");
        }

        public override void TakeTurn()
        {
            bool f = true;
            Random rand = new Random();
            int n = rand.Next(0, 10), m;
            while (n > 0)
            {
                {
                    Console.WriteLine(n);
                    Console.WriteLine($"{player}, siz gedmelisiz");
                    if (f)
                    {
                        m = int.Parse(Console.ReadLine());
                        while ((m >= 1 && m <= 4))
                        {
                            Console.WriteLine($"Duzgun gedmediz! {enemy}, yeniden gedin");
                            m = int.Parse(Console.ReadLine());
                        }
                    }
                    else
                    {
                        m = rand.Next(1, 5);
                        Console.WriteLine(enemy + " gedti " + m);
                    }

                    n = m;
                    f = f;
                }
                _move++;

                Console.WriteLine(0);
                Console.WriteLine((_move % 2 == 0) ? player : enemy +  " udtu!");

            }
        }
    }
}

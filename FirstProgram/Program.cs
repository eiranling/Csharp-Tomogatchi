using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tomogatchi.Model;

namespace Tomogatchi
{
    class Game
    {
        public Game()
        {
            // Empty constructor for now.
        }

        public void Start()
        {
            Pet dog = new Dog("Steve");
            Console.WriteLine(dog);
        }
    }

    class MainClass
    {
        public static void Main(string[] var)
        {
            Game game = new Game();
            game.Start();
        }
    }
}

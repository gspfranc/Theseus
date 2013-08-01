using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Theseus
{
    public class MultiGame : IGame
    {
        List<IGame> games= new List<IGame>();

        public void AddGame(IGame g)
        {
            this.games.Add(g);
        }

        public bool Play()
        {
            foreach (IGame g in games)
            {
                if (!g.Play())
                {
                    Console.Clear();
                    Console.WriteLine("Congratulations, you have failed life.");
                    return false;
                }
                Console.Clear();
            }
            
            Console.WriteLine("Game completed\n");
            return true;
        }
    }
}

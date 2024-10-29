using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2
{
   class Game
    {
        public string Name;
        public Genre Genre;
        public decimal Price;

        public Game(string name, Genre genre, decimal price)
        {
            Name = name;
            Genre = genre;
            Price = price;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2
{
    public class Game
    {
        private string name;
        private double price;
        private int quantity;
        private Genre genre;

        public Game(string name, double price, int quantity, Genre genre)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
            this.genre = genre;
        }

        public string GetName() => name;
        public double GetPrice() => price;
        public int GetQuantity() => quantity;
        public Genre GetGenre() => genre;
    }
}

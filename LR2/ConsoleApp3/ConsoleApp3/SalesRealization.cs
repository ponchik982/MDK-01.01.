using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LR2;

namespace LR2
{
    public class SalesRealization
    {
        private int saleId;
        private Game game;

        public SalesRealization(int saleId, Game game)
        {
            this.saleId = saleId;
            this.game = game;
        }

        public Game GetGame() => game;
        public double GetTotalPrice() => game.GetPrice() * game.GetQuantity();
        public Genre GetGenre() => game.GetGenre();
    }
}

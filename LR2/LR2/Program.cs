using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LR2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Game> Games = new List<Game>()
            {
                new Game("Counter Strike 2", Genre.Action, 100),
                new Game("Dota 2", Genre.RPG, 50),
                new Game("God of war", Genre.Action, 200),
                new Game("Gran Turismo 7", Genre.Sports, 80),
            };
            Dictionary<Genre, (int totalSales, decimal totalRevenue)> salesReport = new Dictionary<Genre, (int totalSales, decimal totalRevenue)>();
            foreach (var genre in Enum.GetValues(typeof(Genre))) 
            {
                salesReport[(Genre)genre] = (0, 0);
            }
            int[,] fixedSales = new int[,]
            {
                { 3, 2, 1 },
                { 2, 3, 2 },
                { 1, 1, 0 },
                { 0, 2, 1 }
            };
            for (int day = 0; day < 3; day++)
            {
                foreach (var game in Games)
                {
                    int genreIndex = (int)game.Genre;
                    int salesCount = fixedSales[genreIndex, day];

                    var currentSalesData = salesReport[game.Genre];

                    currentSalesData.totalSales += salesCount;
                    currentSalesData.totalRevenue += salesCount * game.Price;

                    salesReport[game.Genre] = currentSalesData;
                }
            }

            Console.WriteLine("Отчёт по продажам игр по жанрам:");
            foreach (var report in salesReport)
            {
                Console.WriteLine($"Жанр: {report.Key}");
                Console.WriteLine($"Общее количество продаж: {report.Value.totalSales}");
                Console.WriteLine($"Общая выручка: {report.Value.totalRevenue}");
                Console.WriteLine();
            }
        }
    }
}

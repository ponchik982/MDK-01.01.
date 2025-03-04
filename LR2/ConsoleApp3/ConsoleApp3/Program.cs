using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp3;

namespace LR2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SalesHistory history = new SalesHistory();

            history.AddSale(new SalesRealization(1, new Game("Counter Strike 2", 100.00, 5, Genre.Action)));
            history.AddSale(new SalesRealization(1, new Game("Dota 2", 100.00, 6, Genre.RPG)));
            history.AddSale(new SalesRealization(2, new Game("God of War", 2000.00, 7, Genre.Action)));
            history.AddSale(new SalesRealization(2, new Game("Gran Turismo 7", 5000.00, 8, Genre.Sports)));

            SalesReport report = new SalesReport(history);

            Console.WriteLine("Выберите вид отчёта (0 - Полный, 1 - По жанрам): ");
            int reportType = Convert.ToInt32(Console.ReadLine());

            if (reportType == 0)
            {
                report.PrintFullReport();
            }
            else if (reportType == 1)
            {
                report.PrintGenreReport();
            }
            else
            {
                Console.WriteLine("Недопустимое значение");
            }
        }
    }
}
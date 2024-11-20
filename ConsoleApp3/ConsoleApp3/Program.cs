using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SalesReport report = new SalesReport();

            report.AddSale(new SalesRealization(1, new Game("Counter Strike 2", 100.00, 5, Genre.Action)));
            report.AddSale(new SalesRealization(1, new Game("Dota 2", 100.00, 6, Genre.RPG)));
            report.AddSale(new SalesRealization(2, new Game("God of war", 2000.00, 7, Genre.Action)));
            report.AddSale(new SalesRealization(2, new Game("Gran Turismo 7", 5000.00, 8, Genre.Sports)));

            int reportType;
            Console.WriteLine("Выберите вид отчёта (0 - Полный, 1 - За день, 2 - По жанрам): ");
            reportType = Convert.ToInt32(Console.ReadLine());
            if (reportType == 0)
            {
                report.PrintReportAll();
            }
            else if (reportType == 1)
            {
                report.PrintReportPerDay();
            }
            else if (reportType == 2)
            {
                report.PrintReportPerGenre();
            }
            else
            {
                Console.WriteLine("Недопустимое значение");
            }
        }
    }
}
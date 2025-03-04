using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LR2;

namespace ConsoleApp3
{
    public class SalesHistory
    {
        private List<SalesRealization> sales;

        public SalesHistory()
        {
            sales = new List<SalesRealization>();
        }

        public void AddSale(SalesRealization sale)
        {
            sales.Add(sale);
        }

        public void PrintReportAll()
        {
            Console.WriteLine("Полный отчет о продажах:");
            foreach (var sale in sales)
            {
                Console.WriteLine($"Игра: {sale.GetGame().GetName()}, Количество: {sale.GetGame().GetQuantity()}, Общая стоимость: {sale.GetTotalPrice()} руб.");
            }
        }

        public void CalculateTotalSalesPerGenre()
        {
            var salesByGenre = sales
                .GroupBy(sale => sale.GetGenre())
                .Select(group => new
                {
                    Genre = group.Key,
                    TotalSales = group.Sum(sale => sale.GetTotalPrice())
                });

            Console.WriteLine("Отчет по жанрам:");
            foreach (var genreSales in salesByGenre)
            {
                Console.WriteLine($"Жанр: {genreSales.Genre}, Общая стоимость продаж: {genreSales.TotalSales} руб.");
            }
        }
    }
}

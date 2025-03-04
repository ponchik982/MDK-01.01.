using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp3;

namespace LR2
{
    public class SalesReport
    {
        private SalesHistory history;

        public SalesReport(SalesHistory history)
        {
            this.history = history;
        }

        public void PrintFullReport()
        {
            history.PrintReportAll();
        }

        public void PrintGenreReport()
        {
            history.CalculateTotalSalesPerGenre();
        }
    }
}

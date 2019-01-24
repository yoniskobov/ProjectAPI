using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaemdll
{
    public class Zaem
    {
        public float CreditAmount { get; set; }
        public float CreditDeadline { get; set; }
        public float YearInterest { get; set; }

        public float MonthlyResult { get; set; }
        public float TotalResult { get; set; }

        public static Zaem Calculate(decimal amountStr, decimal deadlineStr, decimal interestStr)
        {
            Zaem results = new Zaem();

            results.CreditAmount = (float)amountStr;
            results.CreditDeadline = (float)deadlineStr;
            results.YearInterest = (float)interestStr;

            double interest = ((float)interestStr) / 100;
            double month = ((float)deadlineStr) / 12;
            double result = ((float)amountStr) * (1 + (interest * month));
            double monthly = result / ((float)deadlineStr);

            results.TotalResult = (float)Math.Round(result,2);
            results.MonthlyResult = (float)Math.Round(monthly);

            return results;
        }
    }
}

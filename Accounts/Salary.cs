using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_17_6_6.Accounts
{
    /// <summary>
    /// Зарплатный аккаунт
    /// </summary>
    public class Salary : IAccount
    {
        // баланс учетной записи
        public double Balance { get; set; }

        // процентная ставка
        public double Interest { get; set; }

        public void CalculateInterest()
        {
            // расчет процентной ставк зарплатного аккаунта по правилам банка
            Interest = Balance * 0.5;
        }

        public void Print()
        {
            Console.WriteLine($"Процентная ставка: {Interest}");
        }
    }
}

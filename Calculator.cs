﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_17_6_6.Accounts;

namespace Task_17_6_6
{
    public static class Calculator
    {
        // Метод для расчета процентной ставки
        public static void CalculateInterest(IAccount account)
        {
            account.CalculateInterest();
        }
    }
}

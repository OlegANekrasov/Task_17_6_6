using Task_17_6_6.Accounts;

namespace Task_17_6_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Обычный аккаунт 
            Ordinary ordinary = new Ordinary() { Balance = 100000 };
            Calculator.CalculateInterest(ordinary);
            ordinary.Print();

            // Зарплатный аккаунт
            Salary salary = new Salary() { Balance = 100000 };
            Calculator.CalculateInterest(salary);
            salary.Print();

            Console.ReadLine();
        }
    }
}
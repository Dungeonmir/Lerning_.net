using System;

namespace Lern_.net
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Калькулятор Вкладчик");


            decimal depositAmount;
            Console.WriteLine("Сумма вклада: ");
            depositAmount = Convert.ToDecimal(Console.ReadLine());

            decimal percents;
            Console.WriteLine("Процентная ставка: ");
            percents = Convert.ToDecimal(Console.ReadLine());
            percents /= 1200;

            int srok;
            Console.WriteLine("Срок вклада (в месяцах): ");
            srok = Convert.ToInt32(Console.ReadLine());

            int length;
            length = srok;
            decimal newDepositAmount = depositAmount;


            for (int i = 0; i < length; i++)
            {
                newDepositAmount *= (1 + percents);
            }

            Console.WriteLine($"Сумма в банке: {Decimal.Round(newDepositAmount, 2)}");
            newDepositAmount -= depositAmount;
            Console.WriteLine($"Прибыль: {Decimal.Round(newDepositAmount, 2)}");
            Console.ReadLine();
        }
    }
}

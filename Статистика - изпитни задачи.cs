using System;
using System.Linq;

namespace Статистика
{
    class Program
    {
        static void Main(string[] args)
        {
            int agents = int.Parse(Console.ReadLine());
            int[] agentsOffers = new int[agents];
            decimal[] values = new decimal[agents];
            for (int i = 0; i < agents; i++)
            {
                agentsOffers[i] = int.Parse(Console.ReadLine());
                values[i] = 0;
                for (int offer  = 0; offer  < agentsOffers[i]; offer ++)
                {
                    int area = int.Parse(Console.ReadLine());
                    decimal price = decimal.Parse(Console.ReadLine());
                    values[i] += area * price;
                }
            }
            Console.WriteLine(Math.Round(values.Average(),3));
        }
    }
}

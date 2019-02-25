using System;
using System.Linq;
using System.Collections.Generic;

namespace Ученици
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> grades = Console.ReadLine().Trim(' ').Split(' ').
                Select(int.Parse).ToList();
            int examCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < examCount; i++)
            {
                if (grades.Count > 0)
                {
                    List<string> info = Console.ReadLine().Split(' ').ToList();
                    int stNumber = int.Parse(info[0]);
                    int assesment = int.Parse(info[1]);
                    if (assesment > grades[stNumber])
                    {
                        grades[stNumber] += assesment;
                    }
                    else
                    {
                        if (assesment > grades [stNumber] / 2)
                        {
                            grades.Remove(grades[stNumber]);
                        }
                        else
                        {
                            grades[stNumber] -= assesment;
                        }
                    }
                }
                else
                {
                    break;
                }
            }
            if (grades.Count > 0)
            {
                Console.WriteLine(String.Join("; " , grades));
            }
            else
            {
                Console.WriteLine("All students has been expelled due bad results");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask8_6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<double> set1 = new HashSet<double>();
            while(true)
            {
                Console.Write("\nВведите число: ");
                bool var = double.TryParse(Console.ReadLine(), out double number);
                if (var == true)
                {
                    var = set1.Contains(number);
                    if (var == true) Console.WriteLine($"Число {number} уже вводилось и содержится в колекции");
                    else set1.Add(number);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Вы ввели что-то не то, До Свидания!");
                    Console.ReadKey();
                    break;
                }
                
            }
            
        }
    }
}

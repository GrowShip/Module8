using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask8_6_1
{
    class Program
    {
        /// <summary>
        /// Заполняет List
        /// </summary>
        /// <param name="IntList"></param>
        static void WriteList(ref List<int> IntList)
        {
            Random r = new Random();
            for (int i = 0; i < 100; i++) IntList.Add(r.Next(0, 100));
        }
        
        /// <summary>
        /// Отображение List
        /// </summary>
        /// <param name="IntList"></param>
        static void ShowList(List<int> IntList)
        {
            Console.WriteLine($"Коллекция чисел: \n");
            foreach (var item in IntList)
            {
                Console.Write($"{item} ");
            }
        }

        /// <summary>
        /// Удаление в list item: 25<item<50
        /// </summary>
        /// <param name="IntList"></param>
        static void DeletItem(ref List<int> IntList)
        {
            for (int i = 0; i < IntList.Count; i++)
            {
                if ((IntList[i] > 25) && (IntList[i] < 50))
                {
                    IntList.RemoveAt(i);
                }
            }
        }

        static void Main(string[] args)
        {
            List<int> IntList = new List<int>();
            WriteList(ref IntList);
            ShowList(IntList);

            Console.ReadKey();
            Console.WriteLine("\n");

            DeletItem(ref IntList);
            Console.WriteLine($"Лист с числами вне диапозона 25..50:");
            ShowList(IntList);

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask8_6_2
{
    class Program
    {
        /// <summary>
        /// Менюшка
        /// </summary>
        static void Menu(ref char key)
        {
            string[][] menu = new string[3][];
            for (int i = 0; i < menu.Length; i++) menu[i] = new string[2];
            menu[0][0] = "Добавить новый номер абонента"; menu[0][1] = "Нажмите 1";
            menu[1][0] = "Найти абонента по номеру"; menu[1][1] = "Нажмите 2";
            menu[2][0] = "Выйти из приложения        "; menu[2][1] = "Нажмите 3";
            for (int i = 0; i < menu.Length; i++)
            {
                Console.WriteLine("{0}\t{1}\t", menu[i][0], menu[i][1]);
            }
            key = Console.ReadKey(true).KeyChar;
        }

        /// <summary>
        /// Выбор из меню
        /// </summary>
        /// <param name="key"></param>
        static void Choice(char key, ref Dictionary<ulong, string> PhoneBook)
        {
            char key1 = '1';
            char key2 = '2';
            if (key == key1) AddNumber(ref PhoneBook);
            else if (key == key2) FindID(PhoneBook);
        }
        /// <summary>
        /// Добавляет номер и ФИО
        /// </summary>
        /// <param name="PhoneBook"></param>
        static void AddNumber(ref Dictionary<ulong, string> PhoneBook)
        {
            Console.Write("Введите номер в формате 79991119911: ");
            ulong number = ulong.Parse(Console.ReadLine());
            Console.Write("Введите ФИО абонента: ");
            string name = Console.ReadLine();
            PhoneBook.Add(number, name);
            Console.Clear();
            Console.WriteLine($"Контакт {name} добавлен в записную книжку");
        }
        /// <summary>
        /// Поиск ФИО по номеру
        /// </summary>
        /// <param name="PhoneBook"></param>
        static void FindID(Dictionary<ulong, string> PhoneBook)
        {
            Console.Write("Введите номер для поиска в формате 79991119911: ");
            ulong number = ulong.Parse(Console.ReadLine());
            bool find = PhoneBook.TryGetValue(number, out string name);
            Console.Clear();
            if (find == true) Console.WriteLine($"Номер {number} ФИО {name}");
            else Console.WriteLine($"Извините, но {number} нет в записной книжке");
        }
        static void Main(string[] args)
        {
            Dictionary<ulong, string> PhoneBook = new Dictionary<ulong, string>();
            char keyChoice = '0';
            char key3 = '3';
            while (true)
            {
                Console.WriteLine();
                Menu(ref keyChoice);
                Console.Clear();
                if (keyChoice != key3) Choice(keyChoice, ref PhoneBook);
                else break;
            }
        }
    }
}

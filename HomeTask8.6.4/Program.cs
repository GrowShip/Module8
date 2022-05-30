using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;

namespace HomeTask8_6_4
{
    class Program
    {
        /// <summary>
        /// Новые данные о контакте
        /// </summary>
        static void InfoPerson(ref Person info)
        {
            Console.Write("Введите ФИО сотрудника - ");
            string fullname = Console.ReadLine();
            Console.Write("Введите улицу - ");
            string street = Console.ReadLine();
            Console.Write("Введите номер дома - ");
            int building = int.Parse(Console.ReadLine());
            Console.Write("Введите номер квартиры - ");
            int apartment = int.Parse(Console.ReadLine());
            Console.Write("Введите мобильный телефон - ");
            ulong mobilenumber = ulong.Parse(Console.ReadLine());
            Console.Write("Введите домашний телефон - ");
            ulong homenumber = ulong.Parse(Console.ReadLine());

            info = new Person()
            {
                FullName = fullname,
                Street = street,
                Building = building,
                Apartment = apartment,
                MobileNumber = mobilenumber,
                HomeNumber = homenumber,
            };
        }

        /// <summary>
        /// Создание структуры XML
        /// </summary>
        /// <param name="infoperson">Данные о контакте</param>
        /// <param name="Person">XML корневой элемент</param>
        static void CreatElement(Person infoperson, ref XElement Person)
        {
            XElement Address = new XElement("Address");
            XElement Phones = new XElement("Phones");

            XElement Street = new XElement("Street", infoperson.Street);
            XElement HouseNumber = new XElement("HouseNumber", infoperson.Building);
            XElement FlatNumber = new XElement("FlatNumber", infoperson.Apartment);

            XElement MobilePhone = new XElement("MobilePhone", infoperson.MobileNumber);
            XElement FlatPhone = new XElement("FlatPhone", infoperson.HomeNumber);

            XAttribute name = new XAttribute("name", infoperson.FullName);

            Person.Add(name);
            Person.Add(Address);
            Person.Add(Phones);

            Address.Add(Street);
            Address.Add(HouseNumber);
            Address.Add(FlatNumber);

            Phones.Add(MobilePhone);
            Phones.Add(FlatPhone);
        }

        static void Main(string[] args)
        {
            Person infoperson = new Person();
            InfoPerson(ref infoperson);

            XElement Person = new XElement("Person");
            CreatElement(infoperson, ref Person);

            Console.WriteLine(Person);

            Person.Save("PersonInfo");

            Console.ReadKey();
        }
    }
}

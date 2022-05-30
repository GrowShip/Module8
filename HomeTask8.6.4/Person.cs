using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask8_6_4
{
    struct Person
    {
        #region Поля
        /// <summary>
        /// Поле ФИО
        /// </summary>
        private string fullname;
        /// <summary>
        /// Поле 3лица
        /// </summary>
        private string street;
        /// <summary>
        /// Поле номер дома
        /// </summary>
        private int building;
        /// <summary>
        /// Поле номер квартиры
        /// </summary>
        private int apartment;
        /// <summary>
        /// Поле номер мобильного телефона
        /// </summary>
        private ulong mobilenumber;
        /// <summary>
        /// Поле номер домашнего телефона
        /// </summary>
        private ulong homenumber;

        #endregion

        #region Свойства
        /// <summary>
        /// ФИО
        /// </summary>
        public string FullName { get { return this.fullname; } set { this.fullname = value; } }
        /// <summary>
        /// Улица
        /// </summary>
        public string Street { get { return this.street; } set { this.street = value; } }
        /// <summary>
        /// Номер дома
        /// </summary>
        public int Building { get { return this.building; } set { this.building = value; } }
        /// <summary>
        /// Номер квартиры
        /// </summary>
        public int Apartment { get { return this.apartment; } set { this.apartment = value; } }
        /// <summary>
        /// Мобильный телефон
        /// </summary>
        public ulong MobileNumber { get { return this.mobilenumber; } set { this.mobilenumber = value; } }
        /// <summary>
        /// Домашний телефон
        /// </summary>
        public ulong HomeNumber { get { return this.homenumber; } set { this.homenumber = value; } }

        #endregion

        #region Конструктор
        /// <summary>
        /// Данные о контакте
        /// </summary>
        /// <param name="FullName">ФИО</param>
        /// <param name="Street">Улица</param>
        /// <param name="Building">Номер дома</param>
        /// <param name="Apartment">Номер квартиры</param>
        /// <param name="MobileNumber">Мобильный телефон</param>
        /// <param name="HomeNumber">Домашний телефон</param>
        public Person(string FullName, string Street, int Building, int Apartment, ulong MobileNumber, ulong HomeNumber)
        {
            this.fullname = FullName;
            this.street = Street;
            this.building = Building;
            this.apartment = Apartment;
            this.mobilenumber = MobileNumber;
            this.homenumber = HomeNumber;
        }
        
        #endregion
    }
}

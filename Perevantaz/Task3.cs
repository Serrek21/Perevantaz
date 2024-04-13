using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perevantaz
{
    internal class Task3
    {
        public class City
        {
            public string Name { get; set; }

            private int _population;
            public int Population
            {
                get { return _population; }
                set { _population = value; }
            }

            public City(string name, int population)
            {
                Name = name;
                Population = population;
            }

            // Перевантаження оператора збільшення кількості жителів
            public static City operator +(City city, int amount)
            {
                city.Population += amount;
                return city;
            }

            // Перевантаження оператора зменшення кількості жителів
            public static City operator -(City city, int amount)
            {
                city.Population -= amount;
                return city;
            }

            // Перевантаження оператора порівняння для перевірки рівності кількості жителів міст
            public static bool operator ==(City city1, City city2)
            {
                if (ReferenceEquals(city1, city2))
                    return true;

                if (city1 is null || city2 is null)
                    return false;

                return city1.Population == city2.Population;
            }

            // Перевантаження оператора порівняння для перевірки нерівності кількості жителів міст
            public static bool operator !=(City city1, City city2)
            {
                return !(city1 == city2);
            }

            // Перевантаження оператора порівняння для порівняння кількості жителів міст
            public static bool operator >(City city1, City city2)
            {
                return city1.Population > city2.Population;
            }

            // Перевантаження оператора порівняння для порівняння кількості жителів міст
            public static bool operator <(City city1, City city2)
            {
                return city1.Population < city2.Population;
            }

            // Перевизначення методу Equals для порівняння міст за кількістю жителів
            public override bool Equals(object obj)
            {
                if (!(obj is City))
                    return false;

                City other = (City)obj;
                return this.Population == other.Population;
            }
        }
    }
}

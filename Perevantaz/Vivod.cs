using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Perevantaz.Task2;
using static Perevantaz.Task4;
using static Perevantaz.Task1;
using static Perevantaz.Task3;

namespace Perevantaz
{
    internal class Vivod
    {
        class Program
        {
            static void Main(string[] args)
            {
                //1
                Employee emp1 = new Employee("John", "Manager", 5000);
                Employee emp2 = new Employee("Alice", "Developer", 4500);

                Console.WriteLine($"Employee 1 Salary: {emp1.Salary}");
                Console.WriteLine($"Employee 2 Salary: {emp2.Salary}");

                emp1.IncreaseSalary(1000);
                Console.WriteLine($"Employee 1 New Salary after Increase: {emp1.Salary}");

                emp2.DecreaseSalary(500);
                Console.WriteLine($"Employee 2 New Salary after Decrease: {emp2.Salary}");

                Console.WriteLine($"Are salaries equal? {emp1.SalaryEquals(emp2)}");
                Console.WriteLine($"Is Employee 1 salary greater than Employee 2? {emp1.IsSalaryGreaterThan(emp2)}");
                Console.WriteLine($"Is Employee 1 salary less than Employee 2? {emp1.IsSalaryLessThan(emp2)}");
                Console.WriteLine($"Are salaries not equal? {emp1.IsNotEquals(emp2)}");
                //2
                Matrix a = new Matrix(2, 2);
                a[0, 0] = 1; a[0, 1] = 2;
                a[1, 0] = 3; a[1, 1] = 4;

                Matrix b = new Matrix(2, 2);
                b[0, 0] = 5; b[0, 1] = 6;
                b[1, 0] = 7; b[1, 1] = 8;

                Matrix c = a + b;
                Console.WriteLine("Matrix addition:");
                for (int i = 0; i < c.Rows; i++)
                {
                    for (int j = 0; j < c.Columns; j++)
                    {
                        Console.Write(c[i, j] + " ");
                    }
                    Console.WriteLine();
                }

                Matrix d = a * b;
                Console.WriteLine("Matrix multiplication:");
                for (int i = 0; i < d.Rows; i++)
                {
                    for (int j = 0; j < d.Columns; j++)
                    {
                        Console.Write(d[i, j] + " ");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine($"Are matrices equal? {a == b}");
                Console.WriteLine($"Are matrices not equal? {a != b}");

                //3
                City city1 = new City("City A", 1000000);
                City city2 = new City("City B", 500000);

                Console.WriteLine($"City 1 Population: {city1.Population}");
                Console.WriteLine($"City 2 Population: {city2.Population}");

                city1 += 50000;
                Console.WriteLine($"City 1 New Population after Increase: {city1.Population}");

                city2 -= 20000;
                Console.WriteLine($"City 2 New Population after Decrease: {city2.Population}");

                Console.WriteLine($"Are populations equal? {city1 == city2}");
                Console.WriteLine($"Is City 1 population greater than City 2? {city1 > city2}");
                Console.WriteLine($"Is City 1 population less than City 2? {city1 < city2}");
                Console.WriteLine($"Are populations not equal? {city1 != city2}");


                //4
                CreditCard card1 = new CreditCard("1234 5678 9012 3456", "12/25", 123, 1000);
                CreditCard card2 = new CreditCard("9876 5432 1098 7654", "11/24", 456, 2000);

                Console.WriteLine($"Card 1 Balance: {card1.Balance}");
                Console.WriteLine($"Card 2 Balance: {card2.Balance}");

                card1 += 500;
                Console.WriteLine($"Card 1 New Balance after Increase: {card1.Balance}");

                card2 -= 300;
                Console.WriteLine($"Card 2 New Balance after Decrease: {card2.Balance}");

                Console.WriteLine($"Are CVC codes equal? {card1 == card2}");
                Console.WriteLine($"Is Card 1 balance greater than Card 2? {card1 > card2}");
                Console.WriteLine($"Is Card 1 balance less than Card 2? {card1 < card2}");
                Console.WriteLine($"Are CVC codes not equal? {card1 != card2}");
            }
        }
    }
}

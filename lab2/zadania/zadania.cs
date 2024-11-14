using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.zadania
{
    public class Person
    {
        private string name;
        private string surname;
        private int age;
        private string pesel;

        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age
        {
            get { return age; } 
            set
            {
                if (value < 0)
                {
                    age = 0;
                }
                else
                {
                    age = value;
                }
            }
        }
        public string Pesel { get; }

        public Person(string name, string surname, int age, string pesel)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Pesel = pesel;
        }

        public void PrzedstawSie()
        {
            Console.WriteLine($"Nazywam się {Name} {Surname} i mam {Age} lat");
        }
    }

    public class Quantity
    {
        private int Num { get; set; }

        public Quantity(int num)
        {
            Num = num; 
        }

        public void Sum(int num)
        {
            Num += num;
        }

        public void Subtraction(int num)
        {
            Num -= num;
        }

        public void Condition()
        {
            Console.WriteLine(Num);
        }
    }

    public class Adder(int[] num)
    {
        private int[] numbers = num;
        public int Sum()
        {
            return numbers.Sum();
        }
        public double SumDiv3()
        {
            return (double)numbers.Sum(x => x/3);
        }
        public int Count()
        {
            return numbers.Count();
        }
        public void Display(int low, int high)
        {
            if(low < 0)
            {
                low = 0;
            }
            if(high > numbers.Length - 1)
            {
                high = numbers.Length - 1;
            }
            for (int i = low; i <= high; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {

        class Animal
        {
            protected string name;
            protected int age;
            protected string habitat;

            public Animal(string name, int age, string habitat)
            {
                this.name = name;
                this.age = age;
                this.habitat = habitat;
            }

            public virtual void DisplayInfo()
            {
                Console.WriteLine("Животное: " + name);
                Console.WriteLine("Возраст: " + age);
                Console.WriteLine("Место обитания: " + habitat);
            }
        }

        class Tiger : Animal
        {
            private string prey;

            public Tiger(string name, int age, string habitat, string prey)
                : base(name, age, habitat)
            {
                this.prey = prey;
            }

            public void Hunt()
            {
                Console.WriteLine(name + " охотится на " + prey);
            }
        }

        class Crocodile : Animal
        {
            private string favoriteFood;

            public Crocodile(string name, int age, string habitat, string favoriteFood)
                : base(name, age, habitat)
            {
                this.favoriteFood = favoriteFood;
            }

            public void Swim()
            {
                Console.WriteLine(name + " плавает в воде.");
            }
        }

        class Kangaroo : Animal
        {
            private int jumpHeight;

            public Kangaroo(string name, int age, string habitat, int jumpHeight)
                : base(name, age, habitat)
            {
                this.jumpHeight = jumpHeight;
            }

            public void Jump()
            {
                Console.WriteLine(name + " прыгает на высоту " + jumpHeight + " метров.");
            }
        }

        class Program2
        {
            static void Main(string[] args)
            {
                //Задание 1
                Tiger tiger = new Tiger("Тигр", 5, "Джунгли", "Оленя");
                tiger.DisplayInfo();
                tiger.Hunt();

                Console.WriteLine();

                Crocodile crocodile = new Crocodile("Крокодил", 10, "Болото", "Газелей");
                crocodile.DisplayInfo();
                crocodile.Swim();

                Console.WriteLine();

                Kangaroo kangaroo = new Kangaroo("Кенгуру", 3, "Австралия", 2);
                kangaroo.DisplayInfo();
                kangaroo.Jump();

                //Задание 2

                int n = 5;

                for (int i = 1; i <= n; i++)
                {
                    for (int j = n - i; j > 0; j--)
                    {
                        Console.Write(" ");
                    }

                    for (int k = 1; k <= i; k++)
                    {
                        Console.Write("* ");
                    }

                    Console.WriteLine();
                }

                for (int i = n - 1; i > 0; i--)
                {
                    for (int j = 0; j < n - i; j++)
                    {
                        Console.Write(" ");
                    }

                    for (int k = i; k > 0; k--)
                    {
                        Console.Write("* ");
                    }

                    Console.WriteLine();
                }
                //Задание 3

                double a = 1.5;
                double b = 2.0;
                double c = 0.5;

                Func<double, double> quadraticFunction = GetQuadraticFunction(a, b, c);

                double x = 2.0;
                double result = quadraticFunction(x);

                Console.WriteLine("Результат: " + result);


                static Func<double, double> GetQuadraticFunction(double a, double b, double c)
                {
                    return x => a * x * x + b * x + c;
                }


                Console.ReadKey();
            }
        }
    }
}

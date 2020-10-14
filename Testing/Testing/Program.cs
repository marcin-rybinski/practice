using System;
using System.Linq;
using System.Threading.Channels;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            var dog = new Dog();
            var wolf = new Wolf();
            Animal animal = new Animal();
            int i = 0;
            double f = 2.1;

            //animal = wolf; //ok

            //wolf = animal; //nie ok 

            //wolf = dog; //nie ok

            //wolf = (Wolf)dog; //nie ok

            //wolf = (Wolf) (Animal) dog; //ok

            //wolf = animal as Wolf; //ok

            wolf = (Wolf) animal; //ok

            i = (int)f;

            //Console.Write("Enter something:");
            //string s1 = Console.ReadLine();

            //if (String.IsNullOrEmpty(s1))
            //{
            //    Console.WriteLine("You didn't enter anything!");
            //}
            //else
            //{
            //    Console.WriteLine("Thank you for your submission!");
            //}

            //string[] heroes = { "D. Va", "Lucio", "Mercy", "Soldier 76", "Pharah", "Reinhardt" };

            //string[] heroes = { "D. Va", "Lucio", "Mercy", "Soldier 76", "Pharah", "Reinhardt" };

            //var heroesT = heroes.Select(h => $"Introducing...{h}");

            //var spacesI = heroes.Where(h => h.Contains(' '))
            //    .Select(s => s.IndexOf(' ')).ToList();
        }
    }
    class Animal { }
    class Wolf : Animal { }
    class Dog : Animal { }

}

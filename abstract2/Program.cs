using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace abstract2
{
    abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public abstract void MakeSound();
    }

    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} the Dog: Woof woof!");
        }
    }

    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} the Cat: Meow meow!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the name of the animal: ");
            string name = Console.ReadLine();

            Console.Write("Enter the age of the animal: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Select an animal:");
            Console.WriteLine("1. Dog");
            Console.WriteLine("2. Cat");
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            Animal animal;

            if (choice == 1)
            {
                animal = new Dog();
            }
            else if (choice == 2)
            {
                animal = new Cat();
            }
            else
            {
                Console.WriteLine("Invalid choice.");
                return;
            }

            animal.Name = name;
            animal.Age = age;

            Console.WriteLine($"Animal Name: {animal.Name}");
            Console.WriteLine($"Animal Age: {animal.Age}");
            animal.MakeSound();
        }
    }
    




}

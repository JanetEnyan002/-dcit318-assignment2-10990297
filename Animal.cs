using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
  class Animal
        {
            public virtual void MakeSound()
            {
                Console.WriteLine("Some generic sound");
            }
        }

        // Derived class Dog inheriting from Animal
        class Dog : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Bark");
            }
        }

        // Derived class Cat inheriting from Animal
        class Cat : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Meow");
            }
        }

        class Program
        {
            static void Main()
            {
                // Create instances of Animal, Dog, and Cat
                Animal animal = new Animal();
                Dog dog = new Dog();
                Cat cat = new Cat();

                // Call MakeSound() method on each instance
                Console.WriteLine("Animal makes:");
                animal.MakeSound();

                Console.WriteLine("\nDog makes:");
                dog.MakeSound();

                Console.WriteLine("\nCat makes:");
                cat.MakeSound();
            }
        }


    }



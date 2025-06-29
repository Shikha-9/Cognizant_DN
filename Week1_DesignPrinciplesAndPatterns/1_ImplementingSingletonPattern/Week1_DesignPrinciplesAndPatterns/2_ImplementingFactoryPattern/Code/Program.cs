using System;

namespace FactoryPatternDemo
{
    
    public interface IAnimal
    {
        void Speak();
    }

    
    public class Dog : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Dog says: Woof!");
        }
    }

    public class Cat : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Cat says: Meow!");
        }
    }

    
    public class AnimalFactory
    {
        public static IAnimal GetAnimal(string animalType)
        {
            if (animalType.ToLower() == "dog")
                return new Dog();
            else if (animalType.ToLower() == "cat")
                return new Cat();
            else
                throw new Exception("Invalid animal type");
        }
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter animal type (dog/cat): ");
            string input = Console.ReadLine();

            IAnimal animal = AnimalFactory.GetAnimal(input);
            animal.Speak();

            Console.ReadLine(); // Keeps console open
        }
    }
}


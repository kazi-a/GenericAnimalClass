using System;

namespace GenericAnimalClass
{
    class Animal<T>
    {
        private T data;

        // Constructor
        public Animal(T animalData)
        {
            data = animalData;
        }

        // Method to retrieve data
        public T GetAnimal()
        {
            return data;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating objects using the generic class
            Animal<string> animalName = new Animal<string>("Lion");
            Animal<string> animalHabitat = new Animal<string>("Savannah");
            Animal<bool> endangered = new Animal<bool>(false);
            Animal<bool> extinct = new Animal<bool>(false);
            Animal<int> averageLifespan = new Animal<int>(15);

            // Printing out the values using the GetAnimal method
            Console.WriteLine("Animal Name: " + animalName.GetAnimal());
            Console.WriteLine("Animal Habitat: " + animalHabitat.GetAnimal());
            Console.WriteLine("Endangered: " + endangered.GetAnimal());
            Console.WriteLine("Extinct: " + extinct.GetAnimal());
            Console.WriteLine("Average Lifespan: " + averageLifespan.GetAnimal() + " years");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace filtro_c_sharp.Models
{
    public class Cat : Animal // Herencia de la clase Animal
    {

        public bool BreedingStatus { get; set; }
        public string FurLength { get; set; }

        // Constructor con los respectivos atributos desde clase padre Animal
        public Cat(int id, string name, DateOnly birthdate, string breed, string color, double weightInKg, bool breedingStatus, string furLength) : base(id, name, birthdate, breed, color, weightInKg)
        {
            BreedingStatus = breedingStatus;
            FurLength = furLength;
        }

        // Función de la clase padre ShowInformation

        public override void ShowInformation()
        {
            Console.WriteLine($"Cat: {Name}");
            Console.WriteLine($"Birthdate: {Birthdate}");
            Console.WriteLine($"Age: {CalculateAgeInMonths()} months old");
            Console.WriteLine($"Breed: {Breed}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Weight: {WeightInKg} kg");
            Console.WriteLine($"Breeding Status: {BreedingStatus}");
            Console.WriteLine($"Fur Length: {FurLength}");
        }

        // Funciones descritas desde el UML
        public void CastrateAnimal()
        {
            Console.WriteLine("");
        }

        public void Hairdress()
        {
            Console.WriteLine("");
        }

        public int GetId()
        {
            return Id;
        }

        public string GetName()
        {
            return Name;
        }
    }
}
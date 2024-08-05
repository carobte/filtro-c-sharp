using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace filtro_c_sharp.Models
{
    public class Dog : Animal  // Herencia de la clase Animal
    {
        public bool BreedingStatus { get; set; }
        public string Temperament { get; set; }
        public string MicrochipNumber { get; set; }
        public string BarkVolume { get; set; }
        public string CoatType { get; set; }

        // Constructor con los respectivos atributos desde clase padre Animal

        public Dog(int id, string name, DateOnly birthdate, string breed, string color, double weightInKg, bool breedingStatus, string temperament, string microchipNumber, string barkVolume, string coatType) : base(id, name, birthdate, breed, color, weightInKg)
        {
            BreedingStatus = breedingStatus;
            Temperament = temperament;
            MicrochipNumber = microchipNumber;
            BarkVolume = barkVolume;
            CoatType = coatType;
        }

        // Función de la clase padre ShowInformation

        public override void ShowInformation()
        {
            Console.WriteLine($"Dog: {Name}");
            Console.WriteLine($"Birthdate: {Birthdate}");
            Console.WriteLine($"Age: {CalculateAgeInMonths()} months old");
            Console.WriteLine($"Breed: {Breed}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Weight: {WeightInKg} kg");
            Console.WriteLine($"Breeding Status: {BreedingStatus}");
            Console.WriteLine($"Temperament: {Temperament}");
            Console.WriteLine($"MicrochipNumber: {MicrochipNumber}");
            Console.WriteLine($"Bark Volume: {BarkVolume}");
            Console.WriteLine($"Coat Type: {CoatType}");
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
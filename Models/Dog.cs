using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace filtro_c_sharp.Models
{
    public class Dog : Animal
    {
        public bool BreedingStatus { get; set; }
        public string Temperament { get; set; }
        public string MicrochipNumber { get; set; }
        public string BarkVolume { get; set; }
        public string CoatType { get; set; }

        public Dog(int id, string name, DateOnly birthdate, string breed, string color, double weightInKg, bool breedingStatus, string temperament, string microchipNumber, string barkVolume, string coatType) : base(id, name, birthdate, breed, color, weightInKg)
        {
            BreedingStatus = breedingStatus;
            Temperament = temperament;
            MicrochipNumber = microchipNumber;
            BarkVolume = barkVolume;
            CoatType = coatType;
        }

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

        public void CastrateAnimal()
        {
            Console.WriteLine("");
        }

        public void Hairdress()
        {
            Console.WriteLine("");
        }


    }
}
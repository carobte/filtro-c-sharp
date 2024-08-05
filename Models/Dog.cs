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
            Console.WriteLine($"Nombre del perro: {Name}");
            Console.WriteLine($"Fecha de nacimiento: {Birthdate}");
            Console.WriteLine($"Edad: {CalculateAgeInMonths()} meses");
            Console.WriteLine($"Raza: {Breed}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Peso: {WeightInKg} kg");
            Console.WriteLine($"Castrado: {BreedingStatus}");
            Console.WriteLine($"Temperamento: {Temperament}");
            Console.WriteLine($"Número de microchip: {MicrochipNumber}");
            Console.WriteLine($"Volumen de ladrido: {BarkVolume}");
            Console.WriteLine($"Pelaje: {CoatType}");
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
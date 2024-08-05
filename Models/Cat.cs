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
            Console.WriteLine($"Nombre del gato: {Name}");
            Console.WriteLine($"Fecha de nacimiento: {Birthdate}");
            Console.WriteLine($"Edad: {CalculateAgeInMonths()} meses");
            Console.WriteLine($"Raza: {Breed}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Peso: {WeightInKg} kg");
            Console.WriteLine($"Castrado: {BreedingStatus}");
            Console.WriteLine($"Longitud pelaje: {FurLength}");
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
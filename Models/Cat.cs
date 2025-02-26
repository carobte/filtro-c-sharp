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
        public Cat(string name, DateOnly birthdate, string breed, string color, double weightInKg, bool breedingStatus, string furLength) : base(name, birthdate, breed, color, weightInKg)
        {
            BreedingStatus = breedingStatus;
            FurLength = furLength;
        }

        // Método de la clase padre ShowInformation

        public override void ShowInformation()
        {
            var status = "";
            if (BreedingStatus == true)
            {
                status = "Sí";
            }
            else
            {
                status = "No";
            }

            ManagerApp.ShowSeparator();
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Nombre del gato: {Name}");
            Console.WriteLine($"Fecha de nacimiento: {Birthdate}");
            Console.WriteLine($"Edad: {CalculateAgeInMonths()} meses");
            Console.WriteLine($"Raza: {Breed}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Peso: {WeightInKg} kg");
            Console.WriteLine($"Castrado: {status}");
            Console.WriteLine($"Pelaje: {FurLength}");
            ManagerApp.ShowSeparator();
        }

        // Métodos descritas desde el UML
        public void CastrateAnimal()
        {
            if (BreedingStatus == true)
            {
                Console.WriteLine($"{Name} ya se encuentra castrado");
            }
            else
            {
                BreedingStatus = true;
                Console.WriteLine($"{Name} fue castrado exitosamente");
            }
        }

        public void Hairdress()
        {
            if (FurLength != "sin pelo" && FurLength != "pelo corto")
            {
                Console.WriteLine($"{Name} ha sido motilado");
            }
            else
            {
                Console.WriteLine($"{Name} no puede ser motilado");
            }
        }

        // Métodos no especificadas en el diagrama

        public string GetId()
        {
            return Id.ToString();
        }

        public string GetName()
        {
            return Name;
        }
        public void SetWeight(double weight)
        {
            WeightInKg = weight;
        }
    }
}
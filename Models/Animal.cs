using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace filtro_c_sharp.Models
{
    public abstract class Animal
    {
        // Atributos de la clase padre animal 
        protected Guid Id { get; set; }
        protected string Name { get; set; }
        protected DateOnly Birthdate { get; set; }
        protected string Breed { get; set; }
        protected string Color { get; set; }
        protected double WeightInKg { get; set; }

        // Constructor de la clase
        public Animal(string name, DateOnly birthdate, string breed, string color, double weightInKg)
        {
            Id = Guid.NewGuid();
            Name = name;
            Birthdate = birthdate;
            Breed = breed;
            Color = color;
            WeightInKg = weightInKg;
        }

        // Métodos descritos en el UML:
        public abstract void ShowInformation();


        protected string BasicReview()
        {
            Console.WriteLine("Escribe el estado con el que ingresa la mascota");
            return Console.ReadLine();
        }

        protected int CalculateAgeInMonths()
        {
            // Años * 12 para volverlo meses, + meses actuales
            return (DateTime.Now.Year - Birthdate.Year) * 12 + (DateTime.Now.Month - Birthdate.Month);
        }

        // Para mostrar el BasicReview

        public void ShowBasicReview()
        {
            Console.WriteLine($"Descripción del ingreso: {BasicReview()}");
        }
    }
}
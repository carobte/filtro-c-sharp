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
        protected int Id { get; set; }
        protected string Name { get; set; }
        protected DateOnly Birthdate { get; set; }
        protected string Breed { get; set; }
        protected string Color { get; set; }
        protected double WeightInKg { get; set; }

        // Constructor de la clase
        public Animal(int id, string name, DateOnly birthdate, string breed, string color, double weightInKg)
        {
            Id = id;
            Name = name;
            Birthdate = birthdate;
            Breed = breed;
            Color = color;
            WeightInKg = weightInKg;
        }

        // Funciones descritas en el UML:
        public abstract void ShowInformation();


        protected void BasicReview()
        {

        }

        protected int CalculateAgeInMonths()
        {
            return DateTime.Now.Month - Birthdate.Month;
        }
    }
}
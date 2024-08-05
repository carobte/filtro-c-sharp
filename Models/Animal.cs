using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace filtro_c_sharp.Models
{
    public abstract class Animal
    {
        protected abstract int Id {get;set;}
        protected abstract string Name {get;set;}
        protected abstract DateOnly Birthdate {get;set;}
        protected abstract string Breed {get;set;}
        protected abstract string Color {get;set;}
        protected abstract double WeightInKg {get;set;}

        public Animal(int id, string name, DateOnly birthdate, string breed, string color, double weightInKg){
            Id = id;
            Name = name;
            Birthdate = birthdate;
            Breed = breed;
            Color = color;
            WeightInKg = weightInKg;
        }

        public abstract void ShowInformation();
        
        protected void BasicReview(){

        }

        protected int CalculateAgeInMonths(){
            return DateTime.Now.Month - Birthdate.Month;
        }
    }
}
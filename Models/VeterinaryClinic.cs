using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace filtro_c_sharp.Models
{
    public class VeterinaryClinic
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public List<Dog> Dogs { get; set; }
        public List<Cat> Cats { get; set; }

        public VeterinaryClinic(string name, string address)
        {
            Name = name;
            Adress = address;
            Dogs = new List<Dog>();
            Cats = new List<Cat>();
        }

        public void SaveDog(Dog newDog)
        {
            Dogs.Add(newDog);
            Console.WriteLine($"El perro ha sido registrado exitosamente");
        }

        public void SaveCat(Cat newCat)
        {
            Cats.Add(newCat);
            Console.WriteLine($"El perro ha sido registrado exitosamente");
        }

        public void UpdateDog(Dog dog)
        {

        }

        public void UpdateCat(Cat cat)
        {

        }

        public void DeleteDog(int id)
        {
            var founded = Dogs.Find(dog => dog.GetId() == id);
            if (founded != null)
            {
                Console.WriteLine($"¿Está seguro que desea eliminar a {founded.GetName()} (si/no)?");
                var confirmation = Console.ReadLine().ToLower();
                if (confirmation == "si")
                {
                    Dogs.Remove(founded);
                    Console.WriteLine($"{founded.GetName()} ha sido eliminado");
                }
                else
                {
                    Console.WriteLine($"{founded.GetName()} no fue eliminado. Si desea, intente nuevamente");
                }
            }
        }

        public void DeleteCat(int id)
        {
            var founded = Cats.Find(cat => cat.GetId() == id);
            if (founded != null)
            {
                Console.WriteLine($"¿Está seguro que desea eliminar a {founded.GetName()} (si/no)?");
                var confirmation = Console.ReadLine().ToLower();
                if (confirmation == "si")
                {
                    Cats.Remove(founded);
                    Console.WriteLine("El gato ha sido eliminado");
                }
                else
                {
                    Console.WriteLine("El gato no fue eliminado. Si desea, intente nuevamente");
                }
            }
        }

        public void ShowAllPatients()
        {
            Console.WriteLine("__________________________________________________");
            Console.WriteLine("Pacientes registrados:");
            Console.WriteLine("Perros: ");

            foreach (var dog in Dogs)
            {
                dog.ShowInformation();
            }

            Console.WriteLine("                                                    ");

            Console.WriteLine("Gatos: ");

            foreach (var cat in Cats)
            {
                cat.ShowInformation();
            }

            Console.WriteLine("__________________________________________________");

        }

        public void ShowAnimals(string type)
        {
            if (type.ToLower() == "perro")
            {
                Console.WriteLine("Perros: ");

                foreach (var dog in Dogs)
                {
                    dog.ShowInformation();
                }
            }
            else if (type.ToLower() == "gato")
            {
                Console.WriteLine("Gatos: ");

                foreach (var cat in Cats)
                {
                    cat.ShowInformation();
                }
            }
        }

        public void ShowPatient(int idPatient)
        {
            Console.WriteLine("Buscando...");
            var foundedDog = Dogs.Find(dog => dog.GetId() == idPatient);
            if (foundedDog != null)
            {
                foundedDog.ShowInformation();
            }
            else
            {
                var foundedCat = Cats.Find(cat => cat.GetId() == idPatient);
                if (foundedCat != null)
                {
                    foundedCat.ShowInformation();
                }
                else
                {
                    Console.WriteLine("El paciente no fue encontrado. Intenta de nuevo");
                }
            }
        }
    }
}
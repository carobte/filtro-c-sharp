using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace filtro_c_sharp.Models
{
    public class VeterinaryClinic
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public static List<Dog> Dogs { get; set; } = new List<Dog>(); // Lista de perros
        public static List<Cat> Cats { get; set; } = new List<Cat>(); // Lista de gatos

        // Constructor sin parametros
        public VeterinaryClinic() { }

        // Constructor con parametros

        public VeterinaryClinic(string name, string address)
        {
            Name = name;
            Address = address;
        }

        // Métodos descritos en el diagrama UML

        public void SaveDog(Dog newDog) // Agregar a perro a la lista
        {
            Dogs.Add(newDog);
            Console.WriteLine($"El perro {newDog.GetName()} ha sido registrado exitosamente");
        }

        public void SaveCat(Cat newCat) // Agregar a gato a la lista
        {
            Cats.Add(newCat);
            Console.WriteLine($"El gato {newCat.GetName()} ha sido registrado exitosamente");
        }

        public void UpdateDog(Dog dog) // Actualizar perro
        {

        }

        public void UpdateCat(Cat cat) // Actualizar gato
        {

        }

        public void DeleteDog(string id) // Eliminar perro según id
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

        public void DeleteCat(string id) // Eliminar gato según id
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

        public void ShowAllPatients() // Mostrar todos los pacientes registrados
        {
            ManagerApp.ShowSeparator();
            ManagerApp.ShowHeader("Pacientes registrados:");
            ManagerApp.ShowHeader("Perros: ");
            
            ManagerApp.ShowSeparator();

            foreach (var dog in Dogs)
            {
                dog.ShowInformation();
            }

            ManagerApp.ShowSeparator();

            ManagerApp.ShowHeader("Gatos: ");

            foreach (var cat in Cats)
            {
                cat.ShowInformation();
            }

            ManagerApp.ShowSeparator();

        }

        public void ShowAnimals(string type) // Mostrar todos los pacientes de algún tipo
        {
            if (type.ToLower() == "perro")
            {
                ManagerApp.ShowHeader("Perros: ");

                foreach (var dog in Dogs)
                {
                    dog.ShowInformation();
                }
            }
            else if (type.ToLower() == "gato")
            {
                ManagerApp.ShowHeader("Gatos: ");

                foreach (var cat in Cats)
                {
                    cat.ShowInformation();
                }
            } else {
                Console.WriteLine("Error. Intenta nuevamente.");
            }
        }

        public void ShowPatient(string idPatient) // Mostrar info de un paciente específico con su id
        {
            ManagerApp.ShowHeader("Buscando...");
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

        public void DataEG()
        {
            Dogs.Add(new Dog( "Milu", new DateOnly(2023, 04, 21), "border collie", "negro", 13.5, false, "normal", "123456", "normal", "pelo largo"));
            Dogs.Add(new Dog( "Orión", new DateOnly(2013, 10, 18), "criollo", "beige", 13.5, true, "timido", "987654", "normal", "pelo mediano"));

            Cats.Add(new Cat( "Molly", new DateOnly(2000, 04, 21), "persa", "naranja", 7.5, false, "pelo mediano"));
            Cats.Add(new Cat( "Salem", new DateOnly(2001, 04, 21), "esfinge", "rosado", 10, false, "sin pelo"));
        }
    }
}
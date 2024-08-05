using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

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

        public void UpdateDog(string id) // Actualizar perro
        {
            var dog = Dogs.Find(dog => dog.GetId() == id);
            if (dog != null)

            {
                var flag = true;
                while (flag)
                {
                    Console.WriteLine($"¿Qué información deseas editar de {dog.GetName()}?");
                    Console.WriteLine($"0. Salir");
                    Console.WriteLine($"1. Peso");
                    Console.WriteLine($"2. Castrado o no");
                    Console.WriteLine($"3. Temperamento");
                    Console.WriteLine($"4. Pelaje");

                    var option = Console.ReadLine();

                    switch (option)
                    {
                        case "0":
                            flag = false;
                            Console.WriteLine("Volviendo al menú principal...");
                            break;
                        case "1":
                            Console.WriteLine("Ingresa el peso actualizado: ");
                            dog.SetWeight(Convert.ToDouble(Console.ReadLine()));
                            Console.WriteLine("El peso fue actualizado");
                            ManagerApp.PauseMenu();
                            break;
                        case "2":
                            Console.WriteLine($"¿{dog.GetName()} se encuentra castrado? Ingresa 1 para sí, 0 para no");
                            dog.BreedingStatus = Convert.ToBoolean(Convert.ToInt16(Console.ReadLine()));
                            Console.WriteLine("Su estado de castración fue actualizado");
                            ManagerApp.PauseMenu();
                            break;
                        case "3":
                            dog.Temperament = ManagerApp.GetTemperament();
                            Console.WriteLine("Su temperamento fue editado satisfactoriamente");
                            ManagerApp.PauseMenu();
                            break;
                        case "4":
                            dog.CoatType = ManagerApp.GetCoatOrFlurType();
                            Console.WriteLine("Su pelaje fue editado satisfactoriamente");
                            ManagerApp.PauseMenu();
                            break;
                        default:
                            Console.WriteLine("Por favor ingresa una opción válida.");
                            break;
                    }
                }

            }
            else
            {
                Console.WriteLine("No se encontró ningún perro con ese id. Intenta nuevamente");
            }

        }

        public void UpdateCat(string id) // Actualizar gato
        {
            var cat = Cats.Find(cat => cat.GetId() == id);
            if (cat != null)

            {
                var flag = true;
                while (flag)
                {
                    Console.WriteLine($"¿Qué información deseas editar de {cat.GetName()}?");
                    Console.WriteLine($"0. Salir");
                    Console.WriteLine($"1. Peso");
                    Console.WriteLine($"2. Castrado o no");
                    Console.WriteLine($"3. Pelaje");

                    var option = Console.ReadLine();

                    switch (option)
                    {
                        case "0":
                            flag = false;
                            Console.WriteLine("Volviendo al menú principal...");
                            break;
                        case "1":
                            Console.WriteLine("Ingresa el peso actualizado: ");
                            cat.SetWeight(Convert.ToDouble(Console.ReadLine()));
                            Console.WriteLine("El peso fue actualizado");
                            ManagerApp.PauseMenu();
                            break;
                        case "2":
                            Console.WriteLine($"¿{cat.GetName()} se encuentra castrado? Ingresa 1 para sí, 0 para no");
                            cat.BreedingStatus = Convert.ToBoolean(Convert.ToInt16(Console.ReadLine()));
                            Console.WriteLine("Su estado de castración fue actualizado");
                            ManagerApp.PauseMenu();
                            break;
                        case "3":
                            cat.FurLength = ManagerApp.GetCoatOrFlurType();
                            Console.WriteLine("Su pelaje fue editado satisfactoriamente");
                            ManagerApp.PauseMenu();
                            break;
                        default:
                            Console.WriteLine("Por favor ingresa una opción válida.");
                            break;
                    }
                }

            }
            else
            {
                Console.WriteLine("No se encontró ningún gato con ese id. Intenta nuevamente");
            }
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
                ManagerApp.ShowSeparator();
                ManagerApp.ShowHeader("Perros: ");

                foreach (var dog in Dogs)
                {
                    dog.ShowInformation();
                }
            }
            else if (type.ToLower() == "gato")
            {
                ManagerApp.ShowSeparator();
                ManagerApp.ShowHeader("Gatos: ");

                foreach (var cat in Cats)
                {
                    cat.ShowInformation();
                }
            }
            else
            {
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
            Dogs.Add(new Dog("Milu", new DateOnly(2023, 04, 21), "border collie", "negro", 13.5, false, "normal", "123456", "normal", "pelo largo"));
            var dog = new Dog("Orion", new DateOnly(2013, 10, 18), "criollo", "beige", 13.5, true, "timido", "987654", "normal", "pelo mediano");

            Dogs.Add(dog);

            // Probando métodos de Dog

            // dog.Hairdress();
            // dog.CastrateAnimal();
            // dog.ShowBasicReview();


            Cats.Add(new Cat("Molly", new DateOnly(2000, 04, 21), "persa", "naranja", 7.5, false, "pelo mediano"));
            var cat = new Cat("Salem", new DateOnly(2001, 04, 21), "esfinge", "rosado", 10, false, "sin pelo");
            Cats.Add(cat);

            // Probando métodos de Cat

            // cat.Hairdress();
            // cat.CastrateAnimal();
            // cat.ShowBasicReview();
        }
    }
}
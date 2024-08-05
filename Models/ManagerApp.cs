using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace filtro_c_sharp.Models
{
    public class ManagerApp
    {
        // Métodos del diagrama UML
        public static Dog CreateDog() // Método para crear un perro
        {
            Console.WriteLine("Ingresa el nombre del perro");
            var name = Console.ReadLine();

            var birthdate = GetBirthdate();

            Console.WriteLine($"Ingresa la raza de {name}");
            var breed = Console.ReadLine();

            Console.WriteLine($"Ingresa el color de {name}");
            var color = Console.ReadLine();

            Console.WriteLine($"Ingresa el peso de {name} en kg");
            var weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"¿{name} se encuentra castrado? Ingresa 1 para sí, 0 para no");
            var breedingStatus = Convert.ToBoolean(Convert.ToInt16(Console.ReadLine()));

            var temperament = GetTemperament();

            Console.WriteLine($"Ingresa el número de microchip de {name}");
            var microchipNumber = Console.ReadLine();

            Console.WriteLine($"Ingresa el volumen de ladrido de {name}");
            var barkVolume = Console.ReadLine();

            var coatType = GetCoatOrFlurType();

            return new Dog(name, birthdate, breed, color, weight, breedingStatus, temperament, microchipNumber, barkVolume, coatType);
        }

        public static Cat CreateCat() // Método para crear un gato
        {
            Console.WriteLine("Ingresa el nombre del gato");
            var name = Console.ReadLine();

            var birthdate = GetBirthdate();

            Console.WriteLine($"Ingresa la raza de {name}");
            var breed = Console.ReadLine();

            Console.WriteLine($"Ingresa el color de {name}");
            var color = Console.ReadLine();

            Console.WriteLine($"Ingresa el peso de {name} en kg");
            var weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"¿{name} se encuentra castrado? Ingresa 1 para sí, 0 para no");
            var breedingStatus = Convert.ToBoolean(Convert.ToInt16(Console.ReadLine()));

            var flurLength = GetCoatOrFlurType();

            return new Cat(name, birthdate, breed, color, weight, breedingStatus, flurLength);
        }

        public static void ShowHeader(string header)
        {
            Console.WriteLine($"{header}");
        }

        public static void ShowFooter(string footer)
        {
            Console.WriteLine($"{footer}");
        }

        public static void ShowSeparator()
        {
            Console.WriteLine("__________________________________________________");
        }

        // Métodos no especificadas en el diagrama

        public static string GetTemperament() // Validación temperamento del perro

        {
            Console.WriteLine($"Ingresa el temperamento de la mascota");
            var temperament = Console.ReadLine().Trim().ToLower();
            while (temperament != "timido" && temperament != "normal" && temperament != "agresivo")
            {
                Console.WriteLine($"Escribe timido, normal o agresivo para poder continuar");
                temperament = Console.ReadLine().Trim().ToLower();
            }

            return temperament;
        }

        public static string GetCoatOrFlurType() // Validación pelaje de la mascota
        {
            Console.WriteLine($"Ingresa el pelaje de la mascota");
            var coatType = Console.ReadLine().Trim().ToLower();

            while (coatType != "sin pelo" && coatType != "pelo corto" && coatType != "pelo mediano" && coatType != "pelo largo")
            {
                Console.WriteLine($"Escribe 'sin pelo', 'pelo corto', 'pelo mediano' o 'pelo largo' para poder continuar");
                coatType = Console.ReadLine().Trim().ToLower();
            }
            return coatType;
        }

        public static DateOnly GetBirthdate() // Validación fecha de nacimiento de la mascota
        {
            Console.WriteLine($"Ingresa la fecha de nacimiento de la mascota (año/mes/día)");

            var birthdate = DateOnly.FromDateTime(Convert.ToDateTime(Console.ReadLine()));

            while (birthdate > DateOnly.FromDateTime(DateTime.Now))
            {
                Console.WriteLine($"Ha ocurrido un error. Ingresa nuevamente la fecha de nacimiento (año/mes/día)");

                birthdate = DateOnly.FromDateTime(Convert.ToDateTime(Console.ReadLine()));
            }

            return birthdate;
        }
    }
}
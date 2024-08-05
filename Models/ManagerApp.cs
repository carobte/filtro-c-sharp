using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace filtro_c_sharp.Models
{
    public class ManagerApp
    {
        private static int Id = 0;
        static Dog CreateDog()
        {
            Console.WriteLine("Ingresa el nombre del perro");
            var name = Console.ReadLine();

            Console.WriteLine($"Ingresa la fecha de nacimiento de {name} (año/mes/día)");
            var birthdate = DateOnly.FromDateTime(Convert.ToDateTime(Console.ReadLine()));

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

            var coatType = GetCoatType();

            return new Dog(GeneratorId(), name, birthdate, breed, color, weight, breedingStatus, temperament, microchipNumber, barkVolume, coatType);
        }

        public static int GeneratorId()
        {
            return Id += 1;
        }

        public static string GetTemperament()

        {
            Console.WriteLine($"Ingresa el temperamento de la mascota");
            var temperament = Console.ReadLine().Trim().ToLower();
            while (temperament != "timido" || temperament != "normal" || temperament != "agresivo")
            {
                Console.WriteLine($"Escribe timido, normal o agresivo para poder continuar");
                temperament = Console.ReadLine().Trim().ToLower();
            }

            return temperament;
        }

        public static string GetCoatType()
        {
            Console.WriteLine($"Ingresa el pelaje de la mascota");
            var coatType = Console.ReadLine().Trim().ToLower();

            while (coatType != "sin pelo" || coatType != "pelo corto" || coatType != "pelo mediano" || coatType != "pelo largo")
            {
                Console.WriteLine($"Escribe 'sin pelo', 'pelo corto', 'pelo mediano' o 'pelo largo' para poder continuar");
                coatType = Console.ReadLine().Trim().ToLower();
            }
            return coatType;
        }
    }
}
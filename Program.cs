

using filtro_c_sharp.Models;

var veterinary = new VeterinaryClinic();
veterinary.DataEG();

void Menu()
{
    var flag = true; // bandera para que se repita el menú
    while (flag)
    {

        ManagerApp.ShowSeparator();
        Console.WriteLine("");
        ManagerApp.ShowHeader("Bienvenido a la gestión de mascotas");
        Console.WriteLine("");
        ManagerApp.ShowSeparator();
        Console.WriteLine("");
        Console.WriteLine("Selecciona una opción:");
        Console.WriteLine("");
        Console.WriteLine("1. Registrar un perro nuevo");
        Console.WriteLine("2. Registrar un gato nuevo");
        Console.WriteLine("3. Editar información de un perro");
        Console.WriteLine("4. Editar información de un gato");
        Console.WriteLine("5. Eliminar un perro");
        Console.WriteLine("6. Eliminar un gato");
        Console.WriteLine("7. Mostrar todas las mascotas registradas");
        Console.WriteLine("8. Mostrar las mascotas registradas de un solo tipo");
        Console.WriteLine("9. Busca la información de una mascota con su ID");
        Console.WriteLine("0. Salir");
        ManagerApp.ShowSeparator();

        var opcion = Console.ReadLine();

        switch (opcion)
        {
            case "0":
                Console.WriteLine("Adiós, vuelva pronto");
                flag = false; // sale del bucle
                break;
            case "1":
                var dog = ManagerApp.CreateDog(); //se crea el perro
                veterinary.SaveDog(dog); // se añade a la lista
                ManagerApp.PauseMenu();
                break;
            case "2":
                var cat = ManagerApp.CreateCat(); // se crea el gato
                veterinary.SaveCat(cat); // se añade a la lista
                ManagerApp.PauseMenu();
                break;
            case "3":
                Console.WriteLine("Escribe el id del perro que deseas editar");
                var idDog = Console.ReadLine().Trim(); // se eliminan espacios al inicio y al final para que concuerde el id
                veterinary.UpdateDog(idDog); 
                break;
            case "4":
                Console.WriteLine("Escribe el id del gato que deseas editar");
                var idCat = Console.ReadLine().Trim(); 
                veterinary.UpdateCat(idCat);
                break;
            case "5":
                Console.WriteLine("Escribe el id del perro que deseas eliminar");
                var idDog2 = Console.ReadLine().Trim();
                veterinary.DeleteDog(idDog2);
                ManagerApp.PauseMenu();
                break;
            case "6":
                Console.WriteLine("Escribe el id del gato que deseas eliminar");
                var idCat2 = Console.ReadLine().Trim();
                veterinary.DeleteCat(idCat2);
                ManagerApp.PauseMenu();
                break;
            case "7":
                veterinary.ShowAllPatients(); // muestra todas las mascotas registradas
                ManagerApp.PauseMenu();
                break;
            case "8":
                Console.WriteLine("¿Qué tipo de mascotas deseas mostrar (perro o gato)?"); // muestra las mascotas registradas según su especie
                var type = Console.ReadLine().Trim().ToLower();
                veterinary.ShowAnimals(type);
                ManagerApp.PauseMenu();
                break;
            case "9":
                Console.WriteLine("Escribe el id de la mascota que deseas buscar"); // muestra una mascota específica con el id
                var id = Console.ReadLine().Trim();
                veterinary.ShowPatient(id);
                ManagerApp.PauseMenu();
                break;
            default:
                Console.WriteLine("Opción incorrecta, intenta de nuevo");
                break;
        }
    }
}



Menu();





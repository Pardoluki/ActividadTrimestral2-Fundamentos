/*
Crea un programa que permita gestionar sesiones de usuarios para poder introducir sus
marcas de entrenamientos. Para ello el sistema permitirá:
- Registrar usuarios: pidiendo un correo y una contraseña. No será posible registrar dos
usuarios con el mismo nombre
- Logear usuario: pidiendo un correo y una contraseña. En el caso de que exista dentro
de la lista, el sistema dejará las siguientes acciones
o Registrar un entrenamiento: donde se pedirá la distancia recorrida y el tiempo
empleado
o Listar entrenamientos: donde se mostrarán todos los entrenamientos
introducidos
o Vaciar entrenamientos: Vaciará la lista de todos los entrenamientos
o Cerrar sesión
Toda la función se realizará mediante un menú iterativo


Funciones:
- RegistrarUsuario: recibe por consola un correo y una contraseña y lo guarda dentro de un
diccionario
- LogearUsuario: recibe un correo y una contraseña y devuelve un booleano
indicando si se ha podido logear o no
- RegistrarEntrenamiento: recibe la distancia y el tiempo y lo añade a la lista
- ListarEntrenamientos: muestra por pantalla todos los entrenamientos
- VaciarEntrenamientos: vacía la lista de entrenamientos
*/

class Program
{
    public static void Main(string[] args)
    {
        do
        {
            MainMenu();
        } while (true);
    }

    public static void MainMenu()
    {
        Console.WriteLine("Bienvenido al sistema de registro de entrenamientos. Por favor, seleccione una opción:");
        Console.WriteLine("1. Registrar usuario");
        Console.WriteLine("2. Iniciar sesión con usuario existente");
        Console.WriteLine("3. Salir");

        string opcion = Console.ReadLine();

        switch (opcion)
        {
            case "1":
                AccionesUsuario registrarUsuario = new AccionesUsuario();
                registrarUsuario.RegistrarUsuario();
                break;
            case "2":
                AccionesUsuario logearUsuario = new AccionesUsuario();
                logearUsuario.LogearUsuario();
                break;
            case "3":
                Console.WriteLine("¡Hasta pronto!");
                return;
            default:
                Console.WriteLine("Opción no válida");
                break;
        }
    }
}
public class AccionesUsuario
{
    // Instancia de la clase AccionesEntrenamiento para manejar las acciones relacionadas con los entrenamientos
    AccionesEntrenamiento accionesEntrenamiento = new AccionesEntrenamiento();
    // Diccionario para almacenar las credenciales de los usuarios (nombre de usuario y contraseña)
    private Dictionary<string, string> credencialesUsuarios = new Dictionary<string, string>();
    // Variable para almacenar el nombre de usuario
    private static string nombre;
    // Variable para almacenar la contraseña del usuario
    private string contrasena;

    public void RegistrarUsuario()
    {
        // Solicitar al usuario que introduzca su nombre de usuario
        Console.WriteLine("\nPor favor, introduzca su nombre de usuario:");
        nombre = Console.ReadLine();

        // Comprobar si el nombre de usuario ya existe
        while (credencialesUsuarios.ContainsKey(nombre))
        {
            // Si el usuario ya existe, solicitar un nombre de usuario diferente
            Console.WriteLine("\nEl usuario ya existe. Por favor, introduzca otro nombre de usuario:");
            nombre = Console.ReadLine();
        }

        // Solicitar al usuario que introduzca su contraseña
        Console.WriteLine("\nPor favor, introduzca su contraseña:");
        contrasena = Console.ReadLine();
        // Añadir las credenciales del usuario al diccionario
        credencialesUsuarios.Add(nombre, contrasena);
        // Confirmar que el usuario ha sido registrado con éxito
        Console.WriteLine("\nUsuario registrado con éxito.");
    }

    public int LogearUsuario()
    {
        // Solicitar al usuario que introduzca su nombre de usuario
        Console.WriteLine("\nPor favor, introduzca su nombre de usuario:");
        string nombre = Console.ReadLine();
        // Solicitar al usuario que introduzca su contraseña
        Console.WriteLine("\nPor favor, introduzca su contraseña:");
        string contrasena = Console.ReadLine();

        // Comprobar si las credenciales son correctas
        if (credencialesUsuarios.ContainsKey(nombre) && credencialesUsuarios[nombre] == contrasena)
        {
            // Si las credenciales son correctas, dar la bienvenida al usuario
            Console.WriteLine($"\nBienvenido, {nombre}.");
            return 0; // Retornar 0 para indicar que el inicio de sesión fue exitoso, y en Program.cs 
                      // se muestre el menú de entrenamientos
        }
        else
        {
            // Si las credenciales son incorrectas, mostrar un mensaje de error
            Console.WriteLine("Usuario o contraseña incorrectos.");
        }
        return 1; // Retornar 1 para indicar que el inicio de sesión falló y reaparezca el menú principal
    }
}
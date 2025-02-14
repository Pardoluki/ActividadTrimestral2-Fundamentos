/*
Crea un programa que permita gestionar sesiones de usuarios:
- Registrar usuarios: pidiendo un correo y una contraseña. No será posible registrar dos
usuarios con el mismo nombre. Podemos utilizar un diccionario.
- Logear usuario: pidiendo un correo y una contraseña. En el caso de que exista dentro
de la lista, el sistema dirá: "Bienvenido". Si no existe, dirá: "Log in incorrecto"
*/

public class AccionesUsuario
{
    AccionesEntrenamiento accionesEntrenamiento = new AccionesEntrenamiento();
    private Dictionary<string, string> credencialesUsuarios = new Dictionary<string, string>();
    private static string nombre;
    private string contrasena;

    public void RegistrarUsuario()
    {
        Console.WriteLine("\nPor favor, introduzca su nombre de usuario:");
        nombre = Console.ReadLine();

        while (credencialesUsuarios.ContainsKey(nombre))
        {
            Console.WriteLine("\nEl usuario ya existe. Por favor, introduzca otro nombre de usuario:");
            nombre = Console.ReadLine();
        }

        Console.WriteLine("\nPor favor, introduzca su contraseña:");
        contrasena = Console.ReadLine();
        credencialesUsuarios.Add(nombre, contrasena);
        Console.WriteLine("\nUsuario registrado con éxito.");
    }

    public int LogearUsuario()
    {
        Console.WriteLine("\nPor favor, introduzca su nombre de usuario:");
        string nombre = Console.ReadLine();
        Console.WriteLine("\nPor favor, introduzca su contraseña:");
        string contrasena = Console.ReadLine();

        if (credencialesUsuarios.ContainsKey(nombre) && credencialesUsuarios[nombre] == contrasena)
        {
            Console.WriteLine($"\nBienvenido, {nombre}.");
            return 0;
        }
        else
        {
            Console.WriteLine("Usuario o contraseña incorrectos.");
        }
        return 1;
    }
}
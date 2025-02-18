class Program
{
    // Instancia de la clase AccionesUsuario para manejar las acciones relacionadas con el usuario
    static AccionesUsuario accionesUsuario = new AccionesUsuario();
    // Instancia de la clase AccionesEntrenamiento para manejar las acciones relacionadas con los entrenamientos
    static AccionesEntrenamiento accionesEntrenamiento = new AccionesEntrenamiento();
    // Variable para almacenar la opción seleccionada en el menú principal
    static int opcionMainMenu;

    public static void Main(string[] args)
    {
        // Bucle para mostrar el menú principal hasta que MainMenu() devuelva una opción diferente a 1
        do
        {
            opcionMainMenu = MainMenu();  
        } while (opcionMainMenu == 1);

        // Si el método MainMenu() devuelve 0, se muestra el menú de entrenamientos
        if (opcionMainMenu == 0)
        {
            accionesEntrenamiento.TrainingMenu();
            Console.WriteLine();
        }
    }

    public static int MainMenu()
    {
        // Mostrar el menú principal
        Console.WriteLine("\nBienvenido al sistema de registro de entrenamientos. Por favor, seleccione una opción:");
        Console.WriteLine("1. Registrar usuario");
        Console.WriteLine("2. Iniciar sesión con usuario existente");

        // Leer la opción seleccionada por el usuario
        opcionMainMenu = int.Parse(Console.ReadLine());

        // Procesar la opción seleccionada
        switch (opcionMainMenu)
        {
            case 1:
                // Registrar un nuevo usuario
                accionesUsuario.RegistrarUsuario();
                return 1;
            case 2:
                // Iniciar sesión con un usuario existente
                return accionesUsuario.LogearUsuario();
            default:
                // Opción no válida
                Console.WriteLine("Opción no válida.");
                return 1;
        }
    }
}
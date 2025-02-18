public class AccionesEntrenamiento
{
    // Diccionario para almacenar los entrenamientos (distancia y tiempo)
    private Dictionary<double, double> entrenamientos = new Dictionary<double, double>();
    // Variable para almacenar la distancia del entrenamiento
    private double distancia;
    // Variable para almacenar el tiempo del entrenamiento
    private double tiempo;
    // Variable para almacenar la opción seleccionada en el menú de entrenamientos
    private int opcionTrainingMenu;

    public void TrainingMenu()
    {
        do
        {
            // Mostrar el menú de entrenamientos
            Console.WriteLine("\nBienvenido al sistema de registro de entrenamientos. Por favor, seleccione una opción:");
            Console.WriteLine("1. Registrar entrenamiento");
            Console.WriteLine("2. Listar entrenamientos");
            Console.WriteLine("3. Vaciar todos los entrenamientos");
            Console.WriteLine("4. Cerrar sesión");

            // Leer la opción del usuario
            opcionTrainingMenu = int.Parse(Console.ReadLine());

            // Procesar la opción seleccionada
            switch (opcionTrainingMenu)
            {
                case 1:
                    RegistrarEntrenamiento();  // Registrar un nuevo entrenamiento
                    break;
                case 2:
                    ListarEntrenamientos();  // Mostrar todos los entrenamientos guardados
                    break;
                case 3:
                    VaciarEntrenamientos();  // Vaciar todos los entrenamientos
                    break;
                case 4:
                    Console.WriteLine("\nSesión cerrada con éxito. ¡Hasta pronto!");  // Salir y terminar el programa
                    break;
                default:
                    // Opción no válida
                    Console.WriteLine("\nPor favor, seleccione una opción válida.");
                    break;
            }

        } while (opcionTrainingMenu != 4);  // Repetir mientras la opción no sea "Cerrar sesión"
    }

    public void RegistrarEntrenamiento()
    {
        // Solicitar al usuario que introduzca la distancia recorrida
        Console.WriteLine("\nPor favor, introduzca la distancia recorrida (en kilómetros):");
        distancia = double.Parse(Console.ReadLine());
        // Solicitar al usuario que introduzca el tiempo empleado
        Console.WriteLine("\nPor favor, introduzca el tiempo empleado (en horas):");
        tiempo = double.Parse(Console.ReadLine());
        // Añadir el entrenamiento al diccionario
        entrenamientos.Add(distancia, tiempo);
        // Confirmar que el entrenamiento ha sido registrado con éxito
        Console.WriteLine("\nEntrenamiento registrado con éxito.");
    }

    public void ListarEntrenamientos()
    {
        // Comprobar si hay entrenamientos registrados
        if (entrenamientos.Count == 0)
        {
            Console.WriteLine("\nNo hay entrenamientos registrados.");
            return;
        }

        Console.WriteLine("\nEntrenamientos registrados:");
        // Mostrar todos los entrenamientos registrados
        foreach (KeyValuePair<double, double> entrenamiento in entrenamientos)
        {
            Console.WriteLine($"Distancia: {entrenamiento.Key} kilómetros - Tiempo: {entrenamiento.Value} horas");
        }
    }

    public void VaciarEntrenamientos()
    {
        // Vaciar todos los entrenamientos
        entrenamientos.Clear();
        // Confirmar que los entrenamientos han sido vaciados con éxito
        Console.WriteLine("\nEntrenamientos vaciados con éxito.");
    }
}
public class AccionesEntrenamiento
{
    private Dictionary<double, double> entrenamientos = new Dictionary<double, double>();
    private double distancia;
    private double tiempo;
    private int opcionTrainingMenu;

    public void TrainingMenu()
    {
         do
        {
            // Mostrar el menú
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
                    ListarEntrenamientos();  // Mostrar todos los entrenamientos
                    break;
                case 3:
                    VaciarEntrenamientos();  // Vaciar todos los entrenamientos
                    break;
                case 4:
                    Console.WriteLine("\nSesión cerrada con éxito. ¡Hasta pronto!");  // Salir
                    break;
                default:
                    Console.WriteLine("\nPor favor, seleccione una opción válida.");
                    break;
            }

        } while (opcionTrainingMenu != 4);  // Repetir mientras la opción no sea "Cerrar sesión"
    }

public void RegistrarEntrenamiento()
    {
        Console.WriteLine("\nPor favor, introduzca la distancia recorrida (en kilómetros):");
        distancia = double.Parse(Console.ReadLine());
        Console.WriteLine("\nPor favor, introduzca el tiempo empleado (en horas):");
        tiempo = double.Parse(Console.ReadLine());
        entrenamientos.Add(distancia, tiempo);
        Console.WriteLine("Entrenamiento registrado con éxito.");
    }

    public void ListarEntrenamientos()
    {
        if (entrenamientos.Count == 0)
        {
            Console.WriteLine("\nNo hay entrenamientos registrados.");
            return;
        }

        foreach (KeyValuePair<double, double> entrenamiento in entrenamientos)
        {
            Console.WriteLine($"Distancia: {entrenamiento.Key} kilómetros - Tiempo: {entrenamiento.Value} horas");
        }
    }

    public void VaciarEntrenamientos()
    {
        entrenamientos.Clear();
        Console.WriteLine("Entrenamientos vaciados con éxito.");
    }
}
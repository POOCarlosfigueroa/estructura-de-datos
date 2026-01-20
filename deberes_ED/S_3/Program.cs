using Registro_Estudiantes;

class Program
    {
        static void Main(string[] args)
        {
            Estudiante nuevoEstudiante = new Estudiante();

            Console.WriteLine("=== Sistema de Registro de Estudiantes ===");

            // Captura de datos básicos
            Console.Write("Ingrese el ID: ");
            nuevoEstudiante.ID = Console.ReadLine();

            Console.Write("Ingrese los Nombres: ");
            nuevoEstudiante.Nombres = Console.ReadLine();

            Console.Write("Ingrese los Apellidos: ");
            nuevoEstudiante.Apellidos = Console.ReadLine();

            Console.Write("Ingrese la Dirección: ");
            nuevoEstudiante.Direccion = Console.ReadLine();

            // Captura de los 3 teléfonos
            for (int i = 0; i < nuevoEstudiante. Telefonos.Length; i++)
            {
                Console.Write($"  {i + 1}. {nuevoEstudiante.Telefonos[i]}");
                string tel = Console.ReadLine()!;
                nuevoEstudiante.Telefonos = new string[3];
            }
        }  
    }
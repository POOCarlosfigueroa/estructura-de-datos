using System;
using System.Collections.Generic;

namespace Registro_Estudiantes
{
    // Definimos la clase Estudiante para organizar los datos
    class Estudiante
    {
        public string? ID { get; set; }
        public string? Nombres { get; set; }
        public string ?Apellidos { get; set; }
        public string ?Direccion { get; set; }
       // Se define un arreglo de string con espacio para 3 elementos
        public string[] Telefonos { get; set; } = new string[3];

        public void MostrarInformacion()
        {
            Console.WriteLine("\n--- Información del Estudiante ---");
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Nombre Completo: {Nombres} {Apellidos}");
            Console.WriteLine($"Dirección: {Direccion}");
            Console.WriteLine("Teléfonos:");
            
                for (int i = 0; i < Telefonos.Length; i++)
              {
                 // Acceso directo por índice
                  Console.WriteLine($"  {i + 1}. {Telefonos[i]}");
              }
            }
        }
    }




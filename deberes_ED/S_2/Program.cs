using System;

namespace deber_2s
{
    // --- CLASE PROGRAM ----
    class Program
    {
        static void Main()
        {
            // Ahora creamos un objeto circulo
            
            Geometria.Circulo miCirculo = new Geometria.Circulo(5.5);
        
            Console.WriteLine($"Radio: {miCirculo.Radio}");
            Console.WriteLine($"Área: {miCirculo.CalcularArea():F2}");
            Console.WriteLine($"Perímetro: {miCirculo.CalcularPerimetro():F2}");
            
            
            // Ahora creamos un objeto cuadrado 
           
            Geometria.Cuadrado miCuadrado = new Geometria.Cuadrado(5.0);
            
            Console.WriteLine($"Cuadrado de lado: {miCuadrado.Lado}");
            Console.WriteLine($"Área: {miCuadrado.CalcularArea()}");
            Console.WriteLine($"Perímetro: {miCuadrado.CalcularPerimetro()}");
        }
    }
}   
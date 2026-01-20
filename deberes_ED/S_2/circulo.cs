using System;

namespace Geometria
{
    public class Circulo
    {
        // Campo privado (Encapsulamiento)
        private double _radio;

        // Propiedad para acceder al radio con validación
        public double Radio
        {
            get { return _radio; }
            set 
            { 
                if (value >= 0)
                    _radio = value;
                else
                    throw new ArgumentException("El radio no puede ser negativo.");
            }
        }

        // Constructor
        public Circulo(double radio)
        {
            Radio = radio; // Usamos la propiedad para aprovechar la validación
        }

        // Método para calcular el Área: π * r²
        public double CalcularArea()
        {
            return Math.PI * Math.Pow(_radio, 2);
        }

        // Método para calcular el Perímetro: 2 * π * r
        public double CalcularPerimetro()
        {
            return 2 * Math.PI * _radio;
        }
    }
}
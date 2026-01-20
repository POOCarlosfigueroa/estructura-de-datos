using System;

namespace Geometria
{
    public class Cuadrado
    {
        // Campo privado (encapsulamiento del dato primitivo)
        private double _lado;

        // Propiedad para acceder y validar el lado
        public double Lado
        {
            get { return _lado; }
            set 
            { 
                if (value > 0)
                    _lado = value;
                else
                    throw new ArgumentException("El lado debe ser mayor a cero.");
            }
        }

        // Constructor
        public Cuadrado(double lado)
        {
            Lado = lado;
        }

        // Método para calcular el área: Lado * Lado
        public double CalcularArea()
        {
            return _lado * _lado;
        }

        // Método para calcular el perímetro: Lado * 4
        public double CalcularPerimetro()
        {
            return _lado * 4;
        }
    }
}
using System;

namespace FigurasGeometricas
{
    // Clase del un Rectángulo
    class Rectangulo
    {
        // Atributos privados
        private double ancho;
        private double alto;

        // Constructor que recibe ancho y alto como parámetros
        public Rectangulo(double ancho, double alto)
        {
            this.ancho = ancho;
            this.alto = alto;
        }

        // Método para calcular el área del rectángulo: A = ancho * alto
        public double CalcularArea()
        {
            return ancho * alto;
        }

        // Método para calcular el perímetro del rectángulo: P = 2 * (ancho + alto)
        public double CalcularPerimetro()
        {
            return 2 * (ancho + alto);
        }
    }

    // Clase del Cuadrado
    class Cuadrado
    {
        // Atributo privado
        private double lado;

        // Constructor que recibe un lado como parámetro
        public Cuadrado(double lado)
        {
            this.lado = lado;
        }

        // Método para calcular el área del cuadrado: A = lado^2
        public double CalcularArea()
        {
            return lado * lado;
        }

        // Método para calcular el perímetro del cuadrado: P = 4 * lado
        public double CalcularPerimetro()
        {
            return 4 * lado;
        }
    }

    // Clase padre para probar las figuras
    class Program
    {
        static void Main(string[] args)
        {
            // Crear un rectángulo con ancho 5 y alto 3
            Rectangulo rect = new Rectangulo(5, 3);
            Console.WriteLine("Rectángulo:");
            Console.WriteLine("Área: " + rect.CalcularArea());
            Console.WriteLine("Perímetro: " + rect.CalcularPerimetro());

            // Crear un cuadrado con lado 4
            Cuadrado cuad = new Cuadrado(4);
            Console.WriteLine("\nCuadrado:");
            Console.WriteLine("Área: " + cuad.CalcularArea());
            Console.WriteLine("Perímetro: " + cuad.CalcularPerimetro());
        }
    }
}


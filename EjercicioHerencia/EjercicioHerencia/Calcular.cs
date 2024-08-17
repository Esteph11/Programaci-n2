using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerencia
{
    public class Calcular : Operaciones
    {
        private double BaseRectangulo { get; set; }
        private double AlturaRectangulo { get; set; }
        public double LadoCuadrado { get; set; }

        public Calcular(double baseRectangulo, double alturaRectangulo, double ladoCuadrado)
        {
            this.BaseRectangulo = baseRectangulo;
            this.AlturaRectangulo = alturaRectangulo;
            this.LadoCuadrado = ladoCuadrado;
        }

        public void imprimir()
        {
            Console.WriteLine();
            Console.WriteLine($"Longitud del rectángulo: {LongitudRectangulo(BaseRectangulo, AlturaRectangulo)}");
            Console.WriteLine($"Área del rectángulo: {AreaRectangulo(BaseRectangulo, AlturaRectangulo)}");
            Console.WriteLine($"Longitud del cuadrado: {LongitudCuadrado(LadoCuadrado)}");
            Console.WriteLine($"Área del cuadrado: {AreaCuadrado(LadoCuadrado)}");
        }


    }
}


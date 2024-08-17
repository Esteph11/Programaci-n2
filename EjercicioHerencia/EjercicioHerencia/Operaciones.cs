using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerencia
{
    public class Operaciones
    {

        public double LongitudRectangulo(double baseRectangulo, double alturaRectangulo)
        {
            return 2 * (baseRectangulo + alturaRectangulo);
        }

        public double AreaRectangulo(double baseRectangulo, double alturaRectangulo)
        {
            return baseRectangulo * alturaRectangulo;
        }

        public double LongitudCuadrado(double lado)
        {
            return 4 * lado;
        }
        public double AreaCuadrado(double lado)
        {
            return lado * lado;
        }


    }

}

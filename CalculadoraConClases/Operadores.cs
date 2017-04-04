using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraConClases
{
    class Operadores //el switch mando la opcion correcta
    {
        public static double Suma(double n1, double n2) //realiza suma
        {
            return n1 + n2;
        }
        public static double Resta(double n1, double n2) //realiza resta
        {
            return n1 - n2;
        }
        public static double Multi(double n1, double n2) //realiza multiplicación
        {
            return n1 * n2;
        }
        public static double Div(double n1, double n2) //realiza divicion
        {
            return n1 / n2;
        }
        public static Double sqrt(Double n1) //realiza raiz cuadrada
        {
            return Math.Sqrt(n1);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularOs3LadosDeUmTriangulo
{
    internal class Triangulo
    {
        public double x;
        public double y;
        public double z;

        public string ResultadoTriangulo()
        {
            if (x + y > z && x + z > y && y + z > x)
            {
                
                if (x == y && x == z)
                {
                    return "É um triângulo equilátero.";
                }
                else if (x == y || x == z || y == z)
                {
                    return "É um triângulo isósceles.";
                }
                else
                {
                    return "É um triângulo escaleno.";
                }
            }
            else
            {
                return "Os valores informados não formam um triângulo.";
            }
        }
    }
}

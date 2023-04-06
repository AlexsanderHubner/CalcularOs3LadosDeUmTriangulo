using System.Security.Cryptography.X509Certificates;

namespace CalcularOs3LadosDeUmTriangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo resultado = new Triangulo();

            resultado.x = 12;
            resultado.y = 7;
            resultado.z = 14;

            Console.WriteLine(resultado.ResultadoTriangulo());

        }
    }
}
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace CalcularAreaTriangulos
{
    class Program
    {
        static void Main(string[] args)
        {
            Cl_triangulo x = new Cl_triangulo();
            Cl_triangulo y = new Cl_triangulo();

            Console.WriteLine("Entre com as medidas dos lados do triângulo 1: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas dos lados do triângulo 2: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CalculaTriangulo(x, y);

        }
        //----------------------------------------------------------------------

        private static void CalculaTriangulo(Cl_triangulo x, Cl_triangulo y)
        {
            double area1;
            double area2;
            double p1;
            double p2;
            

            p1 = (x.A + x.B + x.C) / 2.0;
            area1 = Math.Sqrt(p1*((p1 - x.A)*(p1 - x.B)*(p1 - x.C)));

            p2 = (y.A + y.B + y.C) / 2.0;
            area2 = Math.Sqrt(p2 * ((p2 - y.A) * (p2 - y.B) * (p2 - y.C)));


            Console.WriteLine("Área de x = {0}", area1.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de y = {0}",area2.ToString("F4", CultureInfo.InvariantCulture));

            if(area1 > area2)
                Console.WriteLine("Maior área: X");
            else if(area1 == area2)
                Console.WriteLine("Áreas iguais de x e y");
            else
                Console.WriteLine("Maior área: Y");
        }
    }
}

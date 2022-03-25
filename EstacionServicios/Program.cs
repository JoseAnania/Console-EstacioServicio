using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionServicios
{
    class Program
    {
        static void Main(string[] args)
        {
            int tipoCombustible, cantidadLitros, menorVenta=0, numeroMenor=0;
            float acumuladorS=0, acumuladorP=0, acumuladorG=0, factS=0, factP=0, factG=0;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Sutidor Nº: " + i);
                Console.WriteLine("Tipo de combustible del surtidor Nº " + i + " | 1-Súper | 2-Premium | 3-Gasoil |");
                tipoCombustible = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese cantidad de litros vendidos del Surtidor Nº " + i + " :");
                cantidadLitros = Convert.ToInt32(Console.ReadLine());
                if(tipoCombustible==1)
                {
                    acumuladorS += cantidadLitros;
                    factS = acumuladorS * 25;
                }
                if(tipoCombustible==2)
                {
                    acumuladorP += cantidadLitros;
                    factP = acumuladorP * 30;
                }
                if(tipoCombustible==3)
                {
                    acumuladorG += cantidadLitros;
                    factG = acumuladorG * 20;
                }
                if(i==1 || cantidadLitros<menorVenta)
                {
                    menorVenta = cantidadLitros;
                    numeroMenor = i;
                }


            }
            Console.WriteLine();
            Console.WriteLine("Cantidad de litros de Combustible Súper Vendido: " + acumuladorS);
            Console.WriteLine("Cantidad de litros de Combustible Premium Vendido: " + acumuladorP);
            Console.WriteLine("Cantidad de litros de Combustible Gasoil Vendido: " + acumuladorG);
            if(acumuladorS>acumuladorP && acumuladorS>acumuladorG)
            {
                Console.WriteLine("El combustible más vendido es Súper");
            }
            if(acumuladorP>acumuladorS && acumuladorP>acumuladorG)
            {
                Console.WriteLine("El combustible más vendido es Premium");
            }
            if(acumuladorG>acumuladorS && acumuladorG>acumuladorP)
            {
                Console.WriteLine("El combustible más vendido es Gasoil");
            }
            Console.WriteLine("El Surtidor con menos Venta es el Nº: " + numeroMenor);

            Console.WriteLine("Total Facturado: $" + (factS + factP + factG));
            Console.Read();
        }
    }
}

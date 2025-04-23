using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hallar la suma de los primeros n numeros naturales
            /*int n, suma;
            Console.WriteLine("Ingrese el nùmero de elementos: ");
            n= int.Parse(Console.ReadLine());

            //Sì n= 6
            //1 + 2 + 3 + 4 + 5 + 6
            suma = 0;
            for(int i= 1; i<= n; i++)
            {
                Console.WriteLine("-------\nIteraciòn " + i);
                suma = suma + i;
                Console.WriteLine("->En esta iteraciòn la suma es: " + suma);
                Console.ReadKey();
            }
            Console.WriteLine("La suma es: " + suma);
            */

            //Hallar la suma de los cubos de los n numeros naturales 
            /*int n, Sumacubos;
            Console.WriteLine("Nùmero de elementos: ");
            n = int.Parse(Console.ReadLine());

            Sumacubos = 0;

            for(int i= 1; i <= n; i++)
            {
                Sumacubos = Sumacubos + (i * i * i);
            }
            Console.WriteLine("La suma de los cuadrados es: " + Sumacubos);


            //Hallar la suma de los primeros numeros naturales pares
            /*int n1, sumapares;
            Console.Write("Ingrese numero de elemntos: ");
            n1 = int.Parse(Console.ReadLine());
            sumapares = 0;

            for(int i = 1; i <= n1; i++ )
            {
                Console.WriteLine("Hola");
            }
            */

            //Mostrar los numeros
            //de mayor a menor
            //ejemplo: 10,9,8....1

            Console.WriteLine("Nùmero del 10 al 1");
            for (int i=10; i>=1; i--)
            {
                Console.WriteLine(i);
                if (i > 1) ;
                Console.WriteLine("");
            }
            Console.ReadLine(); 
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

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

            /*Console.WriteLine("Nùmero del 10 al 1");
            for (int i=10; i>=1; i--)
            {
                Console.WriteLine(i);
                if (i > 1) ;
                Console.WriteLine("");
            }
            Console.ReadLine(); 
            */

            //Indicar si un numero es perfecto,
            //cuando la suma de sus divisores es
            //igual al numero.
            //Por ejemplo 6, tiene como divisores
            //a 1,2 y 3, luego 1+2+3= 6
          
            int num;
            int suma = 0;
            Console.Write("Ingrese numero: ");
            num = int.Parse(Console.ReadLine());

            for(int x = 1; x < num; x++) 
            {
                //mod => %
                if (num % x==0)
                {
                    suma = suma + x;
                }
            }
            //Console.WriteLine("Suma: "+Suma");
            if (num == suma) 
            {
                Console.WriteLine("Si es perfecto");
            }else
            {
                Console.WriteLine("No es perfecto");
            }
        }
    }
}

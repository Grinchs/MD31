using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD_3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Inicializē mainīgos

            double x = 0;
            double y = 0;

            // User inputs x

            Console.WriteLine("Ievadiet mainīgo x: ");
            x = double.Parse(Console.ReadLine());         

            // User inputs y

            Console.WriteLine("Ievadiet mainīgo y: ");
            y = double.Parse(Console.ReadLine());           

            // Izprinte abus mainigos

            Console.WriteLine("Mainīgais x = " + x);
            Console.WriteLine("Mainīgais y = " + y);

            // Saskaitishanas darbiba

            double saskaitishana = x + y;
            Console.WriteLine("x+y = " + saskaitishana);

            // Atnemshanas darbiba

            double atnemshana = x - y;
            Console.WriteLine("x - y = " + atnemshana);

            // Dalishanas darbiba (Vesela veida)

            double dalishana = x / y;
            Console.WriteLine("x/y = " + Math.Round(dalishana));

            // Dalīšanas atlikums

            double atl = x % y;
            Console.WriteLine("x % y = " + atl);

            // Dalīšanas rezultāts (Daļskaitlis)

            double dalishana2 = x / y;
            Console.WriteLine("x/y = " + dalishana2);

            // Njaam

            double idk = x * x + y * y;
            Console.WriteLine("x^2+y^2 =" + idk);
        }
    }
}

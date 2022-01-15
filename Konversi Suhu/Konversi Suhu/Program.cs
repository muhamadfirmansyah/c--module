using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Konversi_Suhu
{
    class Program
    {
        static void Main(string[] args)
        {
            double k=273.5, c, v;
            float r, f;
            Console.Write("Input suhu dalam Celcius : ");
            c = Convert.ToInt32(Console.ReadLine());
            r = (float)c * 4 / 5;
            f = (float)c * 9 / 5 + 32;
            v = c + k;
            Console.WriteLine();
            Console.WriteLine("Celcius      = " + c);
            Console.WriteLine("Reamur       = " + r);
            Console.WriteLine("Fahrenheit   = " + f);
            Console.WriteLine("Kelvin       = " + k);
            Console.ReadKey();

        }
    }
}

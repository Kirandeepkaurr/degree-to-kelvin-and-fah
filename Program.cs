using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace degree_to_kelvin_and_fah
{
    class Program
    {
        //convert from Celsius degrees to Kelvin and Fahrenheit.
        static void Main(string[] args)
        {
            Console.Write("Enter the amount of celsius: ");
            int celsius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kelvin = {0}", celsius + 273);
            Console.WriteLine("Fahrenheit = {0}", celsius * 18 / 10 + 32);
        }
    }
}

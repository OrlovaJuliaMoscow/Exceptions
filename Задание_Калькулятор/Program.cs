using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_Калькулятор
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's calculate!");

            
            try
            {
                Console.WriteLine("Write x");
                double x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Write y");
                double y = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Write code");
                double n = Convert.ToDouble(Console.ReadLine());
                if (n == 1)
                {
                    double s = (x + y);
                    Console.WriteLine(s);
                }
                else if (n == 2)
                {
                    double m = (x - y);
                    Console.WriteLine(m);
                }
                else if (n==3)
                {
                    double mu = (x * y);
                    Console.WriteLine(mu);
                }
                else if (n == 4)
                {
                    double d= (x / y);
                    Console.WriteLine(d);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            Console.ReadKey();
            
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int a= Convert.ToInt32(Console.ReadLine());  
           int b= Convert.ToInt32(Console.ReadLine());
            try
            {
                Console.WriteLine(a / b);
            }
            catch (DivideByZeroException) 
            {
                Console.WriteLine("Error 0");
            }
             Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const String MyName = "Roman";
            byte MyAge = 27;
            bool HaveIApet = true;
            double MyShoeSize = 37.5;

            Console.WriteLine("My name is " + MyName);
            Console.WriteLine("MyAge " + MyAge);
            Console.WriteLine("Do I have a pet? " + HaveIApet);
            Console.WriteLine("My shoe size is " + MyShoeSize);
            Console.ReadKey();
        }
    }
}

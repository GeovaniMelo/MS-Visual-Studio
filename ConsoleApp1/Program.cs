using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            FileStream fs = new FileStream(@"C:\\", FileMode.Open, FileAccess.Read);


        }
    }
}

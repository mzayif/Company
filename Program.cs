using System;

namespace Company
{
    class Program
    {
        static void Main(string[] args)
        {               
            using( var Context = new AppDBContext())
            {
                Context.Database.EnsureCreated();
            }

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}

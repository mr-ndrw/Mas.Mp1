using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mas.Mp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var glad = new Gladiator("Hello", new[] {"Hello"}, "World", 350);
            var mirm = new Mirmillo("Bye", new[] {"Bye"}, "World", 150);

            Console.WriteLine(Fighter.Salaries);

            Console.ReadKey();
        }
    }
}

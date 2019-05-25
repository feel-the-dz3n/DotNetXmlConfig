using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetXmlConfig.ConsoleTestProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numbers loaded:");

            foreach (var number in ConfigMan.Numbers.Numbers)
                Console.WriteLine(number.ToString());

            while (true)
            {
                Console.WriteLine("Enter new number. Example: name|number");
                Console.WriteLine("Enter 'q' to exit");

                var line = Console.ReadLine();

                if (line == "q") Environment.Exit(0);

                string[] split = line.Split('|');

                var n = new XmlNumber(split[0], split[1]);

                ConfigMan.Numbers.Numbers.Add(n);

                Console.WriteLine("Added:");
                Console.WriteLine(n.ToString());
            }
        }
    }
}

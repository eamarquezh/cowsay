using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cowsay
{
    class Program
    {
        static void Main(string[] args)
        {
            string dice = "Hola humano";
            if (args.Length > 0)
            {
                dice = args[0];
            }
            const string bs = "\u005c";
            System.Console.WriteLine("________________________________________");
            System.Console.WriteLine(dice);
            System.Console.WriteLine("----------------------------------------");
            System.Console.WriteLine("        " + bs + "   ^__^                         ");
            System.Console.WriteLine("         " + bs + "  (oo)" + bs + "_______                 ");
            System.Console.WriteLine("            (__)" + bs + "       )" + bs + "/" + bs + "             ");
            System.Console.WriteLine("                ||----w |                ");
            System.Console.WriteLine("                ||     ||                ");
            Console.ReadKey();
        }
    }
}

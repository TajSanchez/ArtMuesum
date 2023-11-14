using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtMuesumConsoleApp
{
    internal static class ConsoleLogging
    {
        public static void PassMessage(string message)
        {
            Console.WriteLine(message);
        }

        public static void BlankLine()
        {
            Console.WriteLine();
        }

    }
}

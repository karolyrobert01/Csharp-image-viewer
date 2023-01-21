using System;
using static System.Console;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Example
{
    class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                WriteLine("Hiba! Adja meg a mappa elérési útját!");
                Environment.Exit(1);
            }
            else if (!Directory.Exists(args[0]))
            {
                WriteLine("Hiba! Adja meg a mappa elérési útját!");
                Environment.Exit(1);
            }
            else
            {
                string utvonal = args[0];

                Rekurzio.Bejaras(utvonal);

                WriteLine("VÉGE");
            }
        }
    }
}

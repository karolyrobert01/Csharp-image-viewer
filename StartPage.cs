using System;
using static System.Console;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Example
{
    class StartPage
    {
        public static string Visszalepes(string utvonal)
        {
            int perjelekszama = utvonal.ToCharArray().Where(c => c == '/').Count();
            int gyokerbenperjelekszama = Environment.GetCommandLineArgs()[1].ToCharArray().Where(c => c == '/').Count();
            int visszalepes = perjelekszama - gyokerbenperjelekszama;

            string gyokerutvonal = "index.html";

            for (int i = 0; i < visszalepes; i++)
            {
                gyokerutvonal = "../" + gyokerutvonal;
            }

            return gyokerutvonal;
        }
    }
}

using System;
using static System.Console;
using System.IO;
using System.Collections.Generic;
using System.Linq;


namespace Example
{
    class Index
    {
        public static void IndexLetrehozasa(string utvonal, List<string> kepek, List<string> mappak)
        {
            var g = new StreamWriter(utvonal + "/index.html");
            string gyokerutvonal = StartPage.Visszalepes(utvonal);

            g.WriteLine($"<h2><a href=\"{gyokerutvonal}\">Start Page</h2></a>");
            g.WriteLine("<hr>");
            g.WriteLine("<h2>Directories:</h2>");
            g.WriteLine("<ul>");

            string[] argumentumok = Environment.GetCommandLineArgs();

            if (!(utvonal == argumentumok[1])) //ha van előző mappa, visszatudjunk lépni
            {
                g.WriteLine("<li><a href=\"../index.html\"><<</a></li>");
            }

            foreach (string mappanev in mappak)
            {
                g.WriteLine($"<li><a href=\"{mappanev}/index.html\">{mappanev}</a></li>");
            }

            g.WriteLine("</ul>");
            g.WriteLine("<hr>");
            g.WriteLine("<h2>Images:</h2>");
            g.WriteLine("<ul>");

            foreach (string kep in kepek)
            {
                string kepneve = kep.Substring(0, kep.LastIndexOf('.'));
                g.WriteLine($"<li><a href=\"{kepneve}.html\">{kep}</a></li>");
            }

            g.WriteLine("</ul>");
            g.Close();
        }
    }
}

using System;
using static System.Console;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Example
{
    class Pictures
    {
        public static void KepekLetrehozasa(string utvonal, List<string> kepek)
        {
            for (int i = 0; i < kepek.Count(); i++)
            {
                string kep = kepek[i];
                string kepneve = kep.Substring(0, kep.LastIndexOf('.'));
                var g = new StreamWriter(utvonal + $"/{kepneve}.html");
                string gyokerutvonal = StartPage.Visszalepes(utvonal);

                g.WriteLine($"<h2><a href=\"{gyokerutvonal}\">" + "Start Page</h2></a>");
                g.WriteLine("<hr>");
                g.WriteLine("<a href=\"index.html\">^^</a>");
                g.WriteLine("<br><br>");

                string elozokep = "";
                string kovkep = "";

                if (i - 1 < 0) //legelső kép
                {
                    elozokep = kepneve + ".html";
                    kovkep = kepek[i + 1].Substring(0, kepek[i + 1].LastIndexOf('.')) + ".html";
                    g.WriteLine($"<a href=\"{elozokep}\"> </a> {kep} <a href=\"{kovkep}\"> >> </a>");
                }
                else if (i + 1 >= kepek.Count()) //utolsó kép
                {
                    kovkep = kepneve + ".html";
                    elozokep = kepek[i - 1].Substring(0, kepek[i - 1].LastIndexOf('.')) + ".html";
                    g.WriteLine($"<a href=\"{elozokep}\"> << </a> {kep} <a href=\"{kovkep}\">  </a>");
                }
                else
                {
                    elozokep = kepek[i - 1].Substring(0, kepek[i - 1].LastIndexOf('.')) + ".html";
                    kovkep = kepek[i + 1].Substring(0, kepek[i + 1].LastIndexOf('.')) + ".html";
                    g.WriteLine($"<a href=\"{elozokep}\"> << </a> {kep} <a href=\"{kovkep}\"> >> </a>");
                }

                g.WriteLine("<br><br>");
                g.WriteLine($"<a href=\"{kovkep}\"><img src=\"{kep}\"height=\"40%\" width=\"40%\"></a>");
                g.WriteLine("<br><br>");

                g.Close();
            }
        }
    }
}

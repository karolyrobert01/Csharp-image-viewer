using System;
using static System.Console;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Example
{
    class Rekurzio
    {
        public static void Bejaras(string utvonal)
        {
            string[] kiterjesztes = {"png", "jpg", "jpeg"};

            var kepek = Directory.GetFiles(utvonal).Where(x => kiterjesztes.Contains(x.Substring(x.LastIndexOf('.') + 1).ToLower()))
                                                .Select(f => f.Substring(f.LastIndexOf('/') + 1)).ToList();
            var mappak = Directory.GetDirectories(utvonal).Select(d => d.Substring(d.LastIndexOf('/') + 1)).ToList();

            kepek.Sort();
            mappak.Sort();

            Index.IndexLetrehozasa(utvonal, kepek, mappak);
            Pictures.KepekLetrehozasa(utvonal, kepek);

            if (mappak.Count() != 0)
            {
                for (int i = 0; i < mappak.Count(); i++)
                {
                    string mappaneve = mappak[i];
                    string mappautvonal = utvonal + "/" + mappaneve;

                    WriteLine(mappautvonal);

                    Bejaras(mappautvonal);
                }
            }
        }

    }
}

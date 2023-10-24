using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bolygokdolgozat
{
    class Bolygo
    {
        public string Nev { get; set; }
        public int HoldakSzama { get; set; }
        public double TerfogatArany { get; set; }

        public Bolygo(string sor) {
            var b = sor.Split(";");
            Nev = b[0];
            HoldakSzama = int.Parse(b[1]);
            TerfogatArany = double.Parse(b[2].Replace(".", ","));
        }
    }
}

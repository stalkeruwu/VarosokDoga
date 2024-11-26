using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarosokDoga
{
    internal class Nagyvaros
    {
        public string Varos { get; set; }
        public string Orszag { get; set; }
        public float Nepesseg { get; set; }

        public Nagyvaros(string line)
        {
            var split = line.Split(';');
            Varos = split[0];
            Orszag = split[1];
            Nepesseg = float.Parse(split[2]);
        }
        override public string ToString()
        {
            return $"{Varos} ({Orszag}) - {Nepesseg:.00} millió fő";
        }

    }
}

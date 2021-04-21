using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UwpAutoSuggest
{
    class Radnik
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Firma { get; set; }

        public override string ToString()
        {
            return $"{Ime}\n{Prezime}\n{Firma}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UwpAutoSuggest
{
    static class Podaci
    {
        private static List<Radnik> radnici = new List<Radnik>()
        {
            new Radnik {Ime="James",Prezime="Buchanan", Firma="Benton"},
            new Radnik {Ime="Josephine",Prezime="Darakjy", Firma="Chanay"},
            new Radnik {Ime="Art",Prezime="Venere", Firma="Chemel"},
            new Radnik {Ime="Lenna",Prezime="Paprocki", Firma="Feltz PrintingService"},
            new Radnik {Ime="Donette",Prezime="Foller", Firma="PrintingDimensions"},
            new Radnik {Ime="Simona",Prezime="Marasca", Firma="Chapman"},
            new Radnik {Ime="Mitsue",Prezime="Tollner", Firma="MorlongAssociates"},
            new Radnik {Ime="Leota",Prezime="Wieser", Firma="Truhlar and TruhlarAttys"},
            new Radnik {Ime="Sage",Prezime="Marrier", Firma="King"},
            new Radnik {Ime="Kris",Prezime="Dilliard", Firma="Commercial Press"},
            new Radnik {Ime="Minna",Prezime="Amigon", Firma="Dorl"},
            new Radnik {Ime="Abel",Prezime="Maclead", Firma="Rangioni ofFlorence"}
        };

        public static List<Radnik> Radnici
        {
            get { return radnici; }
        }
    }
}

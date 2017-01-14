using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw6
{
    class Osoba
    {
        protected string imie;
        protected string nazwisko;
        public Osoba() { }

        public Osoba(string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;

        }

        public virtual void WypiszInfo()
        {
            Console.WriteLine("Imie: {0}", imie);
            Console.WriteLine("Nazwisko: {0}", nazwisko);
        }
    }
}

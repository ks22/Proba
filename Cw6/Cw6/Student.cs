using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw6
{
    class Student:Osoba
    {
        private int rokStudiow;
        private int numerGrupy;
        private int numerAlbumu;

        public Student(){}

        public Student(string imie, string nazwisko, int rokStudiow,int numerGrupy, int numerAlbumu)
            :base(imie,nazwisko)
        {
            this.rokStudiow = rokStudiow;
            this.numerGrupy= numerGrupy;
            this.numerAlbumu = numerAlbumu;

        }
        public override void WypiszInfo()
        {
            //Console.WriteLine("Imie: {0}", imie);
            //Console.WriteLine("Nazwisko: {0}", nazwisko);
            base.WypiszInfo();//tak lepiej bo tego powyzej nie trza pisac
            Console.WriteLine("Rok studiow: {0}", rokStudiow);
            Console.WriteLine("Numer grupy {0}", numerGrupy);
            Console.WriteLine("Numer albumu: {0}", numerAlbumu);
        }
    }
}

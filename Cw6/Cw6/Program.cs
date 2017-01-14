using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Osoba osoba1 = new Osoba("Jan", "Kowalski");
            Student student1 = new Student("Anna", "Nowak", 3, 2, 22345);
            osoba1.WypiszInfo();
            student1.WypiszInfo();*/
            Osoba student2 = new Student("Tomasz","Nowak",3,2,11234); // wypisze tylko osobe, cos z rzutowaniem, te virtual i override powoduje, ze bedzie ok
            student2.WypiszInfo();
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ćwiczenie4._2
{
    class Smartphone : Dekorator
    {
        public Smartphone(ZwykłyTelefon zwykłytelefon, string typtelefonu) : base(typtelefonu, zwykłytelefon)
        {

        }
        
        public void OdtwórzMuzykę(string Piosenka)
        {
            Console.WriteLine("Została odtworzona piosenka o tytule {0}", Piosenka);
        }

        public void OtwórzStronę(string Strona)
        {
            Console.WriteLine("Została otworzona strona o adresie {0}", Strona);
        }
    }
}

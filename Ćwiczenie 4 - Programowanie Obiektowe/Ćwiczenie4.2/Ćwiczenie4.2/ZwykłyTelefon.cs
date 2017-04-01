using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ćwiczenie4._2
{
    class ZwykłyTelefon:ITelefon
    {
        private string _TypTelefonu;
        public ZwykłyTelefon(string typtelefonu)
        {
            this._TypTelefonu = typtelefonu;
        }
        public void WybierzNumer(string NumerTelefonu)
        {
            Console.WriteLine("Użytkownik wybrał numer {0}",NumerTelefonu);
        }

        public void WyślijWiadomość(string NumerTelefonu, string TreśćWiadomości)
        {
            Console.WriteLine("Użytkownik wysłał wiadomość na numer {0} o treści: {1}", NumerTelefonu, TreśćWiadomości);
        }

        public void PokażTyp()
        {
            Console.WriteLine("Typem tego telefonu jest {0}", _TypTelefonu);
        }
 
    }
}

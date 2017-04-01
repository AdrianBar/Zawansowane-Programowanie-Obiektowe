using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ćwiczenie4._2
{
    class Dekorator : ITelefon
    {
        private string _TypTelefonu;
        protected ITelefon _ITelefon;

        public Dekorator(string typtelefonu, ITelefon itelefon)
        {
            this._TypTelefonu = typtelefonu;
            this._ITelefon = itelefon;
        }

        public void PokażTyp()
        {
            Console.WriteLine("Typem tego telefonu jest {0}", _TypTelefonu);
        }

        public void WybierzNumer(string NumerTelefonu)
        {
            _ITelefon.WybierzNumer(NumerTelefonu);
        }

        public void WyślijWiadomość(string NumerTelefonu, string TreśćWiadomości)
        {
            _ITelefon.WyślijWiadomość(NumerTelefonu, TreśćWiadomości);
        }
    }
}

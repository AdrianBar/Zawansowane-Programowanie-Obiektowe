using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ćwiczenie4._2
{
    interface ITelefon
    {
        void WybierzNumer(string NumerTelefonu);
        void WyślijWiadomość(string NumerTelefonu, string TreśćWiadomości);
        void PokażTyp();
        
    }
}

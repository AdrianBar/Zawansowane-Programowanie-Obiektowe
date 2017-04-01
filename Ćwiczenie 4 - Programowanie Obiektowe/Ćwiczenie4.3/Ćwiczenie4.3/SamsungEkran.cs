using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ćwiczenie4._3
{
    class SamsungEkran : IEkran
    {
        public void Twórz()
        {
            Console.WriteLine("Ekran telefonu marki Samsung został utworzony");
        }
    }
}

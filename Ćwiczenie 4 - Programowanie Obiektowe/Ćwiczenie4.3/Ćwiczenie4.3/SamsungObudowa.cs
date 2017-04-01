using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ćwiczenie4._3
{
    class SamsungObudowa : IObudowa
    {
        public void Twórz()
        {
            Console.WriteLine("Obudowa przeznaczona do telefonu marki Samsung została utworzona");
        }
    }
}

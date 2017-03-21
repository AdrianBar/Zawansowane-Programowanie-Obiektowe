using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ćwiczenie_2._2
{
    abstract class Bohater: IBohater
    {
        public string Imię;
        public double Hp;
        public double Atak;
        public RasaEnum.Rasy Rasa;

        public void BijWroga(Bohater cel)
        {
            if (!SprawdzHp())
                return;
            Random rnd = new Random();
            double obrazenia = Atak;
            cel.Obrazenia(obrazenia);
            Console.WriteLine("{0} otrzymal {1:0.00} obrazen zadanych atakiem od {2}\npozostalo mu {3:0.00} HP", cel.Imię, obrazenia, Imię, cel.Hp);

        }

        public bool SprawdzHp()
        {
            return Hp > 0;
        }
        public void Obrazenia(double obrazenia)
        {
            if(!SprawdzHp())
            {
                return;
            }
            Hp -= obrazenia;
        }
        public override string ToString()
        {
            return string.Format("Imie: {0}\nHP: {1:0.00}\nAtak: {2:0.00}\nRasa: {3}\n", Imię, Hp, Atak, Rasa);
        }
    }
}

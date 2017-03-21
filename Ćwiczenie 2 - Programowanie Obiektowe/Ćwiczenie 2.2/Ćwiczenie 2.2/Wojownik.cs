using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ćwiczenie_2._2
{
    class Wojownik:Bohater
    {
        public Wojownik(string imie, double hp, double atak, RasaEnum.Rasy rasa)
        {
            this.Imię = imie;
            this.Hp = hp;
            this.Atak = atak;
            this.Rasa = rasa;
        }
        public void RzutToporem(Bohater cel)
        {
            if (!SprawdzHp())
                return;
            Random rnd = new Random();
            double obrazenia = Atak;
            cel.Obrazenia(obrazenia);
            Console.WriteLine("{0} otrzymal {1:0.00} obrazen zadanych rzutem toporem od {2}\npozostalo mu {3:0.00} HP", cel.Imię, obrazenia, Imię, cel.Hp);

        }
    }
}

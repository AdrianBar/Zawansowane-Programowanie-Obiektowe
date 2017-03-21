using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ćwiczenie_2._2
{
    class Mag : Bohater
    {
        public double Mana;

        public Mag(string imie, double hp, double atak, RasaEnum.Rasy rasa, double mana )
        {
            this.Imię = imie;
            this.Hp = hp;
            this.Atak = atak;
            this.Rasa = rasa;
            this.Mana = mana;  
        }
        public void RzucCzar(Bohater cel)
        {
            if (!SprawdzHp())
                return;

            if (Mana <= 0)
                Console.WriteLine("{0}: brak many", Imię);
            Random rnd = new Random();
            double obrazenia = Atak;
            Mana = Mana - 10;
            cel.Obrazenia(obrazenia);
            Console.WriteLine("{0} otrzymal {1:0.00} obrazen zadanych czarem od {2}\npozostalo mu {3:0.00} HP", cel.Imię, obrazenia, Imię, cel.Hp);
        }
        public override string ToString()
        {
            return base.ToString() + string.Format("Mana: {0:0.00}\n", Mana);
        }
    }
}

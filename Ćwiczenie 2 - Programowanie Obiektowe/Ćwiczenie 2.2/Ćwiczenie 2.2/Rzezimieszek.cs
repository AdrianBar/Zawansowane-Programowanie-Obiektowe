using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ćwiczenie_2._2
{
    class Rzezimieszek:Bohater
    {
        public double Energia;

        public Rzezimieszek(string imie, double hp, double atak , RasaEnum.Rasy rasa, double energia)
        {
            this.Imię = imie;
            this.Hp = hp + energia;
            this.Atak = atak;
            this.Rasa = rasa;

        }
        public override string ToString()
        {
            return base.ToString() + string.Format("Energia: {0:0.00}\n", Energia);
        }
    }
}

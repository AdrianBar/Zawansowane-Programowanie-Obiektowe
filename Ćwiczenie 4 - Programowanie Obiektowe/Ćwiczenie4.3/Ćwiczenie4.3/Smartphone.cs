using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ćwiczenie4._3
{
    class Smartphone
    {
        public string Nazwa;
        IEkran Ekran;
        IObudowa Obudowa;
        public Smartphone(string nazwa, IFabryka fabryka)
        {
            this.Nazwa = nazwa;
            this.Obudowa = fabryka.TwórzObudowę();
            this.Ekran = fabryka.TwórzEkran();
        }
        public void TwórzSmartphone()
        {
            Obudowa.Twórz();
            Ekran.Twórz();
            Console.WriteLine("Telefon {0} został zbudowany",Nazwa);
        }

    }
}

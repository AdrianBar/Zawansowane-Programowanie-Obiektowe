using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ćwiczenie_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //tworzenie drużyny i przeciwnika
            List<Bohater> DrużynaPierścieniaIPrzeciwnik = new List<Bohater>();
            Mag Gandalf = new Mag("Gandalf", 100, 150, RasaEnum.Rasy.Człowiek, 100);
            Wojownik Aragorn = new Wojownik("Aragorn", 150, 100, RasaEnum.Rasy.Człowiek);
            Rzezimieszek Frodo = new Rzezimieszek("Frodo", 100, 50, RasaEnum.Rasy.Hobbit, 75);
            Wojownik Ugluk = new Wojownik("Ugluk", 1000, 70, RasaEnum.Rasy.UrukHai);
            DrużynaPierścieniaIPrzeciwnik.Add(Gandalf);
            DrużynaPierścieniaIPrzeciwnik.Add(Aragorn);
            DrużynaPierścieniaIPrzeciwnik.Add(Frodo);
            DrużynaPierścieniaIPrzeciwnik.Add(Ugluk);

            // wypisanie osób biorących udział w walce
            foreach(var postac in DrużynaPierścieniaIPrzeciwnik)
            {
                Console.WriteLine(postac);
            }
            //walka
            Random r = new Random(DateTime.Now.Millisecond);
            int runda = 1;
            while (DrużynaPierścieniaIPrzeciwnik[3].SprawdzHp()&&(DrużynaPierścieniaIPrzeciwnik[0].SprawdzHp() || DrużynaPierścieniaIPrzeciwnik[1].SprawdzHp() || DrużynaPierścieniaIPrzeciwnik[2].SprawdzHp()))
            {
                Console.WriteLine("Runda: {0}\n", runda);

                ((Mag)DrużynaPierścieniaIPrzeciwnik[0]).RzucCzar(DrużynaPierścieniaIPrzeciwnik[3]);
                ((Wojownik)DrużynaPierścieniaIPrzeciwnik[1]).RzutToporem(DrużynaPierścieniaIPrzeciwnik[3]);
                ((Rzezimieszek)DrużynaPierścieniaIPrzeciwnik[2]).BijWroga(DrużynaPierścieniaIPrzeciwnik[3]);

                if (r.NextDouble() < 0.3 && DrużynaPierścieniaIPrzeciwnik[3].SprawdzHp())
                    DrużynaPierścieniaIPrzeciwnik[3].BijWroga(DrużynaPierścieniaIPrzeciwnik[0]);
                if(r.NextDouble() > 0.3 && r.NextDouble() < 0.7 && DrużynaPierścieniaIPrzeciwnik[3].SprawdzHp())
                    DrużynaPierścieniaIPrzeciwnik[3].BijWroga(DrużynaPierścieniaIPrzeciwnik[1]);
                if (r.NextDouble() > 0.7 && DrużynaPierścieniaIPrzeciwnik[3].SprawdzHp())
                    DrużynaPierścieniaIPrzeciwnik[3].BijWroga(DrużynaPierścieniaIPrzeciwnik[2]);
                runda++;
                Console.WriteLine();
            }

            Console.ReadLine();




        }
    }
}

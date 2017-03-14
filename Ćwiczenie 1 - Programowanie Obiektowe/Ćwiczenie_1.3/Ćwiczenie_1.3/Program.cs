using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ćwiczenie_1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> człowiek1Imiona = new List<string>();
            człowiek1Imiona.Add("Andrzej");
            człowiek1Imiona.Add("Patryk");
            StandardowyCzłowiek człowiek1 = new StandardowyCzłowiek(człowiek1Imiona, 24, 146, "Polkowice", 23);
            List<string> człowiek2imiona = new List<string>();
            człowiek2imiona.Add("Paweł");
            człowiek2imiona.Add("Jacek");
            StandardowyCzłowiek człowiek2 = new StandardowyCzłowiek(człowiek2imiona, 35, 146, "Szczecin", 23);
            List<string> człowiek3imiona = new List<string>();
            człowiek3imiona.Add("Marcin");
            człowiek3imiona.Add("Maciej");
            człowiek3imiona.Add("Franek");
            StandardowyCzłowiek człowiek3 = new StandardowyCzłowiek(człowiek3imiona, 15, 146, "Polkowice", 23);
            List<StandardowyCzłowiek> lista = new List<StandardowyCzłowiek>();
            lista.Add(człowiek1);
            lista.Add(człowiek2);
            lista.Add(człowiek3);
            // obliczanie średniej
            double sumawieku = 0;
            foreach (StandardowyCzłowiek człowiek in lista)
            {
                sumawieku = sumawieku + człowiek.Wiek;
            }
            sumawieku = sumawieku / lista.Count();
            Console.WriteLine("Średnia wieku wynosi {0}", sumawieku);
            //wypisanie uniwersalnych wartości
            Console.WriteLine("Człowiek ma 146 kości i 23 chromosomy");
            // wypisanie wszystkich imion obiektu
            Console.Write("Imiona pierwszego obiketu to:");
            foreach(string imiona in człowiek1.Imię)
            {
                Console.Write("{0} ", imiona);
            }
            //wypisanie najczęściej występującej miejscowości
            List<string> miejscowości = new List<string>();

            foreach(StandardowyCzłowiek miejsc1 in lista)
            {
                miejscowości.Add(miejsc1.MiejscePochodzenia);
            }
            string maxreapeted = miejscowości.GroupBy(s => s)
                         .OrderByDescending(s => s.Count())
                         .First().Key;
            Console.WriteLine("");
            Console.WriteLine("Najczęściej powtarzająca się miejscowość to: {0}", maxreapeted);
            Console.ReadLine();
        }
    }
}

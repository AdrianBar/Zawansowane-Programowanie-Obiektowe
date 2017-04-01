using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ćwiczenie4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            ZwykłyTelefon zwykłytelefon = new ZwykłyTelefon("zwykły");
            Smartphone smartphone = new Smartphone(zwykłytelefon,"smartphone");

            //zwykły telefon
            Console.WriteLine("Funkcjonalności zwykłego telefonu:");
            zwykłytelefon.PokażTyp();
            zwykłytelefon.WybierzNumer("0700-880-774");
            zwykłytelefon.WyślijWiadomość("0700-880-774","Hello");
            //smartphone
            Console.WriteLine("Funkcjonalności smartphone'a:");
            smartphone.PokażTyp();
            smartphone.WybierzNumer("0700-880-774");
            smartphone.WyślijWiadomość("0700-880-774", "Hello");
            smartphone.OdtwórzMuzykę("Gangnam Style");
            smartphone.OtwórzStronę("uwm.edu.pl");

            Console.ReadLine();
        }
    }
}

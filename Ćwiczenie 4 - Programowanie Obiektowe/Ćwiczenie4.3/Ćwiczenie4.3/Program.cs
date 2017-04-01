using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ćwiczenie4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Smartphone IPhone = new Smartphone("Apple Iphone 6s", new AppleFabryka());
            Smartphone Samsung = new Smartphone("Samsung Galaxy 5", new SamsungFabryka());

            IPhone.TwórzSmartphone();
            Samsung.TwórzSmartphone();
            Console.ReadLine();
        }
    }
}

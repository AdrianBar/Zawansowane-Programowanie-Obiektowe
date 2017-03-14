using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ćwiczenie_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            AstonMartin AsMa = new AstonMartin();
            RangeRover RaRo = new RangeRover();
            RollsRoyce RoRo = new RollsRoyce();
            AsMa.WypiszMarkę();
            AsMa.WypiszSalon();
            RaRo.WypiszMarkę();
            RaRo.WypiszSalon();
            RoRo.WypiszMarkę();
            RoRo.WypiszSalon();
            Console.ReadLine();
        }
    }
}

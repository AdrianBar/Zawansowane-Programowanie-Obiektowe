using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ćwiczenie_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Uczelnia UWM = Uczelnia.UtworzObiekt("23-10-2016");
            Uczelnia Stanford = Uczelnia.UtworzObiekt("14-09-2015");
            UWM.RekrutujStudentów();
            Stanford.RekrutujStudentów();
            Console.ReadKey();
        }
    }
}

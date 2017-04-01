using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ćwiczenie_4._1
{
    public sealed class Uczelnia
    {
        public string DataRekrutacji;
        private static Uczelnia instance;
        private Uczelnia(string datarekrutacji)
        {
            this.DataRekrutacji = datarekrutacji;
        }
        public static Uczelnia UtworzObiekt(string datarekrutacji)
        {
            if(instance==null)
            {
                instance = new Uczelnia(datarekrutacji);
                return instance;
            }
            return instance;
        }
        public void RekrutujStudentów()
        {
            Console.WriteLine("{0}", DataRekrutacji);
        }
    }
}

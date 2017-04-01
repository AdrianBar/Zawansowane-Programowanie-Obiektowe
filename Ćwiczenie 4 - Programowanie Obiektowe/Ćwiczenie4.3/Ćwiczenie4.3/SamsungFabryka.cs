using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ćwiczenie4._3
{
    class SamsungFabryka : IFabryka
    {
        public IEkran TwórzEkran()
        {
            return new SamsungEkran();
        }

        public IObudowa TwórzObudowę()
        {
            return new SamsungObudowa();
        }
    }
}

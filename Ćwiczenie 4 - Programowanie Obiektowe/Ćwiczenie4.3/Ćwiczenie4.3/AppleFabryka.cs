using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ćwiczenie4._3
{
    class AppleFabryka : IFabryka
    {
        public IEkran TwórzEkran()
        {
            return new AppleEkran();
        }

        public IObudowa TwórzObudowę()
        {
            return new AppleObudowa();
        }
    }
}

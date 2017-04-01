using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ćwiczenie4._3
{
    interface IFabryka
    {
        IEkran TwórzEkran();
        IObudowa TwórzObudowę();
    }
}

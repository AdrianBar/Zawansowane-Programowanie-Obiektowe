using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ćwiczenie_3._2
{
    class KontoBankowe
    {
        private double _stanKonta;
        public KontoBankowe(double stankonta)
        {
            this._stanKonta = stankonta;
        }

        public double Wypłata(double ile)
        {
            if (_stanKonta > ile)
            {
                return _stanKonta = _stanKonta - ile;
            }
            else
               throw new Exception("Nie masz wystarczających środków na koncie");
        }

        public double Wpłata(double ile)
        {
            return _stanKonta = _stanKonta + ile;
        }
        public double StanKonta()
        {
            return _stanKonta;
        }

        public void Przelew(KontoBankowe drugieKonto, double ile)
        {
            if(_stanKonta > ile)
            {
                Wypłata(ile);
                drugieKonto.Wpłata(ile);
            }
        }
    }
}
